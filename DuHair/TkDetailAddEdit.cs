using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using DevExpress.XtraGrid;
using DevExpress.XtraGrid.Views.Grid;
namespace DuHair
{
    public partial class TkDetailAddEdit : DevExpress.XtraEditors.XtraForm
    {
        public string monthAndYear, action = "";
        public int timeKeepingId = 0;
        public delegate void dlLoad();
        public dlLoad dlLoadCallback;
        public TkDetailAddEdit(int timeKeepingId, string action)
        {
            InitializeComponent();
            this.timeKeepingId = timeKeepingId;
            this.action = action;
        }

        private void TKdetailAddEdit_Load(object sender, EventArgs e)
        {
            txtWorkingDay.Focus();
            List<EmployeeTimeKeepingView> employeeTkList = new List<EmployeeTimeKeepingView>();
            if (timeKeepingId == 0)
            {
                monthAndYear = DateTime.Now.ToString("M-yyyy");
                lbTitle.Text = "Chấm công tháng " + monthAndYear;
                using (ModelContext db = new ModelContext())
                {
                    var rs = db.EmployeeList.Where(m => m.Status.Equals("Hiển thị", StringComparison.InvariantCultureIgnoreCase))
                                            .Select(m => new EmployeeTimeKeepingView { 
                                                EmployeeId = m.EmployeeId,
                                                Name = m.Name,
                                                Wage = m.Wage,
                                                WorkedDay = 0,
                                                RealWage = 0,
                                                Overtime = 0
                                            });
                    employeeTkList = rs.ToList();
                    gvMain.DataSource = employeeTkList;
                }
            }
            else
            {
                if (action.Equals("View"))
                    btnSave.Visible = false;
                using (ModelContext db = new ModelContext())
                {
                    List<TkDetail> TkDetailList = db.TkDetailList.Where(t => t.TimeKeeping.TimeKeepingId == timeKeepingId).ToList();
                    foreach (var objTkDetail in TkDetailList)
                    {
                        db.Entry<TkDetail>(objTkDetail).Reference(t => t.Employee).Load();
                        employeeTkList.Add(new EmployeeTimeKeepingView { 
                            EmployeeId = objTkDetail.Employee.EmployeeId,
                            Name = objTkDetail.Employee.Name,
                            Wage = objTkDetail.Employee.Wage,
                            WorkedDay = objTkDetail.WorkedDay,
                            RealWage = objTkDetail.RealWage,
                            Overtime = objTkDetail.Overtime
                        });
                    }
                    gvMain.DataSource = employeeTkList;
                    db.Entry<TkDetail>(TkDetailList.FirstOrDefault()).Reference(t => t.TimeKeeping).Load();
                    lbTitle.Text = "Chấm công tháng " + TkDetailList.FirstOrDefault().TimeKeeping.MonthAndYear;
                    txtWorkingDay.Text = TkDetailList.FirstOrDefault().TimeKeeping.WorkingDay.ToString();
                }
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            float workingDay = float.Parse(txtWorkingDay.Text.Trim());
            if (timeKeepingId == 0)
            {
                using(ModelContext db = new ModelContext())
	            {
                    TimeKeeping objTimeKeeping = new TimeKeeping();
                    objTimeKeeping.MonthAndYear = monthAndYear;
                    objTimeKeeping.WorkingDay = workingDay;

                    for (int i = 0; i < gvList.RowCount; i++)
                    {
                        int employeeId = Convert.ToInt32(gvList.GetRowCellValue(i, "EmployeeId"));
                        Employee objEmployee = db.EmployeeList.Where(m => m.EmployeeId == employeeId).FirstOrDefault();
                        float workedDay = float.Parse(gvList.GetRowCellValue(i, "WorkedDay").ToString());
                        float overtime = float.Parse(gvList.GetRowCellValue(i, "Overtime").ToString());
                        int realWage = int.Parse(gvList.GetRowCellValue(i, "RealWage").ToString());
                        
                        TkDetail objTkDetail = new TkDetail { 
                            TimeKeeping = objTimeKeeping,
                            WorkedDay = workedDay,
                            Overtime = overtime,
                            Employee = objEmployee,
                            RealWage = realWage
                        };
                        db.TkDetailList.Add(objTkDetail);
                    }
                    db.SaveChanges();
                    dlLoadCallback();
                    this.Close();
                }
            }
            else
            {
                using (ModelContext db = new ModelContext())
                {
                    TimeKeeping objTimeKeeping = db.TimeKeepingList.Where(t => t.TimeKeepingId == timeKeepingId).FirstOrDefault();
                    objTimeKeeping.WorkingDay = float.Parse(txtWorkingDay.Text.Trim());

                    List<TkDetail> TkDetailList = db.TkDetailList.Where(t => t.TimeKeeping.TimeKeepingId == timeKeepingId).ToList();
                    for (int i = 0; i < gvList.RowCount; i++)
                    {
                        float workedDay = float.Parse(gvList.GetRowCellValue(i, "WorkedDay").ToString());
                        int realWage = int.Parse(gvList.GetRowCellValue(i, "RealWage").ToString());
                        float overtime = float.Parse(gvList.GetRowCellValue(i, "Overtime").ToString());
                        TkDetailList[i].Overtime = overtime;
                        TkDetailList[i].WorkedDay = workedDay;
                        TkDetailList[i].RealWage = realWage;
                    }
                    db.SaveChanges();
                    dlLoadCallback();
                    this.Close();
                }
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void gvList_FocusedColumnChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedColumnChangedEventArgs e)
        {
            //gvList.FocusedColumn = colWorkedDay;
        }

        private void gvList_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            gvList.FocusedColumn = colWorkedDay;
        }

        private void txtWorkingDay_EditValueChanged(object sender, EventArgs e)
        {
            for (int i = 0; i < gvList.RowCount; i++)
            {
                if (float.Parse(gvList.GetRowCellValue(i, "WorkedDay").ToString()) > 0)
                {
                    float workingDay = float.Parse(txtWorkingDay.Text.Trim());
                    float workedDay = float.Parse(gvList.GetRowCellValue(i, "WorkedDay").ToString());
                    float overtime = float.Parse(gvList.GetRowCellValue(i, "Overtime").ToString());
                    int wage = int.Parse(gvList.GetRowCellValue(i, "Wage").ToString());
                    float rate = wage / workingDay;
                    if (workedDay > 0)
                    {
                        double realWage = (rate * workedDay) + (rate * 1.5 * overtime);
                        gvList.SetRowCellValue(i, "RealWage", Convert.ToInt32(realWage));
                    }
                }
            }
        }

        private void txtWorkingDay_Enter(object sender, EventArgs e)
        {
            TextEdit edit = sender as TextEdit;
            BeginInvoke(new Action(() => edit.SelectAll()));
        }

        private void txtWorkingDay_MouseUp(object sender, MouseEventArgs e)
        {
            TextEdit edit = sender as TextEdit;
            edit.SelectAll();
        }

        private void gvMain_ProcessGridKey(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Tab)
            {
                GridControl grid = sender as GridControl;
                GridView view = grid.FocusedView as GridView;
                if ((e.Modifiers == Keys.None && view.IsLastRow && view.FocusedColumn.VisibleIndex == view.VisibleColumns.Count - 1)
                    || (e.Modifiers == Keys.Shift && view.IsFirstRow && view.FocusedColumn.VisibleIndex == 0))
                {
                    gvList.FocusedRowHandle = 0;
                    btnSave.Focus();
                }
            }
        }

        private void gvList_CellValueChanged(object sender, DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs e)
        {
            if (e.Column == colWorkedDay || e.Column == colOvertime)
            {
                if (txtWorkingDay.Text.Trim().Length > 0 && gvList.GetRowCellValue(e.RowHandle, "WorkedDay") != null)
                {
                    float workingDay = float.Parse(txtWorkingDay.Text.Trim());
                    float workedDay = float.Parse(gvList.GetRowCellValue(e.RowHandle, "WorkedDay").ToString());
                    float overtime = float.Parse(gvList.GetRowCellValue(e.RowHandle, "Overtime").ToString());
                    int wage = int.Parse(gvList.GetRowCellValue(e.RowHandle, "Wage").ToString());
                    float rate = wage / workingDay;
                    if (workedDay > 0)
                    {
                        double realWage = (rate * workedDay) + (rate * 1.5 * overtime);
                        gvList.SetRowCellValue(e.RowHandle, "RealWage", Convert.ToInt32(realWage));
                    }
                }
            }
        }
    }
}