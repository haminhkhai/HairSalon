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
using DevExpress.XtraGrid.Views.Grid.ViewInfo;
using DevExpress.XtraGrid.Views.Grid;
using DevExpress.XtraGrid.Views.Base;
using DevExpress.XtraGrid;

namespace DuHair
{
    public partial class TransactionForm : DevExpress.XtraEditors.XtraForm
    {
        List<Service> serviceList = new List<Service>();
        List<Commission> commissionList = new List<Commission>();
        List<ServiceView> serviceViewList = new List<ServiceView>();
        DataTable dtService = null, dtCommission = null;
        private int transactionId, chairId, amount = 0;
        private string action = "";
        public delegate void dlLoad2();
        public dlLoad2 dlLoadCallback2;
        public delegate void dlLoad(int chairId, int transactionId);
        public dlLoad dlLoadCallback;
        
        public TransactionForm(int TransactionId, int ChairId, string action)
        {
            InitializeComponent();
            this.transactionId = TransactionId;
            this.chairId = ChairId;
            this.action = action;
            int screenHeigt = Screen.PrimaryScreen.WorkingArea.Height;
            int screenWidth = Screen.PrimaryScreen.WorkingArea.Width;
            this.Location = new Point(screenWidth / 5, screenHeigt / 5);
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
                        lblChair.Text = "Ghế " + chairId;
                        cbCustomer.Focus();
                    }));
                }
                catch (Exception)
                {
                }
            }
            //insert
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
                    lbEmployeeName.Text = MainForm.currentEmployeeName;
                    lblTime.Text = DateTime.Now.ToString("HH:mm dd/MM/yyyy");
                    lblId.Text = transactionIdCoded;
                    btnMoney.Visible = false;
                }));
            }
            //money and billing
            else
            {
                //using (ModelContext db = new ModelContext())
                //{
                //    var rs = from t in db.TransactionList
                //             where t.TransactionId == transactionId
                //             select new
                //             {
                //                 customerId = (int?)t.Customer.CustomerId,
                //                 casherName = t.Casher.Name,
                //                 transactionDate = t.TransactionDate,
                //                 note = t.Note
                //             };
                //    this.Invoke((Action)(() =>
                //    {
                //        btnMoney.Visible = true;
                //        lbEmployeeName.Text = rs.First().casherName;
                //        lblTime.Text = rs.First().transactionDate.ToString("HH:mm dd/MM/yyyy");
                //        txtNote.Text = rs.First().note;
                //        lblId.Text = string.Format("GD-{0:D5}", transactionId);
                //        if (rs.FirstOrDefault().customerId == null)
                //            cbCustomer.EditValue = 0;
                //        else
                //            cbCustomer.EditValue = rs.FirstOrDefault().customerId;
                //    }));

                //    var result = from s in db.ServiceList
                //                 from t in s.Transactions
                //                 where t.TransactionId == transactionId
                //                 select new ServiceView { Name = s.Name, Price = s.Price, ServiceId = s.ServiceId, Discount = s.Discount, };
                //    var selectedServices = result.ToList();
                //    foreach (var service in selectedServices)
                //    {
                //        List<CommissionView> commissionList = db.ComissionList.Where(c => c.Service.ServiceId == service.ServiceId)
                //                                                              .Where(c => c.Transaction.TransactionId == transactionId)
                //                                                              .Select(c => new CommissionView
                //                                                              {
                //                                                                  CommissionId = c.CommissionId,
                //                                                                  CommissionPercent = c.CommissionPercent,
                //                                                                  Employee = c.Employee,
                //                                                                  ComMoney = c.ComMoney,
                //                                                                  SellComMoney = c.SellComMoney,
                //                                                                  Service = c.Service,
                //                                                                  Quantity = c.Quantity,
                //                                                                  OtherPrice = c.OtherPrice,
                //                                                                  ComType = c.ComType
                //                                                              }).ToList();
                //        try
                //        {
                //            this.Invoke((Action)(() =>
                //            {
                //                GetCommissionServiceEmployee(service, commissionList);
                //            }));
                //        }
                //        catch (Exception){}
                //    }
                //}
                if (action.Equals("View"))
                {
                    try
                    {
                        this.Invoke((Action)(() =>
                        {
                            btnMoney.Visible = false;
                            btnSave.Visible = false;
                        }));
                    }
                    catch (Exception){}
                }
            }
        }

        private void GetCommissionServiceEmployee(object objService, object objCommissionList)
        {
            //receive objServiceView from AddServiceForm
            ServiceView objServiceView = (ServiceView)objService;
            //add to serviceViewList
            serviceViewList.Add(objServiceView);
            List<CommissionView> commissionListView = (List<CommissionView>)objCommissionList;
            if (dtService != null)
            {
                //to prevent null pointer exception bro
                int OtherPrice = 0;
                string SellEmployeeName = "";
                for (int i = 0; i < commissionListView.Count(); i++)
                {
                    // check if this commission is sell commission 
                    if (commissionListView[i].ComType.Equals("Sell"))
                        SellEmployeeName = commissionListView[i].Employee.Name;
                    // kiem tra xem co gia moi hay khong va chi kiem tra khi i = 0
                    if (commissionListView[i].OtherPrice != 0 && i == 0)
                        OtherPrice = commissionListView[i].OtherPrice;
                    // appoint quantity from commissionListView to objServiceView. Only need to do this when i = 0 because all commissionListView item's quantity are equal
                    if (i == 0)
                        objServiceView.Quantity = commissionListView[i].Quantity;
                }
                if (OtherPrice != 0)
                {
                    objServiceView.Price = OtherPrice;
                }
                dtService.Rows.Add(new object[] { objServiceView.ServiceId, 
                                                  objServiceView.Name, 
                                                  objServiceView.Price, 
                                                  objServiceView.Quantity,
                                                  //objServiceView.Discount,
                                                  SellEmployeeName});
                //add to insert or edit
                this.serviceList.Add(new Service
                {
                    ServiceId = objServiceView.ServiceId,
                    Name = objServiceView.Name,
                    Price = objServiceView.Price,
                    Discount = objServiceView.Discount
                });
                amount += objServiceView.Price * objServiceView.Quantity;
            }
            if (dtCommission != null)
            {
                for (int i = 0; i < commissionListView.Count(); i++)
                {
                    if (commissionListView[i].ComType.Equals("Make"))
                    {
                        dtCommission.Rows.Add(new object[] 
                        {
		                    commissionListView[i].Service.ServiceId, 
                            commissionListView[i].Employee.Name, 
                            commissionListView[i].ComMoney
                        });
                    }
                }
                //add to insert or update 
                this.commissionList.AddRange(commissionListView.Select(c => new Commission
                {
                    CommissionId = c.CommissionId,
                    CommissionPercent = c.CommissionPercent,
                    Service = c.Service,
                    Quantity = c.Quantity,
                    Employee = c.Employee,
                    ComMoney = c.ComMoney,
                    SellComMoney = c.SellComMoney,
                    OtherPrice = c.OtherPrice,
                    ComType = c.ComType
                }).ToList());
            }
            lblAmount.Text = "Tổng: " + amount.ToString("N0") + " VNĐ";
            gvMainDetail.RefreshDataSource();
        }

        protected bool validateData()
        {
            if (gvDetail.RowCount < 1)
            {
                lbStatus.Text = "Dịch vụ không được bỏ trống";
                btnAddService.Focus();
                return false;
            }
            lbStatus.Text = "Không được bỏ trống";
            return true;
        }

        private void InitDatatable()
        {
            dtService = new DataTable("dtMaster");
            dtService.Columns.Add("ServiceId", typeof(int));
            dtService.Columns.Add("Name", typeof(string));
            dtService.Columns.Add("Price", typeof(int));
            dtService.Columns.Add("Quantity", typeof(int));
            //dtService.Columns.Add("Discount", typeof(int));
            dtService.Columns.Add("SellEmployeeName", typeof(string));

            dtCommission = new DataTable("dtDetail");
            //dtCommission.Columns.Add("CommissionId", typeof(int));
            dtCommission.Columns.Add("ServiceId", typeof(int));
            dtCommission.Columns.Add("Name", typeof(string));
            dtCommission.Columns.Add("ComMoney", typeof(int));

            DataSet ds = new DataSet();
            ds.Tables.Add(dtService);
            ds.Tables.Add(dtCommission);
            DataColumn masterKeyColumn = ds.Tables["dtMaster"].Columns["ServiceId"];
            DataColumn detailKeyColumn = ds.Tables["dtDetail"].Columns["ServiceId"];
            ds.Relations.Add(new DataRelation("ServiceCommission", masterKeyColumn, detailKeyColumn));
            ds.EnforceConstraints = false;
            gvMainDetail.DataSource = ds.Tables["dtMaster"];
            //gvMainDetail.ForceInitialize();
            //MUST HAVE SO GRIDVIEW DETAIL WONT AUTO POPULATE COLUMN
            gvMainDetail.LevelTree.Nodes.Add("ServiceCommission", gridView1);
            //gridView1.ViewCaption = "Chi tiết chiết khấu";
            gridView1.OptionsView.ShowViewCaption = false;
        }

        private void Transaction_Load(object sender, EventArgs e)
        {
            InitDatatable();
            Thread insertThread = new Thread(new ThreadStart((Action)(() =>
            {
                LoadData();
            })));
            insertThread.Start();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            int customerId = Convert.ToInt16(cbCustomer.EditValue);
            if (validateData())
            {
                if (transactionId <= 0) //insert
                {
                    using (ModelContext db = new ModelContext())
                    {
                        Transaction objTransaction = new Transaction();

                        objTransaction.Amount = amount;
                        //objTransaction.Note = txtNote.Text.Trim();
                        objTransaction.TransactionDate = DateTime.Now;
                        //objTransaction.Status = 1;
                        db.TransactionList.Add(objTransaction);
                        db.TransactionList.Attach(objTransaction);

                        Employee objCasher = db.EmployeeList.Where(m => m.EmployeeId == MainForm.currentEmployeeId).FirstOrDefault();
                        objTransaction.Casher = objCasher;

                        //Chair objChair = db.ChairList.Where(c => c.ChairId == chairId).FirstOrDefault();
                        //objTransaction.Chair = objChair;

                        Customer objCustomer = null;
                        if (customerId != 0)
                            objCustomer = db.CustomerList.Where(c => c.CustomerId == customerId).FirstOrDefault();
                        objTransaction.Customer = objCustomer;

                        for (int i = 0; i < commissionList.Count(); i++)
                        {
                            Commission commission = commissionList[i];
                            Employee objEmployee = db.EmployeeList.Where(m => m.EmployeeId == commission.Employee.EmployeeId).FirstOrDefault();
                            commission.Employee = objEmployee;

                            Service objService = db.ServiceList.Where(s => s.ServiceId == commission.Service.ServiceId).FirstOrDefault();
                            commission.Service = objService;

                            //if (commission.DiscountType == 1) //tinh tien ck theo % (ck theo tien da duoc tinh tu form addServices)
                            //{
                            //    if (commission.CommissionPercent != 0)
                            //    {
                            //        var comMoney = (commission.CommissionPercent / 100) * commission.Service.Price * (commission.Service.Discount / 100);
                            //        commission.ComMoney = Convert.ToInt32(comMoney);
                            //    }
                            //}
                            //marked with 100 value 
                            //if (commission.SellComMoney == 100)
                            //    commission.SellComMoney = Convert.ToInt32((commission.Service.SellDiscount / 100) * commission.Service.Price);

                            commission.Transaction = objTransaction;
                            //objTransaction.Services.Add(objService);
                            db.ComissionList.Add(commission);
                            if (db.Entry<Commission>(commission).State == System.Data.Entity.EntityState.Detached)
                                db.Set<Commission>().Attach(commission);
                        }
                        db.Entry<Transaction>(objTransaction).State = System.Data.Entity.EntityState.Added;
                        db.SaveChanges();
                        dlLoadCallback(chairId, objTransaction.TransactionId);
                        dlLoadCallback2();
                        this.Close();
                    }
                }
                else //update
                {
                    Edit("Edit");
                    dlLoadCallback2();
                }
            }
        }

        public void Edit(string action)
        {
            //int customerId = Convert.ToInt16(cbCustomer.EditValue);
            //using (ModelContext db = new ModelContext())
            //{
            //    List<Commission> commissionToRemove = db.ComissionList.Where(c => c.Transaction.TransactionId == transactionId).ToList();
            //    foreach (var commission in commissionToRemove)
            //    {
            //        db.Entry<Commission>(commission).State = System.Data.Entity.EntityState.Deleted;
            //    }
            //    Transaction objTransaction = db.TransactionList.Where(t => t.TransactionId == transactionId).FirstOrDefault();
            //    db.Entry<Transaction>(objTransaction).Collection(t => t.Services).Load();
            //    objTransaction.Services.Clear();
            //    db.Entry<Transaction>(objTransaction).State = System.Data.Entity.EntityState.Modified;
            //    db.SaveChanges();
            //}
            //using (ModelContext db = new ModelContext())
            //{
            //    Transaction objTransaction = db.TransactionList.Single(t => t.TransactionId == transactionId);
            //    objTransaction.Amount = amount;
            //    objTransaction.Note = txtNote.Text.Trim();
            //    if (action.Equals("Money"))
            //        objTransaction.Status = 0;
            //    if (db.Entry<Transaction>(objTransaction).State == System.Data.Entity.EntityState.Detached)
            //        db.Set<Transaction>().Attach(objTransaction);
            //    db.Entry<Transaction>(objTransaction).State = System.Data.Entity.EntityState.Modified;

            //    Chair objChair = db.ChairList.Where(c => c.ChairId == chairId).FirstOrDefault();
            //    objTransaction.Chair = objChair;

            //    Customer objCustomer = null;
            //    if (customerId != 0)
            //        objCustomer = db.CustomerList.Where(c => c.CustomerId == customerId).FirstOrDefault();
            //    objTransaction.Customer = objCustomer;

            //    for (int i = 0; i < commissionList.Count(); i++)
            //    {
            //        Commission commission = commissionList[i];
            //        Employee objEmployee = db.EmployeeList.Where(m => m.EmployeeId == commission.Employee.EmployeeId).FirstOrDefault();
            //        commission.Employee = objEmployee;
            //        //calculte comMoney for percent discount
            //        if (commission.CommissionPercent != 0)
            //        {
            //            int price = commission.Service.Price;
            //            if (commission.OtherPrice != 0)
            //            {
            //                price = commission.OtherPrice;
            //            }
            //            var comMoney = (commission.CommissionPercent / 100) * price * (commission.Service.Discount / 100);
            //            commission.ComMoney = Convert.ToInt32(comMoney);
            //        }
            //        Service objService = db.ServiceList.Where(s => s.ServiceId == commission.Service.ServiceId).FirstOrDefault();
            //        commission.Service = objService;

            //        if (commission.SellComMoney == 100)
            //            commission.SellComMoney = Convert.ToInt32((commission.Service.SellDiscount / 100) * commission.Service.Price);

            //        commission.Transaction = objTransaction;
            //        objTransaction.Services.Add(objService);
            //        db.ComissionList.Add(commission);
            //        if (db.Entry<Commission>(commission).State == System.Data.Entity.EntityState.Detached)
            //            db.Set<Commission>().Attach(commission);
            //    }
            //    db.SaveChanges();
            //    if (action.Equals("Money"))
            //    {
            //        dlLoadCallback(chairId, objTransaction.TransactionId);
            //        dlLoadCallback2();
            //        Print(objTransaction.TransactionDate.ToString("dd/MM/yyyy"));
            //    }
            //    this.Close();
            //}
        }

        public void Print(string pDate)
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
                new Microsoft.Reporting.WinForms.ReportParameter("pTransactionIdCoded", string.Format("GD-{0:D5}", transactionId))
            };
            report.SetParameters(para);

            ReportPrintDocument rp = new ReportPrintDocument(report);
            rp.Print();
        }

        private void btnMoney_Click(object sender, EventArgs e)
        {
            if (validateData())
            {
                if (new MyMessage().QuestionDev("Kết thúc GD & in hóa đơn"))
                {
                    Edit("Money");
                }
            }
        }

        private void btnRemoveService_Click(object sender, EventArgs e)
        {
            if (dtService.Rows.Count > 0)
            {
                int serviceId = (int)gvDetail.GetRowCellValue(gvDetail.FocusedRowHandle, "ServiceId");
                removeService(serviceId);
            }
        }

        protected void removeService(int serviceId)
        {
            serviceViewList.Remove(serviceViewList.Where(s => s.ServiceId == serviceId).FirstOrDefault());
            serviceList.Remove(serviceList.Where(s => s.ServiceId == serviceId).FirstOrDefault());
            var commissionToRemove = commissionList.Where(c => c.Service.ServiceId == serviceId).ToList();
            foreach (var commission in commissionToRemove)
            {
                commissionList.Remove(commission);
            }
            for (int i = 0; i < dtService.Rows.Count; i++)
            {
                if ((int)dtService.Rows[i]["ServiceId"] == serviceId)
                {
                    amount -= Convert.ToInt32(dtService.Rows[i]["Price"]) * Convert.ToInt32(dtService.Rows[i]["Quantity"]);
                    dtService.Rows.RemoveAt(i);
                }
            }
            lblAmount.Text = "Tổng: " + amount.ToString("N0") + " VNĐ";
        }

        private void gvDetail_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Delete)
            {
                if (dtService.Rows.Count > 0)
                {
                    int serviceId = (int)gvDetail.GetRowCellValue(gvDetail.FocusedRowHandle, "ServiceId");
                    removeService(serviceId);
                } 
            }
        }

        private void btnAddService_Click(object sender, EventArgs e)
        {
            
            Point startPoint = new Point(this.Location.X + this.Width, this.Location.Y);
            AddServiceForm asf = new AddServiceForm(serviceViewList, startPoint);
            asf.dlSendBackCall = this.GetCommissionServiceEmployee;
            asf.dlRemoveCallback = this.removeService;
            asf.ShowDialog();

        }

        private void gvDetail_DoubleClick(object sender, EventArgs e)
        {
            GridView gridView = (GridView)sender;
            Point point = gridView.GridControl.PointToClient(System.Windows.Forms.Control.MousePosition);
            DoRowDoubleClick(gridView, point);
        }

        private void DoRowDoubleClick(GridView gridView, Point point)
        {
            GridHitInfo info = gridView.CalcHitInfo(point);
            if ((info.InRow ? true : info.InRowCell))
            {
                try
                {
                    if (gvDetail.GetMasterRowExpanded(gvDetail.FocusedRowHandle))
                    {
                        gvDetail.CollapseMasterRow(gvDetail.FocusedRowHandle);
                    }
                    else
                    {
                        gvDetail.ExpandMasterRow(gvDetail.FocusedRowHandle);
                    }
                }
                catch (Exception) { 
                }
            }
        }

        private void gvMainDetail_ProcessGridKey(object sender, KeyEventArgs e)
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
            if (keyData == (Keys.T | Keys.Control))
            {
                btnAddService.PerformClick();
                return true;
            }
            if (keyData == (Keys.S | Keys.Control))
            {
                btnSave.PerformClick();
                return true;
            }
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

        private void TransactionForm_KeyDown(object sender, KeyEventArgs e)
        {
            //if (e.KeyCode )
            //{
                
            //}
        }
    }
}
