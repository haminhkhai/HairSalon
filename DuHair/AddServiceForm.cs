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
    public partial class AddServiceForm : DevExpress.XtraEditors.XtraForm
    {
        private List<ServiceView> serviceViewList = new List<ServiceView>();
        private Label[] lbCommission;
        private TextEdit[] txtCommission;
        public delegate void dlSendBack(object objService, object objCommissionList);
        public dlSendBack dlSendBackCall;
        public delegate void dlRemoveService(int serviceId);
        public dlRemoveService dlRemoveCallback;

        public AddServiceForm(object serviceViewList, Point startPoint)
        {
            InitializeComponent();
            employeePopUp.Properties.CloseUpKey = new DevExpress.Utils.KeyShortcut(Keys.F4);
            if (serviceViewList != null)
            {
                //cast to List<ServiceView>
                this.serviceViewList = (List<ServiceView>)serviceViewList;
            }
            loadData();
            this.Location = startPoint;
        }

        private void AddServiceForm_Load(object sender, EventArgs e)
        {
            employeePopUp_QueryPopUp(sender, new CancelEventArgs());
        }

        protected void loadData()
        { 
            //load service
            ModelContext db = new ModelContext();
            var service = db.ServiceList.Where(s => s.Status.Equals("Hiển thị")).ToList();
            cbService.Properties.DataSource = service;
            List<Employee> employeeList = db.EmployeeList.Where(e => e.Status.Equals("Hiển thị")).ToList();
            gvEmployeeMain.DataSource = employeeList;
            cbEmployee.Properties.DataSource = employeeList;
            gvServiceMain.DataSource = serviceViewList; //get serviceList from TransactionForm if action is update then serviceList.count > 0
            //db.Dispose();
        }

        protected bool validateData()
        {
            if (cbService.EditValue == null || cbService.EditValue.Equals(""))
            {
                lbStatus.Text = "Dịch vụ không được bỏ trống";
                cbService.Focus();
                return false;
            }
            if (txtPrice.Text.Length < 1)
            {
                lbStatus.Text = "Giá không được bỏ trống";
                txtPrice.Focus();
                return false;
            }
            if (Convert.ToInt32(txtQuantity.EditValue) < 1)
            {
                lbStatus.Text = "Số lượng phải lớn hơn 0";
                txtQuantity.Focus();
                return false;
            }
            if (gvEmployee.GetSelectedRows().Count() < 1)
            {
                lbStatus.Text = "Nhân viên không được bỏ trống";
                employeePopUp.Focus();
                return false;
            }
            int serviceId = (int)cbService.EditValue;
            if (serviceViewList.Where(s => s.ServiceId == serviceId).ToList().Count() > 0)
            {
                lbStatus.Text = "Dịch vụ này đã được chọn";
                cbService.Focus();
                return false;
            }
            int total = 0;
            if (txtCommission != null)
                for (int i = 0; i < txtCommission.Count(); i++)
                    total += Convert.ToInt32(txtCommission[i].Text);
            if (total > 100 && rdDiscountType.SelectedIndex == 1)
            {
                lbStatus.Text = "Tổng chiết khấu không được lớn hơn 100 (%)";
                txtCommission[0].Focus();
                return false;
            }
            lbStatus.Text = "(*) Không được bỏ trống";
            return true;
        }

        private void employeePopUp_EditValueChanged(object sender, EventArgs e)
        {
            int[] selectedRows = gvEmployee.GetSelectedRows();
            if (selectedRows.Count() > 0)
            {
                if (txtCommission != null)
                {
                    for (int i = 0; i < txtCommission.Count(); i++)
                    {
                        commissionGroup.Controls.Remove(lbCommission[i]);
                        commissionGroup.Controls.Remove(txtCommission[i]);
                    }
                }
                lbCommission = new Label[selectedRows.Count()];
                txtCommission = new TextEdit[selectedRows.Count()];
                var wqe = this.Height;
                if (selectedRows.Count() > 6)
                {
                    var rowNeeded = Math.Round(Convert.ToDouble(selectedRows.Count() - 6), 0, MidpointRounding.ToEven);
                    this.Height = 505 + 24 * Convert.ToInt16(rowNeeded);
                    commissionGroup.Height = 93 + 24 * Convert.ToInt16(rowNeeded);
                }

                for (int i = 0; i < selectedRows.Count(); i++)
                {
                    Employee employee = gvEmployee.GetRow(selectedRows[i]) as Employee;
                    lbCommission[i] = new Label();
                    txtCommission[i] = new TextEdit();
                    commissionGroup.Controls.Add(txtCommission[i]);
                    commissionGroup.Controls.Add(lbCommission[i]);
                    txtCommission[i].Size = new Size(40, 20);
                    txtCommission[i].Properties.Mask.EditMask = "d";
                    txtCommission[i].Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
                    if (rdDiscountType.SelectedIndex == 0) //chiet khau theo tien
                    {
                        txtCommission[i].Text = "5000";
                    }
                    if (rdDiscountType.SelectedIndex == 1)//chiet khau theo phan tram
                    {
                        txtCommission[i].Text = ((int)100 / selectedRows.Count()).ToString();
                    }
                    
                    if (i % 2 > 0) // cot thu 2
                    {
                        lbCommission[i].Location = new Point(186, 22 + (i / 2 * 23));
                        txtCommission[i].Location = new Point(324, 20 + (i / 2 * 23));
                    }
                    else // cot thu 1 
                    {
                        lbCommission[i].Location = new Point(7, 22 + (i / 2 * 23));
                        txtCommission[i].Location = new Point(136, 20 + (i / 2 * 23));
                    }
                    txtCommission[i].TabIndex = i + 3;
                    lbCommission[i].Text = employee.Name;
                    var wew = txtCommission[i].Location;
                }
            }
            else
            {
                if (lbCommission != null)
                {
                    this.Height = 505;
                    commissionGroup.Height = 93;

                    for (int i = 0; i < txtCommission.Count(); i++)
                    {
                        lbCommission[i].Dispose();
                        txtCommission[i].Dispose();
                    }
                }
            }
        }

        private void employeePopUp_QueryPopUp(object sender, CancelEventArgs e)
        {
            object val = employeePopUp.EditValue;
            if (val == null)
                gvEmployee.ClearSelection();
            else
            {
                string[] texts = val.ToString().Split(',');
                foreach (string text in texts)
                {
                    int rowHandle = gvEmployee.LocateByValue("Name", text.Trim());
                    gvEmployee.SelectRow(rowHandle);
                }
            }
        }

        private void employeePopUp_QueryResultValue(object sender, DevExpress.XtraEditors.Controls.QueryResultValueEventArgs e)
        {
            int[] selectedRows = gvEmployee.GetSelectedRows();
            StringBuilder sb = new StringBuilder();
            foreach (int selectionRow in selectedRows)
            {
                Employee f = gvEmployee.GetRow(selectionRow) as Employee;
                if (sb.ToString().Length > 0) { sb.Append(", "); }
                sb.Append(f.Name);
            }
            e.Value = sb.ToString();
        }

        private void btnChoose_Click(object sender, EventArgs e)
        {
            if (validateData())
            {
                using (ModelContext db = new ModelContext())
                {
                    //phai validate cho serviceId != 0, service ko lap lai
                    int serviceId = (cbService.EditValue != null) ? (int)cbService.EditValue : 0;
                    int newPrice = int.Parse(txtPrice.EditValue.ToString());
                    int quantity = int.Parse(txtQuantity.EditValue.ToString());
                    Service objService = db.ServiceList.Where(s => s.ServiceId == serviceId).FirstOrDefault();
                    var oldPrice = objService.Price;
                    //serviceViewList.Add(objService); //supposed to need but auto added when delegate is call
                    int employeeId = 0;
                    if (cbEmployee.EditValue != null && !cbEmployee.EditValue.ToString().Equals(""))
                    {
                        employeeId = (int)cbEmployee.EditValue;
                    }
                    Employee objSellEmployee = db.EmployeeList.Where(m => m.EmployeeId == employeeId).FirstOrDefault();
                    gvServiceMain.RefreshDataSource();
                    List<CommissionView> commissionList = new List<CommissionView>();
                    int[] selectedRows = gvEmployee.GetSelectedRows();
                    for (int i = 0; i < selectedRows.Count(); i++)
                    {
                        Employee employee = gvEmployee.GetRow(selectedRows[i]) as Employee;
                        CommissionView objCommission = new CommissionView
                        {
                            Service = objService,
                            Quantity = quantity,
                            Employee = employee,
                            ComType = "Make"
                        };
                        
                        //Neu co gia khac thi thay doi gia 
                        if (newPrice != oldPrice)
                        {
                            objCommission.OtherPrice = newPrice;
                            objCommission.Service.Price = newPrice; //update gia
                        }
                        else //Neu khong thi set = 0
                        {
                            objCommission.OtherPrice = 0;
                        }

                        // add EXTRA commission record to define sell commission
                        if (employeeId != 0 && i == 0)
                        {
                            CommissionView objSellCommission = new CommissionView
                            {
                                Service = objService,
                                Quantity = quantity,
                                Employee = objSellEmployee,
                                SellComMoney = Convert.ToInt32((objCommission.Service.SellDiscount / 100) * quantity * objCommission.Service.Price),
                                CommissionPercent = 0,
                                ComType = "Sell"
                            };
                            if (newPrice != oldPrice)
                            {
                                objSellCommission.OtherPrice = newPrice; //update gia
                            }
                            commissionList.Add(objSellCommission);
                        }

                        if (rdDiscountType.SelectedIndex == 0) // discountType = Tien
                        {
                            objCommission.ComMoney = Convert.ToInt32(txtCommission[i].Text);
                            objCommission.CommissionPercent = 0;
                            objCommission.DiscountType = 0;
                        }
                        else if (rdDiscountType.SelectedIndex == 1) //discountType = %
                        {
                            if (selectedRows.Count() > 1) //if there are more than one employee make this tran then commission will split
                            {
                                objCommission.CommissionPercent = Convert.ToInt32(txtCommission[i].Text);
                            }
                            else
                            {
                                objCommission.CommissionPercent = 100; //one employee takes all
                            }
                            var comMoney = (objCommission.CommissionPercent / 100) * quantity * objCommission.Service.Price * (objCommission.Service.Discount / 100);
                            objCommission.ComMoney = Convert.ToInt32(comMoney);
                            objCommission.DiscountType = 1;
                        }
                        commissionList.Add(objCommission);
                    }
                    //doi gia objService neu có giá khác
                    if (newPrice != objService.Price)
                    {
                        objService.Price = newPrice;
                    }

                    ServiceView objServiceView = new ServiceView
                    {
                        ServiceId = objService.ServiceId,
                        Discount = objService.Discount,
                        Name = objService.Name,
                        Price = objService.Price,
                        Quantity = quantity
                    };
                    dlSendBackCall(objServiceView, commissionList);
                    cbService.Focus();
                }
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void cbService_EditValueChanged(object sender, EventArgs e)
        {
            using (ModelContext db = new ModelContext())
            {
                int serviceId = (cbService.EditValue != null) ? (int)cbService.EditValue : 0;
                if (serviceId != 0)
                {
                    Service objService = db.ServiceList.Where(s => s.ServiceId == serviceId).FirstOrDefault();
                    txtPrice.Text = objService.Price.ToString();
                    txtQuantity.Text = "1";
                }
            }
        }

        private void gvEmployee_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (employeePopUp.IsPopupOpen)
                {
                    employeePopUp.ClosePopup();
                    e.Handled = true;
                }
            }
        }

        private void gvServiceMain_ProcessGridKey(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Tab)
            {
                GridControl grid = sender as GridControl;
                GridView view = grid.FocusedView as GridView;
                if ((e.Modifiers == Keys.None && view.IsLastRow && view.FocusedColumn.VisibleIndex == view.VisibleColumns.Count - 1)
                    || (e.Modifiers == Keys.Shift && view.IsFirstRow && view.FocusedColumn.VisibleIndex == 0))
                {
                    btnChoose.Focus();
                }
            }
        }

        protected void removeService(int serviceId)
        {
            serviceViewList.Remove(serviceViewList.Where(s => s.ServiceId == serviceId).FirstOrDefault());
            gvServiceMain.RefreshDataSource();
        }

        private void gvService_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Delete)
            {
                if (gvService.RowCount > 0)
                {
                    int serviceId = Convert.ToInt32(gvService.GetRowCellValue(gvService.FocusedRowHandle, "ServiceId"));
                    removeService(serviceId);
                    dlRemoveCallback(serviceId);
                }
            }
        }

        private void rdDiscountType_SelectedIndexChanged(object sender, EventArgs e)
        {
            int[] selectedRows = gvEmployee.GetSelectedRows();
            for (int i = 0; i < selectedRows.Count(); i++)
            {
                if (rdDiscountType.SelectedIndex == 0)
                {
                    txtCommission[i].Text = "5000";
                }
                else if (rdDiscountType.SelectedIndex == 1)
                {
                    txtCommission[i].Text = ((int)100 / selectedRows.Count()).ToString();
                }
            }
        }

        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            if (keyData == (Keys.T | Keys.Control))
            {
                btnChoose.PerformClick();
                return true;
            }
            return base.ProcessCmdKey(ref msg, keyData);
        }
    }
}