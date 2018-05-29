namespace DuHair
{
    partial class SpendNoteForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SpendNoteForm));
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.spendNoteBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colSpendNoteId = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colAmountMoney = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colMonthly = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.txtFrom = new DevExpress.XtraEditors.DateEdit();
            this.txtTo = new DevExpress.XtraEditors.DateEdit();
            this.label8 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtName = new DevExpress.XtraEditors.TextEdit();
            this.txtNet = new DevExpress.XtraEditors.TextEdit();
            this.panel1 = new System.Windows.Forms.Panel();
            this.txtPrice = new DevExpress.XtraEditors.CheckEdit();
            this.btnCancel = new DevExpress.XtraEditors.SimpleButton();
            this.btnSave = new DevExpress.XtraEditors.SimpleButton();
            this.btnDelete = new DevExpress.XtraEditors.SimpleButton();
            this.btnNew = new DevExpress.XtraEditors.SimpleButton();
            this.btnEdit = new DevExpress.XtraEditors.SimpleButton();
            this.btnReload = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.spendNoteBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtFrom.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtFrom.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTo.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTo.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtName.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtNet.Properties)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtPrice.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(213, 14);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(37, 19);
            this.label2.TabIndex = 25;
            this.label2.Text = "Đến";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(11, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(29, 19);
            this.label1.TabIndex = 23;
            this.label1.Text = "Từ";
            // 
            // gridControl1
            // 
            this.gridControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gridControl1.DataSource = this.spendNoteBindingSource;
            this.gridControl1.Location = new System.Drawing.Point(13, 54);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.MinimumSize = new System.Drawing.Size(400, 300);
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.Size = new System.Drawing.Size(559, 392);
            this.gridControl1.TabIndex = 22;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colSpendNoteId,
            this.colName,
            this.colAmountMoney,
            this.colMonthly,
            this.gridColumn1});
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsSelection.EnableAppearanceFocusedCell = false;
            // 
            // colSpendNoteId
            // 
            this.colSpendNoteId.FieldName = "SpendNoteId";
            this.colSpendNoteId.Name = "colSpendNoteId";
            this.colSpendNoteId.OptionsColumn.AllowEdit = false;
            // 
            // colName
            // 
            this.colName.Caption = "Khoản chi";
            this.colName.FieldName = "Name";
            this.colName.Name = "colName";
            this.colName.OptionsColumn.AllowEdit = false;
            this.colName.Visible = true;
            this.colName.VisibleIndex = 0;
            // 
            // colAmountMoney
            // 
            this.colAmountMoney.Caption = "Tổng tiền";
            this.colAmountMoney.DisplayFormat.FormatString = "n0";
            this.colAmountMoney.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.colAmountMoney.FieldName = "AmountMoney";
            this.colAmountMoney.Name = "colAmountMoney";
            this.colAmountMoney.OptionsColumn.AllowEdit = false;
            this.colAmountMoney.Visible = true;
            this.colAmountMoney.VisibleIndex = 1;
            // 
            // colMonthly
            // 
            this.colMonthly.Caption = "Hàng tháng";
            this.colMonthly.FieldName = "Monthly";
            this.colMonthly.Name = "colMonthly";
            this.colMonthly.OptionsColumn.AllowEdit = false;
            this.colMonthly.Visible = true;
            this.colMonthly.VisibleIndex = 2;
            // 
            // gridColumn1
            // 
            this.gridColumn1.Caption = "Ngày chi";
            this.gridColumn1.DisplayFormat.FormatString = "dd/MM/yyyy";
            this.gridColumn1.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Custom;
            this.gridColumn1.FieldName = "SpendDate";
            this.gridColumn1.Name = "gridColumn1";
            this.gridColumn1.OptionsColumn.AllowEdit = false;
            this.gridColumn1.Visible = true;
            this.gridColumn1.VisibleIndex = 3;
            // 
            // txtFrom
            // 
            this.txtFrom.EditValue = "";
            this.txtFrom.Location = new System.Drawing.Point(46, 11);
            this.txtFrom.Name = "txtFrom";
            this.txtFrom.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.txtFrom.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.txtFrom.Properties.DisplayFormat.FormatString = "dd/MM/yyyy";
            this.txtFrom.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Custom;
            this.txtFrom.Properties.EditFormat.FormatString = "dd/MM/yyyy";
            this.txtFrom.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.Custom;
            this.txtFrom.Properties.Mask.EditMask = "";
            this.txtFrom.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.None;
            this.txtFrom.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor;
            this.txtFrom.Properties.VistaCalendarViewStyle = DevExpress.XtraEditors.VistaCalendarViewStyle.YearView;
            this.txtFrom.Size = new System.Drawing.Size(158, 26);
            this.txtFrom.TabIndex = 24;
            // 
            // txtTo
            // 
            this.txtTo.EditValue = "";
            this.txtTo.Location = new System.Drawing.Point(257, 11);
            this.txtTo.Name = "txtTo";
            this.txtTo.Properties.AllowNullInput = DevExpress.Utils.DefaultBoolean.False;
            this.txtTo.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.txtTo.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.txtTo.Properties.DisplayFormat.FormatString = "dd/MM/yyyy";
            this.txtTo.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Custom;
            this.txtTo.Properties.EditFormat.FormatString = "dd/MM/yyyy";
            this.txtTo.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.Custom;
            this.txtTo.Properties.Mask.EditMask = "";
            this.txtTo.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.None;
            this.txtTo.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor;
            this.txtTo.Properties.VistaCalendarViewStyle = DevExpress.XtraEditors.VistaCalendarViewStyle.YearView;
            this.txtTo.Size = new System.Drawing.Size(158, 26);
            this.txtTo.TabIndex = 26;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(17, 16);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(84, 19);
            this.label8.TabIndex = 0;
            this.label8.Text = "Khoản chi:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(37, 48);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(64, 19);
            this.label4.TabIndex = 1;
            this.label4.Text = "Số tiền:";
            // 
            // txtName
            // 
            this.txtName.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.spendNoteBindingSource, "Name", true));
            this.txtName.EditValue = "";
            this.txtName.Location = new System.Drawing.Point(107, 13);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(265, 26);
            this.txtName.TabIndex = 1;
            // 
            // txtNet
            // 
            this.txtNet.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.spendNoteBindingSource, "AmountMoney", true));
            this.txtNet.EditValue = "";
            this.txtNet.Location = new System.Drawing.Point(107, 45);
            this.txtNet.Name = "txtNet";
            this.txtNet.Size = new System.Drawing.Size(265, 26);
            this.txtNet.TabIndex = 2;
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.txtNet);
            this.panel1.Controls.Add(this.txtName);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.txtPrice);
            this.panel1.Location = new System.Drawing.Point(578, 11);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(389, 435);
            this.panel1.TabIndex = 29;
            // 
            // txtPrice
            // 
            this.txtPrice.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.spendNoteBindingSource, "Monthly", true));
            this.txtPrice.EditValue = "";
            this.txtPrice.Location = new System.Drawing.Point(107, 77);
            this.txtPrice.Name = "txtPrice";
            this.txtPrice.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Default;
            this.txtPrice.Properties.Caption = "Chi hàng tháng";
            this.txtPrice.Size = new System.Drawing.Size(234, 23);
            this.txtPrice.TabIndex = 3;
            // 
            // btnCancel
            // 
            this.btnCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCancel.Image = ((System.Drawing.Image)(resources.GetObject("btnCancel.Image")));
            this.btnCancel.Location = new System.Drawing.Point(716, 455);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(122, 39);
            this.btnCancel.TabIndex = 33;
            this.btnCancel.Text = "Hủy";
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnSave
            // 
            this.btnSave.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSave.Image = ((System.Drawing.Image)(resources.GetObject("btnSave.Image")));
            this.btnSave.Location = new System.Drawing.Point(588, 455);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(122, 39);
            this.btnSave.TabIndex = 32;
            this.btnSave.Text = "Lưu";
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnDelete.Image = ((System.Drawing.Image)(resources.GetObject("btnDelete.Image")));
            this.btnDelete.Location = new System.Drawing.Point(844, 455);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(122, 39);
            this.btnDelete.TabIndex = 34;
            this.btnDelete.Text = "Xóa";
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnNew
            // 
            this.btnNew.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnNew.Image = ((System.Drawing.Image)(resources.GetObject("btnNew.Image")));
            this.btnNew.ImageLocation = DevExpress.XtraEditors.ImageLocation.MiddleLeft;
            this.btnNew.Location = new System.Drawing.Point(332, 455);
            this.btnNew.Name = "btnNew";
            this.btnNew.Size = new System.Drawing.Size(122, 39);
            this.btnNew.TabIndex = 30;
            this.btnNew.Text = "Tạo mới";
            this.btnNew.Click += new System.EventHandler(this.btnNew_Click);
            // 
            // btnEdit
            // 
            this.btnEdit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnEdit.Image = ((System.Drawing.Image)(resources.GetObject("btnEdit.Image")));
            this.btnEdit.Location = new System.Drawing.Point(460, 455);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(122, 39);
            this.btnEdit.TabIndex = 31;
            this.btnEdit.Text = "Chỉnh sửa";
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // btnReload
            // 
            this.btnReload.Image = ((System.Drawing.Image)(resources.GetObject("btnReload.Image")));
            this.btnReload.ImageLocation = DevExpress.XtraEditors.ImageLocation.MiddleLeft;
            this.btnReload.Location = new System.Drawing.Point(421, 12);
            this.btnReload.Name = "btnReload";
            this.btnReload.Size = new System.Drawing.Size(96, 29);
            this.btnReload.TabIndex = 35;
            this.btnReload.Text = "Tải lại";
            this.btnReload.Click += new System.EventHandler(this.btnReload_Click);
            // 
            // SpendNoteForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(978, 504);
            this.Controls.Add(this.btnReload);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnNew);
            this.Controls.Add(this.btnEdit);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.gridControl1);
            this.Controls.Add(this.txtFrom);
            this.Controls.Add(this.txtTo);
            this.Name = "SpendNoteForm";
            this.Text = "Khoản chi";
            this.Load += new System.EventHandler(this.SpendNoteForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.spendNoteBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtFrom.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtFrom.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTo.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTo.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtName.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtNet.Properties)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtPrice.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraEditors.DateEdit txtFrom;
        private DevExpress.XtraEditors.DateEdit txtTo;
        private System.Windows.Forms.BindingSource spendNoteBindingSource;
        private DevExpress.XtraGrid.Columns.GridColumn colSpendNoteId;
        private DevExpress.XtraGrid.Columns.GridColumn colName;
        private DevExpress.XtraGrid.Columns.GridColumn colAmountMoney;
        private DevExpress.XtraGrid.Columns.GridColumn colMonthly;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label4;
        private DevExpress.XtraEditors.TextEdit txtName;
        private DevExpress.XtraEditors.TextEdit txtNet;
        private System.Windows.Forms.Panel panel1;
        private DevExpress.XtraEditors.CheckEdit txtPrice;
        private DevExpress.XtraEditors.SimpleButton btnCancel;
        private DevExpress.XtraEditors.SimpleButton btnSave;
        private DevExpress.XtraEditors.SimpleButton btnDelete;
        private DevExpress.XtraEditors.SimpleButton btnNew;
        private DevExpress.XtraEditors.SimpleButton btnEdit;
        private DevExpress.XtraEditors.SimpleButton btnReload;
    }
}