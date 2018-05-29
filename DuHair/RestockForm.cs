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
using DevExpress.XtraGrid.Views.Grid.ViewInfo;
using DevExpress.XtraGrid.Views.Grid;

namespace DuHair
{
    public partial class RestockForm : DevExpress.XtraEditors.XtraForm
    {
        public RestockForm()
        {
            InitializeComponent();
        }
        private void RestockForm_Load(object sender, EventArgs e)
        {
            loadData();
        }

        protected void loadData()
        { 
            using(ModelContext db = new ModelContext())
	        {
                List<RestockView> restockViewList = db.RestockList.Select(r => new RestockView { 
                                                                   RestockId = r.RestockId,
                                                                   RestockDate = r.RestockDate,
                                                                   AmountMoney = r.AmountMoney}).ToList();
                foreach (var restockView in restockViewList)
                {
                    restockView.RestockIdCoded = string.Format("NK-{0:D5}", restockView.RestockId);
                }
                gridControl1.DataSource = restockViewList;
	        }
        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            RestockAddEdit restockAddEdit = new RestockAddEdit(0, "New");
            restockAddEdit.dlLoadCallback = this.loadData;
            restockAddEdit.ShowDialog();
        }

        private void DoRowDoubleClick(GridView view, Point pt)
        {
            GridHitInfo info = view.CalcHitInfo(pt);
            if ((info.InRow ? true : info.InRowCell))
            {
                try
                {
                    int restockId = Convert.ToInt16(gridView1.GetRowCellValue(info.RowHandle, "RestockId"));
                    RestockAddEdit rae = new RestockAddEdit(restockId, "View");
                    rae.ShowDialog();
                }
                catch (Exception)
                {
                }
            }
        }

        private void gridView1_DoubleClick(object sender, EventArgs e)
        {
            GridView view = (GridView)sender;
            Point pt = view.GridControl.PointToClient(System.Windows.Forms.Control.MousePosition);
            this.DoRowDoubleClick(view, pt);
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            int restockId = Convert.ToInt16(gridView1.GetRowCellValue(gridView1.FocusedRowHandle, "RestockId"));
            RestockAddEdit restockAddEdit = new RestockAddEdit(restockId, "Edit");
            restockAddEdit.dlLoadCallback = this.loadData;
            restockAddEdit.ShowDialog();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (new MyMessage().QuestionDev("Bạn muốn xóa phiếu nhập kho này"))
            {
                using (ModelContext db = new ModelContext())
                {
                    Restock objRestock = gridView1.GetRow(gridView1.FocusedRowHandle) as Restock;
                    List<RestockDetail> restockDetailList = db.RestockDetailList.Where(r => r.Restock.RestockId == objRestock.RestockId).ToList();
                    foreach (var objRestockDetail in restockDetailList)
                    {
                        db.Entry<RestockDetail>(objRestockDetail).State = System.Data.Entity.EntityState.Deleted;
                    }
                    db.Entry<Restock>(objRestock).State = System.Data.Entity.EntityState.Deleted;
                    db.SaveChanges();
                    loadData();
                }
            }
        }
    }
}