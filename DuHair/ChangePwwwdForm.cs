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
    public partial class ChangePwwwdForm : DevExpress.XtraEditors.XtraForm
    {
        private const int _blinkFrequency = 200;
        private const int _maxNumberOfBlinks = 5;
        private int _blinkCount = 0;
        string oldPwwwd = "";
        int employeeId = 0;
        MySecurity sec = new MySecurity();
        public ChangePwwwdForm(string oldPwwwd, int employeeId)
        {
            InitializeComponent();
            this.oldPwwwd = oldPwwwd;
            this.employeeId = employeeId;
        }

        private bool checkInsert()
        {
            if (string.IsNullOrEmpty(txtOldPass.Text.Trim()) == true)
            {
                updateStatus("Vui lòng nhập mật khẩu cũ", Color.Red, false);
                this.Invoke(new MethodInvoker(delegate
                {
                    isAlert();
                    txtOldPass.Focus();
                }));
                return false;
            }
            if (!sec.EnCryptMD5(txtOldPass.Text.Trim(), "remylacroix").Equals(oldPwwwd))
            {
                updateStatus("Mật khẩu cũ không đúng", Color.Red, false);
                this.Invoke(new MethodInvoker(delegate
                {
                    isAlert();
                    txtOldPass.Focus();
                }));
                return false;
            }
            if (string.IsNullOrEmpty(txtNewPass.Text.Trim()) == true)
            {
                updateStatus("Vui lòng nhập mật khẩu mới", Color.Red, false);
                this.Invoke(new MethodInvoker(delegate
                {
                    isAlert();
                    txtNewPass.Focus();
                }));
                return false;
            }
            if (string.IsNullOrEmpty(txtReNewPass.Text.Trim()) == true)
            {
                updateStatus("Vui lòng xác nhận mật khẩu mới", Color.Red, false);
                this.Invoke(new MethodInvoker(delegate
                {
                    isAlert();
                    txtReNewPass.Focus();
                }));
                return false;
            }
            if (!txtNewPass.Text.Trim().Equals(txtReNewPass.Text.Trim()))
            {
                updateStatus("Xác nhận mật khẩu mới không đúng", Color.Red, false);
                this.Invoke(new MethodInvoker(delegate
                {
                    isAlert();
                    txtReNewPass.Focus();
                }));
                return false;
            }
            lblError.Text = "Không được bỏ trống";
            return true;
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            if (checkInsert())
            {
                using (ModelContext db = new ModelContext())
                {
                    Employee objEmployee = db.EmployeeList.Where(m => m.EmployeeId == employeeId).Single();
                    string newPwwwd = sec.EnCryptMD5(txtNewPass.Text.Trim(), "remylacroix");
                    objEmployee.Pwwd = newPwwwd;
                    db.SaveChanges();
                    new MyMessage().InformationDev("Đổi mật khẩu thành công");
                    this.Close();
                }
            }
        }

        private void tmError_Tick(object sender, EventArgs e)
        {
            lblError.Visible = !lblError.Visible;
            _blinkCount++;
            if (_blinkCount == _maxNumberOfBlinks * 2)
            {
                tmError.Stop();
                lblError.Visible = true;
                _blinkCount = 0;
            }
        }

        private void isAlert()
        {
            tmError.Interval = _blinkFrequency;
            tmError.Start();
        }

        private void updateStatus(string text, Color color, bool isProcess)
        {
            this.Invoke(new MethodInvoker(delegate
            {
                lblError.Visible = true;
                lblError.Text = text;
                lblError.ForeColor = color;
                if (isProcess == true)
                    lblError.Appearance.Image = global::DuHair.Properties.Resources.loading2;
                else
                    lblError.Appearance.Image = global::DuHair.Properties.Resources.busy;
            }));
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}