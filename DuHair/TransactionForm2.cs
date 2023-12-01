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
using System.Threading;
using DevExpress.XtraGrid;
using DevExpress.XtraGrid.Views.Grid;

namespace DuHair
{
    public partial class TransactionForm2 : DevExpress.XtraEditors.XtraForm
    {
        List<EmployeeHomeView> employeeViewList = new List<EmployeeHomeView>();
        List<ServiceView> serviceViewList = new List<ServiceView>();
        private int transactionId, amount = 0;
        public delegate void dlLoad();
        public delegate void dlLoad2();
        public dlLoad dlLoadCallback;
        public dlLoad dlLoadCallback2;
        public TransactionForm2(int TransactionId, List<EmployeeHomeView> employeeViewList, List<ServiceView> serviceViewList)
        {
            InitializeComponent();
            this.transactionId = TransactionId;
            this.employeeViewList = employeeViewList;
            this.serviceViewList = serviceViewList;
        }

        private void Transaction2_Load(object sender, EventArgs e)
        {
            Thread insertThread = new Thread(new ThreadStart((Action)(() =>
            {
                LoadData();
            })));
            insertThread.Start();
        }

        protected void LoadData()
        {
            var NullCustomer = new Customer() { CustomerId = 0, Name = "Khách mới", Tel = "", Birthday = DateTime.Now };
            using (ModelContext db = new ModelContext())
            {
                var CustomerList = db.CustomerList.Where(c => c.Status.Equals("Hiển thị")).ToList();
                CustomerList.Insert(0, NullCustomer);
                try
                {
                    this.Invoke((Action)(() =>
                    {
                        cbCustomer.Properties.DataSource = CustomerList;
                        cbCustomer.EditValue = 0;
                        cbCustomer.Focus();
                    }));
                }
                catch (Exception ex )
                {
                    var ww = ex.Message;
                }
            }
            if (transactionId <= 0)
            {
                string transactionIdCoded = "";
                using (ModelContext db = new ModelContext())
                {
                    var newestTransactionId = db.TransactionList.OrderByDescending(t => t.TransactionId)
                                                                .Take(1)
                                                                .Select(t => t.TransactionId)
                                                                .ToList()
                                                                .FirstOrDefault();
                    transactionIdCoded = string.Format("GD-{0:D5}", newestTransactionId + 1);
                }
                this.Invoke((Action)(() =>
                {
                    gvMain.DataSource = serviceViewList;
                    gvMain2.DataSource = employeeViewList;
                    foreach (var service in serviceViewList)
                    {
                        amount += service.Price * service.Quantity;
                    }
                    lbEmployeeName.Text = MainForm.currentEmployeeName;
                    lblTime.Text = DateTime.Now.ToString("HH:mm dd/MM/yyyy");
                    lblId.Text = transactionIdCoded;
                    lblAmount.Text = "Tổng: " + amount.ToString("N0") + " VNĐ";
                }));
            }
            else
            {
                using (ModelContext db = new ModelContext())
                {
                    var rs = from t in db.TransactionList
                             where t.TransactionId == transactionId
                             select new
                             {
                                 customerId = (int?)t.Customer.CustomerId,
                                 casherName = t.Casher.Name,
                                 transactionDate = t.TransactionDate,
                             };
                    var employeeListLocal = (from t in db.TransactionList
                                             where t.TransactionId == transactionId
                                             join tf in db.TransactionEmployeeList on t.TransactionId equals tf.TransactionId
                                             select (new EmployeeHomeView
                                             {
                                                 EmployeeId = tf.EmployeeId,
                                                 Name = tf.Employee.Name,
                                                 DiscountMoney = tf.DiscountMoney
                                             })).ToList();
                    var serviceListLocal = (from t in db.TransactionList
                                            where t.TransactionId == transactionId
                                            join ts in db.TransactionServiceList on t.TransactionId equals ts.TransactionId
                                            select (new ServiceView
                                            {
                                                ServiceId = ts.ServiceId,
                                                Name = ts.Service.Name,
                                                Price = ts.Price2,
                                                Quantity = ts.Quantity
                                            })).ToList();
                    foreach (var service in serviceListLocal)
                    {
                        amount += service.Price * service.Quantity;
                    }
                    this.Invoke((Action)(() =>
                    {
                        btnMoney.Visible = false;
                        lbEmployeeName.Text = rs.First().casherName;
                        lblTime.Text = rs.First().transactionDate.ToString("HH:mm dd/MM/yyyy");
                        lblId.Text = string.Format("GD-{0:D5}", transactionId);
                        lblAmount.Text = "Tổng: " + amount.ToString("N0") + " VNĐ";
                        if (rs.FirstOrDefault().customerId == null)
                            cbCustomer.EditValue = 0;
                        else
                            cbCustomer.EditValue = rs.FirstOrDefault().customerId;
                        gvMain.DataSource = serviceListLocal;
                        gvMain2.DataSource = employeeListLocal;
                    }));
                    
                }
            }
        }
        //protected bool validateData()
        //{
        //    //if (gvService.RowCount < 1)
        //    //{
        //    //    lbStatus.Text = "Dịch vụ không được bỏ trống";
        //    //    return false;
        //    //}
        //    //lbStatus.Text = "";
        //    //return true; 
        //}

        public void Print(string pDate, int PrintCount)
        {
            List<ServiceBill> serviceBillList = serviceViewList.Select(s => new ServiceBill
            {
                ServiceId = s.ServiceId,
                Name = s.Name,
                Price = s.Price,
                Quantity = s.Quantity,
                Total = s.Price * s.Quantity
            }).ToList();
            Microsoft.Reporting.WinForms.LocalReport report = new Microsoft.Reporting.WinForms.LocalReport();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource1 = new Microsoft.Reporting.WinForms.ReportDataSource();
            reportDataSource1.Name = "datasource";
            reportDataSource1.Value = this.ServiceBillBindingSource;
            report.DataSources.Add(reportDataSource1);
            report.ReportPath = "rpBill.rdlc";
            this.ServiceBillBindingSource.DataSource = serviceBillList;
            Microsoft.Reporting.WinForms.ReportParameter[] para = new Microsoft.Reporting.WinForms.ReportParameter[]
            {
                new Microsoft.Reporting.WinForms.ReportParameter("pCasher", MainForm.currentEmployeeName),
                new Microsoft.Reporting.WinForms.ReportParameter("pDate", pDate),
                new Microsoft.Reporting.WinForms.ReportParameter("pTotal", amount.ToString("n0") + " VNĐ"),
                new Microsoft.Reporting.WinForms.ReportParameter("pPrintCount", PrintCount.ToString()),
                new Microsoft.Reporting.WinForms.ReportParameter("pTransactionIdCoded", string.Format("GD-{0:D5}", transactionId))
            };
            report.SetParameters(para);

            ReportPrintDocument rp = new ReportPrintDocument(report);
            rp.Print();
        }

        private void gvService_CellValueChanged(object sender, DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs e)
        {
            amount = 0;
            for (int i = 0; i < gvService.RowCount; i++)
            {
                int currentPrice = Convert.ToInt32(gvService.GetRowCellValue(i, "Price"));
                int currentQuantity = Convert.ToInt32(gvService.GetRowCellValue(i, "Quantity"));
                amount += currentPrice * currentQuantity;
            }
            lblAmount.Text = "Tổng: " + amount.ToString("N0") + " VNĐ";
        }

        private void gvService_CellValueChanging(object sender, DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs e)
        {
            //if (e.Column == colQuantity)
            //{
                amount = 0;
                for (int i = 0; i < gvService.RowCount; i++)
                {
                    int currentPrice = Convert.ToInt32(gvService.GetRowCellValue(i, "Price"));
                    int currentQuantity = Convert.ToInt32(gvService.GetRowCellValue(i, "Quantity"));
                    if (i == e.RowHandle)
                    {
                        int changingValue = 0;
                        if (e.Value != null && !e.Value.ToString().Equals(""))
                            changingValue = int.Parse(e.Value.ToString());
                        if (e.Column == colQuantity)
                        {
                            amount += currentPrice * changingValue;
                        }
                        else if (e.Column == colPrice)
                        {
                            amount += currentQuantity * changingValue;
                        }
                    }
                    else
                    {
                        amount += currentPrice * currentQuantity;
                    }
                }
                lblAmount.Text = "Tổng: " + amount.ToString("N0") + " VNĐ";
            //}
        }

        private void btnMoney_Click(object sender, EventArgs e)
        {
            int customerId = Convert.ToInt16(cbCustomer.EditValue);
            using (ModelContext db = new ModelContext())
            {
                Transaction objTransaction = new Transaction();
                objTransaction.TransactionDate = DateTime.Now;
                objTransaction.PrintCount = 1;

                Customer objCustomer = null;
                if (customerId != 0)
                    objCustomer = db.CustomerList.Where(c => c.CustomerId == customerId).FirstOrDefault();
                objTransaction.Customer = objCustomer;

                Employee objCasher = db.EmployeeList.Where(m => m.EmployeeId == MainForm.currentEmployeeId).FirstOrDefault();
                objTransaction.Casher = objCasher;
                objTransaction.Amount = amount;
                objTransaction.IsPaidWithCash = Convert.ToBoolean(rdPayType.EditValue);
                //TransactionService
                for (int i = 0; i < gvService.RowCount; i++)
                {
                    int serviceId = Convert.ToInt32(gvService.GetRowCellValue(i, "ServiceId"));
                    int quantity = Convert.ToInt32(gvService.GetRowCellValue(i, "Quantity"));
                    int price2 = Convert.ToInt32(gvService.GetRowCellValue(i, "Price"));
                    if (quantity > 0)
                    {
                        Service objService = db.ServiceList.Where(s => s.ServiceId == serviceId).FirstOrDefault();
                        TransactionService objTransactionService = new TransactionService { 
                            Transaction = objTransaction,
                            Service = objService,
                            Quantity = quantity,
                            Price2 = price2
                        };
                        db.TransactionServiceList.Add(objTransactionService);
                    }
                }
                //TransactionEmployee
                for (int i = 0; i < gvEmployee.RowCount; i++)
                {
                    int employeeId = Convert.ToInt32(gvEmployee.GetRowCellValue(i, "EmployeeId"));
                    int discountMoney = Convert.ToInt32(gvEmployee.GetRowCellValue(i, "DiscountMoney"));
                    Employee objEmployee = db.EmployeeList.Where(m => m.EmployeeId == employeeId).FirstOrDefault();
                    TransactionEmployee objTransactionEmployee = new TransactionEmployee {
                        Transaction = objTransaction,
                        Employee = objEmployee,
                        DiscountMoney = discountMoney
                    };
                    db.TransactionEmployeeList.Add(objTransactionEmployee);
                }
                db.SaveChanges();
                transactionId = objTransaction.TransactionId;
                try
                {
                    Print(objTransaction.TransactionDate.ToString("HH:mm dd/MM/yyyy"), objTransaction.PrintCount);
                    dlLoadCallback();
                    dlLoadCallback2();
                }
                catch (Exception ex)
                {
                    var ee = ex.Message;
                }
            }
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
                    if (btnMoney.Visible)
                    {
                        btnMoney.Focus();
                    }
                }
            }
        }

        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            if (keyData == (Keys.D | Keys.Control))
            {
                if (btnMoney.Visible)
                {
                    btnMoney.PerformClick();
                    return true;
                }
            }
            return base.ProcessCmdKey(ref msg, keyData);
        }

        private void lblAmount_Click(object sender, EventArgs e)
        {

        }

        private void btnRePrint_Click(object sender, EventArgs e)
        {
            using(ModelContext db = new ModelContext())
	        {
                Transaction objTransaction = db.TransactionList.Where(t => t.TransactionId == transactionId).FirstOrDefault();
                objTransaction.PrintCount += 1;
                try
                {
                    Print(objTransaction.TransactionDate.ToString("HH:mm dd/MM/yyyy"), objTransaction.PrintCount);
                }
                catch (Exception)
                {
                }
                db.SaveChanges();
	        }
        }
    }
}