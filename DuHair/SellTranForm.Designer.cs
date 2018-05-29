namespace DuHair
{
    partial class SellTranForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SellTranForm));
            this.lblId = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.lblTime = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lblChair = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.materialPopup = new DevExpress.XtraEditors.PopupContainerEdit();
            this.materialPopUpControl = new DevExpress.XtraEditors.PopupContainerControl();
            this.gvMaterialMainPopup = new DevExpress.XtraGrid.GridControl();
            this.gvMaterialPopup = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colMaterialId = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colPrice2 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.gvMaterialMain = new DevExpress.XtraGrid.GridControl();
            this.gvMaterial = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gridColumn3 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDiscount = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSellTranCom = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colPrice = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colQuantity = new DevExpress.XtraGrid.Columns.GridColumn();
            this.cbEmployee = new DevExpress.XtraEditors.SearchLookUpEdit();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gridColumn2 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn4 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.btnMoney = new DevExpress.XtraEditors.SimpleButton();
            this.lblAmount = new System.Windows.Forms.Label();
            this.btnClose = new DevExpress.XtraEditors.SimpleButton();
            this.label2 = new System.Windows.Forms.Label();
            this.cbCustomer = new DevExpress.XtraEditors.SearchLookUpEdit();
            this.searchLookUpEdit1View = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gridColumn6 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn7 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn8 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.lbStatus = new DevExpress.XtraEditors.LabelControl();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.lbEmployeeName = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.materialPopup.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.materialPopUpControl)).BeginInit();
            this.materialPopUpControl.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gvMaterialMainPopup)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvMaterialPopup)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvMaterialMain)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvMaterial)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbEmployee.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbCustomer.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.searchLookUpEdit1View)).BeginInit();
            this.SuspendLayout();
            // 
            // lblId
            // 
            this.lblId.AutoSize = true;
            this.lblId.Font = new System.Drawing.Font("Tahoma", 14F);
            this.lblId.Location = new System.Drawing.Point(150, 145);
            this.lblId.Name = "lblId";
            this.lblId.Size = new System.Drawing.Size(136, 34);
            this.lblId.TabIndex = 19;
            this.lblId.Text = "BH-00001";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Tahoma", 14F);
            this.label7.Location = new System.Drawing.Point(23, 145);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(139, 34);
            this.label7.TabIndex = 18;
            this.label7.Text = "Mã phiếu:";
            // 
            // lblTime
            // 
            this.lblTime.AutoSize = true;
            this.lblTime.Font = new System.Drawing.Font("Tahoma", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTime.Location = new System.Drawing.Point(186, 96);
            this.lblTime.Name = "lblTime";
            this.lblTime.Size = new System.Drawing.Size(96, 39);
            this.lblTime.TabIndex = 17;
            this.lblTime.Text = "15:45";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Tahoma", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(22, 96);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(163, 39);
            this.label3.TabIndex = 16;
            this.label3.Text = "Ngày bán:";
            // 
            // lblChair
            // 
            this.lblChair.AutoSize = true;
            this.lblChair.Font = new System.Drawing.Font("Tahoma", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblChair.Location = new System.Drawing.Point(12, 9);
            this.lblChair.Name = "lblChair";
            this.lblChair.Size = new System.Drawing.Size(533, 87);
            this.lblChair.TabIndex = 15;
            this.lblChair.Text = "Phiếu bán hàng";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Tahoma", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(26, 205);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(117, 27);
            this.label4.TabIndex = 22;
            this.label4.Text = "NV tư vấn:";
            // 
            // materialPopup
            // 
            this.materialPopup.EditValue = "";
            this.materialPopup.Location = new System.Drawing.Point(147, 281);
            this.materialPopup.Name = "materialPopup";
            this.materialPopup.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.materialPopup.Properties.Appearance.Options.UseFont = true;
            this.materialPopup.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.materialPopup.Properties.PopupControl = this.materialPopUpControl;
            this.materialPopup.Properties.ValidateOnEnterKey = true;
            this.materialPopup.Size = new System.Drawing.Size(554, 34);
            this.materialPopup.TabIndex = 3;
            this.materialPopup.QueryResultValue += new DevExpress.XtraEditors.Controls.QueryResultValueEventHandler(this.materialPopup_QueryResultValue);
            this.materialPopup.QueryPopUp += new System.ComponentModel.CancelEventHandler(this.materialPopup_QueryPopUp);
            this.materialPopup.EditValueChanged += new System.EventHandler(this.materialPopup_EditValueChanged);
            // 
            // materialPopUpControl
            // 
            this.materialPopUpControl.Controls.Add(this.gvMaterialMainPopup);
            this.materialPopUpControl.Location = new System.Drawing.Point(147, 650);
            this.materialPopUpControl.Name = "materialPopUpControl";
            this.materialPopUpControl.Size = new System.Drawing.Size(554, 336);
            this.materialPopUpControl.TabIndex = 26;
            // 
            // gvMaterialMainPopup
            // 
            this.gvMaterialMainPopup.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gvMaterialMainPopup.Location = new System.Drawing.Point(0, 0);
            this.gvMaterialMainPopup.MainView = this.gvMaterialPopup;
            this.gvMaterialMainPopup.MinimumSize = new System.Drawing.Size(400, 349);
            this.gvMaterialMainPopup.Name = "gvMaterialMainPopup";
            this.gvMaterialMainPopup.Size = new System.Drawing.Size(554, 349);
            this.gvMaterialMainPopup.TabIndex = 1;
            this.gvMaterialMainPopup.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gvMaterialPopup});
            // 
            // gvMaterialPopup
            // 
            this.gvMaterialPopup.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colMaterialId,
            this.gridColumn1,
            this.colPrice2});
            this.gvMaterialPopup.GridControl = this.gvMaterialMainPopup;
            this.gvMaterialPopup.Name = "gvMaterialPopup";
            this.gvMaterialPopup.OptionsFind.AlwaysVisible = true;
            this.gvMaterialPopup.OptionsFind.FindDelay = 200;
            this.gvMaterialPopup.OptionsFind.FindNullPrompt = "";
            this.gvMaterialPopup.OptionsSelection.MultiSelect = true;
            this.gvMaterialPopup.OptionsSelection.MultiSelectMode = DevExpress.XtraGrid.Views.Grid.GridMultiSelectMode.CheckBoxRowSelect;
            this.gvMaterialPopup.OptionsView.ShowGroupPanel = false;
            this.gvMaterialPopup.OptionsView.ShowIndicator = false;
            this.gvMaterialPopup.KeyDown += new System.Windows.Forms.KeyEventHandler(this.gvMaterialPopup_KeyDown);
            // 
            // colMaterialId
            // 
            this.colMaterialId.Caption = "MaterialId";
            this.colMaterialId.FieldName = "MaterialId";
            this.colMaterialId.Name = "colMaterialId";
            this.colMaterialId.OptionsColumn.AllowEdit = false;
            // 
            // gridColumn1
            // 
            this.gridColumn1.Caption = "Sản phẩm";
            this.gridColumn1.FieldName = "Name";
            this.gridColumn1.Name = "gridColumn1";
            this.gridColumn1.OptionsColumn.AllowEdit = false;
            this.gridColumn1.Visible = true;
            this.gridColumn1.VisibleIndex = 1;
            // 
            // colPrice2
            // 
            this.colPrice2.Caption = "Giá bán";
            this.colPrice2.FieldName = "Price";
            this.colPrice2.Name = "colPrice2";
            this.colPrice2.OptionsColumn.AllowEdit = false;
            this.colPrice2.Visible = true;
            this.colPrice2.VisibleIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Tahoma", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(26, 284);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(117, 27);
            this.label1.TabIndex = 27;
            this.label1.Text = "Sản phẩm:";
            // 
            // gvMaterialMain
            // 
            this.gvMaterialMain.Location = new System.Drawing.Point(147, 322);
            this.gvMaterialMain.MainView = this.gvMaterial;
            this.gvMaterialMain.MinimumSize = new System.Drawing.Size(400, 180);
            this.gvMaterialMain.Name = "gvMaterialMain";
            this.gvMaterialMain.Size = new System.Drawing.Size(554, 205);
            this.gvMaterialMain.TabIndex = 4;
            this.gvMaterialMain.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gvMaterial});
            this.gvMaterialMain.ProcessGridKey += new System.Windows.Forms.KeyEventHandler(this.gvMaterialMain_ProcessGridKey);
            // 
            // gvMaterial
            // 
            this.gvMaterial.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.gridColumn3,
            this.colName,
            this.colDiscount,
            this.colSellTranCom,
            this.colPrice,
            this.colQuantity});
            this.gvMaterial.GridControl = this.gvMaterialMain;
            this.gvMaterial.Name = "gvMaterial";
            this.gvMaterial.OptionsView.ShowFooter = true;
            this.gvMaterial.OptionsView.ShowGroupPanel = false;
            this.gvMaterial.OptionsView.ShowIndicator = false;
            this.gvMaterial.CellValueChanged += new DevExpress.XtraGrid.Views.Base.CellValueChangedEventHandler(this.gvMaterial_CellValueChanged);
            // 
            // gridColumn3
            // 
            this.gridColumn3.Caption = "MaterialId";
            this.gridColumn3.FieldName = "MaterialId";
            this.gridColumn3.Name = "gridColumn3";
            this.gridColumn3.OptionsColumn.AllowEdit = false;
            this.gridColumn3.OptionsColumn.AllowFocus = false;
            // 
            // colName
            // 
            this.colName.Caption = "Sản phẩm";
            this.colName.FieldName = "Name";
            this.colName.Name = "colName";
            this.colName.OptionsColumn.AllowEdit = false;
            this.colName.OptionsColumn.AllowFocus = false;
            this.colName.Visible = true;
            this.colName.VisibleIndex = 0;
            this.colName.Width = 200;
            // 
            // colDiscount
            // 
            this.colDiscount.Caption = "CK";
            this.colDiscount.DisplayFormat.FormatString = "{0}%";
            this.colDiscount.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Custom;
            this.colDiscount.FieldName = "Discount";
            this.colDiscount.Name = "colDiscount";
            this.colDiscount.OptionsColumn.AllowEdit = false;
            this.colDiscount.OptionsColumn.AllowFocus = false;
            this.colDiscount.Visible = true;
            this.colDiscount.VisibleIndex = 1;
            this.colDiscount.Width = 77;
            // 
            // colSellTranCom
            // 
            this.colSellTranCom.Caption = "Tiền CK";
            this.colSellTranCom.DisplayFormat.FormatString = "n0";
            this.colSellTranCom.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.colSellTranCom.FieldName = "SellComMoney";
            this.colSellTranCom.Name = "colSellTranCom";
            this.colSellTranCom.OptionsColumn.AllowEdit = false;
            this.colSellTranCom.OptionsColumn.AllowFocus = false;
            this.colSellTranCom.Visible = true;
            this.colSellTranCom.VisibleIndex = 2;
            this.colSellTranCom.Width = 97;
            // 
            // colPrice
            // 
            this.colPrice.Caption = "Giá";
            this.colPrice.DisplayFormat.FormatString = "{0:n0}";
            this.colPrice.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.colPrice.FieldName = "Price";
            this.colPrice.Name = "colPrice";
            this.colPrice.OptionsColumn.AllowEdit = false;
            this.colPrice.OptionsColumn.AllowFocus = false;
            this.colPrice.Visible = true;
            this.colPrice.VisibleIndex = 3;
            this.colPrice.Width = 95;
            // 
            // colQuantity
            // 
            this.colQuantity.Caption = "Số lượng";
            this.colQuantity.DisplayFormat.FormatString = "n0";
            this.colQuantity.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.colQuantity.FieldName = "Quantity";
            this.colQuantity.Name = "colQuantity";
            this.colQuantity.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "Quantity", "{0:n0}")});
            this.colQuantity.Visible = true;
            this.colQuantity.VisibleIndex = 4;
            this.colQuantity.Width = 83;
            // 
            // cbEmployee
            // 
            this.cbEmployee.EditValue = "";
            this.cbEmployee.Location = new System.Drawing.Point(147, 202);
            this.cbEmployee.Name = "cbEmployee";
            this.cbEmployee.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbEmployee.Properties.Appearance.Options.UseFont = true;
            this.cbEmployee.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cbEmployee.Properties.DisplayMember = "Name";
            this.cbEmployee.Properties.NullText = "";
            this.cbEmployee.Properties.PopupFormSize = new System.Drawing.Size(566, 350);
            this.cbEmployee.Properties.PopupSizeable = false;
            this.cbEmployee.Properties.ValueMember = "EmployeeId";
            this.cbEmployee.Properties.View = this.gridView1;
            this.cbEmployee.Size = new System.Drawing.Size(554, 34);
            this.cbEmployee.TabIndex = 1;
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.gridColumn2,
            this.gridColumn4});
            this.gridView1.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsFind.AlwaysVisible = true;
            this.gridView1.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.gridView1.OptionsView.ShowGroupPanel = false;
            // 
            // gridColumn2
            // 
            this.gridColumn2.Caption = "ServiceId";
            this.gridColumn2.FieldName = "EmployeeId";
            this.gridColumn2.Name = "gridColumn2";
            // 
            // gridColumn4
            // 
            this.gridColumn4.Caption = "Nhân viên";
            this.gridColumn4.FieldName = "Name";
            this.gridColumn4.Name = "gridColumn4";
            this.gridColumn4.Visible = true;
            this.gridColumn4.VisibleIndex = 0;
            this.gridColumn4.Width = 200;
            // 
            // btnMoney
            // 
            this.btnMoney.Image = ((System.Drawing.Image)(resources.GetObject("btnMoney.Image")));
            this.btnMoney.Location = new System.Drawing.Point(372, 668);
            this.btnMoney.Name = "btnMoney";
            this.btnMoney.Size = new System.Drawing.Size(201, 39);
            this.btnMoney.TabIndex = 5;
            this.btnMoney.Text = "Tính tiền && in hóa đơn";
            this.btnMoney.Click += new System.EventHandler(this.btnMoney_Click);
            // 
            // lblAmount
            // 
            this.lblAmount.AutoSize = true;
            this.lblAmount.Font = new System.Drawing.Font("Tahoma", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAmount.Location = new System.Drawing.Point(21, 550);
            this.lblAmount.Name = "lblAmount";
            this.lblAmount.Size = new System.Drawing.Size(301, 58);
            this.lblAmount.TabIndex = 32;
            this.lblAmount.Text = "Tổng: 0 VNĐ";
            // 
            // btnClose
            // 
            this.btnClose.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnClose.Image = ((System.Drawing.Image)(resources.GetObject("btnClose.Image")));
            this.btnClose.Location = new System.Drawing.Point(579, 668);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(122, 39);
            this.btnClose.TabIndex = 6;
            this.btnClose.Text = "Đóng";
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Tahoma", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(62, 244);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(79, 27);
            this.label2.TabIndex = 34;
            this.label2.Text = "Khách:";
            // 
            // cbCustomer
            // 
            this.cbCustomer.EditValue = "";
            this.cbCustomer.Location = new System.Drawing.Point(147, 241);
            this.cbCustomer.Name = "cbCustomer";
            this.cbCustomer.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbCustomer.Properties.Appearance.Options.UseFont = true;
            this.cbCustomer.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cbCustomer.Properties.DisplayMember = "Name";
            this.cbCustomer.Properties.NullText = "";
            this.cbCustomer.Properties.PopupFormSize = new System.Drawing.Size(517, 400);
            this.cbCustomer.Properties.PopupSizeable = false;
            this.cbCustomer.Properties.ValueMember = "CustomerId";
            this.cbCustomer.Properties.View = this.searchLookUpEdit1View;
            this.cbCustomer.Size = new System.Drawing.Size(554, 34);
            this.cbCustomer.TabIndex = 2;
            // 
            // searchLookUpEdit1View
            // 
            this.searchLookUpEdit1View.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.gridColumn6,
            this.gridColumn7,
            this.gridColumn8});
            this.searchLookUpEdit1View.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.searchLookUpEdit1View.Name = "searchLookUpEdit1View";
            this.searchLookUpEdit1View.OptionsFind.AlwaysVisible = true;
            this.searchLookUpEdit1View.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.searchLookUpEdit1View.OptionsView.ShowGroupPanel = false;
            // 
            // gridColumn6
            // 
            this.gridColumn6.Caption = "customerId";
            this.gridColumn6.FieldName = "CustomerId";
            this.gridColumn6.Name = "gridColumn6";
            // 
            // gridColumn7
            // 
            this.gridColumn7.Caption = "Tên";
            this.gridColumn7.FieldName = "Name";
            this.gridColumn7.Name = "gridColumn7";
            this.gridColumn7.Visible = true;
            this.gridColumn7.VisibleIndex = 0;
            this.gridColumn7.Width = 200;
            // 
            // gridColumn8
            // 
            this.gridColumn8.Caption = "SĐT";
            this.gridColumn8.FieldName = "Tel";
            this.gridColumn8.Name = "gridColumn8";
            this.gridColumn8.Visible = true;
            this.gridColumn8.VisibleIndex = 1;
            this.gridColumn8.Width = 181;
            // 
            // lbStatus
            // 
            this.lbStatus.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lbStatus.Appearance.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbStatus.Appearance.ForeColor = System.Drawing.Color.Red;
            this.lbStatus.Appearance.Image = global::DuHair.Properties.Resources.busy;
            this.lbStatus.ImageAlignToText = DevExpress.XtraEditors.ImageAlignToText.LeftCenter;
            this.lbStatus.Location = new System.Drawing.Point(32, 623);
            this.lbStatus.Name = "lbStatus";
            this.lbStatus.Size = new System.Drawing.Size(221, 22);
            this.lbStatus.TabIndex = 37;
            this.lbStatus.Text = "(*) Không được bỏ trống";
            // 
            // labelControl2
            // 
            this.labelControl2.Appearance.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl2.Appearance.ForeColor = System.Drawing.Color.Red;
            this.labelControl2.Location = new System.Drawing.Point(706, 286);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(11, 24);
            this.labelControl2.TabIndex = 38;
            this.labelControl2.Text = "*";
            // 
            // lbEmployeeName
            // 
            this.lbEmployeeName.AutoSize = true;
            this.lbEmployeeName.Font = new System.Drawing.Font("Tahoma", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbEmployeeName.Location = new System.Drawing.Point(432, 145);
            this.lbEmployeeName.Name = "lbEmployeeName";
            this.lbEmployeeName.Size = new System.Drawing.Size(180, 34);
            this.lbEmployeeName.TabIndex = 42;
            this.lbEmployeeName.Text = "Hà Minh Khải";
            this.lbEmployeeName.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Tahoma", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(295, 145);
            this.label5.Name = "label5";
            this.label5.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label5.Size = new System.Drawing.Size(144, 34);
            this.label5.TabIndex = 41;
            this.label5.Text = "Thu ngân:";
            this.label5.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // SellTranForm
            // 
            this.AcceptButton = this.btnMoney;
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnClose;
            this.ClientSize = new System.Drawing.Size(724, 723);
            this.Controls.Add(this.lbEmployeeName);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.labelControl2);
            this.Controls.Add(this.lbStatus);
            this.Controls.Add(this.cbCustomer);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnMoney);
            this.Controls.Add(this.lblAmount);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.cbEmployee);
            this.Controls.Add(this.gvMaterialMain);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.materialPopUpControl);
            this.Controls.Add(this.materialPopup);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.lblId);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.lblTime);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lblChair);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "SellTranForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Load += new System.EventHandler(this.SellTranForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.materialPopup.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.materialPopUpControl)).EndInit();
            this.materialPopUpControl.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gvMaterialMainPopup)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvMaterialPopup)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvMaterialMain)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvMaterial)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbEmployee.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbCustomer.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.searchLookUpEdit1View)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblId;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label lblTime;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblChair;
        private System.Windows.Forms.Label label4;
        private DevExpress.XtraEditors.PopupContainerEdit materialPopup;
        private DevExpress.XtraEditors.PopupContainerControl materialPopUpControl;
        private DevExpress.XtraGrid.GridControl gvMaterialMainPopup;
        private DevExpress.XtraGrid.Views.Grid.GridView gvMaterialPopup;
        private DevExpress.XtraGrid.Columns.GridColumn colMaterialId;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn1;
        private DevExpress.XtraGrid.Columns.GridColumn colPrice2;
        private System.Windows.Forms.Label label1;
        private DevExpress.XtraGrid.GridControl gvMaterialMain;
        private DevExpress.XtraGrid.Views.Grid.GridView gvMaterial;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn3;
        private DevExpress.XtraGrid.Columns.GridColumn colName;
        private DevExpress.XtraGrid.Columns.GridColumn colPrice;
        private DevExpress.XtraGrid.Columns.GridColumn colQuantity;
        private DevExpress.XtraGrid.Columns.GridColumn colDiscount;
        private DevExpress.XtraEditors.SearchLookUpEdit cbEmployee;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn2;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn4;
        private DevExpress.XtraEditors.SimpleButton btnMoney;
        private System.Windows.Forms.Label lblAmount;
        private DevExpress.XtraEditors.SimpleButton btnClose;
        private System.Windows.Forms.Label label2;
        private DevExpress.XtraEditors.SearchLookUpEdit cbCustomer;
        private DevExpress.XtraGrid.Views.Grid.GridView searchLookUpEdit1View;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn6;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn7;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn8;
        private DevExpress.XtraEditors.LabelControl lbStatus;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraGrid.Columns.GridColumn colSellTranCom;
        private System.Windows.Forms.Label lbEmployeeName;
        private System.Windows.Forms.Label label5;
    }
}