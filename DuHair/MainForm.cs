using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraBars;
using System.Threading;
using System.Diagnostics;

namespace DuHair
{
    public partial class MainForm : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        HomeForm homeForm;
        string role, oldPwwwd = "";
        public static int currentEmployeeId;
        public static string currentEmployeeName;
        public MainForm(string role, string oldPwwwd, int employeeId, string employeeName)
        {
            InitializeComponent();
            this.role = role;
            this.oldPwwwd = oldPwwwd;
            currentEmployeeId = employeeId;
            currentEmployeeName = employeeName;
            this.WindowState = FormWindowState.Maximized;
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            OpenForm("Home");
            RoleManage();
            InsertMonthly();
        }

        protected void RoleManage()
        {
            if (role.Equals("Thu ngân"))
            {
                this.Invoke((Action)(() =>
                {
                    btnEmployee.Visibility = BarItemVisibility.Never;
                    btnStock.Visibility = BarItemVisibility.Never;
                    btnRestock.Visibility = BarItemVisibility.Never;
                    btnSpend.Visibility = BarItemVisibility.Never;
                    btnStatistic.Visibility = BarItemVisibility.Never;
                    btnTimeKeeping.Visibility = BarItemVisibility.Never;
                }));
            }
        }

        private void switchStatus(string text, Color color, string action)
        {
            try
            {
                this.Invoke((Action)(() =>
                {
                    lbStatus.Text = text;
                    lbStatus.ForeColor = color;
                    picStatus.Properties.SizeMode = DevExpress.XtraEditors.Controls.PictureSizeMode.Stretch;
                    if (action.Equals("loading"))
                    {
                        picStatus.Image = global::DuHair.Properties.Resources.loading3;
                        ribbon.Enabled = false;
                    }
                    else if (action.Equals("done"))
                    { 
                        picStatus.Image = null;
                        ribbon.Enabled = true;
                    }
                }));
            }
            catch (Exception) {}
        }

        protected void InsertMonthly()
        {
            Thread thread = new Thread(new ThreadStart((Action)(() => { 
                using (ModelContext db = new ModelContext())
                {
                    var rs = db.SpendNoteList.Where(s => s.Monthly == true)
                                             .GroupBy(s => s.Name) 
                                             .Select(g => g.OrderByDescending(x => x.SpendNoteId).FirstOrDefault()).ToList();
                    foreach (var spendNote in rs)
                    {
                        if (DateTime.Now.Day == spendNote.SpendDate.Day)
                        {
                            if (DateTime.Now.Month > spendNote.SpendDate.Month)
                            {
                                SpendNote objSpendNote = new SpendNote {
                                    AmountMoney = spendNote.AmountMoney,
                                    Monthly = true,
                                    Name = spendNote.Name,
                                    SpendDate = DateTime.Now
                                };
                                db.SpendNoteList.Add(objSpendNote);
                            }
                        }
                    }
                    db.SaveChanges();
                }
            })));
            thread.Start();
        }

        protected void OpenForm(string name)
        {
            foreach (DevExpress.XtraTabbedMdi.XtraMdiTabPage pg in mdiManager.Pages)
            {
                if (pg.MdiChild.Name == name)
                {
                    mdiManager.SelectedPage = pg;
                    return;
                }
            }
            Form frm = null;
            Thread insertThread = new Thread(new ThreadStart((Action)(() =>
            {
                switchStatus("Đang xử lý", Color.White, "loading");
                if (name.Equals("Home"))
                    homeForm = new HomeForm();
                if (name.Equals("Employee"))
                    frm = new EmployeeForm();
                if (name.Equals("Service"))
                    frm = new ServiceForm();
                if (name.Equals("Material"))
                    frm = new MaterialForm();
                if (name.Equals("Customer"))
                    frm = new CustomerForm();
                if (name.Equals("Warehouse"))
                    frm = new WarehouseForm();
                if (name.Equals("Restock"))
                    frm = new RestockForm();
                if (name.Equals("Statistic"))
                    frm = new StatisticForm();
                if (name.Equals("SpendNote"))
                    frm = new SpendNoteForm();
                if (name.Equals("TimeKeepingForm"))
                    frm = new TimeKeepingForm();
                this.Invoke((Action)(() =>
                {
                    if (name.Equals("Home"))
                    {
                        homeForm.MdiParent = this;
                        homeForm.Name = name;
                        homeForm.Show();
                    }
                    else
                    {
                        frm.MdiParent = this;
                        frm.Name = name;
                        frm.Show();
                    }
                }));
                switchStatus("", Color.White, "done");
            })));
            insertThread.Start();
        }

        private void btnHome_ItemClick(object sender, ItemClickEventArgs e)
        {
            OpenForm("Home");
        }

        private void btnEmployee_ItemClick(object sender, ItemClickEventArgs e)
        {
            OpenForm("Employee");
        }

        private void btnService_ItemClick(object sender, ItemClickEventArgs e)
        {
            OpenForm("Service");
        }

        private void btnMaterial_ItemClick(object sender, ItemClickEventArgs e)
        {
            OpenForm("Material");
        }

        private void btnCustomer_ItemClick(object sender, ItemClickEventArgs e)
        {
            OpenForm("Customer");
        }

        private void btnStock_ItemClick(object sender, ItemClickEventArgs e)
        {
            OpenForm("Warehouse");
        }

        private void btnRestock_ItemClick(object sender, ItemClickEventArgs e)
        {
            OpenForm("Restock");
        }

        private void btnStatistic_ItemClick(object sender, ItemClickEventArgs e)
        {
            OpenForm("Statistic");
        }

        private void btnSpend_ItemClick(object sender, ItemClickEventArgs e)
        {
            OpenForm("SpendNote");
        }

        private void btnTimeKeeping_ItemClick(object sender, ItemClickEventArgs e)
        {
            OpenForm("TimeKeepingForm");
        }

        private void btnChangePw_ItemClick(object sender, ItemClickEventArgs e)
        {
            ChangePwwwdForm cp = new ChangePwwwdForm(oldPwwwd, currentEmployeeId);
            cp.ShowDialog();
        }

        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            foreach (Form child in this.MdiChildren)
            {
                if (!child.Focused)
                {
                    child.Close();
                }
            }
            Application.ExitThread();
            Application.Exit();
        }

        private void MainForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
            Process[] prs = Process.GetProcesses();
            try
            {
                foreach (Process pr in prs)
                {
                    string processName = pr.ProcessName;
                    if (processName == "DuHair")
                    {
                        pr.Kill();
                    }
                }
            }
            catch (Exception)
            {
            }
            
        }

        private void barButtonItem3_ItemClick(object sender, ItemClickEventArgs e)
        {
            Thread thread = new Thread(new ThreadStart((Action)(() =>
            {
                SellTranForm st = new SellTranForm(0);
                st.dlLoadCallback = homeForm.loadDataSellTransaction;
                this.Invoke((Action)(() =>
                {
                    st.ShowDialog();
                }));
            })));
            thread.Start();
        }
    }
}