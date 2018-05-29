namespace DuHair
{
    partial class CustomerForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CustomerForm));
            this.panel1 = new System.Windows.Forms.Panel();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.lbStatus = new DevExpress.XtraEditors.LabelControl();
            this.txtPoint = new DevExpress.XtraEditors.TextEdit();
            this.customerModelBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.label3 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtTel = new DevExpress.XtraEditors.TextEdit();
            this.txtName = new DevExpress.XtraEditors.TextEdit();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtBirthday = new DevExpress.XtraEditors.DateEdit();
            this.cbStatus = new DevExpress.XtraEditors.ComboBoxEdit();
            this.cbSex = new DevExpress.XtraEditors.ComboBoxEdit();
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colCustomerId = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTel = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colPoint = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colStatus = new DevExpress.XtraGrid.Columns.GridColumn();
            this.btnCancel = new DevExpress.XtraEditors.SimpleButton();
            this.btnSave = new DevExpress.XtraEditors.SimpleButton();
            this.btnNew = new DevExpress.XtraEditors.SimpleButton();
            this.btnEdit = new DevExpress.XtraEditors.SimpleButton();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtPoint.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.customerModelBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTel.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtName.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtBirthday.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtBirthday.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbStatus.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbSex.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.labelControl1);
            this.panel1.Controls.Add(this.labelControl2);
            this.panel1.Controls.Add(this.lbStatus);
            this.panel1.Controls.Add(this.txtPoint);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.txtTel);
            this.panel1.Controls.Add(this.txtName);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.txtBirthday);
            this.panel1.Controls.Add(this.cbStatus);
            this.panel1.Controls.Add(this.cbSex);
            this.panel1.Location = new System.Drawing.Point(418, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(550, 435);
            this.panel1.TabIndex = 15;
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl1.Appearance.ForeColor = System.Drawing.Color.Red;
            this.labelControl1.Location = new System.Drawing.Point(525, 51);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(11, 24);
            this.labelControl1.TabIndex = 40;
            this.labelControl1.Text = "*";
            // 
            // labelControl2
            // 
            this.labelControl2.Appearance.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl2.Appearance.ForeColor = System.Drawing.Color.Red;
            this.labelControl2.Location = new System.Drawing.Point(525, 18);
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
            this.lbStatus.Location = new System.Drawing.Point(18, 213);
            this.lbStatus.Name = "lbStatus";
            this.lbStatus.Size = new System.Drawing.Size(221, 22);
            this.lbStatus.TabIndex = 38;
            this.lbStatus.Text = "(*) Không được bỏ trống";
            // 
            // txtPoint
            // 
            this.txtPoint.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.customerModelBindingSource, "Point", true));
            this.txtPoint.EditValue = "";
            this.txtPoint.Enabled = false;
            this.txtPoint.Location = new System.Drawing.Point(112, 143);
            this.txtPoint.Name = "txtPoint";
            this.txtPoint.Size = new System.Drawing.Size(406, 26);
            this.txtPoint.TabIndex = 5;
            // 
            // customerModelBindingSource
            // 
            this.customerModelBindingSource.DataSource = typeof(DuHair.Customer);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(20, 146);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(82, 19);
            this.label3.TabIndex = 17;
            this.label3.Text = "Điểm tích:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(14, 178);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(94, 19);
            this.label7.TabIndex = 16;
            this.label7.Text = "Tình trạng: ";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(27, 114);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(80, 19);
            this.label6.TabIndex = 12;
            this.label6.Text = "Giới tính: ";
            // 
            // txtTel
            // 
            this.txtTel.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.customerModelBindingSource, "Tel", true));
            this.txtTel.EditValue = "";
            this.txtTel.Location = new System.Drawing.Point(112, 47);
            this.txtTel.Name = "txtTel";
            this.txtTel.Size = new System.Drawing.Size(406, 26);
            this.txtTel.TabIndex = 2;
            // 
            // txtName
            // 
            this.txtName.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.customerModelBindingSource, "Name", true));
            this.txtName.EditValue = "";
            this.txtName.Location = new System.Drawing.Point(112, 15);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(406, 26);
            this.txtName.TabIndex = 1;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(16, 82);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(90, 19);
            this.label4.TabIndex = 3;
            this.label4.Text = "Ngày sinh: ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(57, 50);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(50, 19);
            this.label2.TabIndex = 1;
            this.label2.Text = "SĐT: ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(60, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 19);
            this.label1.TabIndex = 0;
            this.label1.Text = "Tên: ";
            // 
            // txtBirthday
            // 
            this.txtBirthday.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.customerModelBindingSource, "Birthday", true));
            this.txtBirthday.EditValue = "";
            this.txtBirthday.Location = new System.Drawing.Point(112, 79);
            this.txtBirthday.Name = "txtBirthday";
            this.txtBirthday.Properties.AllowNullInput = DevExpress.Utils.DefaultBoolean.False;
            this.txtBirthday.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.txtBirthday.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.txtBirthday.Properties.DisplayFormat.FormatString = "dd/MM/yyyy";
            this.txtBirthday.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Custom;
            this.txtBirthday.Properties.EditFormat.FormatString = "dd/MM/yyyy";
            this.txtBirthday.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.Custom;
            this.txtBirthday.Properties.Mask.EditMask = "dd/MM/yyyy";
            this.txtBirthday.Size = new System.Drawing.Size(406, 26);
            this.txtBirthday.TabIndex = 3;
            // 
            // cbStatus
            // 
            this.cbStatus.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.customerModelBindingSource, "Status", true));
            this.cbStatus.EditValue = "Hiển thị";
            this.cbStatus.Location = new System.Drawing.Point(112, 175);
            this.cbStatus.Name = "cbStatus";
            this.cbStatus.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cbStatus.Properties.Items.AddRange(new object[] {
            "Hiển thị",
            "Ẩn"});
            this.cbStatus.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor;
            this.cbStatus.Size = new System.Drawing.Size(406, 26);
            this.cbStatus.TabIndex = 7;
            // 
            // cbSex
            // 
            this.cbSex.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.customerModelBindingSource, "Sex", true));
            this.cbSex.EditValue = "";
            this.cbSex.Location = new System.Drawing.Point(112, 111);
            this.cbSex.Name = "cbSex";
            this.cbSex.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cbSex.Properties.Items.AddRange(new object[] {
            "Nam",
            "Nữ",
            "Khác"});
            this.cbSex.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor;
            this.cbSex.Size = new System.Drawing.Size(406, 26);
            this.cbSex.TabIndex = 4;
            // 
            // gridControl1
            // 
            this.gridControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gridControl1.DataSource = this.customerModelBindingSource;
            this.gridControl1.Location = new System.Drawing.Point(12, 12);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.MinimumSize = new System.Drawing.Size(400, 400);
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.Size = new System.Drawing.Size(400, 436);
            this.gridControl1.TabIndex = 14;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colCustomerId,
            this.colName,
            this.colTel,
            this.colPoint,
            this.colStatus});
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsSelection.EnableAppearanceFocusedCell = false;
            // 
            // colCustomerId
            // 
            this.colCustomerId.FieldName = "CustomerId";
            this.colCustomerId.Name = "colCustomerId";
            this.colCustomerId.OptionsColumn.AllowEdit = false;
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
            // colPoint
            // 
            this.colPoint.Caption = "Điểm tích";
            this.colPoint.FieldName = "Point";
            this.colPoint.Name = "colPoint";
            this.colPoint.OptionsColumn.AllowEdit = false;
            this.colPoint.Visible = true;
            this.colPoint.VisibleIndex = 2;
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
            // btnCancel
            // 
            this.btnCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.Image = ((System.Drawing.Image)(resources.GetObject("btnCancel.Image")));
            this.btnCancel.Location = new System.Drawing.Point(846, 455);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(122, 39);
            this.btnCancel.TabIndex = 19;
            this.btnCancel.Text = "Hủy";
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnSave
            // 
            this.btnSave.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSave.Image = ((System.Drawing.Image)(resources.GetObject("btnSave.Image")));
            this.btnSave.Location = new System.Drawing.Point(718, 455);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(122, 39);
            this.btnSave.TabIndex = 18;
            this.btnSave.Text = "Lưu";
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnNew
            // 
            this.btnNew.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnNew.Image = ((System.Drawing.Image)(resources.GetObject("btnNew.Image")));
            this.btnNew.ImageLocation = DevExpress.XtraEditors.ImageLocation.MiddleLeft;
            this.btnNew.Location = new System.Drawing.Point(462, 455);
            this.btnNew.Name = "btnNew";
            this.btnNew.Size = new System.Drawing.Size(122, 39);
            this.btnNew.TabIndex = 16;
            this.btnNew.Text = "Tạo mới";
            this.btnNew.Click += new System.EventHandler(this.btnNew_Click);
            // 
            // btnEdit
            // 
            this.btnEdit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnEdit.Image = ((System.Drawing.Image)(resources.GetObject("btnEdit.Image")));
            this.btnEdit.Location = new System.Drawing.Point(590, 455);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(122, 39);
            this.btnEdit.TabIndex = 17;
            this.btnEdit.Text = "Chỉnh sửa";
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // CustomerForm
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
            this.Name = "CustomerForm";
            this.Text = "Khách";
            this.Load += new System.EventHandler(this.CustomerForm_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtPoint.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.customerModelBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTel.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtName.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtBirthday.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtBirthday.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbStatus.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbSex.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.SimpleButton btnCancel;
        private DevExpress.XtraEditors.SimpleButton btnSave;
        private DevExpress.XtraEditors.SimpleButton btnNew;
        private DevExpress.XtraEditors.SimpleButton btnEdit;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private DevExpress.XtraEditors.TextEdit txtTel;
        private DevExpress.XtraEditors.TextEdit txtName;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private DevExpress.XtraEditors.DateEdit txtBirthday;
        private DevExpress.XtraEditors.ComboBoxEdit cbStatus;
        private DevExpress.XtraEditors.ComboBoxEdit cbSex;
        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private System.Windows.Forms.BindingSource customerModelBindingSource;
        private DevExpress.XtraGrid.Columns.GridColumn colCustomerId;
        private DevExpress.XtraGrid.Columns.GridColumn colName;
        private DevExpress.XtraGrid.Columns.GridColumn colTel;
        private DevExpress.XtraGrid.Columns.GridColumn colPoint;
        private DevExpress.XtraGrid.Columns.GridColumn colStatus;
        private DevExpress.XtraEditors.TextEdit txtPoint;
        private System.Windows.Forms.Label label3;
        private DevExpress.XtraEditors.LabelControl lbStatus;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.LabelControl labelControl2;
    }
}