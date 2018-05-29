namespace DuHair
{
    partial class TimeKeepingForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TimeKeepingForm));
            this.gvMain = new DevExpress.XtraGrid.GridControl();
            this.gvList = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colTimeKeepingId = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colMonthAndYear = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colAmountMoney = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSumRealWage = new DevExpress.XtraGrid.Columns.GridColumn();
            this.btnDelete = new DevExpress.XtraEditors.SimpleButton();
            this.btnNew = new DevExpress.XtraEditors.SimpleButton();
            this.btnEdit = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.gvMain)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvList)).BeginInit();
            this.SuspendLayout();
            // 
            // gvMain
            // 
            this.gvMain.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gvMain.Location = new System.Drawing.Point(12, 12);
            this.gvMain.MainView = this.gvList;
            this.gvMain.MinimumSize = new System.Drawing.Size(400, 400);
            this.gvMain.Name = "gvMain";
            this.gvMain.Size = new System.Drawing.Size(954, 434);
            this.gvMain.TabIndex = 26;
            this.gvMain.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gvList});
            // 
            // gvList
            // 
            this.gvList.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colTimeKeepingId,
            this.colMonthAndYear,
            this.colAmountMoney,
            this.colSumRealWage});
            this.gvList.GridControl = this.gvMain;
            this.gvList.Name = "gvList";
            this.gvList.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.gvList.DoubleClick += new System.EventHandler(this.gvList_DoubleClick);
            // 
            // colTimeKeepingId
            // 
            this.colTimeKeepingId.FieldName = "TimeKeepingId";
            this.colTimeKeepingId.Name = "colTimeKeepingId";
            this.colTimeKeepingId.OptionsColumn.AllowEdit = false;
            // 
            // colMonthAndYear
            // 
            this.colMonthAndYear.Caption = "Thời điểm ";
            this.colMonthAndYear.FieldName = "MonthAndYear";
            this.colMonthAndYear.MaxWidth = 250;
            this.colMonthAndYear.Name = "colMonthAndYear";
            this.colMonthAndYear.OptionsColumn.AllowEdit = false;
            this.colMonthAndYear.Visible = true;
            this.colMonthAndYear.VisibleIndex = 0;
            this.colMonthAndYear.Width = 219;
            // 
            // colAmountMoney
            // 
            this.colAmountMoney.Caption = "Ngày công trong tháng";
            this.colAmountMoney.FieldName = "WorkingDay";
            this.colAmountMoney.Name = "colAmountMoney";
            this.colAmountMoney.OptionsColumn.AllowEdit = false;
            this.colAmountMoney.Visible = true;
            this.colAmountMoney.VisibleIndex = 1;
            this.colAmountMoney.Width = 334;
            // 
            // colSumRealWage
            // 
            this.colSumRealWage.Caption = "Tổng lương";
            this.colSumRealWage.DisplayFormat.FormatString = "n0";
            this.colSumRealWage.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.colSumRealWage.FieldName = "SumRealWage";
            this.colSumRealWage.Name = "colSumRealWage";
            this.colSumRealWage.OptionsColumn.AllowEdit = false;
            this.colSumRealWage.Visible = true;
            this.colSumRealWage.VisibleIndex = 2;
            this.colSumRealWage.Width = 383;
            // 
            // btnDelete
            // 
            this.btnDelete.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnDelete.Image = ((System.Drawing.Image)(resources.GetObject("btnDelete.Image")));
            this.btnDelete.Location = new System.Drawing.Point(844, 455);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(122, 39);
            this.btnDelete.TabIndex = 29;
            this.btnDelete.Text = "Xóa";
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnNew
            // 
            this.btnNew.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnNew.Image = ((System.Drawing.Image)(resources.GetObject("btnNew.Image")));
            this.btnNew.ImageLocation = DevExpress.XtraEditors.ImageLocation.MiddleLeft;
            this.btnNew.Location = new System.Drawing.Point(588, 455);
            this.btnNew.Name = "btnNew";
            this.btnNew.Size = new System.Drawing.Size(122, 39);
            this.btnNew.TabIndex = 27;
            this.btnNew.Text = "Tạo mới";
            this.btnNew.Click += new System.EventHandler(this.btnNew_Click);
            // 
            // btnEdit
            // 
            this.btnEdit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnEdit.Image = ((System.Drawing.Image)(resources.GetObject("btnEdit.Image")));
            this.btnEdit.Location = new System.Drawing.Point(716, 455);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(122, 39);
            this.btnEdit.TabIndex = 28;
            this.btnEdit.Text = "Chỉnh sửa";
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // TimeKeepingForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(978, 504);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnNew);
            this.Controls.Add(this.btnEdit);
            this.Controls.Add(this.gvMain);
            this.Name = "TimeKeepingForm";
            this.Text = "Chấm công";
            this.Load += new System.EventHandler(this.TimeKeepingForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gvMain)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvList)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.SimpleButton btnDelete;
        private DevExpress.XtraEditors.SimpleButton btnNew;
        private DevExpress.XtraEditors.SimpleButton btnEdit;
        private DevExpress.XtraGrid.GridControl gvMain;
        private DevExpress.XtraGrid.Views.Grid.GridView gvList;
        private DevExpress.XtraGrid.Columns.GridColumn colTimeKeepingId;
        private DevExpress.XtraGrid.Columns.GridColumn colMonthAndYear;
        private DevExpress.XtraGrid.Columns.GridColumn colAmountMoney;
        private DevExpress.XtraGrid.Columns.GridColumn colSumRealWage;

    }
}