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
    public partial class SpendNoteForm : DevExpress.XtraEditors.XtraForm
    {
        public SpendNoteForm()
        {
            InitializeComponent();
            using (ModelContext db = new ModelContext())
            {
                try
                {
                    spendNoteBindingSource.DataSource = db.SpendNoteList.Where(s => s.SpendDate.Month == DateTime.Now.Month).ToList();
                }
                catch (Exception) {}
            }
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

        private void SpendNoteForm_Load(object sender, EventArgs e)
        {
            
            
            panel1.Enabled = false;
            btnSave.Enabled = false;
            btnCancel.Enabled = false;
        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            SwitchControl(true);
            spendNoteBindingSource.Add(new SpendNote());
            spendNoteBindingSource.MoveLast();
            txtName.Focus();
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            SwitchControl(true);
            txtName.Focus();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            using (ModelContext db = new ModelContext())
            {
                SpendNote objSpendNote = spendNoteBindingSource.Current as SpendNote;
                if (objSpendNote != null)
                {
                    if (db.Entry<SpendNote>(objSpendNote).State == System.Data.Entity.EntityState.Detached)
                    {
                        db.Set<SpendNote>().Attach(objSpendNote);
                    }
                    if (objSpendNote.SpendNoteId == 0)
                    {
                        objSpendNote.SpendDate = DateTime.Now;
                        db.Entry<SpendNote>(objSpendNote).State = System.Data.Entity.EntityState.Added;
                    }
                    else
                    {
                        db.Entry<SpendNote>(objSpendNote).State = System.Data.Entity.EntityState.Modified;
                    }
                    db.SaveChanges();
                    SwitchControl(false);
                    gridView1.RefreshData();
                }
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            SwitchControl(false);
            spendNoteBindingSource.ResetBindings(false);
            SpendNoteForm_Load(sender, e);
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (new MyMessage().QuestionDev("Bạn muốn xóa khoản chi này"))
            {
                using (ModelContext db = new ModelContext())
                {
                    SpendNote objSpendNote = spendNoteBindingSource.Current as SpendNote;
                    if (objSpendNote != null)
                    {
                        if (db.Entry<SpendNote>(objSpendNote).State == System.Data.Entity.EntityState.Detached)
                        {
                            db.Set<SpendNote>().Attach(objSpendNote);
                        }
                        db.Entry<SpendNote>(objSpendNote).State = System.Data.Entity.EntityState.Deleted;
                        db.SaveChanges();
                        spendNoteBindingSource.RemoveCurrent();
                        SwitchControl(false);
                    }
                }
            }
        }

        private void btnReload_Click(object sender, EventArgs e)
        {
            using (ModelContext db = new ModelContext())
            {
                try
                {
                    DateTime from = (DateTime)txtFrom.EditValue;
                    DateTime to = (DateTime)txtTo.EditValue;

                    spendNoteBindingSource.DataSource = db.SpendNoteList.Where(s => s.SpendDate.Month >= from.Month && s.SpendDate.Month <= to.Month).ToList();
                    spendNoteBindingSource.ResetBindings(true);
                }
                catch (Exception){}
            }
        }
    }
}