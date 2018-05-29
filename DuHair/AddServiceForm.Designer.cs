namespace DuHair
{
    partial class AddServiceForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddServiceForm));
            this.label9 = new System.Windows.Forms.Label();
            this.cbService = new DevExpress.XtraEditors.SearchLookUpEdit();
            this.searchLookUpEdit1View = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gridColumn6 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn7 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn8 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.employeePopUp = new DevExpress.XtraEditors.PopupContainerEdit();
            this.employeePopUpControl = new DevExpress.XtraEditors.PopupContainerControl();
            this.gvEmployeeMain = new DevExpress.XtraGrid.GridControl();
            this.gvEmployee = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colEmployeeId = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTel = new DevExpress.XtraGrid.Columns.GridColumn();
            this.label4 = new System.Windows.Forms.Label();
            this.gvServiceMain = new DevExpress.XtraGrid.GridControl();
            this.gvService = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gridColumn3 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colPrice = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colQuantity = new DevExpress.XtraGrid.Columns.GridColumn();
            this.commissionGroup = new DevExpress.XtraEditors.GroupControl();
            this.btnChoose = new DevExpress.XtraEditors.SimpleButton();
            this.btnClose = new DevExpress.XtraEditors.SimpleButton();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.lbStatus = new DevExpress.XtraEditors.LabelControl();
            this.label1 = new System.Windows.Forms.Label();
            this.cbEmployee = new DevExpress.XtraEditors.SearchLookUpEdit();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gridColumn2 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn4 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.label2 = new System.Windows.Forms.Label();
            this.txtPrice = new DevExpress.XtraEditors.TextEdit();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.rdDiscountType = new DevExpress.XtraEditors.RadioGroup();
            this.label3 = new System.Windows.Forms.Label();
            this.txtQuantity = new DevExpress.XtraEditors.TextEdit();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            ((System.ComponentModel.ISupportInitialize)(this.cbService.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.searchLookUpEdit1View)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.employeePopUp.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.employeePopUpControl)).BeginInit();
            this.employeePopUpControl.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gvEmployeeMain)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvEmployee)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvServiceMain)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvService)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.commissionGroup)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbEmployee.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtPrice.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rdDiscountType.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtQuantity.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.Transparent;
            this.label9.Font = new System.Drawing.Font("Tahoma", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(32, 11);
            this.label9.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(61, 18);
            this.label9.TabIndex = 17;
            this.label9.Text = "Dịch vụ:";
            // 
            // cbService
            // 
            this.cbService.EditValue = "";
            this.cbService.Location = new System.Drawing.Point(97, 9);
            this.cbService.Margin = new System.Windows.Forms.Padding(2);
            this.cbService.Name = "cbService";
            this.cbService.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbService.Properties.Appearance.Options.UseFont = true;
            this.cbService.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cbService.Properties.DisplayMember = "Name";
            this.cbService.Properties.NullText = "";
            this.cbService.Properties.PopupFormSize = new System.Drawing.Size(566, 350);
            this.cbService.Properties.PopupSizeable = false;
            this.cbService.Properties.ValueMember = "ServiceId";
            this.cbService.Properties.View = this.searchLookUpEdit1View;
            this.cbService.Size = new System.Drawing.Size(369, 24);
            this.cbService.TabIndex = 1;
            this.cbService.EditValueChanged += new System.EventHandler(this.cbService_EditValueChanged);
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
            this.searchLookUpEdit1View.OptionsFind.FindDelay = 200;
            this.searchLookUpEdit1View.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.searchLookUpEdit1View.OptionsView.ShowGroupPanel = false;
            // 
            // gridColumn6
            // 
            this.gridColumn6.Caption = "ServiceId";
            this.gridColumn6.FieldName = "ServiceId";
            this.gridColumn6.Name = "gridColumn6";
            // 
            // gridColumn7
            // 
            this.gridColumn7.Caption = "Dịch vụ";
            this.gridColumn7.FieldName = "Name";
            this.gridColumn7.Name = "gridColumn7";
            this.gridColumn7.Visible = true;
            this.gridColumn7.VisibleIndex = 0;
            this.gridColumn7.Width = 200;
            // 
            // gridColumn8
            // 
            this.gridColumn8.Caption = "Giá";
            this.gridColumn8.DisplayFormat.FormatString = "n0";
            this.gridColumn8.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.gridColumn8.FieldName = "Price";
            this.gridColumn8.Name = "gridColumn8";
            this.gridColumn8.Visible = true;
            this.gridColumn8.VisibleIndex = 1;
            this.gridColumn8.Width = 181;
            // 
            // employeePopUp
            // 
            this.employeePopUp.EditValue = "";
            this.employeePopUp.Location = new System.Drawing.Point(97, 94);
            this.employeePopUp.Margin = new System.Windows.Forms.Padding(2);
            this.employeePopUp.Name = "employeePopUp";
            this.employeePopUp.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.employeePopUp.Properties.Appearance.Options.UseFont = true;
            this.employeePopUp.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.employeePopUp.Properties.CloseUpKey = new DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.None);
            this.employeePopUp.Properties.PopupControl = this.employeePopUpControl;
            this.employeePopUp.Properties.ValidateOnEnterKey = true;
            this.employeePopUp.Size = new System.Drawing.Size(369, 24);
            this.employeePopUp.TabIndex = 4;
            this.employeePopUp.QueryResultValue += new DevExpress.XtraEditors.Controls.QueryResultValueEventHandler(this.employeePopUp_QueryResultValue);
            this.employeePopUp.QueryPopUp += new System.ComponentModel.CancelEventHandler(this.employeePopUp_QueryPopUp);
            this.employeePopUp.EditValueChanged += new System.EventHandler(this.employeePopUp_EditValueChanged);
            // 
            // employeePopUpControl
            // 
            this.employeePopUpControl.Controls.Add(this.gvEmployeeMain);
            this.employeePopUpControl.Location = new System.Drawing.Point(8, 450);
            this.employeePopUpControl.Margin = new System.Windows.Forms.Padding(2);
            this.employeePopUpControl.Name = "employeePopUpControl";
            this.employeePopUpControl.Size = new System.Drawing.Size(377, 239);
            this.employeePopUpControl.TabIndex = 25;
            // 
            // gvEmployeeMain
            // 
            this.gvEmployeeMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gvEmployeeMain.EmbeddedNavigator.Margin = new System.Windows.Forms.Padding(2);
            this.gvEmployeeMain.Location = new System.Drawing.Point(0, 0);
            this.gvEmployeeMain.MainView = this.gvEmployee;
            this.gvEmployeeMain.Margin = new System.Windows.Forms.Padding(2);
            this.gvEmployeeMain.MinimumSize = new System.Drawing.Size(267, 239);
            this.gvEmployeeMain.Name = "gvEmployeeMain";
            this.gvEmployeeMain.Size = new System.Drawing.Size(377, 239);
            this.gvEmployeeMain.TabIndex = 1;
            this.gvEmployeeMain.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gvEmployee});
            // 
            // gvEmployee
            // 
            this.gvEmployee.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colEmployeeId,
            this.gridColumn1,
            this.colTel});
            this.gvEmployee.GridControl = this.gvEmployeeMain;
            this.gvEmployee.Name = "gvEmployee";
            this.gvEmployee.OptionsFind.AlwaysVisible = true;
            this.gvEmployee.OptionsFind.FindDelay = 200;
            this.gvEmployee.OptionsFind.FindNullPrompt = "";
            this.gvEmployee.OptionsSelection.MultiSelect = true;
            this.gvEmployee.OptionsSelection.MultiSelectMode = DevExpress.XtraGrid.Views.Grid.GridMultiSelectMode.CheckBoxRowSelect;
            this.gvEmployee.OptionsView.ShowGroupPanel = false;
            this.gvEmployee.OptionsView.ShowIndicator = false;
            this.gvEmployee.KeyDown += new System.Windows.Forms.KeyEventHandler(this.gvEmployee_KeyDown);
            // 
            // colEmployeeId
            // 
            this.colEmployeeId.FieldName = "EmployeeId";
            this.colEmployeeId.Name = "colEmployeeId";
            this.colEmployeeId.OptionsColumn.AllowEdit = false;
            // 
            // gridColumn1
            // 
            this.gridColumn1.Caption = "Tên";
            this.gridColumn1.FieldName = "Name";
            this.gridColumn1.Name = "gridColumn1";
            this.gridColumn1.OptionsColumn.AllowEdit = false;
            this.gridColumn1.Visible = true;
            this.gridColumn1.VisibleIndex = 1;
            // 
            // colTel
            // 
            this.colTel.Caption = "SĐT";
            this.colTel.FieldName = "Tel";
            this.colTel.Name = "colTel";
            this.colTel.OptionsColumn.AllowEdit = false;
            this.colTel.Visible = true;
            this.colTel.VisibleIndex = 2;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Tahoma", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(15, 96);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(78, 18);
            this.label4.TabIndex = 20;
            this.label4.Text = "Nhân viên:";
            // 
            // gvServiceMain
            // 
            this.gvServiceMain.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gvServiceMain.EmbeddedNavigator.Margin = new System.Windows.Forms.Padding(2);
            this.gvServiceMain.Location = new System.Drawing.Point(97, 247);
            this.gvServiceMain.MainView = this.gvService;
            this.gvServiceMain.Margin = new System.Windows.Forms.Padding(2);
            this.gvServiceMain.MinimumSize = new System.Drawing.Size(267, 123);
            this.gvServiceMain.Name = "gvServiceMain";
            this.gvServiceMain.Size = new System.Drawing.Size(369, 177);
            this.gvServiceMain.TabIndex = 11;
            this.gvServiceMain.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gvService});
            this.gvServiceMain.ProcessGridKey += new System.Windows.Forms.KeyEventHandler(this.gvServiceMain_ProcessGridKey);
            // 
            // gvService
            // 
            this.gvService.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.gridColumn3,
            this.colName,
            this.colPrice,
            this.colQuantity});
            this.gvService.GridControl = this.gvServiceMain;
            this.gvService.Name = "gvService";
            this.gvService.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.gvService.OptionsView.ShowGroupPanel = false;
            this.gvService.OptionsView.ShowIndicator = false;
            this.gvService.KeyDown += new System.Windows.Forms.KeyEventHandler(this.gvService_KeyDown);
            // 
            // gridColumn3
            // 
            this.gridColumn3.FieldName = "ServiceId";
            this.gridColumn3.Name = "gridColumn3";
            this.gridColumn3.OptionsColumn.AllowEdit = false;
            // 
            // colName
            // 
            this.colName.Caption = "Dịch vụ";
            this.colName.FieldName = "Name";
            this.colName.Name = "colName";
            this.colName.OptionsColumn.AllowEdit = false;
            this.colName.Visible = true;
            this.colName.VisibleIndex = 0;
            this.colName.Width = 159;
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
            this.colPrice.Width = 107;
            // 
            // colQuantity
            // 
            this.colQuantity.Caption = "Số lượng";
            this.colQuantity.FieldName = "Quantity";
            this.colQuantity.Name = "colQuantity";
            this.colQuantity.OptionsColumn.AllowEdit = false;
            this.colQuantity.Visible = true;
            this.colQuantity.VisibleIndex = 2;
            this.colQuantity.Width = 101;
            // 
            // commissionGroup
            // 
            this.commissionGroup.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.commissionGroup.Location = new System.Drawing.Point(97, 122);
            this.commissionGroup.Margin = new System.Windows.Forms.Padding(2);
            this.commissionGroup.Name = "commissionGroup";
            this.commissionGroup.Size = new System.Drawing.Size(369, 93);
            this.commissionGroup.TabIndex = 5;
            this.commissionGroup.Text = "Chiết khấu";
            // 
            // btnChoose
            // 
            this.btnChoose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnChoose.Image = ((System.Drawing.Image)(resources.GetObject("btnChoose.Image")));
            this.btnChoose.Location = new System.Drawing.Point(344, 433);
            this.btnChoose.Margin = new System.Windows.Forms.Padding(2);
            this.btnChoose.Name = "btnChoose";
            this.btnChoose.Size = new System.Drawing.Size(59, 25);
            this.btnChoose.TabIndex = 12;
            this.btnChoose.Text = "Thêm";
            this.btnChoose.Click += new System.EventHandler(this.btnChoose_Click);
            // 
            // btnClose
            // 
            this.btnClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnClose.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnClose.Image = ((System.Drawing.Image)(resources.GetObject("btnClose.Image")));
            this.btnClose.Location = new System.Drawing.Point(407, 433);
            this.btnClose.Margin = new System.Windows.Forms.Padding(2);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(59, 25);
            this.btnClose.TabIndex = 13;
            this.btnClose.Text = "Đóng";
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl1.Appearance.ForeColor = System.Drawing.Color.Red;
            this.labelControl1.Location = new System.Drawing.Point(473, 12);
            this.labelControl1.Margin = new System.Windows.Forms.Padding(2);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(8, 16);
            this.labelControl1.TabIndex = 34;
            this.labelControl1.Text = "*";
            // 
            // labelControl2
            // 
            this.labelControl2.Appearance.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl2.Appearance.ForeColor = System.Drawing.Color.Red;
            this.labelControl2.Location = new System.Drawing.Point(473, 70);
            this.labelControl2.Margin = new System.Windows.Forms.Padding(2);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(8, 16);
            this.labelControl2.TabIndex = 35;
            this.labelControl2.Text = "*";
            // 
            // lbStatus
            // 
            this.lbStatus.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lbStatus.Appearance.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbStatus.Appearance.ForeColor = System.Drawing.Color.Red;
            this.lbStatus.Appearance.Image = global::DuHair.Properties.Resources.busy;
            this.lbStatus.ImageAlignToText = DevExpress.XtraEditors.ImageAlignToText.LeftCenter;
            this.lbStatus.Location = new System.Drawing.Point(8, 440);
            this.lbStatus.Margin = new System.Windows.Forms.Padding(2);
            this.lbStatus.Name = "lbStatus";
            this.lbStatus.Size = new System.Drawing.Size(161, 20);
            this.lbStatus.TabIndex = 36;
            this.lbStatus.Text = "(*) Không được bỏ trống";
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Tahoma", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(8, 222);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(85, 18);
            this.label1.TabIndex = 38;
            this.label1.Text = "NV Tư vấn:";
            // 
            // cbEmployee
            // 
            this.cbEmployee.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cbEmployee.EditValue = "";
            this.cbEmployee.Location = new System.Drawing.Point(97, 219);
            this.cbEmployee.Margin = new System.Windows.Forms.Padding(2);
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
            this.cbEmployee.Size = new System.Drawing.Size(369, 24);
            this.cbEmployee.TabIndex = 10;
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
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Tahoma", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(59, 40);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(33, 18);
            this.label2.TabIndex = 40;
            this.label2.Text = "Giá:";
            // 
            // txtPrice
            // 
            this.txtPrice.EditValue = "";
            this.txtPrice.Location = new System.Drawing.Point(97, 38);
            this.txtPrice.Margin = new System.Windows.Forms.Padding(2);
            this.txtPrice.Name = "txtPrice";
            this.txtPrice.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPrice.Properties.Appearance.Options.UseFont = true;
            this.txtPrice.Properties.Mask.EditMask = "n0";
            this.txtPrice.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
            this.txtPrice.Properties.Mask.UseMaskAsDisplayFormat = true;
            this.txtPrice.Size = new System.Drawing.Size(369, 24);
            this.txtPrice.TabIndex = 2;
            // 
            // labelControl3
            // 
            this.labelControl3.Appearance.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl3.Appearance.ForeColor = System.Drawing.Color.Red;
            this.labelControl3.Location = new System.Drawing.Point(473, 41);
            this.labelControl3.Margin = new System.Windows.Forms.Padding(2);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(8, 16);
            this.labelControl3.TabIndex = 41;
            this.labelControl3.Text = "*";
            // 
            // rdDiscountType
            // 
            this.rdDiscountType.EditValue = ((short)(0));
            this.rdDiscountType.Location = new System.Drawing.Point(31, 122);
            this.rdDiscountType.Name = "rdDiscountType";
            this.rdDiscountType.Properties.Appearance.BackColor = System.Drawing.Color.Transparent;
            this.rdDiscountType.Properties.Appearance.Options.UseBackColor = true;
            this.rdDiscountType.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.rdDiscountType.Properties.Items.AddRange(new DevExpress.XtraEditors.Controls.RadioGroupItem[] {
            new DevExpress.XtraEditors.Controls.RadioGroupItem(((short)(0)), "CK tiền"),
            new DevExpress.XtraEditors.Controls.RadioGroupItem(((short)(1)), "CK %")});
            this.rdDiscountType.Size = new System.Drawing.Size(61, 55);
            this.rdDiscountType.TabIndex = 14;
            this.rdDiscountType.SelectedIndexChanged += new System.EventHandler(this.rdDiscountType_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Tahoma", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(24, 68);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(69, 18);
            this.label3.TabIndex = 46;
            this.label3.Text = "Số lượng:";
            // 
            // txtQuantity
            // 
            this.txtQuantity.EditValue = "";
            this.txtQuantity.Location = new System.Drawing.Point(97, 66);
            this.txtQuantity.Margin = new System.Windows.Forms.Padding(2);
            this.txtQuantity.Name = "txtQuantity";
            this.txtQuantity.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtQuantity.Properties.Appearance.Options.UseFont = true;
            this.txtQuantity.Properties.Mask.EditMask = "n0";
            this.txtQuantity.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
            this.txtQuantity.Properties.Mask.UseMaskAsDisplayFormat = true;
            this.txtQuantity.Size = new System.Drawing.Size(369, 24);
            this.txtQuantity.TabIndex = 3;
            // 
            // labelControl4
            // 
            this.labelControl4.Appearance.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl4.Appearance.ForeColor = System.Drawing.Color.Red;
            this.labelControl4.Location = new System.Drawing.Point(473, 99);
            this.labelControl4.Margin = new System.Windows.Forms.Padding(2);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(8, 16);
            this.labelControl4.TabIndex = 47;
            this.labelControl4.Text = "*";
            // 
            // AddServiceForm
            // 
            this.AcceptButton = this.btnChoose;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnClose;
            this.ClientSize = new System.Drawing.Size(489, 466);
            this.Controls.Add(this.labelControl4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtQuantity);
            this.Controls.Add(this.rdDiscountType);
            this.Controls.Add(this.labelControl3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cbEmployee);
            this.Controls.Add(this.lbStatus);
            this.Controls.Add(this.labelControl2);
            this.Controls.Add(this.labelControl1);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnChoose);
            this.Controls.Add(this.commissionGroup);
            this.Controls.Add(this.employeePopUpControl);
            this.Controls.Add(this.gvServiceMain);
            this.Controls.Add(this.employeePopUp);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.cbService);
            this.Controls.Add(this.txtPrice);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.KeyPreview = true;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MinimizeBox = false;
            this.Name = "AddServiceForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Load += new System.EventHandler(this.AddServiceForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.cbService.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.searchLookUpEdit1View)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.employeePopUp.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.employeePopUpControl)).EndInit();
            this.employeePopUpControl.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gvEmployeeMain)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvEmployee)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvServiceMain)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvService)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.commissionGroup)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbEmployee.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtPrice.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rdDiscountType.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtQuantity.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label9;
        private DevExpress.XtraEditors.SearchLookUpEdit cbService;
        private DevExpress.XtraGrid.Views.Grid.GridView searchLookUpEdit1View;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn6;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn7;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn8;
        private DevExpress.XtraEditors.PopupContainerEdit employeePopUp;
        private System.Windows.Forms.Label label4;
        private DevExpress.XtraGrid.GridControl gvServiceMain;
        private DevExpress.XtraGrid.Views.Grid.GridView gvService;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn3;
        private DevExpress.XtraGrid.Columns.GridColumn colName;
        private DevExpress.XtraGrid.Columns.GridColumn colPrice;
        private DevExpress.XtraEditors.PopupContainerControl employeePopUpControl;
        private DevExpress.XtraGrid.GridControl gvEmployeeMain;
        private DevExpress.XtraGrid.Views.Grid.GridView gvEmployee;
        private DevExpress.XtraGrid.Columns.GridColumn colEmployeeId;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn1;
        private DevExpress.XtraGrid.Columns.GridColumn colTel;
        private DevExpress.XtraEditors.GroupControl commissionGroup;
        private DevExpress.XtraEditors.SimpleButton btnChoose;
        private DevExpress.XtraEditors.SimpleButton btnClose;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.LabelControl lbStatus;
        private System.Windows.Forms.Label label1;
        private DevExpress.XtraEditors.SearchLookUpEdit cbEmployee;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn2;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn4;
        private System.Windows.Forms.Label label2;
        private DevExpress.XtraEditors.TextEdit txtPrice;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.RadioGroup rdDiscountType;
        private System.Windows.Forms.Label label3;
        private DevExpress.XtraEditors.TextEdit txtQuantity;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private DevExpress.XtraGrid.Columns.GridColumn colQuantity;
    }
}