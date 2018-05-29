namespace DuHair
{
    partial class ServiceForm
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ServiceForm));
            this.btnCancel = new DevExpress.XtraEditors.SimpleButton();
            this.btnSave = new DevExpress.XtraEditors.SimpleButton();
            this.btnNew = new DevExpress.XtraEditors.SimpleButton();
            this.btnEdit = new DevExpress.XtraEditors.SimpleButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.lbStatus = new DevExpress.XtraEditors.LabelControl();
            this.txtSellDiscount = new DevExpress.XtraEditors.TextEdit();
            this.serviceModelBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.label3 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txtDiscount = new DevExpress.XtraEditors.TextEdit();
            this.txtPrice = new DevExpress.XtraEditors.TextEdit();
            this.txtName = new DevExpress.XtraEditors.TextEdit();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.popupMaterial = new DevExpress.XtraEditors.PopupContainerEdit();
            this.popupContainerControl1 = new DevExpress.XtraEditors.PopupContainerControl();
            this.gvMaterialMain = new DevExpress.XtraGrid.GridControl();
            this.gvMaterial = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colMaterialId = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colName1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.cbStatus = new DevExpress.XtraEditors.ComboBoxEdit();
            this.materialModelBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colServiceId = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colPrice = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDiscount = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colStatus = new DevExpress.XtraGrid.Columns.GridColumn();
            this.serviceModelBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtSellDiscount.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.serviceModelBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDiscount.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtPrice.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtName.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.popupMaterial.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.popupContainerControl1)).BeginInit();
            this.popupContainerControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gvMaterialMain)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvMaterial)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbStatus.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.materialModelBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.serviceModelBindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnCancel
            // 
            this.btnCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.Image = ((System.Drawing.Image)(resources.GetObject("btnCancel.Image")));
            this.btnCancel.Location = new System.Drawing.Point(844, 455);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(122, 39);
            this.btnCancel.TabIndex = 19;
            this.btnCancel.Text = "Hủy";
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnSave
            // 
            this.btnSave.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSave.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnSave.Image = ((System.Drawing.Image)(resources.GetObject("btnSave.Image")));
            this.btnSave.Location = new System.Drawing.Point(717, 455);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(122, 39);
            this.btnSave.TabIndex = 18;
            this.btnSave.Text = "Lưu";
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnNew
            // 
            this.btnNew.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnNew.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnNew.Image = ((System.Drawing.Image)(resources.GetObject("btnNew.Image")));
            this.btnNew.ImageLocation = DevExpress.XtraEditors.ImageLocation.MiddleLeft;
            this.btnNew.Location = new System.Drawing.Point(460, 455);
            this.btnNew.Name = "btnNew";
            this.btnNew.Size = new System.Drawing.Size(122, 39);
            this.btnNew.TabIndex = 16;
            this.btnNew.Text = "Tạo mới";
            this.btnNew.Click += new System.EventHandler(this.btnNew_Click);
            // 
            // btnEdit
            // 
            this.btnEdit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnEdit.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnEdit.Image = ((System.Drawing.Image)(resources.GetObject("btnEdit.Image")));
            this.btnEdit.Location = new System.Drawing.Point(590, 455);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(122, 39);
            this.btnEdit.TabIndex = 17;
            this.btnEdit.Text = "Chỉnh sửa";
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.labelControl1);
            this.panel1.Controls.Add(this.labelControl2);
            this.panel1.Controls.Add(this.lbStatus);
            this.panel1.Controls.Add(this.txtSellDiscount);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.txtDiscount);
            this.panel1.Controls.Add(this.txtPrice);
            this.panel1.Controls.Add(this.txtName);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.popupMaterial);
            this.panel1.Controls.Add(this.popupContainerControl1);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.cbStatus);
            this.panel1.Location = new System.Drawing.Point(417, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(550, 435);
            this.panel1.TabIndex = 15;
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl1.Appearance.ForeColor = System.Drawing.Color.Red;
            this.labelControl1.Location = new System.Drawing.Point(520, 53);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(11, 24);
            this.labelControl1.TabIndex = 40;
            this.labelControl1.Text = "*";
            // 
            // labelControl2
            // 
            this.labelControl2.Appearance.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl2.Appearance.ForeColor = System.Drawing.Color.Red;
            this.labelControl2.Location = new System.Drawing.Point(520, 20);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(11, 24);
            this.labelControl2.TabIndex = 39;
            this.labelControl2.Text = "*";
            // 
            // lbStatus
            // 
            this.lbStatus.Appearance.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbStatus.Appearance.ForeColor = System.Drawing.Color.Red;
            this.lbStatus.Appearance.Image = global::DuHair.Properties.Resources.busy;
            this.lbStatus.ImageAlignToText = DevExpress.XtraEditors.ImageAlignToText.LeftCenter;
            this.lbStatus.Location = new System.Drawing.Point(27, 221);
            this.lbStatus.Name = "lbStatus";
            this.lbStatus.Size = new System.Drawing.Size(221, 22);
            this.lbStatus.TabIndex = 38;
            this.lbStatus.Text = "(*) Không được bỏ trống";
            // 
            // txtSellDiscount
            // 
            this.txtSellDiscount.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.serviceModelBindingSource, "SellDiscount", true));
            this.txtSellDiscount.EditValue = "";
            this.txtSellDiscount.Location = new System.Drawing.Point(124, 145);
            this.txtSellDiscount.Name = "txtSellDiscount";
            this.txtSellDiscount.Properties.Mask.EditMask = "P1";
            this.txtSellDiscount.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
            this.txtSellDiscount.Properties.Mask.UseMaskAsDisplayFormat = true;
            this.txtSellDiscount.Size = new System.Drawing.Size(392, 26);
            this.txtSellDiscount.TabIndex = 5;
            this.txtSellDiscount.Enter += new System.EventHandler(this.txtSellDiscount_Enter);
            this.txtSellDiscount.MouseUp += new System.Windows.Forms.MouseEventHandler(this.txtSellDiscount_MouseUp);
            // 
            // serviceModelBindingSource
            // 
            this.serviceModelBindingSource.DataSource = typeof(DuHair.Service);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(28, 148);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(84, 19);
            this.label3.TabIndex = 17;
            this.label3.Text = "CK tư vấn:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(24, 180);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(89, 19);
            this.label7.TabIndex = 16;
            this.label7.Text = "Tình trạng:";
            // 
            // txtDiscount
            // 
            this.txtDiscount.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.serviceModelBindingSource, "Discount", true));
            this.txtDiscount.EditValue = "";
            this.txtDiscount.Location = new System.Drawing.Point(124, 113);
            this.txtDiscount.Name = "txtDiscount";
            this.txtDiscount.Properties.Mask.EditMask = "P1";
            this.txtDiscount.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
            this.txtDiscount.Properties.Mask.UseMaskAsDisplayFormat = true;
            this.txtDiscount.Size = new System.Drawing.Size(392, 26);
            this.txtDiscount.TabIndex = 4;
            this.txtDiscount.Enter += new System.EventHandler(this.txtDiscount_Enter);
            this.txtDiscount.MouseUp += new System.Windows.Forms.MouseEventHandler(this.txtDiscount_MouseUp);
            // 
            // txtPrice
            // 
            this.txtPrice.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.serviceModelBindingSource, "Price", true));
            this.txtPrice.EditValue = "";
            this.txtPrice.Location = new System.Drawing.Point(124, 50);
            this.txtPrice.Name = "txtPrice";
            this.txtPrice.Properties.Mask.EditMask = "n0";
            this.txtPrice.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
            this.txtPrice.Properties.Mask.UseMaskAsDisplayFormat = true;
            this.txtPrice.Size = new System.Drawing.Size(392, 26);
            this.txtPrice.TabIndex = 2;
            // 
            // txtName
            // 
            this.txtName.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.serviceModelBindingSource, "Name", true));
            this.txtName.EditValue = "";
            this.txtName.Location = new System.Drawing.Point(124, 18);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(392, 26);
            this.txtName.TabIndex = 1;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(22, 115);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(90, 19);
            this.label5.TabIndex = 4;
            this.label5.Text = "Chiết khấu:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(15, 83);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(99, 19);
            this.label4.TabIndex = 3;
            this.label4.Text = "Nguyên liệu:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(75, 53);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 19);
            this.label2.TabIndex = 1;
            this.label2.Text = "Giá:";
            // 
            // popupMaterial
            // 
            this.popupMaterial.EditValue = "";
            this.popupMaterial.Location = new System.Drawing.Point(124, 80);
            this.popupMaterial.Name = "popupMaterial";
            this.popupMaterial.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.popupMaterial.Properties.PopupControl = this.popupContainerControl1;
            this.popupMaterial.Size = new System.Drawing.Size(392, 26);
            this.popupMaterial.TabIndex = 3;
            // 
            // popupContainerControl1
            // 
            this.popupContainerControl1.Controls.Add(this.gvMaterialMain);
            this.popupContainerControl1.Location = new System.Drawing.Point(124, 221);
            this.popupContainerControl1.Margin = new System.Windows.Forms.Padding(4);
            this.popupContainerControl1.Name = "popupContainerControl1";
            this.popupContainerControl1.Size = new System.Drawing.Size(392, 450);
            this.popupContainerControl1.TabIndex = 7;
            // 
            // gvMaterialMain
            // 
            this.gvMaterialMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gvMaterialMain.Location = new System.Drawing.Point(0, 0);
            this.gvMaterialMain.MainView = this.gvMaterial;
            this.gvMaterialMain.Name = "gvMaterialMain";
            this.gvMaterialMain.Size = new System.Drawing.Size(392, 450);
            this.gvMaterialMain.TabIndex = 17;
            this.gvMaterialMain.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gvMaterial});
            // 
            // gvMaterial
            // 
            this.gvMaterial.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colMaterialId,
            this.colName1});
            this.gvMaterial.GridControl = this.gvMaterialMain;
            this.gvMaterial.Name = "gvMaterial";
            this.gvMaterial.OptionsFind.AlwaysVisible = true;
            this.gvMaterial.OptionsFind.FindDelay = 500;
            this.gvMaterial.OptionsFind.FindNullPrompt = "Tên nguyên liệu";
            this.gvMaterial.OptionsSelection.MultiSelect = true;
            this.gvMaterial.OptionsSelection.MultiSelectMode = DevExpress.XtraGrid.Views.Grid.GridMultiSelectMode.CheckBoxRowSelect;
            this.gvMaterial.OptionsView.ShowGroupPanel = false;
            this.gvMaterial.KeyDown += new System.Windows.Forms.KeyEventHandler(this.gvMaterial_KeyDown);
            // 
            // colMaterialId
            // 
            this.colMaterialId.FieldName = "MaterialId";
            this.colMaterialId.Name = "colMaterialId";
            // 
            // colName1
            // 
            this.colName1.Caption = "Nguyên liệu";
            this.colName1.FieldName = "Name";
            this.colName1.Name = "colName1";
            this.colName1.Visible = true;
            this.colName1.VisibleIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(45, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 19);
            this.label1.TabIndex = 0;
            this.label1.Text = "Tên DV:";
            // 
            // cbStatus
            // 
            this.cbStatus.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.serviceModelBindingSource, "Status", true));
            this.cbStatus.EditValue = "Hiển thị";
            this.cbStatus.Location = new System.Drawing.Point(124, 177);
            this.cbStatus.Name = "cbStatus";
            this.cbStatus.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cbStatus.Properties.Items.AddRange(new object[] {
            "Hiển thị",
            "Ẩn"});
            this.cbStatus.Size = new System.Drawing.Size(392, 26);
            this.cbStatus.TabIndex = 6;
            // 
            // gridControl1
            // 
            this.gridControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gridControl1.DataSource = this.serviceModelBindingSource;
            this.gridControl1.Location = new System.Drawing.Point(10, 12);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.MinimumSize = new System.Drawing.Size(400, 400);
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.Size = new System.Drawing.Size(400, 434);
            this.gridControl1.TabIndex = 14;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colServiceId,
            this.colName,
            this.colPrice,
            this.colDiscount,
            this.colStatus});
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.gridView1.RowClick += new DevExpress.XtraGrid.Views.Grid.RowClickEventHandler(this.gridView1_RowClick);
            this.gridView1.FocusedRowChanged += new DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventHandler(this.gridView1_FocusedRowChanged);
            // 
            // colServiceId
            // 
            this.colServiceId.FieldName = "ServiceId";
            this.colServiceId.Name = "colServiceId";
            this.colServiceId.OptionsColumn.AllowEdit = false;
            // 
            // colName
            // 
            this.colName.Caption = "Tên DV";
            this.colName.FieldName = "Name";
            this.colName.Name = "colName";
            this.colName.OptionsColumn.AllowEdit = false;
            this.colName.Visible = true;
            this.colName.VisibleIndex = 0;
            // 
            // colPrice
            // 
            this.colPrice.Caption = "Giá";
            this.colPrice.DisplayFormat.FormatString = "n0";
            this.colPrice.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.colPrice.FieldName = "Price";
            this.colPrice.Name = "colPrice";
            this.colPrice.OptionsColumn.AllowEdit = false;
            this.colPrice.Visible = true;
            this.colPrice.VisibleIndex = 1;
            // 
            // colDiscount
            // 
            this.colDiscount.Caption = "Chiết khấu";
            this.colDiscount.DisplayFormat.FormatString = "{0}%";
            this.colDiscount.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Custom;
            this.colDiscount.FieldName = "Discount";
            this.colDiscount.Name = "colDiscount";
            this.colDiscount.OptionsColumn.AllowEdit = false;
            this.colDiscount.Visible = true;
            this.colDiscount.VisibleIndex = 2;
            // 
            // colStatus
            // 
            this.colStatus.Caption = "Tình trạng";
            this.colStatus.FieldName = "Status";
            this.colStatus.Name = "colStatus";
            this.colStatus.OptionsColumn.AllowEdit = false;
            this.colStatus.Visible = true;
            this.colStatus.VisibleIndex = 3;
            // 
            // serviceModelBindingSource1
            // 
            this.serviceModelBindingSource1.DataSource = typeof(DuHair.Service);
            // 
            // ServiceForm
            // 
            this.AcceptButton = this.btnSave;
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnCancel;
            this.ClientSize = new System.Drawing.Size(978, 504);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnNew);
            this.Controls.Add(this.btnEdit);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.gridControl1);
            this.KeyPreview = true;
            this.Name = "ServiceForm";
            this.Text = "Dịch vụ";
            this.Load += new System.EventHandler(this.Service_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtSellDiscount.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.serviceModelBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDiscount.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtPrice.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtName.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.popupMaterial.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.popupContainerControl1)).EndInit();
            this.popupContainerControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gvMaterialMain)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvMaterial)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbStatus.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.materialModelBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.serviceModelBindingSource1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.SimpleButton btnCancel;
        private DevExpress.XtraEditors.SimpleButton btnSave;
        private DevExpress.XtraEditors.SimpleButton btnNew;
        private DevExpress.XtraEditors.SimpleButton btnEdit;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label7;
        private DevExpress.XtraEditors.TextEdit txtDiscount;
        private DevExpress.XtraEditors.TextEdit txtPrice;
        private DevExpress.XtraEditors.TextEdit txtName;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private DevExpress.XtraEditors.ComboBoxEdit cbStatus;
        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private System.Windows.Forms.BindingSource serviceModelBindingSource;
        private System.Windows.Forms.BindingSource materialModelBindingSource;
        private DevExpress.XtraEditors.PopupContainerEdit popupMaterial;
        private DevExpress.XtraEditors.PopupContainerControl popupContainerControl1;
        private DevExpress.XtraGrid.GridControl gvMaterialMain;
        private DevExpress.XtraGrid.Views.Grid.GridView gvMaterial;
        private DevExpress.XtraGrid.Columns.GridColumn colMaterialId;
        private DevExpress.XtraGrid.Columns.GridColumn colName1;
        private DevExpress.XtraGrid.Columns.GridColumn colServiceId;
        private DevExpress.XtraGrid.Columns.GridColumn colName;
        private DevExpress.XtraGrid.Columns.GridColumn colPrice;
        private DevExpress.XtraGrid.Columns.GridColumn colDiscount;
        private DevExpress.XtraGrid.Columns.GridColumn colStatus;
        private System.Windows.Forms.BindingSource serviceModelBindingSource1;
        private DevExpress.XtraEditors.TextEdit txtSellDiscount;
        private System.Windows.Forms.Label label3;
        private DevExpress.XtraEditors.LabelControl lbStatus;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.LabelControl labelControl2;
    }
}