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
using DevExpress.XtraGrid;
using DevExpress.XtraGrid.Views.Grid;

namespace DuHair
{
    public partial class WarehouseCheckAddEdit : DevExpress.XtraEditors.XtraForm
    {
        private int warehouseCheckId = 0;
        private string action = "";
        private DateTime checkDate;
        public delegate void dlLoad();
        public dlLoad dlLoadCallback;
        public WarehouseCheckAddEdit(int warehouseCheckId, string action)
        {
            InitializeComponent();
            this.warehouseCheckId = warehouseCheckId;
            this.action = action;
        }

        private void WarehouseCheckAddEdit_Load(object sender, EventArgs e)
        {
            if (warehouseCheckId == 0)
            {
                checkDate = DateTime.Now;
                lblTime.Text = checkDate.ToString("HH:mm dd/MM/yyyy");
                using (ModelContext db = new ModelContext())
                {
                    List<WarehouseCheckDetailView> warehouseCheckDetailList = new List<WarehouseCheckDetailView>();
                    var rs = from w in db.WarehouseList
                             select new WarehouseCheckDetailView
                             {
                                 Material = w.Material,
                                 OldQuantity = w.Quantity,
                                 Quantity = 0
                             };
                    warehouseCheckDetailList = rs.ToList();
                    gridControl1.DataSource = warehouseCheckDetailList;
                    //get new id coded
                    var newestWarehouseCheckId = db.WarehouseCheckList.OrderByDescending(w => w.WarehouseCheckId)
                                                                .Take(1)
                                                                .Select(w => w.WarehouseCheckId)
                                                                .ToList()
                                                                .FirstOrDefault();
                    string warehouseCheckIdCoded = string.Format("KK-{0:D5}", newestWarehouseCheckId + 1);
                    lblId.Text = warehouseCheckIdCoded;
                }
            }
            else
            {
                using(ModelContext db = new ModelContext())
	            {
                    List<WarehouseCheckDetail> warehouseCheckDetailList = db.WarehouseCheckDetailList.
                                                                             Where(w => w.WarehouseCheck.WarehouseCheckId == warehouseCheckId).ToList();
                    foreach (var warehouseCheckDetail in warehouseCheckDetailList)
                    {
                        db.Entry<WarehouseCheckDetail>(warehouseCheckDetail).Reference(w => w.Material).Load();
                    }
                    db.Entry<WarehouseCheckDetail>(warehouseCheckDetailList.First()).Reference(w => w.WarehouseCheck).Load();
                    gridControl1.DataSource = warehouseCheckDetailList;
                    txtNote.Text = warehouseCheckDetailList.FirstOrDefault().WarehouseCheck.Note;
                    checkDate = warehouseCheckDetailList.FirstOrDefault().WarehouseCheck.CheckDate;
                    lblTime.Text = checkDate.ToString("HH:mm dd/MM/yyyy");
                    lblId.Text = string.Format("KK-{0:D5}", warehouseCheckId);
	            }
                if (action.Equals("View"))
                    btnSave.Visible = false;
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            WarehouseCheckDetail objWarehouseCheckDetail = null;
            Material objMaterial = null;
            Warehouse objWarehouse = null;
            if (warehouseCheckId == 0)
            {
                using (ModelContext db = new ModelContext())
                {
                    WarehouseCheck objWarehouseCheck = new WarehouseCheck();
                    objWarehouseCheck.Note = txtNote.Text.Trim();
                    objWarehouseCheck.CheckDate = checkDate;
                    objWarehouseCheck.Margin = (int)colQuantity.SummaryItem.SummaryValue - (int)colOldQuantity.SummaryItem.SummaryValue;
                    db.WarehouseCheckList.Add(objWarehouseCheck);
                    db.WarehouseCheckList.Attach(objWarehouseCheck);
                    
                    for (int i = 0; i < gridView1.RowCount; i++)
                    {
                        var quantity = Convert.ToInt32(gridView1.GetRowCellValue(i, "Quantity"));
                        var oldQuantity = Convert.ToInt32(gridView1.GetRowCellValue(i, "OldQuantity"));
                        var materialId = Convert.ToInt32(gridView1.GetRowCellValue(i, "Material.MaterialId"));
                        objMaterial = db.MaterialList.Where(m => m.MaterialId == materialId).FirstOrDefault();
                        objWarehouseCheckDetail = new WarehouseCheckDetail { WarehouseCheck = objWarehouseCheck,
                                                                             Material = objMaterial,
                                                                             OldQuantity = oldQuantity,
                                                                             Quantity = quantity,
                                                                             Margin = quantity - oldQuantity};
                        db.WarehouseCheckDetailList.Add(objWarehouseCheckDetail);
                        //update warehouse quantity
                        objWarehouse = db.WarehouseList.Where(w => w.Material.MaterialId == materialId).FirstOrDefault();
                        objWarehouse.Material.MaterialId = objMaterial.MaterialId;
                        objWarehouse.Quantity = quantity;
                        db.WarehouseList.Attach(objWarehouse);
                        db.Entry<Warehouse>(objWarehouse).State = System.Data.Entity.EntityState.Modified;
                    }
                    db.Entry<WarehouseCheck>(objWarehouseCheck).State = System.Data.Entity.EntityState.Added;
                    db.SaveChanges();
                    dlLoadCallback();
                    this.Close();
                }
            }
            else
            {
                using (ModelContext db = new ModelContext())
                {
                    WarehouseCheck objWarehouseCheck = db.WarehouseCheckList.Where(w => w.WarehouseCheckId == warehouseCheckId).FirstOrDefault();
                    objWarehouseCheck.Note = txtNote.Text.Trim();
                    objWarehouseCheck.CheckDate = checkDate;
                    objWarehouseCheck.Margin = (int)colQuantity.SummaryItem.SummaryValue - (int)colOldQuantity.SummaryItem.SummaryValue;
                    db.WarehouseCheckList.Add(objWarehouseCheck);
                    db.WarehouseCheckList.Attach(objWarehouseCheck);

                    for (int i = 0; i < gridView1.RowCount; i++)
                    {
                        var warehouseCheckDetailId = Convert.ToInt32(gridView1.GetRowCellValue(i, "WarehouseCheckDetailId"));
                        var quantity = Convert.ToInt32(gridView1.GetRowCellValue(i, "Quantity"));
                        var oldQuantity = Convert.ToInt32(gridView1.GetRowCellValue(i, "OldQuantity"));
                        var materialId = Convert.ToInt32(gridView1.GetRowCellValue(i, "Material.MaterialId"));
                        objMaterial = db.MaterialList.Where(m => m.MaterialId == materialId).FirstOrDefault();
                        db.MaterialList.Add(objMaterial);
                        db.MaterialList.Attach(objMaterial);
                        objWarehouseCheckDetail = new WarehouseCheckDetail
                        {
                            WarehouseCheckDetailId = warehouseCheckDetailId,
                            WarehouseCheck = objWarehouseCheck,
                            Material = objMaterial,
                            OldQuantity = oldQuantity,
                            Quantity = quantity,
                            Margin = quantity - oldQuantity
                        };
                        if (db.Entry<WarehouseCheckDetail>(objWarehouseCheckDetail).State == System.Data.Entity.EntityState.Detached)
                            db.Set<WarehouseCheckDetail>().Attach(objWarehouseCheckDetail);
                        db.Entry<WarehouseCheckDetail>(objWarehouseCheckDetail).State = System.Data.Entity.EntityState.Modified;
                        //update warehouse quantity
                        //get newest WarehouseCheckId to compare whether this is the first record.
                        var newestWarehouseCheckId = db.WarehouseCheckList.OrderByDescending(x => x.WarehouseCheckId)
                                                                          .Take(1)
                                                                          .Select(x => x.WarehouseCheckId)
                                                                          .ToList()
                                                                          .FirstOrDefault();
                        if (newestWarehouseCheckId == warehouseCheckId)
                        {
                            objWarehouse = db.WarehouseList.Where(w => w.Material.MaterialId == materialId).FirstOrDefault();
                            objWarehouse.Material.MaterialId = objMaterial.MaterialId;
                            objWarehouse.Quantity = quantity;
                            db.WarehouseList.Attach(objWarehouse);
                            db.Entry<Warehouse>(objWarehouse).State = System.Data.Entity.EntityState.Modified;
                        }
                    }
                    db.Entry<WarehouseCheck>(objWarehouseCheck).State = System.Data.Entity.EntityState.Modified;
                    db.SaveChanges();
                    dlLoadCallback();
                    this.Close();
                }
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void gridView1_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            gridView1.FocusedColumn = colQuantity;
        }

        private void gridView1_FocusedColumnChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedColumnChangedEventArgs e)
        {
            gridView1.FocusedColumn = colQuantity;
        }

        private void gridControl1_ProcessGridKey(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Tab)
            {
                GridControl grid = sender as GridControl;
                GridView view = grid.FocusedView as GridView;
                if ((e.Modifiers == Keys.None && view.IsLastRow && view.FocusedColumn.VisibleIndex == view.VisibleColumns.Count - 1)
                    || (e.Modifiers == Keys.Shift && view.IsFirstRow && view.FocusedColumn.VisibleIndex == 0))
                {
                    txtNote.Focus();
                }
            }
        }
    }
}