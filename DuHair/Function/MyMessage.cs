using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using System.Threading;

public class MyMessage
{
    public void InformationDev(string Message)
    {
        XtraMessageBox.Show(Message, "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
    }

    public void WarningDev(string Message)
    {
        XtraMessageBox.Show(Message, "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
    }

    public void ErrorDev(string Message)
    {
        XtraMessageBox.Show(Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
    }

    public bool QuestionDev(string Message)
    {
        if (XtraMessageBox.Show(Message + " ?", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
        {
            return true;
        }
        else return false;
    }
}
