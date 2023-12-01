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
using DevExpress.XtraGrid.Views.Grid;
using DevExpress.XtraGrid.Views.Grid.ViewInfo;
using System.Data.Entity;

namespace DuHair
{
    public partial class HomeForm : DevExpress.XtraEditors.XtraForm
    {
        List<EmployeeHomeView> employeeList = new List<EmployeeHomeView>();
        List<ServiceView> serviceList = new List<ServiceView>();
        MyMessage mess = new MyMessage();
        //const int NumberOfChair = 13;
        //PictureEdit[] BunchOfChair;
        CheckBox[] employeeCheckboxes;
        PanelControl[] servicePanels, employeePanels;
        Label[] serviceLabels;
        Label[] counterLabels;
        public static LabelControl[] BunchOfService;
        public HomeForm()
        {
            InitializeComponent();
        }

        private void HomeForm_Load(object sender, EventArgs e)
        {
            //InitChair();
            //loadDoingTransaction();
            employeeList = LoadEmployeeList();
            serviceList = LoadServiceList();
            InitServiceButton(new Size(110, 80), serviceList.Count(), panelService);
            InitEmployeeCheckbox(new Size(130, 35), employeeList.Count(), panelEmployee);
            LoadDataTransaction();
            //LoadDataSellTransaction();
            this.MaximizeBox = true;
        }

        private List<ServiceView> LoadServiceList()
        {
            using (ModelContext db = new ModelContext())
            {
                var list = (from s in db.ServiceList
                               where (s.Status.Equals("Hiển thị"))
                               orderby (s.Order)
                               select (new ServiceView
                               {
                                   ServiceId = s.ServiceId,
                                   Name = s.Name,
                                   Price = s.Price,
                                   Quantity = 0
                               })).ToList();
                return list;
            }
        }

        private List<EmployeeHomeView> LoadEmployeeList()
        {
            using (ModelContext db = new ModelContext())
            {
                var list = (from m in db.EmployeeList
                           where (m.Status.Equals("Hiển thị") && !m.Role.Equals("Admin", StringComparison.InvariantCultureIgnoreCase))
                           select (new EmployeeHomeView { 
                                EmployeeId = m.EmployeeId,
                                Name = m.Name,
                                DiscountMoney = 5000,
                                Selected = false
                           })).ToList();
                return list;
            }
        }

        public bool MyFunction(DateTime s)
        {
            var today = DateTime.Today.Date;
            return (s.Date == today);
        }

        protected void LoadDataTransaction()
        {
            //Thread thread = new Thread(new ThreadStart((Action)(() =>
            //{
            var today = DateTime.Now;
                using (ModelContext db = new ModelContext())
                {
                var result = db.TransactionList.Include("Customer").Where(x => x.TransactionDate.Year == today.Year && 
                                                            x.TransactionDate.Month == today.Month && 
                                                            x.TransactionDate.Day == today.Day && 
                                                            x.IsDelete == false).ToList();


                //var result = from t in db.TransactionList
                //             where ((t.TransactionDate.Year == DateTime.Now.Year) &&
                //                    (t.TransactionDate.Month == DateTime.Now.Month)
                //                    //&&
                //                    //(t.TransactionDate.Day == DateTime.Now.Day)
                //                    //&&
                //                    //t.IsDelete == false)
                //                    )
                //             select (new TransactionStatisticView
                //             {
                //                 TransactionId = t.TransactionId,
                //                 Name = t.Customer.Name,
                //                 TransactionDate = t.TransactionDate,
                //                 Amount = t.Amount
                //             });

                List < TransactionStatisticView> transactionStatisticViewList = new List<TransactionStatisticView>();
                    //try
                    //{
                    foreach (var item in result)
                    {
                        transactionStatisticViewList.Add(new TransactionStatisticView { Amount = item.Amount,
                                                                                        TransactionDate = item.TransactionDate,
                                                                                        TransactionId = item.TransactionId, 
                                                                                        Name = item.Customer != null ? item.Customer.Name : ""
                                                                                      });
                    }
                    //transactionStatisticViewList = result.ToList();
                    foreach (var transactionStatisticView in transactionStatisticViewList)
                            transactionStatisticView.TransactionIdCoded = string.Format("GD-{0:D5}", transactionStatisticView.TransactionId);
                        this.Invoke((Action)(() =>
                        {
                            gvMain.DataSource = transactionStatisticViewList;
                        }));
                    //}
                    //catch (Exception ex)
                    //{
                    //    var ww = ex.Message;
                    //}
                }
                foreach (var employee in employeeList)
                {
                    employee.Selected = false;
                }
                foreach (var service in serviceList)
                {
                    service.Quantity = 0;
                }
            //})));
            //thread.Start();
        }

        public void LoadDataSellTransaction()
        {
            Thread thread = new Thread(new ThreadStart((Action)(() =>
            {
                using (ModelContext db = new ModelContext())
                {
                    db.Database.Connection.Open();
                    //select from 2 tables and sum one table and map to a class
                    var result = from s in db.SellTranList
                                 join dt in db.SellTranDetailList on s.SellTranId equals dt.SellTran.SellTranId
                                 where (s.SellDate.Day == DateTime.Now.Day)
                                 group dt by new {s.SellTranId, s.Amount, s.Customer.Name, EmployeeName = s.Employee.Name , s.SellDate} into g
                                 select (new SellTranView {
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
                            //gvSellTranMain.DataSource = sellTranViewList;
                        }));
                    }
                    catch (Exception){}
                }
            })));
            thread.Start();
        }

        private void InitEmployeeCheckbox(Size boxSize, int numberOfBoxes, Panel parentPanel)
        {
            employeePanels = new PanelControl[numberOfBoxes];
            employeeCheckboxes = new CheckBox[numberOfBoxes];
            for (int i = 0; i < numberOfBoxes; i++)
            {
                employeePanels[i] = new PanelControl();
                employeeCheckboxes[i] = new CheckBox();
                parentPanel.Controls.Add(employeePanels[i]);

                employeePanels[i].Name = "pnE" + (i + 1).ToString();
                employeePanels[i].Location = new System.Drawing.Point(3, 3);
                employeePanels[i].LookAndFeel.UseDefaultLookAndFeel = false;
                employeePanels[i].LookAndFeel.Style = DevExpress.LookAndFeel.LookAndFeelStyle.Flat;
                employeePanels[i].Appearance.Options.UseBackColor = true;
                employeePanels[i].Appearance.BackColor = Color.FromArgb(82, 151, 201);
                employeePanels[i].BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
                employeePanels[i].Size = boxSize;
                employeePanels[i].Controls.Add(employeeCheckboxes[i]);
                employeePanels[i].Tag = employeeList[i].EmployeeId;

                employeeCheckboxes[i].Name = "cbE" + (i + 1).ToString();
                employeeCheckboxes[i].Location = new System.Drawing.Point(3,4);
                employeeCheckboxes[i].Size = new Size(boxSize.Width - 6, boxSize.Height - 7);
                employeeCheckboxes[i].Text = employeeList[i].Name;
                employeeCheckboxes[i].Tag = employeeList[i].EmployeeId;
                employeeCheckboxes[i].Font = new Font("Tahoma", 12F);
                employeeCheckboxes[i].TextAlign = ContentAlignment.MiddleLeft;
                employeeCheckboxes[i].CheckedChanged += new EventHandler(employeeCheckChanged);
            }
        }

        protected void employeeCheckChanged(object sender, EventArgs e)
        {
            CheckBox cbEmployee = (CheckBox)sender;
            int employeeId = Convert.ToInt32(cbEmployee.Tag);
            if (cbEmployee.Checked)
            {
                employeeList.Where(m => m.EmployeeId == employeeId).First().Selected = true;
            }
            else
            {
                employeeList.Where(m => m.EmployeeId == employeeId).First().Selected = false;
            }
        }

        private void InitServiceButton(Size boxSize, int numberOfBoxes, Panel parentPanel)
        { 
            servicePanels = new PanelControl[numberOfBoxes];
            counterLabels = new Label[numberOfBoxes];
            serviceLabels = new Label[numberOfBoxes];

            for (int i = 0; i < numberOfBoxes; i++)
            {
                servicePanels[i] = new PanelControl();
                counterLabels[i] = new Label();
                serviceLabels[i] = new Label();
                parentPanel.Controls.Add(servicePanels[i]);

                servicePanels[i].Name = "pnSv" + (i + 1).ToString();
                servicePanels[i].Location = new System.Drawing.Point(3, 3);
                servicePanels[i].LookAndFeel.UseDefaultLookAndFeel = false;
                servicePanels[i].LookAndFeel.Style = DevExpress.LookAndFeel.LookAndFeelStyle.Flat;
                servicePanels[i].Appearance.Options.UseBackColor = true;
                servicePanels[i].Appearance.BackColor = Color.FromArgb(82,151,201);
                servicePanels[i].BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
                servicePanels[i].Size = boxSize;
                servicePanels[i].Controls.Add(counterLabels[i]);
                servicePanels[i].Controls.Add(serviceLabels[i]);
                servicePanels[i].Tag = serviceList[i].ServiceId;
                servicePanels[i].Click += new EventHandler(Services_Click);

                serviceLabels[i].Name = "lbSv" + (i + 1).ToString();
                serviceLabels[i].Location = new System.Drawing.Point(3, 3);
                serviceLabels[i].Size = new Size(boxSize.Width - 6, boxSize.Height - 18);
                serviceLabels[i].Text = serviceList[i].Name;
                serviceLabels[i].Font = new Font("Tahoma", 12F);
                serviceLabels[i].ForeColor = Color.White;
                serviceLabels[i].TextAlign = ContentAlignment.MiddleCenter;
                serviceLabels[i].Tag = serviceList[i].ServiceId;
                serviceLabels[i].Click += new EventHandler(Services_Click);

                counterLabels[i].Name = "lbCounter" + (i + 1).ToString();
                counterLabels[i].Location = new System.Drawing.Point(boxSize.Width - 38, boxSize.Height - 23);
                counterLabels[i].Text = "x";
                counterLabels[i].Size = new Size(38, 22);
                counterLabels[i].AutoSize = false;
                counterLabels[i].ForeColor = Color.White;
                counterLabels[i].BackColor = Color.Red;
                counterLabels[i].TextAlign = ContentAlignment.MiddleCenter;
                counterLabels[i].Font = new Font("Tahoma", 12F);
                counterLabels[i].Tag = serviceList[i].ServiceId;
                counterLabels[i].Click += new EventHandler(Services_Click);
                counterLabels[i].Visible = false;
            }
        }

        protected void Services_Click(object sender, EventArgs e)
        {
            if (sender is Label)
            {
                Label counterOrName = (Label)sender;
                if (counterOrName.Name.IndexOf("lbCounter") != -1) //if label is counter then minus the quantity
                {
                    Label lbCounter = counterOrName;
                    int serviceId = Convert.ToInt32(lbCounter.Tag);
                    serviceList.Where(s => s.ServiceId == serviceId)
                               .Where(s => s.Quantity > 0)
                               .First().Quantity -= 1;
                    lbCounter.Text = "x" + serviceList.Where(s => s.ServiceId == serviceId).First().Quantity.ToString();
                    if (lbCounter.Text.Equals("x0"))
                        lbCounter.Visible = false;
                }
                else //if label is serviceName then add the quantity
                {
                    int serviceId = Convert.ToInt32(counterOrName.Tag);
                    string counterName = "lbCounter" + counterOrName.Name.Split('v')[1].ToString();
                    var lbCounter = this.Controls.Find(counterName, true)[0];
                    lbCounter.Visible = true;
                    serviceList.Where(s => s.ServiceId == serviceId).First().Quantity += 1;
                    lbCounter.Text = "x" + serviceList.Where(s => s.ServiceId == serviceId).First().Quantity.ToString();    
                }
            }
            else
            {
                PanelControl panelService = (PanelControl)sender;
                int serviceId = Convert.ToInt32(panelService.Tag);
                string counterName = "lbCounter" + panelService.Name.Split('v')[1].ToString();
                var lbCounter = this.Controls.Find(counterName, true)[0];
                lbCounter.Visible = true;
                serviceList.Where(s => s.ServiceId == serviceId).First().Quantity += 1;
                lbCounter.Text = "x" + serviceList.Where(s => s.ServiceId == serviceId).First().Quantity.ToString();  
            }
        }

        //private void InitChair()
        //{
        //    Thread insertThread = new Thread(new ThreadStart((Action)(() =>
        //    {
        //        BunchOfChair = new PictureEdit[NumberOfChair];
        //        BunchOfLabel = new Label[NumberOfChair];
        //        BunchOfPanel = new PanelControl[NumberOfChair];
        //        this.Invoke((Action)(() =>
        //        {
        //            var PsList = new List<string>();
        //            for (int i = 0; i < NumberOfChair; i++)
        //            {
        //                PsList.Add("Ghế " + (i + 1).ToString());
        //                BunchOfChair[i] = new PictureEdit();
        //                BunchOfPanel[i] = new PanelControl();
        //                BunchOfLabel[i] = new Label();
        //                panelService.Controls.Add(BunchOfPanel[i]);
        //                BunchOfPanel[i].Name = "Panel" + (i + 1).ToString();
        //                BunchOfPanel[i].Location = new System.Drawing.Point(3, 3);
        //                BunchOfPanel[i].LookAndFeel.UseDefaultLookAndFeel = false;
        //                BunchOfPanel[i].LookAndFeel.Style = DevExpress.LookAndFeel.LookAndFeelStyle.Flat;
        //                BunchOfPanel[i].Appearance.Options.UseBackColor = true;
        //                BunchOfPanel[i].BackColor = Color.White;
        //                BunchOfPanel[i].Appearance.BackColor = Color.White;
        //                BunchOfPanel[i].BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
        //                BunchOfPanel[i].Width = 100;
        //                BunchOfPanel[i].Height = 33;
        //                BunchOfPanel[i].Controls.Add(BunchOfChair[i]);
        //                BunchOfPanel[i].Controls.Add(BunchOfLabel[i]);

        //                BunchOfPanel[i].DoubleClick += new EventHandler(Ps_DoubleClick);
        //                BunchOfChair[i].Properties.NullText = "";
        //                BunchOfChair[i].Location = new System.Drawing.Point(1, 1);
        //                BunchOfChair[i].Name = "Chair" + (i + 1).ToString();
        //                BunchOfChair[i].Tag = "0";
        //                BunchOfChair[i].ToolTip = (i + 1).ToString();
        //                BunchOfChair[i].Properties.AllowFocused = false;
        //                BunchOfChair[i].Properties.Appearance.BackColor = System.Drawing.Color.ForestGreen;
        //                BunchOfChair[i].Properties.Appearance.ForeColor = System.Drawing.Color.Transparent;
        //                BunchOfChair[i].Properties.Appearance.Options.UseBackColor = true;
        //                BunchOfChair[i].Properties.Appearance.Options.UseForeColor = true;
        //                BunchOfChair[i].Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
        //                BunchOfChair[i].Properties.SizeMode = DevExpress.XtraEditors.Controls.PictureSizeMode.Stretch;
        //                BunchOfChair[i].Size = new System.Drawing.Size(10, 31);
        //                BunchOfChair[i].EditValue = global::DuHair.Properties.Resources.Green;
        //                BunchOfChair[i].DoubleClick += new EventHandler(Ps_DoubleClick);

        //                BunchOfLabel[i].Name = "lblCh" + (i + 1).ToString();
        //                BunchOfLabel[i].Location = new System.Drawing.Point(17, 9);
        //                BunchOfLabel[i].Text = PsList[i];
        //                BunchOfLabel[i].Font = new Font("Arial", 10F);
        //                BunchOfLabel[i].DoubleClick += new EventHandler(Ps_DoubleClick);
        //            }
        //        }));
        //    })));
        //    insertThread.Start();
        //}

        //protected void SwitchChairForm(int chairId, int transactionId)
        //{
        //    if (BunchOfChair[chairId-1].Properties.Appearance.BackColor.Name.Equals("ForestGreen"))
        //    {
        //        BunchOfChair[chairId-1].EditValue = global::DuHair.Properties.Resources.Red;
        //        BunchOfChair[chairId-1].Properties.Appearance.BackColor = Color.DarkRed;
        //        BunchOfChair[chairId-1].Tag = transactionId;
        //    }
        //    else
        //    {
        //        BunchOfChair[chairId - 1].EditValue = global::DuHair.Properties.Resources.Green;
        //        BunchOfChair[chairId - 1].Properties.Appearance.BackColor = Color.ForestGreen;
        //        BunchOfChair[chairId - 1].Tag = 0;
        //    }
        //}

        private void switchStatus(string text, Color color, string action)
        {
            try
            {
                this.Invoke((Action)(() =>
                {
                    LabelControl lbStatus = ((MainForm)this.MdiParent).lbStatus;
                    PictureEdit picStatus = ((MainForm)this.MdiParent).picStatus;
                    lbStatus.Text = text;
                    lbStatus.ForeColor = color;
                    picStatus.Properties.SizeMode = DevExpress.XtraEditors.Controls.PictureSizeMode.Stretch;
                    if (action.Equals("loading"))
                        picStatus.Image = global::DuHair.Properties.Resources.loading3;  
                    else if (action.Equals("done"))
                        picStatus.Image = null;
                }));
            }
            catch (Exception) { }
        }

        //protected void loadDoingTransaction()
        //{
        //    IEnumerable<Transaction> doingTransaction = null;
        //    Thread thread = new Thread(new ThreadStart((Action)(() => { 
        //        using (ModelContext db = new ModelContext())
        //        {
        //            doingTransaction = db.TransactionList.Where(t => t.Status == 1).ToList();
        //            foreach (var transaction in doingTransaction)
        //            {
        //                db.Entry<Transaction>(transaction).Reference(t => t.Chair).Load();
        //                if (this.IsHandleCreated)
        //                {
        //                    this.Invoke((Action)(() =>
        //                    {
        //                        BunchOfChair[transaction.Chair.ChairId - 1].EditValue = global::DuHair.Properties.Resources.Red;
        //                        BunchOfChair[transaction.Chair.ChairId - 1].Properties.Appearance.BackColor = Color.DarkRed;
        //                        BunchOfChair[transaction.Chair.ChairId - 1].Tag = transaction.TransactionId;
        //                    }));
        //                }
        //            }
        //        }
        //    })));
        //    thread.Start();
        //}

        protected void Ps_DoubleClick(object sender, EventArgs e)
        {
            switchStatus("Đang xử lý", Color.White, "loading");
            Thread insertThread = new Thread(new ThreadStart((Action)(() =>
            {
                string chairId, transactionId = "";
                PictureEdit pic = null;
                if (sender is PictureEdit)
                    pic = (PictureEdit)sender;
                else
                {
                    PanelControl panel = null;
                    if (sender is LabelControl)
                    {
                        LabelControl label = null;
                        label = (LabelControl)sender;
                        panel = (PanelControl)label.Parent;
                    }
                    else
                    {
                        panel = (PanelControl)sender;
                    }
                    pic = panel.Controls.OfType<PictureEdit>().First();
                }
                transactionId = pic.Tag.ToString();
                chairId = pic.ToolTip;
                
                this.Invoke((Action)(() =>
                {
                    TransactionForm tran = new TransactionForm(Convert.ToInt16(transactionId), Convert.ToInt16(chairId), "insertOrEdit");
                    //tran.dlLoadCallback = new TransactionForm.dlLoad(SwitchChairForm);
                    tran.dlLoadCallback2 = new TransactionForm.dlLoad2(LoadDataTransaction);
                    switchStatus("",Color.White, "done");
                    tran.ShowDialog();
                }));
                
            })));
            insertThread.Start();
        }

        private void gvTransaction_CustomColumnDisplayText(object sender, DevExpress.XtraGrid.Views.Base.CustomColumnDisplayTextEventArgs e)
        {
            //if (e.Column == colStatus)
            //{
            //    if (e.Value.ToString().Equals("1"))
            //    {
            //        e.DisplayText = "Đang thực hiện";
            //    }
            //    else
            //    {
            //        e.DisplayText = "Đã xong";
            //    }
            //}
        }

        private void DoRowDoubleClick(GridView gridView, Point pt)
        {
            GridHitInfo info = gridView.CalcHitInfo(pt);
            if ((info.InRow ? true : info.InRowCell))
            {
                if (gridView.Name.Equals("gvTransaction"))
                {
                    try
                    {
                        using(ModelContext db = new ModelContext())
	                    {
		                    int TransactionId = Convert.ToInt16(gvTransaction.GetRowCellValue(info.RowHandle, "TransactionId"));
                            
                            TransactionForm2 tf2 = new TransactionForm2(TransactionId, new List<EmployeeHomeView>(), new List<ServiceView>());
                            tf2.ShowDialog();
	                    }
                        
                    }
                    catch (Exception) { }
                }
                //else if (gridView.Name.Equals("gvSellTran"))
                //{
                //    int SellTranId = Convert.ToInt32(gvSellTran.GetRowCellValue(info.RowHandle, "SellTranId"));
                //    SellTranForm st = new SellTranForm(SellTranId);
                //    st.ShowDialog();
                //}
            }
        }

        private void gvTransaction_DoubleClick(object sender, EventArgs e)
        {
            GridView gridView = (GridView)sender;
            Point pt = gridView.GridControl.PointToClient(System.Windows.Forms.Control.MousePosition);
            DoRowDoubleClick(gridView, pt);
        }

        private void gvSellTran_DoubleClick(object sender, EventArgs e)
        {
            GridView gridView = (GridView)sender;
            Point pt = gridView.GridControl.PointToClient(System.Windows.Forms.Control.MousePosition);
            DoRowDoubleClick(gridView, pt);
        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            bool flag = false;
            for (int i = 0; i < serviceList.Count(); i++)
            {
                if (serviceList[i].Quantity > 0)
                    flag = true;
            }
            if (flag)
            {
                var passServiceList = serviceList.Where(s => s.Quantity > 0).ToList();
                var passEmployeeList = employeeList.Where(m => m.Selected == true).ToList();
                TransactionForm2 tf2 = new TransactionForm2(0, passEmployeeList, passServiceList);
                tf2.dlLoadCallback = this.LoadDataTransaction;
                tf2.dlLoadCallback2 = this.ClearSelectedServiceAndEmployee;
                tf2.ShowDialog();
            }
            else
            {
                new MyMessage().InformationDev("Vui lòng chọn dịch vụ");
            }
        }

        protected void ClearSelectedServiceAndEmployee()
        {
            serviceList.Clear();
            employeeList.Clear();
            employeeList = LoadEmployeeList();
            serviceList = LoadServiceList();
            for (int i = 0; i < counterLabels.Count(); i++)
            {
                if (counterLabels[i].Text.IndexOf('x') != -1)
                {
                    counterLabels[i].Text = "";
                    counterLabels[i].Visible = false;
                }
            }
            for (int i = 0; i < employeeCheckboxes.Count(); i++)
            {
                employeeCheckboxes[i].Checked = false;
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            ClearSelectedServiceAndEmployee();
        }

        private void gvTransaction_KeyDown(object sender, KeyEventArgs e)
        {
            using(ModelContext db = new ModelContext())
            {
                if (MainForm.currentRole.Equals("Admin"))
                {
                    if (e.KeyCode == Keys.Delete)
                    {
                        if (new MyMessage().QuestionDev("Bạn muốn xóa hóa đơn này"))
	                    {
		                    int transactionId = Convert.ToInt32(gvTransaction.GetRowCellValue(gvTransaction.FocusedRowHandle, "TransactionId"));
                            Transaction objTransaction = db.TransactionList.Where(m => m.TransactionId == transactionId).FirstOrDefault();
                            objTransaction.IsDelete = true;
                            db.SaveChanges();
                            gvTransaction.DeleteRow(gvTransaction.FocusedRowHandle);
	                    }
                    }
                }
	        }
        }
    }
}