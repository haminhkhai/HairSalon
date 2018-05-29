namespace DuHair
{
    partial class TkDetailAddEdit
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TkDetailAddEdit));
            this.gvMain = new DevExpress.XtraGrid.GridControl();
            this.gvList = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colEmployeeId = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colEmployee = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colWage = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colRealWage = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colWorkedDay = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colOvertime = new DevExpress.XtraGrid.Columns.GridColumn();
            this.lbTitle = new System.Windows.Forms.Label();
            this.btnSave = new DevExpress.XtraEditors.SimpleButton();
            this.btnClose = new DevExpress.XtraEditors.SimpleButton();
            this.txtWorkingDay = new DevExpress.XtraEditors.TextEdit();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.gvMain)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvList)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtWorkingDay.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // gvMain
            // 
            this.gvMain.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gvMain.EmbeddedNavigator.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.gvMain.Location = new System.Drawing.Point(8, 90);
            this.gvMain.MainView = this.gvList;
            this.gvMain.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.gvMain.MinimumSize = new System.Drawing.Size(267, 274);
            this.gvMain.Name = "gvMain";
            this.gvMain.Size = new System.Drawing.Size(436, 350);
            this.gvMain.TabIndex = 2;
            this.gvMain.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gvList});
            this.gvMain.ProcessGridKey += new System.Windows.Forms.KeyEventHandler(this.gvMain_ProcessGridKey);
            // 
            // gvList
            // 
            this.gvList.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colEmployeeId,
            this.colEmployee,
            this.colWage,
            this.colRealWage,
            this.colWorkedDay,
            this.colOvertime});
            this.gvList.GridControl = this.gvMain;
            this.gvList.Name = "gvList";
            this.gvList.OptionsView.ShowGroupPanel = false;
            this.gvList.OptionsView.ShowIndicator = false;
            this.gvList.FocusedRowChanged += new DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventHandler(this.gvList_FocusedRowChanged);
            this.gvList.FocusedColumnChanged += new DevExpress.XtraGrid.Views.Base.FocusedColumnChangedEventHandler(this.gvList_FocusedColumnChanged);
            this.gvList.CellValueChanged += new DevExpress.XtraGrid.Views.Base.CellValueChangedEventHandler(this.gvList_CellValueChanged);
            // 
            // colEmployeeId
            // 
            this.colEmployeeId.FieldName = "EmployeeId";
            this.colEmployeeId.Name = "colEmployeeId";
            this.colEmployeeId.OptionsColumn.AllowEdit = false;
            // 
            // colEmployee
            // 
            this.colEmployee.Caption = "Nhân viên";
            this.colEmployee.FieldName = "Name";
            this.colEmployee.Name = "colEmployee";
            this.colEmployee.OptionsColumn.AllowEdit = false;
            this.colEmployee.OptionsColumn.AllowFocus = false;
            this.colEmployee.Visible = true;
            this.colEmployee.VisibleIndex = 0;
            this.colEmployee.Width = 206;
            // 
            // colWage
            // 
            this.colWage.Caption = "Lương cơ bản";
            this.colWage.DisplayFormat.FormatString = "n0";
            this.colWage.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.colWage.FieldName = "Wage";
            this.colWage.Name = "colWage";
            this.colWage.OptionsColumn.AllowEdit = false;
            this.colWage.OptionsColumn.AllowFocus = false;
            this.colWage.Visible = true;
            this.colWage.VisibleIndex = 1;
            this.colWage.Width = 106;
            // 
            // colRealWage
            // 
            this.colRealWage.Caption = "Lương thực tế";
            this.colRealWage.DisplayFormat.FormatString = "n0";
            this.colRealWage.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.colRealWage.FieldName = "RealWage";
            this.colRealWage.Name = "colRealWage";
            this.colRealWage.OptionsColumn.AllowEdit = false;
            this.colRealWage.OptionsColumn.AllowFocus = false;
            this.colRealWage.Visible = true;
            this.colRealWage.VisibleIndex = 2;
            this.colRealWage.Width = 128;
            // 
            // colWorkedDay
            // 
            this.colWorkedDay.Caption = "Ngày công";
            this.colWorkedDay.DisplayFormat.FormatString = "n1";
            this.colWorkedDay.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.colWorkedDay.FieldName = "WorkedDay";
            this.colWorkedDay.Name = "colWorkedDay";
            this.colWorkedDay.Visible = true;
            this.colWorkedDay.VisibleIndex = 3;
            this.colWorkedDay.Width = 103;
            // 
            // colOvertime
            // 
            this.colOvertime.Caption = "Ngày tăng ca";
            this.colOvertime.DisplayFormat.FormatString = "n1";
            this.colOvertime.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.colOvertime.FieldName = "Overtime";
            this.colOvertime.Name = "colOvertime";
            this.colOvertime.Visible = true;
            this.colOvertime.VisibleIndex = 4;
            this.colOvertime.Width = 109;
            // 
            // lbTitle
            // 
            this.lbTitle.AutoSize = true;
            this.lbTitle.Font = new System.Drawing.Font("Tahoma", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTitle.Location = new System.Drawing.Point(3, 11);
            this.lbTitle.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbTitle.Name = "lbTitle";
            this.lbTitle.Size = new System.Drawing.Size(281, 29);
            this.lbTitle.TabIndex = 27;
            this.lbTitle.Text = "Chấm công tháng 8-2018";
            // 
            // btnSave
            // 
            this.btnSave.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSave.Image = ((System.Drawing.Image)(resources.GetObject("btnSave.Image")));
            this.btnSave.Location = new System.Drawing.Point(273, 450);
            this.btnSave.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(81, 27);
            this.btnSave.TabIndex = 3;
            this.btnSave.Text = "Lưu";
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnClose
            // 
            this.btnClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnClose.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnClose.Image = ((System.Drawing.Image)(resources.GetObject("btnClose.Image")));
            this.btnClose.Location = new System.Drawing.Point(363, 450);
            this.btnClose.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(81, 27);
            this.btnClose.TabIndex = 4;
            this.btnClose.Text = "Đóng";
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // txtWorkingDay
            // 
            this.txtWorkingDay.EditValue = "28";
            this.txtWorkingDay.Location = new System.Drawing.Point(171, 54);
            this.txtWorkingDay.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtWorkingDay.Name = "txtWorkingDay";
            this.txtWorkingDay.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 11F);
            this.txtWorkingDay.Properties.Appearance.Options.UseFont = true;
            this.txtWorkingDay.Properties.Mask.EditMask = "n1";
            this.txtWorkingDay.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
            this.txtWorkingDay.Size = new System.Drawing.Size(273, 24);
            this.txtWorkingDay.TabIndex = 1;
            this.txtWorkingDay.EditValueChanged += new System.EventHandler(this.txtWorkingDay_EditValueChanged);
            this.txtWorkingDay.Enter += new System.EventHandler(this.txtWorkingDay_Enter);
            this.txtWorkingDay.MouseUp += new System.Windows.Forms.MouseEventHandler(this.txtWorkingDay_MouseUp);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 11F);
            this.label1.Location = new System.Drawing.Point(5, 56);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(164, 18);
            this.label1.TabIndex = 36;
            this.label1.Text = "Ngày công trong tháng:";
            // 
            // TkDetailAddEdit
            // 
            this.AcceptButton = this.btnSave;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnClose;
            this.ClientSize = new System.Drawing.Size(452, 487);
            this.Controls.Add(this.txtWorkingDay);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.gvMain);
            this.Controls.Add(this.lbTitle);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "TkDetailAddEdit";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Chấm công tháng 8-2018";
            this.Load += new System.EventHandler(this.TKdetailAddEdit_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gvMain)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvList)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtWorkingDay.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.SimpleButton btnSave;
        private DevExpress.XtraEditors.SimpleButton btnClose;
        private DevExpress.XtraGrid.GridControl gvMain;
        private DevExpress.XtraGrid.Views.Grid.GridView gvList;
        private DevExpress.XtraGrid.Columns.GridColumn colEmployeeId;
        private DevExpress.XtraGrid.Columns.GridColumn colEmployee;
        private DevExpress.XtraGrid.Columns.GridColumn colWage;
        private DevExpress.XtraGrid.Columns.GridColumn colWorkedDay;
        private System.Windows.Forms.Label lbTitle;
        private DevExpress.XtraEditors.TextEdit txtWorkingDay;
        private System.Windows.Forms.Label label1;
        private DevExpress.XtraGrid.Columns.GridColumn colRealWage;
        private DevExpress.XtraGrid.Columns.GridColumn colOvertime;
    }
}