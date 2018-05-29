﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using DevExpress.XtraGrid.Views.Grid.ViewInfo;
using DevExpress.XtraGrid.Views.Grid;
using DevExpress.Utils.Drawing;
using System.Threading;

namespace DuHair
{
    public partial class StatisticForm : DevExpress.XtraEditors.XtraForm
    {
        DataTable dtEmployee = null, dtCommission = null, dtSellCom = null, dtIncomeSpend = null, dtIncome = null, dtSpend = null;
        public StatisticForm()
        {
            InitializeComponent();
        }

        private void StatisticForm_Load(object sender, EventArgs e)
        {
            txtFrom.EditValue = DateTime.Now;
            txtTo.EditValue = DateTime.Now;
            loadDataTransaction();
        }

        protected void loadDataTransaction()
        {
            DateTime fromDate = (DateTime)txtFrom.EditValue;
            DateTime toDate = (DateTime)txtTo.EditValue;
            fromDate = new DateTime(fromDate.Year, fromDate.Month, fromDate.Day, 0, 0, 0);
            toDate = new DateTime(toDate.Year, toDate.Month, toDate.Day, 23, 59, 59);
            using (ModelContext db = new ModelContext())
            {
                var result = from t in db.TransactionList
                             where (t.TransactionDate >= fromDate && t.TransactionDate <= toDate)
                             select (new TransactionStatisticView {
                                                                    TransactionId = t.TransactionId, 
                                                                    Name = t.Customer.Name,
                                                                    ChairId = t.Chair.ChairId,
                                                                    ChairName = t.Chair.Name,
                                                                    TransactionDate = t.TransactionDate, 
                                                                    Amount = t.Amount });
                List<TransactionStatisticView> transactionStatisticViewList = new List<TransactionStatisticView>();
                transactionStatisticViewList = result.ToList();
                foreach (var transactionStatisticView in transactionStatisticViewList)
                    transactionStatisticView.TransactionIdCoded = string.Format("GD-{0:D5}", transactionStatisticView.TransactionId);
                gvMain.MainView = gvTransaction;
                gvMain.DataSource = transactionStatisticViewList;
            }
        }

        protected void loadDataSellTran()
        {
            DateTime fromDate = (DateTime)txtFrom.EditValue;
            DateTime toDate = (DateTime)txtTo.EditValue;
            fromDate = new DateTime(fromDate.Year, fromDate.Month, fromDate.Day, 0, 0, 0);
            toDate = new DateTime(toDate.Year, toDate.Month, toDate.Day, 23, 59, 59);
            Thread thread = new Thread(new ThreadStart((Action)(() =>
            {
                using (ModelContext db = new ModelContext())
                {
                    db.Database.Connection.Open();
                    //select from 2 tables and sum one table and map to a class
                    var result = from s in db.SellTranList
                                 join dt in db.SellTranDetailList on s.SellTranId equals dt.SellTran.SellTranId
                                 where (s.SellDate >= fromDate && s.SellDate <= toDate)
                                 group dt by new { s.SellTranId, s.Amount, s.Customer.Name, EmployeeName = s.Employee.Name, s.SellDate } into g
                                 select (new SellTranView
                                 {
                                     SellTranId = g.Key.SellTranId,
                                     Amount = g.Key.Amount,
                                     CustomerName = g.Key.Name,
                                     EmployeeName = g.Key.EmployeeName,
                                     SellDate = g.Key.SellDate,
                                     TotalDiscountMoney = g.Sum(x => x.SellComMoney)
                                 });
                    List<SellTranView> sellTranViewList = result.ToList();
                    foreach (var objSellTranView in sellTranViewList)
                        objSellTranView.SellTranIdCoded = string.Format("BH-{0:D5}", objSellTranView.SellTranId);
                    try
                    {
                        this.Invoke((Action)(() =>
                        {
                            gvMain.MainView = gvSellTran;
                            gvMain.DataSource = sellTranViewList;
                        }));
                    }
                    catch (Exception) { }
                }
            })));
            thread.Start();
        }

        protected void initDatatableIncomeSpend()
        {
            dtIncomeSpend = new DataTable("dtIncomeSpend");
            dtIncomeSpend.Columns.Add("KeyColumn", typeof(string));
            dtIncomeSpend.Columns.Add("Income", typeof(int));
            dtIncomeSpend.Columns.Add("Spend", typeof(string));
            dtIncomeSpend.Columns.Add("Profit", typeof(int));
            dtIncomeSpend.Columns.Add("Time", typeof(DateTime));

            dtIncome = new DataTable("dtIncome");
            dtIncome.Columns.Add("KeyColumn", typeof(string));
            dtIncome.Columns.Add("IncomeName", typeof(string));
            dtIncome.Columns.Add("Total", typeof(int));
            dtIncome.Columns.Add("IncomeTime", typeof(DateTime));

            dtSpend = new DataTable("dtSpend");
            dtSpend.Columns.Add("KeyColumn", typeof(string));
            dtSpend.Columns.Add("SpendName", typeof(string));
            dtSpend.Columns.Add("Total", typeof(int));
            dtSpend.Columns.Add("SpendTime", typeof(DateTime));

            DataSet ds = new DataSet();
            ds.Tables.Add(dtIncomeSpend);
            ds.Tables.Add(dtIncome);
            ds.Tables.Add(dtSpend);

            DataColumn masterKeyColumn = ds.Tables["dtIncomeSpend"].Columns["KeyColumn"];
            DataColumn detailKeyColumn = ds.Tables["dtIncome"].Columns["KeyColumn"];
            DataColumn detailKeyColumn2 = ds.Tables["dtSpend"].Columns["KeyColumn"];
            ds.Relations.Add(new DataRelation("IncomeRelation", masterKeyColumn, detailKeyColumn)); //name must match to prevent auto populate
            gvMain.LevelTree.Nodes.Add("IncomeRelation", gvIncome); //name must match to prevent auto populate
            ds.Relations.Add(new DataRelation("SpendRelation", masterKeyColumn, detailKeyColumn2)); //name must match to prevent auto populate
            gvMain.LevelTree.Nodes.Add("SpendRelation", gvSpend); //name must match to prevent auto populate

            gvMain.MainView = gvIncomeSpend;
            gvMain.DataSource = ds.Tables["dtIncomeSpend"];
            gvMain.ForceInitialize();

            gvIncome.ViewCaption = "Khoản thu";
            gvSpend.ViewCaption = "Khoản chi";
        }

        protected void loadDataIncomeAndSpend()
        {
            initDatatableIncomeSpend();
            DateTime fromDate = (DateTime)txtFrom.EditValue;
            DateTime toDate = (DateTime)txtTo.EditValue;
            fromDate = new DateTime(fromDate.Year, fromDate.Month, fromDate.Day, 0, 0, 1);
            toDate = new DateTime(toDate.Year, toDate.Month, toDate.Day, 23, 59, 59);
            using (ModelContext db = new ModelContext())
            {
                var ImcomeTransaction = (from t in db.TransactionList
                             where (t.TransactionDate >= fromDate && t.TransactionDate <= toDate)
                             group t by 1 into g
                             select new { 
                                KeyColumn = "thuchi",
                                SumAmount = g.Sum(x => x.Amount)
                             }).ToList();
                var IncomeSell = (from s in db.SellTranList
                                 where (s.SellDate >= fromDate && s.SellDate <= toDate)
                                 group s by 1 into g
                                 select new
                                 {
                                     KeyColumn = "thuchi",
                                     SumSellAmount = g.Sum(x => x.Amount)
                                 }).ToList();
                var Income = (from t in ImcomeTransaction
                             join s in IncomeSell on t.KeyColumn equals s.KeyColumn into lj
                             from g in lj.DefaultIfEmpty()
                             select new
                             {
                                KeyColumn = "thuchi",
                                Total = t.SumAmount + (g == null ? 0 : g.SumSellAmount)
                             }).ToList();

                            
            }
        }

        protected void loadDataEmployeeCommission()
        {
            InitDatatableEmployeeCom();
            DateTime fromDate = (DateTime)txtFrom.EditValue;
            DateTime toDate = (DateTime)txtTo.EditValue;
            fromDate = new DateTime(fromDate.Year, fromDate.Month, fromDate.Day, 0, 0, 1);
            toDate = new DateTime(toDate.Year, toDate.Month, toDate.Day, 23, 59, 59);
            using (ModelContext db = new ModelContext())
            {
                //get employee list
                List<Employee> employeeList = db.EmployeeList.ToList();    
                //get service comissions (làm, tư vấn) of employee
                var commissions = (from c in db.ComissionList   
                                  where (c.Transaction.TransactionDate >= fromDate && c.Transaction.TransactionDate <= toDate)
                                  group c by new { c.Employee.EmployeeId, c.Service.Name} into g
                                  select new
                                  {
                                      g.Key.EmployeeId,
                                      g.Key.Name,
                                      sumComMoney = g.Sum(x => x.ComMoney),
                                      countMakeTimes = g.Where(x => x.ComType.Equals("Make")).Count(),
                                      sumSellComMoney = g.Sum(x => x.SellComMoney),
                                      countSellTimes = g.Where(x => x.ComType.Equals("Sell")).Count()
                                  }).ToList();
                //get sell commission (bán sản phẩm) of employee
                var sellComs = (from s in db.SellTranList
                               join dt in db.SellTranDetailList on s.SellTranId equals dt.SellTran.SellTranId
                               where (s.Employee != null)
                               where (s.SellDate >= fromDate && s.SellDate <= toDate)
                               group dt by new { s.Employee.EmployeeId, dt.Material.Name} into g
                               select new 
                               {
                                   g.Key.EmployeeId,
                                   g.Key.Name,
                                   sumSellComMoney = g.Sum(x => x.SellComMoney),
                                   countSellTimes = g.Sum(x => x.Quantity)
                               }).ToList();
                // merge employee with service commissions (commissions can be null)
                var employeeWithCom = (from e in employeeList
                                       join c in commissions on e.EmployeeId equals c.EmployeeId into lj
                                       from g in lj.DefaultIfEmpty()
                                       group new { g } by new { e.EmployeeId, e.Name, e.Wage, e.Tel, e.Role, e.Status } into g2
                                       select new
                                       {
                                           g2.Key.EmployeeId,
                                           g2.Key.Name,
                                           g2.Key.Wage,
                                           g2.Key.Tel,
                                           g2.Key.Role,
                                           g2.Key.Status,
                                           TotalTranComMoney = g2.Sum(x => (x.g == null ? 0 : x.g.sumComMoney)),
                                           TotalTranSellCom = g2.Sum(x => (x.g == null ? 0 : x.g.sumSellComMoney))
                                       }).ToList();
                // merge employee with sell commissions (commissions can be null)
                var employeeWithSellCom = (from e in employeeList
                                           join s in sellComs on e.EmployeeId equals s.EmployeeId into jg
                                           from g in jg.DefaultIfEmpty()
                                           group new { g } by new { e.EmployeeId} into g2
                                           select new
                                           {
                                               g2.Key.EmployeeId,
                                               TotalSellCom = g2.Sum(x => (x.g == null ? 0 : x.g.sumSellComMoney))
                                           }).ToList();
                //merge all together
                var employeeTotalCom = (from c in employeeWithCom
                                       join s in employeeWithSellCom on c.EmployeeId equals s.EmployeeId into jg
                                       from g in jg.DefaultIfEmpty()
                                       select new
                                       {
                                           c.EmployeeId,
                                           c.Name,
                                           c.Wage,
                                           c.Tel, 
                                           c.Role,
                                           c.Status,
                                           TotalCom = ((g==null) ? 0 : g.TotalSellCom) + c.TotalTranComMoney + c.TotalTranSellCom,
                                           RealWage = ((g == null) ? 0 : g.TotalSellCom) + c.TotalTranComMoney + c.TotalTranSellCom + c.Wage
                                       }).ToList();
                //add to datatable
                foreach (var employee in employeeTotalCom)
                {
                    dtEmployee.Rows.Add(new object[]{
                        employee.EmployeeId,
                        employee.Name,
                        employee.Wage,
                        employee.Tel,
                        employee.Role,
                        employee.Status,
                        employee.TotalCom,
                        employee.RealWage
                    });
                }
                foreach (var com in commissions)
                {
                    dtCommission.Rows.Add(new object[]{
                        com.Name,
                        com.sumComMoney,
                        com.countMakeTimes,
                        com.sumSellComMoney,
                        com.countSellTimes,
                        com.EmployeeId
                    });
                }
                foreach (var sellCom in sellComs)
                {
                    dtSellCom.Rows.Add(new object[]{
                        sellCom.Name,
                        sellCom.sumSellComMoney,
                        sellCom.countSellTimes,
                        sellCom.EmployeeId
                    });
                }
            }
            gvMain.MainView = gvEmployeeCom;
        }

        private void InitDatatableEmployeeCom()
        {
            dtEmployee = new DataTable("dtMaster");
            dtEmployee.Columns.Add("EmployeeId", typeof(int));
            dtEmployee.Columns.Add("Name", typeof(string));
            dtEmployee.Columns.Add("Wage", typeof(int));
            dtEmployee.Columns.Add("Tel", typeof(string));
            dtEmployee.Columns.Add("Role", typeof(string));
            dtEmployee.Columns.Add("Status", typeof(string));
            dtEmployee.Columns.Add("TotalCom", typeof(int));
            dtEmployee.Columns.Add("RealWage", typeof(int));

            dtCommission = new DataTable("dtDetail");
            dtCommission.Columns.Add("Name", typeof(string));
            dtCommission.Columns.Add("ComMoney", typeof(int));
            dtCommission.Columns.Add("MakeTimes", typeof(int));
            dtCommission.Columns.Add("SellComMoney", typeof(int));
            dtCommission.Columns.Add("SellTimes", typeof(int));
            dtCommission.Columns.Add("EmployeeId", typeof(int));

            dtSellCom = new DataTable("dtDetail2");
            dtSellCom.Columns.Add("Name", typeof(string));
            dtSellCom.Columns.Add("SellComMoney", typeof(int));
            dtSellCom.Columns.Add("SellTimes", typeof(int));
            dtSellCom.Columns.Add("EmployeeId", typeof(int));

            DataSet ds = new DataSet();
            ds.Tables.Add(dtEmployee);
            ds.Tables.Add(dtCommission);
            ds.Tables.Add(dtSellCom);
            DataColumn masterKeyColumn = ds.Tables["dtMaster"].Columns["EmployeeId"];
            DataColumn detailKeyColumn = ds.Tables["dtDetail"].Columns["EmployeeId"];
            DataColumn detailKeyColumn2 = ds.Tables["dtDetail2"].Columns["EmployeeId"];
            ds.Relations.Add(new DataRelation("EmployeeCommission", masterKeyColumn, detailKeyColumn));
            ds.Relations.Add(new DataRelation("SellProductCommission", masterKeyColumn, detailKeyColumn2));//name must match to prevent auto populate
            gvMain.LevelTree.Nodes.Add("EmployeeCommission", gvComDetail); //name must match to prevent auto populate
             //name must match to prevent auto populate
            gvMain.LevelTree.Nodes.Add("SellProductCommission", gvSellComDetail); //name must match to prevent auto populate
             
            gvMain.MainView = gvEmployeeCom;
            gvMain.DataSource = ds.Tables["dtMaster"];
            gvMain.ForceInitialize();
            
            gvComDetail.ViewCaption = "Làm dịch vụ";
            gvSellComDetail.ViewCaption = "Bán sản phẩm";
        }

        private void btnReload_Click(object sender, EventArgs e)
        {
            if (cbStatisticType.SelectedIndex == 0)
                loadDataTransaction();
            if (cbStatisticType.SelectedIndex == 1)
                loadDataSellTran();
            if (cbStatisticType.SelectedIndex == 2)
                loadDataEmployeeCommission();
            if (cbStatisticType.SelectedIndex == 3)
                loadDataIncomeAndSpend();
        }

        private void cbStatisticType_SelectedIndexChanged(object sender, EventArgs e)
        {
            //set the txtTo value to the first day of month
            //set the txtTo value to the last day of month
            if (cbStatisticType.SelectedIndex == 3)
            {
                //txtFrom.Properties.VistaCalendarViewStyle = DevExpress.XtraEditors.VistaCalendarViewStyle.YearView;
                //txtTo.Properties.VistaCalendarViewStyle = DevExpress.XtraEditors.VistaCalendarViewStyle.YearView;
                //int currentMonth = DateTime.Now.Month;
                //int currentYear = DateTime.Now.Year;
                //txtFrom.EditValue = new DateTime(currentYear, currentMonth, 1, 0, 0, 0);
                //txtTo.EditValue = new DateTime(currentYear, currentMonth, DateTime.DaysInMonth(currentYear, currentMonth), 0, 0, 0);
            }
            else
            {
                txtFrom.Properties.VistaCalendarViewStyle = DevExpress.XtraEditors.VistaCalendarViewStyle.All;
                txtTo.Properties.VistaCalendarViewStyle = DevExpress.XtraEditors.VistaCalendarViewStyle.All;
                txtFrom.EditValue = DateTime.Now;
                txtTo.EditValue = DateTime.Now;
            }
        }

        private void txtTo_EditValueChanged(object sender, EventArgs e)
        {
            //set the txtTo value to the last day of month
            if (cbStatisticType.SelectedIndex == 3)
            {
                int currentMonth = Convert.ToDateTime(txtTo.EditValue).Month;
                int currentYear = Convert.ToDateTime(txtTo.EditValue).Year;
                txtTo.EditValue = new DateTime(currentYear, currentMonth, DateTime.DaysInMonth(currentYear, currentMonth), 23, 59, 59);
            }
        }

        private void gvEmployeeCom_DoubleClick(object sender, EventArgs e)
        {
            GridView gridView = (GridView)sender;
            Point pt = gridView.GridControl.PointToClient(System.Windows.Forms.Control.MousePosition);
            DoRowDoubleClickGvEmployeeCom(gridView, pt);
        }

        private void DoRowDoubleClickGvEmployeeCom(GridView gridView, Point pt)
        {
            GridHitInfo info = gridView.CalcHitInfo(pt);
            if ((info.InRow ? true : info.InRowCell))
            {
                try
                {
                    if (gvEmployeeCom.GetMasterRowExpanded(gvEmployeeCom.FocusedRowHandle))
                    {
                        gvEmployeeCom.CollapseMasterRow(gvEmployeeCom.FocusedRowHandle);
                    }
                    else
                    {
                        gvEmployeeCom.ExpandMasterRow(gvEmployeeCom.FocusedRowHandle);
                    }
                }
                catch (Exception){}
            }
        }

        private void DoRowDoubleClick(GridView gridView, Point pt)
        {
            GridHitInfo info = gridView.CalcHitInfo(pt);
            if ((info.InRow ? true : info.InRowCell))
            {
                try
                {
                    if (gridView.Name.Equals("gvTransaction"))
                    {
                        int TransactionId = Convert.ToInt16(gvTransaction.GetRowCellValue(info.RowHandle, "TransactionId"));
                        int ChairId = Convert.ToInt16(gvTransaction.GetRowCellValue(info.RowHandle, "ChairId"));
                        TransactionForm tf = new TransactionForm(TransactionId, ChairId, "View");
                        tf.ShowDialog();
                    }
                    else if (gridView.Name.Equals("gvSellTran"))
                    {
                        int SellTranId = Convert.ToInt32(gvSellTran.GetRowCellValue(info.RowHandle, "SellTranId"));
                        SellTranForm st = new SellTranForm(SellTranId);
                        st.ShowDialog();
                    }
                }
                catch (Exception) { }
            }
        }

        private void gvTransaction_DoubleClick(object sender, EventArgs e)
        {
            GridView gridView = (GridView)sender;
            Point pt = gridView.GridControl.PointToClient(System.Windows.Forms.Control.MousePosition);
            DoRowDoubleClick(gridView, pt);
        }

        //to change gridview column header color when use skin which is used all the time
        private void gvEmployeeCom_CustomDrawColumnHeader(object sender, ColumnHeaderCustomDrawEventArgs e)
        {
            if (e.Column != null && e.Column.AppearanceHeader.BackColor != Color.Empty)
            {
                // Fill column headers with the specified colors.
                SolidBrush brush = new SolidBrush(e.Appearance.BackColor);
                e.Cache.FillRectangle(brush, e.Bounds);
                e.Appearance.DrawString(e.Cache, e.Info.Caption, e.Info.CaptionRect);
                // Draw the filter and sort buttons.
                foreach (DrawElementInfo info in e.Info.InnerElements)
                {
                    if (!info.Visible) continue;
                    ObjectPainter.DrawObject(e.Cache, info.ElementPainter, info.ElementInfo);
                }
                brush.Dispose();
                e.Handled = true;
            }      
        }

        private void gvSellTran_DoubleClick(object sender, EventArgs e)
        {
            GridView gridView = (GridView)sender;
            Point pt = gridView.GridControl.PointToClient(System.Windows.Forms.Control.MousePosition);
            DoRowDoubleClick(gridView, pt);
        }

        private void gvTransaction_CustomColumnDisplayText(object sender, DevExpress.XtraGrid.Views.Base.CustomColumnDisplayTextEventArgs e)
        {
            if (e.Column == colStatus)
            {
                if (e.Value.ToString().Equals("1"))
                {
                    e.DisplayText = "Đang thực hiện";
                }
                else
                {
                    e.DisplayText = "Đã xong";
                }
            }
        }
    }
}