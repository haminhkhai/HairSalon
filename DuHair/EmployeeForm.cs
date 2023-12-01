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
	public partial class EmployeeForm : DevExpress.XtraEditors.XtraForm
	{
		string CurrentName = "";
		MySecurity sec = new MySecurity();
		public EmployeeForm()
		{
			InitializeComponent();
            if (!MainForm.currentRole.Equals("Admin"))
            {
                cbRole.Properties.Items.RemoveAt(1);
                cbRole.Properties.Items.RemoveAt(1);
            }
		}

		protected bool validateData()
		{
			if (txtName.Text.Trim().Length < 3)
			{
				lbStatus.Text = "Tên nhân viên phải từ 3 kí tự";
				txtName.Focus();
				return false;
			}
			if (!txtName.Text.Trim().Equals(CurrentName))
			{
				using(ModelContext db = new ModelContext())
				{
					var checkExist = db.EmployeeList.Where(m => m.Name.Equals(txtName.Text.Trim())).FirstOrDefault();
					if (checkExist != null)
					{
						lbStatus.Text = "Tên này đã tồn tại";
						txtName.Focus();
						return false;
					}
				}
			}
			if (cbRole.SelectedIndex == 1 || cbRole.SelectedIndex == 2)
			{
				if (txtUsername.Text.Trim().Length < 6)
				{
					lbStatus.Text = "Tên đăng nhập phải từ 6 kí tự";
					txtUsername.Focus();
					return false;
				}
				if (txtPwwd.Text.Trim().Length < 6)
				{
					lbStatus.Text = "Mật khẩu phải từ 6 kí tự";
					txtPwwd.Focus();
					return false;
				}
			}
			if (Convert.ToInt32(txtWage.EditValue) < 1)
			{
				lbStatus.Text = "Lương không được bỏ trống";
				txtWage.Focus();
				return false;
			}
            lbStatus.Text = "Không được bỏ trống";
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

		private void Employee_Load(object sender, EventArgs e)
		{
            LoadDataEmployee();
			panel1.Enabled = false;
			btnSave.Enabled = false;
			btnCancel.Enabled = false;
		}

        protected void LoadDataEmployee()
        {
            using (ModelContext db = new ModelContext())
            {
                var employeeList = db.EmployeeList.ToList();
                foreach (var employee in employeeList)
                {
                    if (!string.IsNullOrEmpty(employee.Username))
                    {
                        employee.Pwwd = sec.DeCryptMD5(employee.Pwwd, "remylacroix");
                    }
                }
                employeeModelBindingSource.DataSource = employeeList;
            }
        }

		private void btnNew_Click(object sender, EventArgs e)
		{
			SwitchControl(true);
			employeeModelBindingSource.Add(new Employee { Birthday = DateTime.Parse("2000/01/01"), Status = "Hiển thị", Role = "Nhân viên"});
			employeeModelBindingSource.MoveLast();
			txtName.Focus();
			cbRole.SelectedIndex = 0;
		}

		private void btnEdit_Click(object sender, EventArgs e)
		{
            Employee obj = employeeModelBindingSource.Current as Employee;
            if (obj.Role.Equals("Admin"))
            {
                new MyMessage().ErrorDev("Access denied");
            }
            else
            {
                CurrentName = txtName.Text.Trim();
                SwitchControl(true);
                txtName.Focus();
            }
		}

		private void btnDelete_Click(object sender, EventArgs e)
		{
			if (new MyMessage().QuestionDev("Bạn muốn xóa nhân viên này"))
			{
				using (ModelContext db = new ModelContext())
				{
					Employee obj = employeeModelBindingSource.Current as Employee;
					if (obj != null)
					{
						if (db.Entry<Employee>(obj).State == System.Data.Entity.EntityState.Detached)
						{
							db.Set<Employee>().Attach(obj);
						}
						db.Entry<Employee>(obj).State = System.Data.Entity.EntityState.Deleted;
						db.SaveChanges();
						employeeModelBindingSource.RemoveCurrent();
						SwitchControl(false);
					}
				}
			}
		}

		private void btnSave_Click(object sender, EventArgs e)
		{
			if (validateData())
			{
				using (ModelContext db = new ModelContext())
				{
					Employee obj = employeeModelBindingSource.Current as Employee;
					obj.Pwwd = sec.EnCryptMD5(txtPwwd.Text, "remylacroix");
					if (obj != null)
					{
						if (db.Entry<Employee>(obj).State == System.Data.Entity.EntityState.Detached)
						{
							db.Set<Employee>().Attach(obj);
						}
						if (obj.EmployeeId == 0)
						{
							db.Entry<Employee>(obj).State = System.Data.Entity.EntityState.Added;
						}
						else
						{
							db.Entry<Employee>(obj).State = System.Data.Entity.EntityState.Modified;
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
			employeeModelBindingSource.ResetBindings(false);
			Employee_Load(sender,e);
		}

		private void cbRole_Properties_EditValueChanged(object sender, EventArgs e)
		{
			var Role = cbRole.Text.Trim();
			if (Role.Equals("Nhân viên"))
			{
				pwwwdForce.Visible = false;
				usernameForce.Visible = false;
				txtUsername.Enabled = false;
				txtPwwd.Enabled = false;
			}
			else
			{
				pwwwdForce.Visible = true;
				usernameForce.Visible = true;
				txtUsername.Enabled = true;
				txtPwwd.Enabled = true;
			}
		}
	}
}