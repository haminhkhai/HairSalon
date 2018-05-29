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
    public partial class CustomerForm : DevExpress.XtraEditors.XtraForm
    {
        string currentName = "";
        public CustomerForm()
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
            if (txtName.Text.Trim().Length < 6)
            {
                lbStatus.Text = "Tên khách phải từ 6 kí tự";
                txtName.Focus();
                return false;
            }
            if (!txtName.Text.Trim().Equals(currentName))
            {
                using (ModelContext db = new ModelContext())
                {
                    var checkExist = db.CustomerList.Where(m => m.Name.Equals(txtName.Text.Trim())).FirstOrDefault();
                    if (checkExist != null)
                    {
                        lbStatus.Text = "Tên này đã tồn tại";
                        txtName.Focus();
                        return false;
                    }
                }
            }
            if (txtTel.Text.Trim().Length < 7)
            {
                lbStatus.Text = "Sđt phải từ 7 kí tự";
                txtTel.Focus();
                return false;
            }
            lbStatus.Text = "(*) Không được bỏ trống";
            return true;
        }

        private void CustomerForm_Load(object sender, EventArgs e)
        {
            using (ModelContext db = new ModelContext())
            {
                customerModelBindingSource.DataSource = db.CustomerList.ToList();
                panel1.Enabled = false;
                btnSave.Enabled = false;
                btnCancel.Enabled = false;
            }
        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            SwitchControl(true);
            cbStatus.SelectedIndex = 1;
            txtBirthday.EditValue = DateTime.Now;
            customerModelBindingSource.Add(new Customer { Birthday = DateTime.Parse("2000/01/01"), Status = "Hiển thị" });
            customerModelBindingSource.MoveLast();
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
                    Customer objCustomer = customerModelBindingSource.Current as Customer;
                    if (objCustomer != null)
                    {
                        if (db.Entry<Customer>(objCustomer).State == System.Data.Entity.EntityState.Detached)
                        {
                            db.Set<Customer>().Attach(objCustomer);
                        }
                        if (objCustomer.CustomerId == 0)
                        {
                            db.Entry<Customer>(objCustomer).State = System.Data.Entity.EntityState.Added;
                        }
                        else
                        {
                            db.Entry<Customer>(objCustomer).State = System.Data.Entity.EntityState.Modified;
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
            customerModelBindingSource.ResetBindings(false);
            CustomerForm_Load(sender, e);
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (new MyMessage().QuestionDev("Bạn muốn xóa khách này"))
            {
                using (ModelContext db = new ModelContext())
                {
                    Customer objCustomer = customerModelBindingSource.Current as Customer;
                    if (objCustomer != null)
                    {
                        if (db.Entry<Customer>(objCustomer).State == System.Data.Entity.EntityState.Detached)
                        {
                            db.Set<Customer>().Attach(objCustomer);
                        }
                        db.Entry<Customer>(objCustomer).State = System.Data.Entity.EntityState.Deleted;
                        db.SaveChanges();
                        customerModelBindingSource.RemoveCurrent();
                        SwitchControl(false);
                    }
                }
            }
        }
    }
}