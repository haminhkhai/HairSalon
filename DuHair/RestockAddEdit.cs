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
    public partial class RestockAddEdit : DevExpress.XtraEditors.XtraForm
    {
        private int restockId = 0;
        private string action = "";
        private DateTime restockDate;
        public delegate void dlLoad();
        public dlLoad dlLoadCallback;
        public RestockAddEdit(int restockId, string action)
        {
            InitializeComponent();
            this.restockId = restockId;
            this.action = action;
        }

        private void RestockAddEdit_Load(object sender, EventArgs e)
        {
            List<MaterialRestockView> materialRestockViewList = new List<MaterialRestockView>();
            if (restockId == 0)
            {
                restockDate = DateTime.Now;
                lblTime.Text = restockDate.ToString("HH:mm dd/MM/yyyy");
                using (ModelContext db = new ModelContext())
                {
                    var rs = db.MaterialList.Select(c => new MaterialRestockView()
                    {
                        MaterialId = c.MaterialId,
                        Name = c.Name,
                        PriceBuy = c.PriceBuy,
                        Quantity = 0
                    });
                    materialRestockViewList = rs.ToList();
                    gridControl1.DataSource = materialRestockViewList;

                    var newestRestockId = db.RestockList.OrderByDescending(r => r.RestockId)
                                                                .Take(1)
                                                                .Select(r => r.RestockId)
                                                                .ToList()
                                                                .FirstOrDefault();
                    string restockIdCoded = string.Format("NK-{0:D5}", newestRestockId + 1);
                    lblId.Text = restockIdCoded;
                }
            }
            else
            {
                if (action.Equals("View"))
                    btnSave.Visible = false;
                using(ModelContext db = new ModelContext())
	            {
                    List<RestockDetail> restockDetailList = db.RestockDetailList.Where(r => r.Restock.RestockId == restockId).ToList();
                    foreach (var objRestockDetail in restockDetailList)
                    {
                        db.Entry<RestockDetail>(objRestockDetail).Reference(r => r.Material).Load();
                        materialRestockViewList.Add(new MaterialRestockView{ Name = objRestockDetail.Material.Name,
                                                                             MaterialId = objRestockDetail.Material.MaterialId,
                                                                             PriceBuy = objRestockDetail.PriceBuy,
                                                                             Quantity = objRestockDetail.Quantity
                        });
                    }
                    db.Entry<RestockDetail>(restockDetailList.First()).Reference(r => r.Restock).Load();
                    gridControl1.DataSource = materialRestockViewList;
                    txtAmount.Text = restockDetailList.FirstOrDefault().Restock.AmountMoney.ToString();
                    restockDate = restockDetailList.FirstOrDefault().Restock.RestockDate;
                    lblTime.Text = restockDate.ToString("HH:mm dd/MM/yyyy");
                    lblId.Text = string.Format("NK-{0:D5}", restockId);
	            }
            }
        }

        private void gridView1_FocusedColumnChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedColumnChangedEventArgs e)
        {
            gridView1.FocusedColumn = colQuantity;
        }

        private void gridView1_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            gridView1.FocusedColumn = colQuantity;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            var amountMoney = Convert.ToInt32(txtAmount.Text.Trim());
            RestockDetail objRestockDetail = null;
            Material objMaterial = null;
            Warehouse objWarehouse = null;

            if (restockId == 0)
            {
                using (ModelContext db = new ModelContext())
                {
                    Restock objRestock = new Restock();
                    objRestock.RestockDate = restockDate;
                    objRestock.AmountMoney = amountMoney;
                    db.RestockList.Add(objRestock);
                    db.RestockList.Attach(objRestock);

                    for (int i = 0; i < gridView1.RowCount; i++)
                    {
                        var quantity = Convert.ToInt32(gridView1.GetRowCellValue(i, "Quantity"));
                        var materialId = Convert.ToInt32(gridView1.GetRowCellValue(i, "MaterialId"));
                        var priceBuy = Convert.ToInt32(gridView1.GetRowCellValue(i, "PriceBuy"));
                        if (quantity > 0)
                        {
                            objMaterial = db.MaterialList.Where(m => m.MaterialId == materialId).FirstOrDefault();
                            objRestockDetail = new RestockDetail { Material = objMaterial,
                                                                   Restock = objRestock,
                                                                   Quantity = quantity,
                                                                   PriceBuy = priceBuy};
                            db.RestockDetailList.Add(objRestockDetail);
                            //update warehouse quantity
                            objWarehouse = db.WarehouseList.Where(w => w.Material.MaterialId == materialId).FirstOrDefault();
                            objWarehouse.Quantity += quantity;
                            db.WarehouseList.Attach(objWarehouse);
                            db.Entry<Warehouse>(objWarehouse).State = System.Data.Entity.EntityState.Modified;
                        }
                    }
                    db.Entry<Restock>(objRestock).State = System.Data.Entity.EntityState.Added;
                    db.SaveChanges();
                    dlLoadCallback();
                    this.Close();
                }
            }
            else
            {
                int newestRestockId = 0;
                using (ModelContext db = new ModelContext())
                {
                    newestRestockId = db.RestockList.OrderByDescending(r => r.RestockId)
                                                                .Take(1)
                                                                .Select(r => r.RestockId)
                                                                .ToList()
                                                                .FirstOrDefault();
                    List<RestockDetail> restockDetailList = db.RestockDetailList.Where(r => r.Restock.RestockId == restockId).ToList();
                    foreach (var restockDetail in restockDetailList)
                    {
                        db.Entry<RestockDetail>(restockDetail).Reference(r => r.Material).Load();
                        //update warehouse quantity if this restock is the newest
                        if (restockId == newestRestockId)
                        {
                            objWarehouse = db.WarehouseList.Where(w => w.Material.MaterialId == restockDetail.Material.MaterialId).FirstOrDefault();
                            objWarehouse.Quantity -= restockDetail.Quantity;
                            db.WarehouseList.Attach(objWarehouse);
                            db.Entry<Warehouse>(objWarehouse).State = System.Data.Entity.EntityState.Modified;
                        }
                        db.Entry<RestockDetail>(restockDetail).State = System.Data.Entity.EntityState.Deleted;
                    }
                    db.SaveChanges();
                }
                using (ModelContext db = new ModelContext())
                {
                    Restock objRestock = db.RestockList.Where(r => r.RestockId == restockId).FirstOrDefault();
                    objRestock.RestockDate = restockDate;
                    objRestock.AmountMoney = amountMoney;
                    if (db.Entry<Restock>(objRestock).State == System.Data.Entity.EntityState.Detached)
                        db.Set<Restock>().Attach(objRestock);
                    db.RestockList.Add(objRestock);
                    db.RestockList.Attach(objRestock);

                    for (int i = 0; i < gridView1.RowCount; i++)
                    {
                        var quantity = Convert.ToInt32(gridView1.GetRowCellValue(i, "Quantity"));
                        var materialId = Convert.ToInt32(gridView1.GetRowCellValue(i, "MaterialId"));
                        var priceBuy = Convert.ToInt32(gridView1.GetRowCellValue(i, "PriceBuy"));
                        if (quantity > 0)
                        {
                            objMaterial = new Material { MaterialId = materialId };
                            db.MaterialList.Add(objMaterial);
                            db.MaterialList.Attach(objMaterial);
                            objRestockDetail = new RestockDetail
                            {
                                Material = objMaterial,
                                Restock = objRestock,
                                Quantity = quantity,
                                PriceBuy = priceBuy
                            };
                            db.RestockDetailList.Add(objRestockDetail);
                            if (db.Entry<RestockDetail>(objRestockDetail).State == System.Data.Entity.EntityState.Detached)
                                db.Set<RestockDetail>().Attach(objRestockDetail);
                            //update warehouse quantity
                            if (restockId == newestRestockId)
                            {
                                objWarehouse = db.WarehouseList.Where(w => w.Material.MaterialId == materialId).FirstOrDefault();
                                objWarehouse.Material.MaterialId = objMaterial.MaterialId;
                                objWarehouse.Quantity += quantity;
                                db.WarehouseList.Attach(objWarehouse);
                                db.Entry<Warehouse>(objWarehouse).State = System.Data.Entity.EntityState.Modified;
                            }

                        }
                    }
                    db.Entry<Restock>(objRestock).State = System.Data.Entity.EntityState.Modified;
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
    }
}