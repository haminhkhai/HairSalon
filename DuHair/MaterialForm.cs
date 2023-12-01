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

namespace DuHair
{
    public partial class MaterialForm : DevExpress.XtraEditors.XtraForm
    {
        string currentName = "";
        public MaterialForm()
        {
            InitializeComponent();
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

        protected bool validateData()
        {
            if (txtName.Text.Trim().Length < 3)
            {
                lbStatus.Text = "Tên sản phẩm phải từ 3 kí tự";
                txtName.Focus();
                return false;
            }
            if (!txtName.Text.Trim().Equals(currentName))
            {
                using (ModelContext db = new ModelContext())
                {
                    var checkExist = db.MaterialList.Where(m => m.Name.Equals(txtName.Text.Trim())).Select(m => m.Name).FirstOrDefault();
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
                lbStatus.Text = "Giá bán không được bỏ trống";
                txtPrice.Focus();
                return false;
            }
            if (Convert.ToInt32(txtPriceBuy.EditValue) < 1)
            {
                lbStatus.Text = "Giá nhập không được bỏ trống";
                txtPriceBuy.Focus();
                return false;
            }
            //if (Convert.ToInt32(txtDiscount.EditValue) < 1)
            //{
            //    lbStatus.Text = "Chiết khấu không được bỏ trống";
            //    txtDiscount.Focus();
            //    return false;
            //}
            lbStatus.Text = "(*) Không được bỏ trống";
            return true;
        }

        private void Material_Load(object sender, EventArgs e)
        {
            using (ModelContext db = new ModelContext())
            {
                materialModelBindingSource.DataSource = db.MaterialList.ToList();
            }
            panel1.Enabled = false;
            btnSave.Enabled = false;
            btnCancel.Enabled = false;
        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            SwitchControl(true);
            materialModelBindingSource.Add(new Material { Status = "Hiển thị"});
            materialModelBindingSource.MoveLast();
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
                using (ModelContext db = new ModelContext())
                {
                    Material objMaterial = materialModelBindingSource.Current as Material;
                    if (objMaterial != null)
                    {
                        db.MaterialList.Add(objMaterial);
                        if (objMaterial.MaterialId == 0)
                        {
                            Warehouse objWarehouse = new Warehouse { Material = objMaterial, Quantity = 0 };
                            db.WarehouseList.Add(objWarehouse);
                        }
                        else
                        {
                            db.Entry<Material>(objMaterial).State = System.Data.Entity.EntityState.Modified;
                        }
                        db.SaveChanges();
                        SwitchControl(false);
                        gridView1.RefreshData();
                    }
                }
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            SwitchControl(false);
            materialModelBindingSource.ResetBindings(false);
            Material_Load(sender, e);
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (new MyMessage().QuestionDev("Bạn muốn xóa nguyên liệu này"))
            {
                using (ModelContext db = new ModelContext())
                {
                    Material obj = materialModelBindingSource.Current as Material;
                    if (obj != null)
                    {
                        if (db.Entry<Material>(obj).State == System.Data.Entity.EntityState.Detached)
                        {
                            db.Set<Material>().Attach(obj);
                        }
                        db.Entry<Material>(obj).State = System.Data.Entity.EntityState.Deleted;
                        db.SaveChanges();
                        materialModelBindingSource.RemoveCurrent();
                        SwitchControl(false);
                    }
                }
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
    }
}