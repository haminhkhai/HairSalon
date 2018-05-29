namespace DuHair
{
    partial class HomeForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(HomeForm));
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.panelDad = new System.Windows.Forms.FlowLayoutPanel();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.gvSellTranMain = new DevExpress.XtraGrid.GridControl();
            this.gvSellTran = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gridColumn12 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn13 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn14 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn15 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTotalDiscount = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn16 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn17 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gvMain = new DevExpress.XtraGrid.GridControl();
            this.gvTransaction = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colTransactionId = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTransactionIdCoded = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCustomerName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colChair = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colAmount = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTransactionDate = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colStatus = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn6 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn8 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn10 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn9 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn7 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gvSellTranMain)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvSellTran)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvMain)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvTransaction)).BeginInit();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 40F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 60F));
            this.tableLayoutPanel1.Controls.Add(this.panelDad, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel2, 1, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1578, 805);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // panelDad
            // 
            this.panelDad.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelDad.Location = new System.Drawing.Point(4, 4);
            this.panelDad.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panelDad.Name = "panelDad";
            this.panelDad.Size = new System.Drawing.Size(623, 797);
            this.panelDad.TabIndex = 17;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 1;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Controls.Add(this.gvSellTranMain, 0, 1);
            this.tableLayoutPanel2.Controls.Add(this.gvMain, 0, 0);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(634, 3);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 2;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(941, 799);
            this.tableLayoutPanel2.TabIndex = 18;
            // 
            // gvSellTranMain
            // 
            this.gvSellTranMain.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gvSellTranMain.Location = new System.Drawing.Point(3, 402);
            this.gvSellTranMain.MainView = this.gvSellTran;
            this.gvSellTranMain.MinimumSize = new System.Drawing.Size(400, 300);
            this.gvSellTranMain.Name = "gvSellTranMain";
            this.gvSellTranMain.Size = new System.Drawing.Size(935, 394);
            this.gvSellTranMain.TabIndex = 19;
            this.gvSellTranMain.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gvSellTran});
            // 
            // gvSellTran
            // 
            this.gvSellTran.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.gridColumn12,
            this.gridColumn13,
            this.gridColumn14,
            this.gridColumn15,
            this.colTotalDiscount,
            this.gridColumn16,
            this.gridColumn17});
            this.gvSellTran.GridControl = this.gvSellTranMain;
            this.gvSellTran.Name = "gvSellTran";
            this.gvSellTran.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.gvSellTran.OptionsView.ShowViewCaption = true;
            this.gvSellTran.ViewCaption = "Phiếu bán hàng trong ngày";
            this.gvSellTran.DoubleClick += new System.EventHandler(this.gvSellTran_DoubleClick);
            // 
            // gridColumn12
            // 
            this.gridColumn12.FieldName = "SellTranId";
            this.gridColumn12.Name = "gridColumn12";
            this.gridColumn12.OptionsColumn.AllowEdit = false;
            // 
            // gridColumn13
            // 
            this.gridColumn13.Caption = "Mã phiếu";
            this.gridColumn13.FieldName = "SellTranIdCoded";
            this.gridColumn13.MaxWidth = 100;
            this.gridColumn13.MinWidth = 100;
            this.gridColumn13.Name = "gridColumn13";
            this.gridColumn13.OptionsColumn.AllowEdit = false;
            this.gridColumn13.Visible = true;
            this.gridColumn13.VisibleIndex = 0;
            this.gridColumn13.Width = 100;
            // 
            // gridColumn14
            // 
            this.gridColumn14.Caption = "Khách";
            this.gridColumn14.FieldName = "CustomerName";
            this.gridColumn14.Name = "gridColumn14";
            this.gridColumn14.OptionsColumn.AllowEdit = false;
            this.gridColumn14.Visible = true;
            this.gridColumn14.VisibleIndex = 1;
            this.gridColumn14.Width = 124;
            // 
            // gridColumn15
            // 
            this.gridColumn15.Caption = "NV tư vấn";
            this.gridColumn15.FieldName = "EmployeeName";
            this.gridColumn15.Name = "gridColumn15";
            this.gridColumn15.OptionsColumn.AllowEdit = false;
            this.gridColumn15.Visible = true;
            this.gridColumn15.VisibleIndex = 2;
            this.gridColumn15.Width = 108;
            // 
            // colTotalDiscount
            // 
            this.colTotalDiscount.Caption = "Chiết khấu";
            this.colTotalDiscount.DisplayFormat.FormatString = "n0";
            this.colTotalDiscount.FieldName = "TotalDiscountMoney";
            this.colTotalDiscount.Name = "colTotalDiscount";
            this.colTotalDiscount.Visible = true;
            this.colTotalDiscount.VisibleIndex = 3;
            this.colTotalDiscount.Width = 78;
            // 
            // gridColumn16
            // 
            this.gridColumn16.Caption = "Tổng tiền";
            this.gridColumn16.DisplayFormat.FormatString = "n0";
            this.gridColumn16.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Custom;
            this.gridColumn16.FieldName = "Amount";
            this.gridColumn16.Name = "gridColumn16";
            this.gridColumn16.OptionsColumn.AllowEdit = false;
            this.gridColumn16.Visible = true;
            this.gridColumn16.VisibleIndex = 4;
            this.gridColumn16.Width = 108;
            // 
            // gridColumn17
            // 
            this.gridColumn17.Caption = "Ngày GD";
            this.gridColumn17.DisplayFormat.FormatString = "HH:mm dd/MM/yyyy";
            this.gridColumn17.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Custom;
            this.gridColumn17.FieldName = "SellDate";
            this.gridColumn17.MaxWidth = 240;
            this.gridColumn17.Name = "gridColumn17";
            this.gridColumn17.OptionsColumn.AllowEdit = false;
            this.gridColumn17.Visible = true;
            this.gridColumn17.VisibleIndex = 5;
            this.gridColumn17.Width = 88;
            // 
            // gvMain
            // 
            this.gvMain.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gvMain.Location = new System.Drawing.Point(3, 3);
            this.gvMain.MainView = this.gvTransaction;
            this.gvMain.MinimumSize = new System.Drawing.Size(400, 300);
            this.gvMain.Name = "gvMain";
            this.gvMain.Size = new System.Drawing.Size(935, 393);
            this.gvMain.TabIndex = 18;
            this.gvMain.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gvTransaction});
            // 
            // gvTransaction
            // 
            this.gvTransaction.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colTransactionId,
            this.colTransactionIdCoded,
            this.colCustomerName,
            this.colChair,
            this.colAmount,
            this.colTransactionDate,
            this.colStatus});
            this.gvTransaction.GridControl = this.gvMain;
            this.gvTransaction.Name = "gvTransaction";
            this.gvTransaction.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.gvTransaction.OptionsView.ShowViewCaption = true;
            this.gvTransaction.ViewCaption = "GD trong ngày";
            this.gvTransaction.ViewCaptionHeight = 15;
            this.gvTransaction.CustomColumnDisplayText += new DevExpress.XtraGrid.Views.Base.CustomColumnDisplayTextEventHandler(this.gvTransaction_CustomColumnDisplayText);
            this.gvTransaction.DoubleClick += new System.EventHandler(this.gvTransaction_DoubleClick);
            // 
            // colTransactionId
            // 
            this.colTransactionId.FieldName = "TransactionId";
            this.colTransactionId.Name = "colTransactionId";
            this.colTransactionId.OptionsColumn.AllowEdit = false;
            // 
            // colTransactionIdCoded
            // 
            this.colTransactionIdCoded.Caption = "Mã GD";
            this.colTransactionIdCoded.FieldName = "TransactionIdCoded";
            this.colTransactionIdCoded.MaxWidth = 100;
            this.colTransactionIdCoded.MinWidth = 100;
            this.colTransactionIdCoded.Name = "colTransactionIdCoded";
            this.colTransactionIdCoded.OptionsColumn.AllowEdit = false;
            this.colTransactionIdCoded.Visible = true;
            this.colTransactionIdCoded.VisibleIndex = 0;
            this.colTransactionIdCoded.Width = 100;
            // 
            // colCustomerName
            // 
            this.colCustomerName.Caption = "Khách";
            this.colCustomerName.FieldName = "Name";
            this.colCustomerName.Name = "colCustomerName";
            this.colCustomerName.OptionsColumn.AllowEdit = false;
            this.colCustomerName.Visible = true;
            this.colCustomerName.VisibleIndex = 1;
            this.colCustomerName.Width = 125;
            // 
            // colChair
            // 
            this.colChair.Caption = "Ghế";
            this.colChair.FieldName = "ChairName";
            this.colChair.MaxWidth = 100;
            this.colChair.Name = "colChair";
            this.colChair.OptionsColumn.AllowEdit = false;
            this.colChair.Visible = true;
            this.colChair.VisibleIndex = 2;
            this.colChair.Width = 56;
            // 
            // colAmount
            // 
            this.colAmount.Caption = "Tổng tiền";
            this.colAmount.DisplayFormat.FormatString = "n0";
            this.colAmount.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Custom;
            this.colAmount.FieldName = "Amount";
            this.colAmount.Name = "colAmount";
            this.colAmount.OptionsColumn.AllowEdit = false;
            this.colAmount.Visible = true;
            this.colAmount.VisibleIndex = 3;
            this.colAmount.Width = 160;
            // 
            // colTransactionDate
            // 
            this.colTransactionDate.Caption = "Ngày GD";
            this.colTransactionDate.DisplayFormat.FormatString = "HH:mm dd/MM/yyyy";
            this.colTransactionDate.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Custom;
            this.colTransactionDate.FieldName = "TransactionDate";
            this.colTransactionDate.MaxWidth = 240;
            this.colTransactionDate.Name = "colTransactionDate";
            this.colTransactionDate.OptionsColumn.AllowEdit = false;
            this.colTransactionDate.Visible = true;
            this.colTransactionDate.VisibleIndex = 4;
            this.colTransactionDate.Width = 144;
            // 
            // colStatus
            // 
            this.colStatus.Caption = "Tình trạng";
            this.colStatus.FieldName = "Status";
            this.colStatus.Name = "colStatus";
            this.colStatus.Visible = true;
            this.colStatus.VisibleIndex = 5;
            this.colStatus.Width = 150;
            // 
            // gridColumn6
            // 
            this.gridColumn6.Caption = "Dịch vụ";
            this.gridColumn6.FieldName = "Name";
            this.gridColumn6.Name = "gridColumn6";
            this.gridColumn6.OptionsColumn.AllowEdit = false;
            this.gridColumn6.Visible = true;
            this.gridColumn6.VisibleIndex = 0;
            this.gridColumn6.Width = 252;
            // 
            // gridColumn8
            // 
            this.gridColumn8.Caption = "Chiết khấu (thực hiện)";
            this.gridColumn8.FieldName = "ComMoney";
            this.gridColumn8.Name = "gridColumn8";
            this.gridColumn8.OptionsColumn.AllowEdit = false;
            this.gridColumn8.Visible = true;
            this.gridColumn8.VisibleIndex = 1;
            this.gridColumn8.Width = 199;
            // 
            // gridColumn10
            // 
            this.gridColumn10.Caption = "Số lần thực hiện";
            this.gridColumn10.FieldName = "MakeTimes";
            this.gridColumn10.Name = "gridColumn10";
            this.gridColumn10.OptionsColumn.AllowEdit = false;
            this.gridColumn10.Visible = true;
            this.gridColumn10.VisibleIndex = 2;
            this.gridColumn10.Width = 137;
            // 
            // gridColumn9
            // 
            this.gridColumn9.Caption = "Chiết khấu (tư vấn)";
            this.gridColumn9.FieldName = "SellComMoney";
            this.gridColumn9.Name = "gridColumn9";
            this.gridColumn9.OptionsColumn.AllowEdit = false;
            this.gridColumn9.Visible = true;
            this.gridColumn9.VisibleIndex = 3;
            this.gridColumn9.Width = 219;
            // 
            // gridColumn7
            // 
            this.gridColumn7.Caption = "Số lần tư vấn";
            this.gridColumn7.FieldName = "SellTimes";
            this.gridColumn7.Name = "gridColumn7";
            this.gridColumn7.Visible = true;
            this.gridColumn7.VisibleIndex = 4;
            this.gridColumn7.Width = 129;
            // 
            // HomeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1578, 805);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "HomeForm";
            this.Text = "Home";
            this.Load += new System.EventHandler(this.HomeForm_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gvSellTranMain)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvSellTran)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvMain)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvTransaction)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.FlowLayoutPanel panelDad;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private DevExpress.XtraGrid.GridControl gvSellTranMain;
        private DevExpress.XtraGrid.Views.Grid.GridView gvSellTran;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn12;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn13;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn14;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn15;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn16;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn17;
        private DevExpress.XtraGrid.GridControl gvMain;
        private DevExpress.XtraGrid.Views.Grid.GridView gvTransaction;
        private DevExpress.XtraGrid.Columns.GridColumn colTransactionId;
        private DevExpress.XtraGrid.Columns.GridColumn colTransactionIdCoded;
        private DevExpress.XtraGrid.Columns.GridColumn colCustomerName;
        private DevExpress.XtraGrid.Columns.GridColumn colChair;
        private DevExpress.XtraGrid.Columns.GridColumn colAmount;
        private DevExpress.XtraGrid.Columns.GridColumn colTransactionDate;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn6;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn8;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn10;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn9;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn7;
        private DevExpress.XtraGrid.Columns.GridColumn colStatus;
        private DevExpress.XtraGrid.Columns.GridColumn colTotalDiscount;


    }
}