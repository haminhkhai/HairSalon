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
using DevExpress.XtraGrid.Views.Grid;
using DevExpress.XtraGrid.Views.Grid.ViewInfo;

namespace DuHair
{
    public partial class TimeKeepingForm : DevExpress.XtraEditors.XtraForm
    {
        public TimeKeepingForm()
        {
            InitializeComponent();
        }

        private void TimeKeepingForm_Load(object sender, EventArgs e)
        {
            loadData();
        }

        protected void loadData()
        {
            using (ModelContext db = new ModelContext())
            {
                List<TimeKeepingView> TkList = new List<TimeKeepingView>();
                var result = from t in db.TkDetailList
                             group t by new { t.TimeKeeping.MonthAndYear, t.TimeKeeping.WorkingDay, t.TimeKeeping.TimeKeepingId } into g
                             orderby g.Key.TimeKeepingId descending
                             select new
                             {
                                 g.Key.TimeKeepingId,
                                 g.Key.MonthAndYear,
                                 g.Key.WorkingDay,
                                 SumRealWage = g.Sum(x => x.RealWage)
                             };
                gvMain.DataSource = result.ToList();
            }
        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            using (ModelContext db = new ModelContext())
            {
                string newestTimeKeeping = db.TimeKeepingList.OrderByDescending(t => t.TimeKeepingId)
                                                                    .Take(1)
                                                                    .Select(t => t.MonthAndYear)
                                                                    .FirstOrDefault();
                if (!string.IsNullOrEmpty(newestTimeKeeping))
                {
                    if (!newestTimeKeeping.Equals(DateTime.Now.ToString("M-yyyy")))
                    {
                        TkDetailAddEdit tkDetail = new TkDetailAddEdit(0, "Insert");
                        tkDetail.dlLoadCallback = this.loadData;
                        tkDetail.ShowDialog();
                    }
                    else
                        new MyMessage().ErrorDev("Đã có chấm công của tháng này");
                }
                else
                {
                    TkDetailAddEdit tkDetail = new TkDetailAddEdit(0, "Insert");
                    tkDetail.dlLoadCallback = this.loadData;
                    tkDetail.ShowDialog();
                }
            }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            int TimeKeepingId = Convert.ToInt16(gvList.GetRowCellValue(gvList.FocusedRowHandle, "TimeKeepingId"));
            TkDetailAddEdit tkDetail = new TkDetailAddEdit(TimeKeepingId, "Edit");
            tkDetail.dlLoadCallback = this.loadData;
            tkDetail.ShowDialog();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            using (ModelContext db = new ModelContext())
            {
                if (new MyMessage().QuestionDev("Bạn muốn xóa chấm công này"))
                {
                    int timeKeepingId = Convert.ToInt16(gvList.GetRowCellValue(gvList.FocusedRowHandle, "TimeKeepingId"));
                    TimeKeeping objTimeKeeping = db.TimeKeepingList.Where(t => t.TimeKeepingId == timeKeepingId).Single();
                    List<TkDetail> tkDetailList = db.TkDetailList.Where(t => t.TimeKeeping.TimeKeepingId == timeKeepingId).ToList();
                    foreach (var tkDetail in tkDetailList)
                    {
                        db.Entry<TkDetail>(tkDetail).State = System.Data.Entity.EntityState.Deleted;
                    }
                    db.Entry<TimeKeeping>(objTimeKeeping).State = System.Data.Entity.EntityState.Deleted;
                    db.SaveChanges();
                    loadData();
                }
            }
        }

        private void DoRowDoubleClick(GridView gridView, Point pt)
        {
            GridHitInfo info = gridView.CalcHitInfo(pt);
            if ((info.InRow ? true : info.InRowCell))
            {
                try
                {
                    int TimeKeepingId = Convert.ToInt16(gvList.GetRowCellValue(info.RowHandle, "TimeKeepingId"));
                    TkDetailAddEdit tkDetail = new TkDetailAddEdit(TimeKeepingId, "View");
                    tkDetail.ShowDialog();
                }
                catch (Exception) { }
            }
        }

        private void gvList_DoubleClick(object sender, EventArgs e)
        {
            GridView view = (GridView)sender;
            Point pt = view.GridControl.PointToClient(System.Windows.Forms.Control.MousePosition);
            DoRowDoubleClick(view, pt);
        }
    }
}