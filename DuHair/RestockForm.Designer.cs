namespace DuHair
{
    partial class RestockForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RestockForm));
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colRestockId = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colRestockIdCoded = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colAmountMoney = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colRestockDate = new DevExpress.XtraGrid.Columns.GridColumn();
            this.btnDelete = new DevExpress.XtraEditors.SimpleButton();
            this.btnNew = new DevExpress.XtraEditors.SimpleButton();
            this.btnEdit = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // gridControl1
            // 
            this.gridControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gridControl1.EmbeddedNavigator.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.gridControl1.Location = new System.Drawing.Point(8, 8);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.gridControl1.MinimumSize = new System.Drawing.Size(267, 274);
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.Size = new System.Drawing.Size(636, 297);
            this.gridControl1.TabIndex = 15;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colRestockId,
            this.colRestockIdCoded,
            this.colAmountMoney,
            this.colRestockDate});
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.Name = "gridView1";
            this.gridView1.DoubleClick += new System.EventHandler(this.gridView1_DoubleClick);
            // 
            // colRestockId
            // 
            this.colRestockId.FieldName = "RestockId";
            this.colRestockId.Name = "colRestockId";
            this.colRestockId.OptionsColumn.AllowEdit = false;
            // 
            // colRestockIdCoded
            // 
            this.colRestockIdCoded.Caption = "Phiếu nhập kho";
            this.colRestockIdCoded.FieldName = "RestockIdCoded";
            this.colRestockIdCoded.MaxWidth = 140;
            this.colRestockIdCoded.Name = "colRestockIdCoded";
            this.colRestockIdCoded.OptionsColumn.AllowEdit = false;
            this.colRestockIdCoded.Visible = true;
            this.colRestockIdCoded.VisibleIndex = 0;
            this.colRestockIdCoded.Width = 140;
            // 
            // colAmountMoney
            // 
            this.colAmountMoney.Caption = "Tổng tiền";
            this.colAmountMoney.DisplayFormat.FormatString = "n0";
            this.colAmountMoney.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Custom;
            this.colAmountMoney.FieldName = "AmountMoney";
            this.colAmountMoney.Name = "colAmountMoney";
            this.colAmountMoney.OptionsColumn.AllowEdit = false;
            this.colAmountMoney.Visible = true;
            this.colAmountMoney.VisibleIndex = 1;
            this.colAmountMoney.Width = 395;
            // 
            // colRestockDate
            // 
            this.colRestockDate.Caption = "Ngày nhập";
            this.colRestockDate.DisplayFormat.FormatString = "{0:HH:mm dd/MM/yyyy}";
            this.colRestockDate.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Custom;
            this.colRestockDate.FieldName = "RestockDate";
            this.colRestockDate.Name = "colRestockDate";
            this.colRestockDate.OptionsColumn.AllowEdit = false;
            this.colRestockDate.Visible = true;
            this.colRestockDate.VisibleIndex = 2;
            this.colRestockDate.Width = 398;
            // 
            // btnDelete
            // 
            this.btnDelete.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnDelete.Image = ((System.Drawing.Image)(resources.GetObject("btnDelete.Image")));
            this.btnDelete.Location = new System.Drawing.Point(563, 311);
            this.btnDelete.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(81, 27);
            this.btnDelete.TabIndex = 25;
            this.btnDelete.Text = "Xóa";
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnNew
            // 
            this.btnNew.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnNew.Image = ((System.Drawing.Image)(resources.GetObject("btnNew.Image")));
            this.btnNew.ImageLocation = DevExpress.XtraEditors.ImageLocation.MiddleLeft;
            this.btnNew.Location = new System.Drawing.Point(392, 311);
            this.btnNew.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnNew.Name = "btnNew";
            this.btnNew.Size = new System.Drawing.Size(81, 27);
            this.btnNew.TabIndex = 21;
            this.btnNew.Text = "Tạo mới";
            this.btnNew.Click += new System.EventHandler(this.btnNew_Click);
            // 
            // btnEdit
            // 
            this.btnEdit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnEdit.Image = ((System.Drawing.Image)(resources.GetObject("btnEdit.Image")));
            this.btnEdit.Location = new System.Drawing.Point(477, 311);
            this.btnEdit.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(81, 27);
            this.btnEdit.TabIndex = 22;
            this.btnEdit.Text = "Chỉnh sửa";
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // RestockForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(652, 345);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnNew);
            this.Controls.Add(this.btnEdit);
            this.Controls.Add(this.gridControl1);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "RestockForm";
            this.Text = "Nhập kho";
            this.Load += new System.EventHandler(this.RestockForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Columns.GridColumn colRestockId;
        private DevExpress.XtraGrid.Columns.GridColumn colRestockIdCoded;
        private DevExpress.XtraGrid.Columns.GridColumn colAmountMoney;
        private DevExpress.XtraGrid.Columns.GridColumn colRestockDate;
        private DevExpress.XtraEditors.SimpleButton btnDelete;
        private DevExpress.XtraEditors.SimpleButton btnNew;
        private DevExpress.XtraEditors.SimpleButton btnEdit;
    }
}