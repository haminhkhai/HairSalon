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
    public partial class CheckForm : DevExpress.XtraEditors.XtraForm
    {
        delegate void dgCheckExitDatabase(string Text);
        delegate void dgCloseCheck();
        bool closeFlag = false;
        MyMessage mess;
        public CheckForm()
        {
            InitializeComponent();
            mess = new MyMessage();
        }

        public void showCheck()
        {
            if (InvokeRequired)
            {
                BeginInvoke(new dgCloseCheck(showCheck));
                return;
            }
            this.Show();
            Application.Run(this);
        }

        public void closeCheck()
        {
            if (InvokeRequired)
            {
                BeginInvoke(new dgCloseCheck(closeCheck));
                return;
            }
            closeFlag = true;
            this.Close();
        }

        public void updateStatus(string message)
        {
            if (InvokeRequired)
            {
                BeginInvoke(new dgCheckExitDatabase(updateStatus), new object[] { message });
                return;
            }

            lblStatus.Text = message;
        }

        private void CheckForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (closeFlag == false)
                e.Cancel = true;
        }
    }
}