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

namespace DuHair
{
    public partial class HomeForm : DevExpress.XtraEditors.XtraForm
    {
        MyMessage mess = new MyMessage();
        const int NumberOfPs = 13;
        PictureEdit[] BunchOfChair = new PictureEdit[NumberOfPs];
        PanelControl[] BunchOfPanel = new PanelControl[NumberOfPs];
        LabelControl[] BunchOfLabel = new LabelControl[NumberOfPs];
        public static LabelControl[] BunchOfService = new LabelControl[NumberOfPs];
        public HomeForm()
        {
            InitializeComponent();
        }

        private void HomeForm_Load(object sender, EventArgs e)
        {
            Init();
            loadDoingTransaction();
            loadDataTransaction();
            loadDataSellTransaction();
            this.MaximizeBox = true;
        }

        protected void loadDataTransaction()
        {
            Thread thread = new Thread(new ThreadStart((Action)(() =>
            {
                using (ModelContext db = new ModelContext())
                {
                    var result = from t in db.TransactionList
                                 where (t.TransactionDate.Day == DateTime.Now.Day)
                                 select (new TransactionStatisticView
                                 {
                                     TransactionId = t.TransactionId, 
                                     Name = t.Customer.Name,
                                     ChairId = t.Chair.ChairId,
                                     ChairName = t.Chair.Name,
                                     TransactionDate = t.TransactionDate,
                                     Amount = t.Amount,
                                     Status = t.Status
                                 });
                    List<TransactionStatisticView> transactionStatisticViewList = new List<TransactionStatisticView>();
                    try
                    {
                        transactionStatisticViewList = result.ToList();
                        foreach (var transactionStatisticView in transactionStatisticViewList)
                            transactionStatisticView.TransactionIdCoded = string.Format("GD-{0:D5}", transactionStatisticView.TransactionId);
                        this.Invoke((Action)(() =>
                        {
                            gvMain.DataSource = transactionStatisticViewList;
                        }));
                    }
                    catch (Exception)
                    {
                        
                    }
                }
            })));
            thread.Start();
        }

        public void loadDataSellTransaction()
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
                            gvSellTranMain.DataSource = sellTranViewList;
                        }));
                    }
                    catch (Exception){}
                }
            })));
            thread.Start();
        }

        private void Init()
        {
            Thread insertThread = new Thread(new ThreadStart((Action)(() =>
            {
                this.Invoke((Action)(() =>
                {
                    var PsList = new List<string>();
                    for (int i = 0; i < NumberOfPs; i++)
                    {
                        PsList.Add("Ghế " + (i + 1).ToString());
                        BunchOfChair[i] = new PictureEdit();
                        BunchOfPanel[i] = new PanelControl();
                        BunchOfLabel[i] = new LabelControl();
                        panelDad.Controls.Add(BunchOfPanel[i]);
                        BunchOfPanel[i].Name = "Panel" + (i + 1).ToString();
                        BunchOfPanel[i].Location = new System.Drawing.Point(3, 3);
                        BunchOfPanel[i].LookAndFeel.UseDefaultLookAndFeel = false;
                        BunchOfPanel[i].LookAndFeel.Style = DevExpress.LookAndFeel.LookAndFeelStyle.Flat;
                        BunchOfPanel[i].Appearance.Options.UseBackColor = true;
                        BunchOfPanel[i].BackColor = Color.White;
                        BunchOfPanel[i].Appearance.BackColor = Color.White;
                        BunchOfPanel[i].BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
                        BunchOfPanel[i].Width = 100;
                        BunchOfPanel[i].Height = 33;
                        BunchOfPanel[i].Controls.Add(BunchOfChair[i]);
                        BunchOfPanel[i].Controls.Add(BunchOfLabel[i]);

                        BunchOfPanel[i].DoubleClick += new EventHandler(Ps_DoubleClick);
                        BunchOfChair[i].Properties.NullText = "";
                        BunchOfChair[i].Location = new System.Drawing.Point(1, 1);
                        BunchOfChair[i].Name = "Chair" + (i + 1).ToString();
                        BunchOfChair[i].Tag = "0";
                        BunchOfChair[i].ToolTip = (i + 1).ToString();
                        BunchOfChair[i].Properties.AllowFocused = false;
                        BunchOfChair[i].Properties.Appearance.BackColor = System.Drawing.Color.ForestGreen;
                        BunchOfChair[i].Properties.Appearance.ForeColor = System.Drawing.Color.Transparent;
                        BunchOfChair[i].Properties.Appearance.Options.UseBackColor = true;
                        BunchOfChair[i].Properties.Appearance.Options.UseForeColor = true;
                        BunchOfChair[i].Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
                        BunchOfChair[i].Properties.SizeMode = DevExpress.XtraEditors.Controls.PictureSizeMode.Stretch;
                        BunchOfChair[i].Size = new System.Drawing.Size(10, 31);
                        BunchOfChair[i].EditValue = global::DuHair.Properties.Resources.Green;
                        BunchOfChair[i].DoubleClick += new EventHandler(Ps_DoubleClick);

                        BunchOfLabel[i].Name = "lblCh" + (i + 1).ToString();
                        BunchOfLabel[i].Location = new System.Drawing.Point(17, 9);
                        BunchOfLabel[i].Text = PsList[i];
                        BunchOfLabel[i].Appearance.Font = new Font("Arial", 10F);
                        BunchOfLabel[i].DoubleClick += new EventHandler(Ps_DoubleClick);
                    }
                }));
            })));
            insertThread.Start();
        }

        protected void SwitchChairForm(int chairId, int transactionId)
        {
            if (BunchOfChair[chairId-1].Properties.Appearance.BackColor.Name.Equals("ForestGreen"))
            {
                BunchOfChair[chairId-1].EditValue = global::DuHair.Properties.Resources.Red;
                BunchOfChair[chairId-1].Properties.Appearance.BackColor = Color.DarkRed;
                BunchOfChair[chairId-1].Tag = transactionId;
            }
            else
            {
                BunchOfChair[chairId - 1].EditValue = global::DuHair.Properties.Resources.Green;
                BunchOfChair[chairId - 1].Properties.Appearance.BackColor = Color.ForestGreen;
                BunchOfChair[chairId - 1].Tag = 0;
            }
        }

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

        protected void loadDoingTransaction()
        {
            IEnumerable<Transaction> doingTransaction = null;
            Thread thread = new Thread(new ThreadStart((Action)(() => { 
                using (ModelContext db = new ModelContext())
                {
                    doingTransaction = db.TransactionList.Where(t => t.Status == 1).ToList();
                    foreach (var transaction in doingTransaction)
                    {
                        db.Entry<Transaction>(transaction).Reference(t => t.Chair).Load();
                        if (this.IsHandleCreated)
                        {
                            this.Invoke((Action)(() =>
                            {
                                BunchOfChair[transaction.Chair.ChairId - 1].EditValue = global::DuHair.Properties.Resources.Red;
                                BunchOfChair[transaction.Chair.ChairId - 1].Properties.Appearance.BackColor = Color.DarkRed;
                                BunchOfChair[transaction.Chair.ChairId - 1].Tag = transaction.TransactionId;
                            }));
                        }
                    }
                }
            })));
            thread.Start();
        }

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
                    tran.dlLoadCallback = new TransactionForm.dlLoad(SwitchChairForm);
                    tran.dlLoadCallback2 = new TransactionForm.dlLoad2(loadDataTransaction);
                    switchStatus("",Color.White, "done");
                    tran.ShowDialog();
                }));
                
            })));
            insertThread.Start();
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

        private void DoRowDoubleClick(GridView gridView, Point pt)
        {
            GridHitInfo info = gridView.CalcHitInfo(pt);
            if ((info.InRow ? true : info.InRowCell))
            {
                if (gridView.Name.Equals("gvTransaction"))
                {
                    try
                    {
                        int TransactionId = Convert.ToInt16(gvTransaction.GetRowCellValue(info.RowHandle, "TransactionId"));
                        int ChairId = Convert.ToInt16(gvTransaction.GetRowCellValue(info.RowHandle, "ChairId"));
                        TransactionForm tf = new TransactionForm(TransactionId, ChairId, "View");
                        tf.ShowDialog();
                    }
                    catch (Exception) { }
                }
                else if (gridView.Name.Equals("gvSellTran"))
                {
                    int SellTranId = Convert.ToInt32(gvSellTran.GetRowCellValue(info.RowHandle, "SellTranId"));
                    SellTranForm st = new SellTranForm(SellTranId);
                    st.ShowDialog();
                }
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
    }
}