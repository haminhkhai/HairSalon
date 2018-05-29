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
    public partial class WarehouseForm : DevExpress.XtraEditors.XtraForm
    {
        public WarehouseForm()
        {
            InitializeComponent();
        }

        private void WarehouseForm_Load(object sender, EventArgs e)
        {
            loadDataWarehouseCheck();
        }

        public void loadDataWarehouseCheck()
        {
            using (ModelContext db = new ModelContext())
            {
                var objWarehouseMaterial = from w in db.WarehouseList
                                           select new
                                           {
                                               WarehouseId = w.WarehouseId,
                                               Name = w.Material.Name,
                                               Quantity = w.Quantity
                                           };
                gridControl1.DataSource = objWarehouseMaterial.ToList();

                List<WarehouseCheckView> warehouseCheckViewList =
                    db.WarehouseCheckList.Select(w => new WarehouseCheckView
                    {
                        WarehouseCheckId = w.WarehouseCheckId,
                        WarehouseCheckIdCoded = "",
                        Margin = w.Margin,
                        CheckDate = w.CheckDate
                    }).ToList();
                foreach (var warehouseCheckView in warehouseCheckViewList)
                {
                    warehouseCheckView.WarehouseCheckIdCoded = string.Format("KK-{0:D5}", warehouseCheckView.WarehouseCheckId);
                }
                gridControl2.DataSource = warehouseCheckViewList;
            }
        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            WarehouseCheckAddEdit wae = new WarehouseCheckAddEdit(0, "insert");
            wae.dlLoadCallback = this.loadDataWarehouseCheck;
            wae.ShowDialog();
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            int warehouseCheckId = (int)gridView2.GetRowCellValue(gridView2.FocusedRowHandle, "WarehouseCheckId");
            WarehouseCheckAddEdit wae = new WarehouseCheckAddEdit(warehouseCheckId, "Edit");
            wae.dlLoadCallback = this.loadDataWarehouseCheck;
            wae.ShowDialog();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (new MyMessage().QuestionDev("Bạn muốn xóa phiếu kiểm kho này"))
            {
                int warehouseCheckId = (int)gridView2.GetRowCellValue(gridView2.FocusedRowHandle, "WarehouseCheckId");
                using(ModelContext db = new ModelContext())
	            {
                    WarehouseCheck objWarehouseCheck = db.WarehouseCheckList.Where(w => w.WarehouseCheckId == warehouseCheckId).FirstOrDefault();
                    if (db.Entry<WarehouseCheck>(objWarehouseCheck).State == System.Data.Entity.EntityState.Detached)
                        db.WarehouseCheckList.Attach(objWarehouseCheck);
                    db.Entry<WarehouseCheck>(objWarehouseCheck).State = System.Data.Entity.EntityState.Deleted;
                    db.SaveChanges();
	            }
            }
        }

        private void DoRowDoubleClick(GridView gridView, Point pt)
        {
            GridHitInfo info = gridView.CalcHitInfo(pt);
            if ((info.InRow ? true : info.InRowCell))
            {
                try
                {
                    int warehouseCheckId = Convert.ToInt32(gridView2.GetRowCellValue(info.RowHandle, "WarehouseCheckId"));
                    WarehouseCheckAddEdit wae = new WarehouseCheckAddEdit(warehouseCheckId, "View");
                    wae.ShowDialog();
                }
                catch (Exception)
                {
                }
            }
        }

        private void gridView2_DoubleClick(object sender, EventArgs e)
        {
            GridView gridView = (GridView)sender;
            Point pt = gridView.GridControl.PointToClient(System.Windows.Forms.Control.MousePosition);
            DoRowDoubleClick(gridView, pt);
        }
    }
}