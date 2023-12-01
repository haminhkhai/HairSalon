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
using DevExpress.XtraGrid.Views.Base;

namespace DuHair
{
    public partial class ServiceForm : DevExpress.XtraEditors.XtraForm
    {
        string currentName = "";
        public ServiceForm()
        {
            InitializeComponent();
        }

        protected bool validateData()
        {
            if (txtName.Text.Trim().Length < 3)
            {
                lbStatus.Text = "Tên dịch vụ phải từ 3 kí tự";
                txtName.Focus();
                return false;
            }
            if (!txtName.Text.Trim().Equals(currentName))
            {
                using (ModelContext db = new ModelContext())
                {
                    var checkExist = db.ServiceList.Where(m => m.Name.Equals(txtName.Text.Trim())).Select(m => m.Name).FirstOrDefault();
                    if (checkExist != null)
                    {
                        lbStatus.Text = "Tên này đã tồn tại";
                        txtName.Focus();
                        return false;
                    }
                }
            }
            if (Convert.ToInt32(txtPrice.EditValue) < 1)
            {
                lbStatus.Text = "Giá không được bỏ trống";
                txtPrice.Focus();
                return false;
            }
            lbStatus.Text = "(*) Không được bỏ trống";
            return true;
        }

        protected void SwitchControl(bool InsertOrEdit)
        {
            btnCancel.Enabled = InsertOrEdit;
            btnSave.Enabled = InsertOrEdit;
            panel1.Enabled = InsertOrEdit;
            btnNew.Enabled = !InsertOrEdit;
            btnEdit.Enabled = !InsertOrEdit;
            gridControl1.Enabled = !InsertOrEdit;
        }

        private void Service_Load(object sender, EventArgs e)
        {
            using (ModelContext db = new ModelContext())
            {
                serviceModelBindingSource.DataSource = db.ServiceList.ToList().OrderBy(s => s.Order);
                materialModelBindingSource.DataSource = db.MaterialList.Where(m => m.Status.Equals("Hiển thị")).ToList();
            }
            //popupMaterial.DataBindings.Add("EditValue", materialModelBindingSource, "Name", false, DataSourceUpdateMode.OnPropertyChanged);
            gvMaterialMain.DataSource = materialModelBindingSource;
            panel1.Enabled = false;
            btnSave.Enabled = false;
            btnCancel.Enabled = false;
            lbStatus.Text = "Không được bỏ trống";
            this.popupMaterial.QueryResultValue += popupMaterial_QueryResultValue;
            this.popupMaterial.QueryPopUp += popupMaterial_QueryPopUp;
        }

        //check gridview if value is selected bro 
        private void popupMaterial_QueryPopUp(object sender, CancelEventArgs e)
        {
            object val = popupMaterial.EditValue;
            if (val == null)
                gvMaterial.ClearSelection();
            else
            {
                gvMaterialMain.ForceInitialize();
                string[] texts = val.ToString().Split(',');
                foreach (string text in texts)
                {
                    int rowHandle = gvMaterial.LocateByValue("Name", text.Trim());
                    gvMaterial.SelectRow(rowHandle);
                }
            }
        }

        private void popupMaterial_QueryResultValue(object sender, DevExpress.XtraEditors.Controls.QueryResultValueEventArgs e)
        {
            int[] selectedRows = gvMaterial.GetSelectedRows();
            StringBuilder sb = new StringBuilder();
            foreach (int selectionRow in selectedRows)
            {
                Material f = gvMaterial.GetRow(selectionRow) as Material;
                if (sb.ToString().Length > 0) { sb.Append(", "); }
                sb.Append(f.Name);
            }
            e.Value = sb.ToString();
        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            SwitchControl(true);
            serviceModelBindingSource.Add(new Service { Status = "Hiển thị" });
            serviceModelBindingSource.MoveLast();
            txtName.Focus();
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            currentName = txtName.Text.Trim();
            SwitchControl(true);
            txtName.Focus();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (validateData())
            {
                Service objService = serviceModelBindingSource.Current as Service;
                if (objService != null)
                {
                    if (objService.ServiceId == 0)
                    {
                        using (ModelContext db = new ModelContext())
                        {
                            db.ServiceList.Add(objService);
                            int[] selectedRows = gvMaterial.GetSelectedRows();
                            foreach (var selectionRow in selectedRows)
                            {
                                Material objMaterial = gvMaterial.GetRow(selectionRow) as Material;
                                //must have or context will insert objMaterial into database
                                db.MaterialList.Attach(objMaterial);
                                objService.Materials.Add(objMaterial);
                            }
                            db.SaveChanges();
                            SwitchControl(false);
                            gridView1.RefreshData();
                        }
                    }
                    else
                    {
                        using (ModelContext db = new ModelContext())
                        {
                            if (db.Entry<Service>(objService).State == System.Data.Entity.EntityState.Detached)
                            {
                                db.Set<Service>().Attach(objService);
                            }
                            db.Entry<Service>(objService).Collection(c => c.Materials).Load();
                            objService.Materials.Clear();
                            db.SaveChanges();
                        }
                        using (ModelContext db = new ModelContext())
                        {
                            if (db.Entry<Service>(objService).State == System.Data.Entity.EntityState.Detached)
                            {
                                db.Set<Service>().Attach(objService);
                            }
                            db.Entry<Service>(objService).State = System.Data.Entity.EntityState.Modified;
                            //add navigate properties
                            int[] selectedRows = gvMaterial.GetSelectedRows();
                            Material objMaterial = null;
                            foreach (var selectionRow in selectedRows)
                            {
                                objMaterial = gvMaterial.GetRow(selectionRow) as Material;
                                //objMaterial.Services = null;
                                db.MaterialList.Attach(objMaterial);
                                objService.Materials.Add(objMaterial);
                            }
                            db.SaveChanges();
                            SwitchControl(false);
                            gridView1.RefreshData();

                        }
                    }
                }
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            SwitchControl(false);
            serviceModelBindingSource.ResetBindings(false);
            materialModelBindingSource.ResetBindings(false);
            Service_Load(sender, e);
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
        }

        private void gridView1_RowClick(object sender, DevExpress.XtraGrid.Views.Grid.RowClickEventArgs e)
        {
            
        }

        private void gridView1_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            int SelectedServiceId = int.Parse(gridView1.GetRowCellValue(gridView1.FocusedRowHandle, "ServiceId").ToString());
            StringBuilder sb = new StringBuilder();
            using (ModelContext db = new ModelContext())
            {
                var result = from c in db.MaterialList
                             from p in c.Services
                             where p.ServiceId == SelectedServiceId
                             select c.Name;
                var SelectedMaterial = result.ToList();
                foreach (var Material in SelectedMaterial)
                {
                    if (sb.ToString().Length > 0) { sb.Append(", "); }
                    sb.Append(Material);
                }
                popupMaterial.EditValue = sb.ToString();
            }
        }

        private void txtDiscount_MouseUp(object sender, MouseEventArgs e)
        {
            TextEdit edit = sender as TextEdit;
            edit.SelectAll();
        }

        private void txtDiscount_Enter(object sender, EventArgs e)
        {
            TextEdit edit = sender as TextEdit;
            BeginInvoke(new Action(() => edit.SelectAll()));
        }

        private void txtSellDiscount_MouseUp(object sender, MouseEventArgs e)
        {
            TextEdit edit = sender as TextEdit;
            edit.SelectAll();
        }

        private void txtSellDiscount_Enter(object sender, EventArgs e)
        {
            TextEdit edit = sender as TextEdit;
            BeginInvoke(new Action(() => edit.SelectAll()));
        }

        private void gvMaterial_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (popupMaterial.IsPopupOpen)
                {
                    popupMaterial.ClosePopup();
                    e.Handled = true;
                }
            }
        }

        private void gridView1_CellValueChanged(object sender, CellValueChangedEventArgs e)
        {
            try
            {
                ModelContext db = new ModelContext();
                int order = Convert.ToInt32(e.Value);
                int serviceId = Convert.ToInt32(gridView1.GetRowCellValue(e.RowHandle, "ServiceId"));
                var raisedOrder = order + 1;
                db.ServiceList.Where(s => s.ServiceId == serviceId).First().Order = order;
                db.ServiceList.Where(s => s.Order >= order && s.ServiceId != serviceId).OrderBy(s => s.Order).ToList().ForEach(s => s.Order = raisedOrder++);
                db.SaveChanges();

                serviceModelBindingSource.DataSource = db.ServiceList.ToList().OrderBy(s => s.Order);
            }
            catch (Exception)
            {
                
                throw;
            }
        }

        private void gridView1_RowUpdated(object sender, RowObjectEventArgs e)
        {

        }
    }
}