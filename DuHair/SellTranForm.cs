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
using System.Threading;

namespace DuHair
{
    public partial class SellTranForm : DevExpress.XtraEditors.XtraForm
    {
        List<MaterialSellView> selectedMaterial = new List<MaterialSellView>();
        int sellTranId, amount = 0;
        DateTime sellDate;
        public delegate void dlLoad();
        public dlLoad dlLoadCallback;
        string SellTranIdCoded = "";
        bool materialPopUpValueChangeFlag = true;
        public SellTranForm(int sellTranId)
        {
            InitializeComponent();
            this.sellTranId = sellTranId;
        }

        private void SellTranForm_Load(object sender, EventArgs e)
        {
            using (ModelContext db = new ModelContext())
            {
                var NullCustomer = new Customer() { CustomerId = 0, Name = "Khách mới", Tel = "", Birthday = DateTime.Now };
                var CustomerList = db.CustomerList.Where(c => c.Status.Equals("Hiển thị")).ToList();
                CustomerList.Insert(0, NullCustomer);
                this.Invoke((Action)(() =>
                {
                    cbCustomer.Properties.DataSource = CustomerList;
                    cbCustomer.EditValue = 0;
                    cbEmployee.Properties.DataSource = db.EmployeeList.Where(m => m.Status.Equals("Hiển thị")).ToList();
                    gvMaterialMainPopup.DataSource = db.MaterialList.Where(m => m.Status.Equals("Hiển thị")).ToList();
                    gvMaterialMain.DataSource = selectedMaterial;
                }));
            }
            if (sellTranId == 0)
            {
                sellDate = DateTime.Now;
                lblTime.Text = DateTime.Now.ToString("HH:mm dd/MM/yyyy");
                lbEmployeeName.Text = MainForm.currentEmployeeName;
                using (ModelContext db = new ModelContext())
                {
                    var newestSellTranId = db.SellTranList.OrderByDescending(s => s.SellTranId)
                                                            .Take(1)
                                                            .Select(s => s.SellTranId)
                                                            .FirstOrDefault();
                    SellTranIdCoded = string.Format("BH-{0:D5}", newestSellTranId + 1);
                    lblId.Text = SellTranIdCoded;
                }
            }
            else
            {
                StringBuilder sb = new StringBuilder();
                using (ModelContext db = new ModelContext())
                {
                    var objSellTran = (from s in db.SellTranList
                                        where s.SellTranId == sellTranId
                                        select new
                                        {
                                            sellTranId = s.SellTranId,
                                            sellDate = s.SellDate,
                                            amount = s.Amount,
                                            employeeId = (int?)s.Employee.EmployeeId,
                                            customerId = (int?)s.Customer.CustomerId,
                                            casherName = s.Casher.Name
                                        }).First();
                    this.Invoke((Action)(() =>
                    {
                        btnMoney.Visible = false;
                        lblTime.Text = objSellTran.sellDate.ToString("HH:mm dd/MM/yyyy");
                        lblId.Text = string.Format("BH-{0:D5}", objSellTran.sellTranId);
                        lbEmployeeName.Text = objSellTran.casherName;
                        lblAmount.Text = "Tổng: " + objSellTran.amount.ToString("N0") + " VNĐ";
                        cbEmployee.EditValue = objSellTran.employeeId;
                        if (objSellTran.customerId == null)
                            cbCustomer.EditValue = 0;
                        else
                            cbCustomer.EditValue = objSellTran.customerId;
                    }));

                    var sellTranDetailList = (from s in db.SellTranDetailList
                                                where s.SellTran.SellTranId == sellTranId
                                                select new
                                                {
                                                    quantity = s.Quantity,
                                                    price = s.Price,
                                                    discount = s.Discount,
                                                    name = s.Material.Name,
                                                    materialId = s.Material.MaterialId,
                                                    sellComMoney = s.SellComMoney
                                                }).ToList();
                    foreach (var objSellTranDetail in sellTranDetailList)
                    {
                        if (sb.ToString().Length > 0)
                            sb.Append(", ");
                        sb.Append(objSellTranDetail.name);
                        int rowHandle = gvMaterialPopup.LocateByValue("Name", objSellTranDetail.name);
                        gvMaterialPopup.SelectRow(rowHandle);

                        selectedMaterial.Add(new MaterialSellView
                        {
                            Name = objSellTranDetail.name,
                            Discount = objSellTranDetail.discount,
                            MaterialId = objSellTranDetail.materialId,
                            Price = objSellTranDetail.price,
                            Quantity = objSellTranDetail.quantity,
                            SellComMoney = objSellTranDetail.sellComMoney
                        });
                    }
                    this.Invoke((Action)(() =>
                    {
                        materialPopUpValueChangeFlag = false; // this flag to make materialPopUp editvaluechange event does not fire
                        materialPopup.EditValue = sb;
                        gvMaterialMain.DataSource = selectedMaterial;
                    })); 
                }
                materialPopUpValueChangeFlag = true;
            }
        }

        private void materialPopup_QueryPopUp(object sender, CancelEventArgs e)
        {
            object val = materialPopup.EditValue;
            if (val == null)
                gvMaterialPopup.ClearSelection();
            else
            {
                gvMaterialMainPopup.ForceInitialize();
                string[] texts = val.ToString().Split(',');
                foreach (string text in texts)
                {
                    int rowHandle = gvMaterialPopup.LocateByValue("Name", text.Trim());
                    gvMaterialPopup.SelectRow(rowHandle);
                }
            }
        }

        private void materialPopup_QueryResultValue(object sender, DevExpress.XtraEditors.Controls.QueryResultValueEventArgs e)
        {
            int[] selectedRows = gvMaterialPopup.GetSelectedRows();
            StringBuilder sb = new StringBuilder();
            foreach (int selectionRow in selectedRows)
            {
                Material f = gvMaterialPopup.GetRow(selectionRow) as Material;
                if (sb.ToString().Length > 0) { sb.Append(", "); }
                sb.Append(f.Name);
            }
            e.Value = sb.ToString();
        }

        private void materialPopup_EditValueChanged(object sender, EventArgs e)
        {
            if (materialPopUpValueChangeFlag)
            {
                amount = 0;
                selectedMaterial.Clear();
                int[] selectedRows = gvMaterialPopup.GetSelectedRows();
                foreach (var row in selectedRows)
                {
                    Material objMaterial = gvMaterialPopup.GetRow(row) as Material;
                    selectedMaterial.Add(new MaterialSellView
                    {
                        MaterialId = objMaterial.MaterialId,
                        Name = objMaterial.Name,
                        Discount = objMaterial.Discount,
                        Price = objMaterial.Price,
                        Quantity = 1
                    });
                    amount += objMaterial.Price;
                    lblAmount.Text = "Tổng: " + amount.ToString("N0") + " VNĐ";
                }
                gvMaterialMain.RefreshDataSource();
            }
        }

        protected bool validateData()
        {
            if (materialPopup.EditValue == null || materialPopup.EditValue.Equals(""))
            {
                lbStatus.Text = "Sản phẩm không được bỏ trống";
                materialPopup.Focus();
                return false;
            }
            lbStatus.Text = "(*) Không được bỏ trống";
            return true;
        }

        private void btnMoney_Click(object sender, EventArgs e)
        {
            if (validateData())
            {
                int employeeId = 0;
                if (cbEmployee.EditValue != null)
                    if (!cbEmployee.EditValue.ToString().Equals(""))
                        employeeId = Convert.ToInt32(cbEmployee.EditValue);
                int customerId = Convert.ToInt16(cbCustomer.EditValue);
                if (sellTranId == 0)
                {
                    if (new MyMessage().QuestionDev("Tính tiền & in hóa đơn"))
                    {
                        using (ModelContext db = new ModelContext())
                        {
                            SellTran objSellTran = new SellTran();
                            objSellTran.SellDate = sellDate;
                            objSellTran.Amount = amount;
                            db.SellTranList.Add(objSellTran);

                            Employee objCasher = db.EmployeeList.Where(m => m.EmployeeId == MainForm.currentEmployeeId).FirstOrDefault();
                            objSellTran.Casher = objCasher;

                            Customer objCustomer = null;
                            if (customerId != 0)
                                objCustomer = db.CustomerList.Where(c => c.CustomerId == customerId).FirstOrDefault();
                            objSellTran.Customer = objCustomer;

                            Employee objEmployee = null;
                            objEmployee = db.EmployeeList.Where(m => m.EmployeeId == employeeId).FirstOrDefault();
                            objSellTran.Employee = objEmployee;

                            foreach (var objMaterialSell in selectedMaterial)
                            {
                                
                                SellTranDetail objSellTranDetail = new SellTranDetail
                                {
                                    Material = db.MaterialList.Where(m => m.MaterialId == objMaterialSell.MaterialId).FirstOrDefault(),
                                    Price = objMaterialSell.Price,
                                    Quantity = objMaterialSell.Quantity,
                                    SellTran = objSellTran,
                                    Discount = objMaterialSell.Discount,
                                    SellComMoney = objMaterialSell.SellComMoney
                                };
                                db.SellTranDetailList.Add(objSellTranDetail);
                            }
                            db.SaveChanges();
                            dlLoadCallback();
                            Print(objSellTran.SellDate.ToString("dd/MM/yyyy"));
                            this.Close();
                        }
                    }
                }
            }
        }

        public void Print(string pDate)
        {
            List<MaterialSellView> serviceBillList = selectedMaterial.Select(s => new MaterialSellView
            {
                MaterialId = s.MaterialId,
                Name = s.Name,
                Price = s.Price,
                Quantity = s.Quantity,
                Total = s.Price * s.Quantity
            }).ToList();
            Microsoft.Reporting.WinForms.LocalReport report = new Microsoft.Reporting.WinForms.LocalReport();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource1 = new Microsoft.Reporting.WinForms.ReportDataSource();
            reportDataSource1.Name = "datasource";
            reportDataSource1.Value = serviceBillList;
            report.DataSources.Add(reportDataSource1);
            report.ReportPath = "rpSellBill.rdlc";
            Microsoft.Reporting.WinForms.ReportParameter[] para = new Microsoft.Reporting.WinForms.ReportParameter[]
            {
                new Microsoft.Reporting.WinForms.ReportParameter("pCasher", MainForm.currentEmployeeName),
                new Microsoft.Reporting.WinForms.ReportParameter("pDate", pDate),
                new Microsoft.Reporting.WinForms.ReportParameter("pTotal", amount.ToString("n0") + " VNĐ"),
                new Microsoft.Reporting.WinForms.ReportParameter("pTransactionIdCoded", SellTranIdCoded)
            };
            report.SetParameters(para);

            ReportPrintDocument rp = new ReportPrintDocument(report);
            rp.Print();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void gvMaterialMain_ProcessGridKey(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Tab)
            {
                GridControl grid = sender as GridControl;
                GridView view = grid.FocusedView as GridView;
                if ((e.Modifiers == Keys.None && view.IsLastRow && view.FocusedColumn.VisibleIndex == view.VisibleColumns.Count - 1)
                    || (e.Modifiers == Keys.Shift && view.IsFirstRow && view.FocusedColumn.VisibleIndex == 0))
                {
                    btnMoney.Focus();
                }
            }
        }

        private void gvMaterial_CellValueChanged(object sender, DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs e)
        {
            if (e.Column == colQuantity)
            {
                int employeeId = 0;
                if (cbEmployee.EditValue != null)
                    if (!cbEmployee.EditValue.ToString().Equals(""))
                        employeeId = Convert.ToInt32(cbEmployee.EditValue);
                amount = 0;
                for (int i = 0; i < gvMaterial.RowCount; i++)
                {

                    float discount = float.Parse(gvMaterial.GetRowCellValue(i, "Discount").ToString());
                    int price = Convert.ToInt32(gvMaterial.GetRowCellValue(i, "Price"));
                    int quantity = Convert.ToInt32(gvMaterial.GetRowCellValue(i, "Quantity"));
                    amount += price * quantity;
                    lblAmount.Text = "Tổng: " + amount.ToString("N0") + " VNĐ";
                    if (discount != 0 && employeeId != 0)
                    {
                        var com = price * quantity * discount / 100;
                        int sellComMoney = Convert.ToInt32(com);
                        gvMaterial.SetRowCellValue(i, "SellComMoney", sellComMoney);
                    }
                }
            }
        }

        private void gvMaterialPopup_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (materialPopup.IsPopupOpen)
                {
                    materialPopup.ClosePopup();
                }
            }
        }

        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            if (keyData == (Keys.D | Keys.Control))
            {
                btnMoney.PerformClick();
                return true;
            }
            return base.ProcessCmdKey(ref msg, keyData);
        }
    }
}