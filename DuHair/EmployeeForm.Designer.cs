namespace DuHair
{
    partial class EmployeeForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EmployeeForm));
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.employeeModelBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colEmployeeId = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTel = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colRole = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colStatus = new DevExpress.XtraGrid.Columns.GridColumn();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lbStatus = new DevExpress.XtraEditors.LabelControl();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.pwwwdForce = new DevExpress.XtraEditors.LabelControl();
            this.usernameForce = new DevExpress.XtraEditors.LabelControl();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.textEdit2 = new DevExpress.XtraEditors.TextEdit();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.cbRole = new DevExpress.XtraEditors.ComboBoxEdit();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtWage = new DevExpress.XtraEditors.TextEdit();
            this.txtName = new DevExpress.XtraEditors.TextEdit();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtAddress = new DevExpress.XtraEditors.MemoEdit();
            this.txtBirthday = new DevExpress.XtraEditors.DateEdit();
            this.cbStatus = new DevExpress.XtraEditors.ComboBoxEdit();
            this.cbSex = new DevExpress.XtraEditors.ComboBoxEdit();
            this.txtUsername = new DevExpress.XtraEditors.TextEdit();
            this.txtPwwd = new DevExpress.XtraEditors.TextEdit();
            this.btnEdit = new DevExpress.XtraEditors.SimpleButton();
            this.btnNew = new DevExpress.XtraEditors.SimpleButton();
            this.btnSave = new DevExpress.XtraEditors.SimpleButton();
            this.btnCancel = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.employeeModelBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit2.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbRole.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtWage.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtName.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtAddress.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtBirthday.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtBirthday.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbStatus.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbSex.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtUsername.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtPwwd.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // gridControl1
            // 
            this.gridControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gridControl1.DataSource = this.employeeModelBindingSource;
            this.gridControl1.Location = new System.Drawing.Point(12, 12);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.MinimumSize = new System.Drawing.Size(400, 400);
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.Size = new System.Drawing.Size(400, 436);
            this.gridControl1.TabIndex = 0;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // employeeModelBindingSource
            // 
            this.employeeModelBindingSource.DataSource = typeof(DuHair.Employee);
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colEmployeeId,
            this.colName,
            this.colTel,
            this.colRole,
            this.colStatus});
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsSelection.EnableAppearanceFocusedCell = false;
            // 
            // colEmployeeId
            // 
            this.colEmployeeId.FieldName = "EmployeeId";
            this.colEmployeeId.Name = "colEmployeeId";
            this.colEmployeeId.OptionsColumn.AllowEdit = false;
            // 
            // colName
            // 
            this.colName.Caption = "Tên";
            this.colName.FieldName = "Name";
            this.colName.Name = "colName";
            this.colName.OptionsColumn.AllowEdit = false;
            this.colName.Visible = true;
            this.colName.VisibleIndex = 0;
            // 
            // colTel
            // 
            this.colTel.Caption = "SĐT";
            this.colTel.FieldName = "Tel";
            this.colTel.Name = "colTel";
            this.colTel.OptionsColumn.AllowEdit = false;
            this.colTel.Visible = true;
            this.colTel.VisibleIndex = 1;
            // 
            // colRole
            // 
            this.colRole.Caption = "Quyền";
            this.colRole.FieldName = "Role";
            this.colRole.Name = "colRole";
            this.colRole.OptionsColumn.AllowEdit = false;
            this.colRole.Visible = true;
            this.colRole.VisibleIndex = 2;
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
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.lbStatus);
            this.panel1.Controls.Add(this.labelControl4);
            this.panel1.Controls.Add(this.pwwwdForce);
            this.panel1.Controls.Add(this.usernameForce);
            this.panel1.Controls.Add(this.labelControl2);
            this.panel1.Controls.Add(this.textEdit2);
            this.panel1.Controls.Add(this.label9);
            this.panel1.Controls.Add(this.label10);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.cbRole);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.txtWage);
            this.panel1.Controls.Add(this.txtName);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.txtAddress);
            this.panel1.Controls.Add(this.txtBirthday);
            this.panel1.Controls.Add(this.cbStatus);
            this.panel1.Controls.Add(this.cbSex);
            this.panel1.Controls.Add(this.txtUsername);
            this.panel1.Controls.Add(this.txtPwwd);
            this.panel1.Location = new System.Drawing.Point(418, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(550, 435);
            this.panel1.TabIndex = 1;
            // 
            // lbStatus
            // 
            this.lbStatus.Appearance.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbStatus.Appearance.ForeColor = System.Drawing.Color.Red;
            this.lbStatus.Appearance.Image = global::DuHair.Properties.Resources.busy;
            this.lbStatus.ImageAlignToText = DevExpress.XtraEditors.ImageAlignToText.LeftCenter;
            this.lbStatus.Location = new System.Drawing.Point(22, 384);
            this.lbStatus.Name = "lbStatus";
            this.lbStatus.Size = new System.Drawing.Size(221, 22);
            this.lbStatus.TabIndex = 37;
            this.lbStatus.Text = "(*) Không được bỏ trống";
            // 
            // labelControl4
            // 
            this.labelControl4.Appearance.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl4.Appearance.ForeColor = System.Drawing.Color.Red;
            this.labelControl4.Location = new System.Drawing.Point(525, 210);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(11, 24);
            this.labelControl4.TabIndex = 39;
            this.labelControl4.Text = "*";
            // 
            // pwwwdForce
            // 
            this.pwwwdForce.Appearance.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pwwwdForce.Appearance.ForeColor = System.Drawing.Color.Red;
            this.pwwwdForce.Location = new System.Drawing.Point(525, 114);
            this.pwwwdForce.Name = "pwwwdForce";
            this.pwwwdForce.Size = new System.Drawing.Size(11, 24);
            this.pwwwdForce.TabIndex = 38;
            this.pwwwdForce.Text = "*";
            // 
            // usernameForce
            // 
            this.usernameForce.Appearance.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.usernameForce.Appearance.ForeColor = System.Drawing.Color.Red;
            this.usernameForce.Location = new System.Drawing.Point(525, 82);
            this.usernameForce.Name = "usernameForce";
            this.usernameForce.Size = new System.Drawing.Size(11, 24);
            this.usernameForce.TabIndex = 37;
            this.usernameForce.Text = "*";
            // 
            // labelControl2
            // 
            this.labelControl2.Appearance.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl2.Appearance.ForeColor = System.Drawing.Color.Red;
            this.labelControl2.Location = new System.Drawing.Point(525, 18);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(11, 24);
            this.labelControl2.TabIndex = 36;
            this.labelControl2.Text = "*";
            // 
            // textEdit2
            // 
            this.textEdit2.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.employeeModelBindingSource, "Tel", true));
            this.textEdit2.EditValue = "";
            this.textEdit2.Location = new System.Drawing.Point(117, 47);
            this.textEdit2.Name = "textEdit2";
            this.textEdit2.Size = new System.Drawing.Size(402, 26);
            this.textEdit2.TabIndex = 2;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(38, 82);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(69, 19);
            this.label9.TabIndex = 21;
            this.label9.Text = "Tên ĐN:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(62, 50);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(45, 19);
            this.label10.TabIndex = 19;
            this.label10.Text = "SĐT:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(46, 314);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(61, 19);
            this.label8.TabIndex = 18;
            this.label8.Text = "Quyền:";
            // 
            // cbRole
            // 
            this.cbRole.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.employeeModelBindingSource, "Role", true));
            this.cbRole.EditValue = "";
            this.cbRole.Location = new System.Drawing.Point(117, 308);
            this.cbRole.Name = "cbRole";
            this.cbRole.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cbRole.Properties.DropDownRows = 3;
            this.cbRole.Properties.Items.AddRange(new object[] {
            "Nhân viên",
            "Thu ngân",
            "Admin"});
            this.cbRole.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor;
            this.cbRole.Properties.EditValueChanged += new System.EventHandler(this.cbRole_Properties_EditValueChanged);
            this.cbRole.Size = new System.Drawing.Size(402, 26);
            this.cbRole.TabIndex = 9;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(18, 346);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(89, 19);
            this.label7.TabIndex = 16;
            this.label7.Text = "Tình trạng:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(32, 178);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(75, 19);
            this.label6.TabIndex = 12;
            this.label6.Text = "Giới tính:";
            // 
            // txtWage
            // 
            this.txtWage.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.employeeModelBindingSource, "Wage", true));
            this.txtWage.EditValue = "";
            this.txtWage.Location = new System.Drawing.Point(117, 208);
            this.txtWage.Name = "txtWage";
            this.txtWage.Properties.Mask.EditMask = "n0";
            this.txtWage.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
            this.txtWage.Size = new System.Drawing.Size(402, 26);
            this.txtWage.TabIndex = 7;
            // 
            // txtName
            // 
            this.txtName.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.employeeModelBindingSource, "Name", true));
            this.txtName.EditValue = "";
            this.txtName.Location = new System.Drawing.Point(117, 15);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(402, 26);
            this.txtName.TabIndex = 1;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(46, 210);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(60, 19);
            this.label5.TabIndex = 4;
            this.label5.Text = "Lương:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(22, 146);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(85, 19);
            this.label4.TabIndex = 3;
            this.label4.Text = "Ngày sinh:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(44, 243);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(63, 19);
            this.label3.TabIndex = 2;
            this.label3.Text = "Địa chỉ:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(28, 114);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(79, 19);
            this.label2.TabIndex = 1;
            this.label2.Text = "Mật khẩu:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(64, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(42, 19);
            this.label1.TabIndex = 0;
            this.label1.Text = "Tên:";
            // 
            // txtAddress
            // 
            this.txtAddress.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.employeeModelBindingSource, "Address", true));
            this.txtAddress.EditValue = "";
            this.txtAddress.Location = new System.Drawing.Point(117, 240);
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.Size = new System.Drawing.Size(402, 64);
            this.txtAddress.TabIndex = 8;
            // 
            // txtBirthday
            // 
            this.txtBirthday.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.employeeModelBindingSource, "Birthday", true));
            this.txtBirthday.EditValue = "";
            this.txtBirthday.Location = new System.Drawing.Point(117, 143);
            this.txtBirthday.Name = "txtBirthday";
            this.txtBirthday.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.txtBirthday.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.txtBirthday.Properties.DisplayFormat.FormatString = "dd/MM/yyyy";
            this.txtBirthday.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Custom;
            this.txtBirthday.Properties.EditFormat.FormatString = "dd/MM/yyyy";
            this.txtBirthday.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.Custom;
            this.txtBirthday.Properties.Mask.EditMask = "dd/MM/yyyy";
            this.txtBirthday.Size = new System.Drawing.Size(402, 26);
            this.txtBirthday.TabIndex = 5;
            // 
            // cbStatus
            // 
            this.cbStatus.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.employeeModelBindingSource, "Status", true));
            this.cbStatus.EditValue = "Hiển thị";
            this.cbStatus.Location = new System.Drawing.Point(117, 341);
            this.cbStatus.Name = "cbStatus";
            this.cbStatus.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cbStatus.Properties.DropDownRows = 2;
            this.cbStatus.Properties.Items.AddRange(new object[] {
            "Hiển thị",
            "Ẩn"});
            this.cbStatus.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor;
            this.cbStatus.Size = new System.Drawing.Size(402, 26);
            this.cbStatus.TabIndex = 10;
            // 
            // cbSex
            // 
            this.cbSex.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.employeeModelBindingSource, "Sex", true));
            this.cbSex.EditValue = "";
            this.cbSex.Location = new System.Drawing.Point(117, 175);
            this.cbSex.Name = "cbSex";
            this.cbSex.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cbSex.Properties.Items.AddRange(new object[] {
            "Nam",
            "Nữ",
            "Khác"});
            this.cbSex.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor;
            this.cbSex.Size = new System.Drawing.Size(402, 26);
            this.cbSex.TabIndex = 6;
            // 
            // txtUsername
            // 
            this.txtUsername.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.employeeModelBindingSource, "Username", true));
            this.txtUsername.EditValue = "";
            this.txtUsername.Location = new System.Drawing.Point(117, 79);
            this.txtUsername.Name = "txtUsername";
            this.txtUsername.Size = new System.Drawing.Size(402, 26);
            this.txtUsername.TabIndex = 3;
            // 
            // txtPwwd
            // 
            this.txtPwwd.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.employeeModelBindingSource, "Pwwd", true));
            this.txtPwwd.EditValue = "";
            this.txtPwwd.Location = new System.Drawing.Point(117, 111);
            this.txtPwwd.Name = "txtPwwd";
            this.txtPwwd.Properties.PasswordChar = '*';
            this.txtPwwd.Size = new System.Drawing.Size(402, 26);
            this.txtPwwd.TabIndex = 4;
            // 
            // btnEdit
            // 
            this.btnEdit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnEdit.Image = ((System.Drawing.Image)(resources.GetObject("btnEdit.Image")));
            this.btnEdit.Location = new System.Drawing.Point(590, 453);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(122, 39);
            this.btnEdit.TabIndex = 13;
            this.btnEdit.Text = "Chỉnh sửa";
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // btnNew
            // 
            this.btnNew.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnNew.Image = ((System.Drawing.Image)(resources.GetObject("btnNew.Image")));
            this.btnNew.ImageLocation = DevExpress.XtraEditors.ImageLocation.MiddleLeft;
            this.btnNew.Location = new System.Drawing.Point(462, 453);
            this.btnNew.Name = "btnNew";
            this.btnNew.Size = new System.Drawing.Size(122, 39);
            this.btnNew.TabIndex = 12;
            this.btnNew.Text = "Tạo mới";
            this.btnNew.Click += new System.EventHandler(this.btnNew_Click);
            // 
            // btnSave
            // 
            this.btnSave.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSave.Image = ((System.Drawing.Image)(resources.GetObject("btnSave.Image")));
            this.btnSave.Location = new System.Drawing.Point(718, 453);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(122, 39);
            this.btnSave.TabIndex = 14;
            this.btnSave.Text = "Lưu";
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.Image = ((System.Drawing.Image)(resources.GetObject("btnCancel.Image")));
            this.btnCancel.Location = new System.Drawing.Point(846, 453);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(122, 39);
            this.btnCancel.TabIndex = 15;
            this.btnCancel.Text = "Hủy";
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // EmployeeForm
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
            this.Name = "EmployeeForm";
            this.Text = "Nhân viên";
            this.Load += new System.EventHandler(this.Employee_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.employeeModelBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit2.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbRole.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtWage.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtName.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtAddress.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtBirthday.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtBirthday.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbStatus.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbSex.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtUsername.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtPwwd.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private DevExpress.XtraEditors.SimpleButton btnEdit;
        private DevExpress.XtraEditors.SimpleButton btnNew;
        private DevExpress.XtraEditors.TextEdit txtWage;
        private DevExpress.XtraEditors.TextEdit txtName;
        private DevExpress.XtraEditors.MemoEdit txtAddress;
        private System.Windows.Forms.Label label6;
        private DevExpress.XtraEditors.SimpleButton btnSave;
        private System.Windows.Forms.BindingSource employeeModelBindingSource;
        private DevExpress.XtraGrid.Columns.GridColumn colEmployeeId;
        private DevExpress.XtraGrid.Columns.GridColumn colName;
        private DevExpress.XtraGrid.Columns.GridColumn colTel;
        private DevExpress.XtraGrid.Columns.GridColumn colStatus;
        private System.Windows.Forms.Label label7;
        private DevExpress.XtraEditors.DateEdit txtBirthday;
        private DevExpress.XtraEditors.ComboBoxEdit cbStatus;
        private DevExpress.XtraEditors.SimpleButton btnCancel;
        private DevExpress.XtraEditors.ComboBoxEdit cbSex;
        private DevExpress.XtraEditors.TextEdit textEdit2;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label8;
        private DevExpress.XtraEditors.ComboBoxEdit cbRole;
        private DevExpress.XtraEditors.TextEdit txtUsername;
        private DevExpress.XtraEditors.TextEdit txtPwwd;
        private DevExpress.XtraGrid.Columns.GridColumn colRole;
        private DevExpress.XtraEditors.LabelControl lbStatus;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private DevExpress.XtraEditors.LabelControl pwwwdForce;
        private DevExpress.XtraEditors.LabelControl usernameForce;
        private DevExpress.XtraEditors.LabelControl labelControl2;
    }
}