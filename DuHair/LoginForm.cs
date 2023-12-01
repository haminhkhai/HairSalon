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

namespace DuHair
{
    public partial class LoginForm : DevExpress.XtraEditors.XtraForm
    {
        string version = "v 1.1";
        string nameApp = "DŨ HAIR SALON";
        private const int _blinkFrequency = 200;
        private const int _maxNumberOfBlinks = 5;
        private int _blinkCount = 0;
        MyMessage mess;
        Thread thProcess;
        MySecurity sec;
        public LoginForm()
        {
            
            this.Hide();
            Thread checkThread = new Thread(new ThreadStart(checkScreen.showCheck));
            checkThread.IsBackground = true;
            checkThread.Start();
            InitializeComponent();
            this.Text = nameApp + " " + version + " " + "- Đăng nhập";
            mess = new MyMessage();
            sec = new MySecurity();
            //cof = new frmConfig();
        }

        private void LoginForm_Load(object sender, EventArgs e)
        {
            try
            {
                checkScreen.updateStatus("Kiểm tra thiết lập ...");
                Thread.Sleep(500);
                //checkExitingConfig();
                checkScreen.updateStatus("Kiểm tra kết nối cơ sở dữ liệu ...");
                Thread.Sleep(500);
                //checkConnectionDatabase();
                this.Show();
                checkScreen.closeCheck();
                this.Activate();
                lblStatus.Visible = false;
            }
            catch (Exception)
            {
                Application.ExitThread();
                Application.Exit();
            }
        }

        private bool checkValidateInput()
        {
            string name = txtUsername.Text.Trim();
            string password = txtPassword.Text.Trim();
            if (string.IsNullOrEmpty(name) == true)
            {
                updateStatus("Vui lòng nhập tài khoản", Color.Red, false);

                this.Invoke(new MethodInvoker(delegate
                {
                    isAlert();
                    txtUsername.Focus();
                }));
                return false;
            }
            if (string.IsNullOrEmpty(password) == true)
            {
                updateStatus("Vui lòng nhập mật khẩu", Color.Red, false);
                this.Invoke(new MethodInvoker(delegate
                {
                    isAlert();
                    txtPassword.Focus();
                }));
                return false;
            }
            return true;
        }

        // kiểm tra login
        private void checkLogin()
        {
            if (checkValidateInput() == true)
            {
                if (checkValidateInput() == true)
                {
                    Employee employee = null;
                    string username = txtUsername.Text.Trim();
                    string password = sec.EnCryptMD5(txtPassword.Text.Trim(), "remylacroix"); ; 
                    updateStatus("Đang đăng nhập vào hệ thống!", Color.Black, true);
                    Thread.Sleep(200);
                    try
                    {
                        using (ModelContext db = new ModelContext())
                        {
                            employee = db.EmployeeList.Where(e => e.Username.Equals(username))
                                                               .Where(e => e.Pwwd.Equals(password)).SingleOrDefault();
                        }
                    }
                    catch (Exception ex)
                    {
                        string ee = ex.Message;
                    }

                    if (employee != null)
                    {
                        if (employee.Status.Equals("Hiển thị", StringComparison.InvariantCultureIgnoreCase))
                        {
                            updateStatus("Đăng nhập thành công, vui lòng chờ giây lát...", Color.Black, true);
                            this.Invoke(new MethodInvoker(delegate
                            {
                                MainForm main = new MainForm(employee.Role, employee.Pwwd, employee.EmployeeId, employee.Name);
                                main.Show();
                                this.Hide();
                            }));
                        }
                        else
                        {
                            updateStatus("Tài khoản của bạn đã bị khóa", Color.Red, false);
                            this.Invoke(new MethodInvoker(delegate
                            {
                                isAlert();
                                txtUsername.Focus();
                            }));
                        }
                    }
                    else
                    {
                        updateStatus("Sai tài khoản hoặc mật khẩu!", Color.Red, false);
                        this.Invoke(new MethodInvoker(delegate
                        {
                            isAlert();
                            txtUsername.Focus();
                        }));
                    }
                }
            }
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            thProcess = new Thread(new ThreadStart(checkLogin));
            thProcess.Start();
        }

        private void tmError_Tick(object sender, EventArgs e)
        {
            lblStatus.Visible = !lblStatus.Visible;
            _blinkCount++;
            if (_blinkCount == _maxNumberOfBlinks * 2)
            {
                tmError.Stop();
                lblStatus.Visible = true;
                _blinkCount = 0;
            }
        }

        private void isAlert()
        {
            tmError.Interval = _blinkFrequency;
            tmError.Start();
        }
        //update status
        private void updateStatus(string text, Color color, bool isProcess)
        {
            this.Invoke(new MethodInvoker(delegate
            {
                lblStatus.Visible = true;
                lblStatus.Text = text;
                lblStatus.ForeColor = color;
                if (isProcess == true)
                    lblStatus.Appearance.Image = global::DuHair.Properties.Resources.loading2;
                else
                    lblStatus.Appearance.Image = global::DuHair.Properties.Resources.busy;
            }));
        }
    }
}