namespace DuHair
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.ribbon = new DevExpress.XtraBars.Ribbon.RibbonControl();
            this.btnEmployee = new DevExpress.XtraBars.BarButtonItem();
            this.btnService = new DevExpress.XtraBars.BarButtonItem();
            this.btnMaterial = new DevExpress.XtraBars.BarButtonItem();
            this.btnStock = new DevExpress.XtraBars.BarButtonItem();
            this.btnCustomer = new DevExpress.XtraBars.BarButtonItem();
            this.btnSetting = new DevExpress.XtraBars.BarButtonItem();
            this.popupMenu1 = new DevExpress.XtraBars.PopupMenu(this.components);
            this.barButtonGroup1 = new DevExpress.XtraBars.BarButtonGroup();
            this.btnRestock = new DevExpress.XtraBars.BarButtonItem();
            this.btnStatistic = new DevExpress.XtraBars.BarButtonItem();
            this.btnSpend = new DevExpress.XtraBars.BarButtonItem();
            this.barSubItem1 = new DevExpress.XtraBars.BarSubItem();
            this.barButtonItem1 = new DevExpress.XtraBars.BarButtonItem();
            this.barSubItem2 = new DevExpress.XtraBars.BarSubItem();
            this.barButtonItem2 = new DevExpress.XtraBars.BarButtonItem();
            this.btnSetting2 = new DevExpress.XtraBars.BarSubItem();
            this.btnChangePw = new DevExpress.XtraBars.BarButtonItem();
            this.btnTimeKeeping = new DevExpress.XtraBars.BarButtonItem();
            this.btnHome = new DevExpress.XtraBars.BarSubItem();
            this.barButtonItem3 = new DevExpress.XtraBars.BarButtonItem();
            this.ribbonPage1 = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPageGroup1 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPageGroup2 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonStatusBar = new DevExpress.XtraBars.Ribbon.RibbonStatusBar();
            this.mdiManager = new DevExpress.XtraTabbedMdi.XtraTabbedMdiManager(this.components);
            this.defaultLookAndFeel1 = new DevExpress.LookAndFeel.DefaultLookAndFeel(this.components);
            this.lbStatus = new DevExpress.XtraEditors.LabelControl();
            this.picStatus = new DevExpress.XtraEditors.PictureEdit();
            ((System.ComponentModel.ISupportInitialize)(this.ribbon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.popupMenu1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mdiManager)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picStatus.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // ribbon
            // 
            this.ribbon.AllowMdiChildButtons = false;
            this.ribbon.ExpandCollapseItem.Id = 0;
            this.ribbon.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.ribbon.ExpandCollapseItem,
            this.btnEmployee,
            this.btnService,
            this.btnMaterial,
            this.btnStock,
            this.btnCustomer,
            this.btnSetting,
            this.barButtonGroup1,
            this.btnRestock,
            this.btnStatistic,
            this.btnSpend,
            this.barSubItem1,
            this.barButtonItem1,
            this.barSubItem2,
            this.barButtonItem2,
            this.btnSetting2,
            this.btnChangePw,
            this.btnTimeKeeping,
            this.btnHome,
            this.barButtonItem3});
            this.ribbon.Location = new System.Drawing.Point(0, 0);
            this.ribbon.Margin = new System.Windows.Forms.Padding(0);
            this.ribbon.MaxItemId = 23;
            this.ribbon.Name = "ribbon";
            this.ribbon.Pages.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPage[] {
            this.ribbonPage1});
            this.ribbon.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonControlStyle.MacOffice;
            this.ribbon.ShowCategoryInCaption = false;
            this.ribbon.ShowFullScreenButton = DevExpress.Utils.DefaultBoolean.False;
            this.ribbon.ShowPageHeadersMode = DevExpress.XtraBars.Ribbon.ShowPageHeadersMode.Hide;
            this.ribbon.ShowToolbarCustomizeItem = false;
            this.ribbon.Size = new System.Drawing.Size(796, 113);
            this.ribbon.StatusBar = this.ribbonStatusBar;
            this.ribbon.Toolbar.ShowCustomizeItem = false;
            this.ribbon.ToolbarLocation = DevExpress.XtraBars.Ribbon.RibbonQuickAccessToolbarLocation.Above;
            // 
            // btnEmployee
            // 
            this.btnEmployee.Caption = "Nhân viên";
            this.btnEmployee.Glyph = ((System.Drawing.Image)(resources.GetObject("btnEmployee.Glyph")));
            this.btnEmployee.Id = 1;
            this.btnEmployee.LargeGlyph = ((System.Drawing.Image)(resources.GetObject("btnEmployee.LargeGlyph")));
            this.btnEmployee.Name = "btnEmployee";
            this.btnEmployee.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnEmployee_ItemClick);
            // 
            // btnService
            // 
            this.btnService.Caption = "Dịch vụ";
            this.btnService.Glyph = ((System.Drawing.Image)(resources.GetObject("btnService.Glyph")));
            this.btnService.Id = 5;
            this.btnService.LargeGlyph = ((System.Drawing.Image)(resources.GetObject("btnService.LargeGlyph")));
            this.btnService.Name = "btnService";
            this.btnService.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnService_ItemClick);
            // 
            // btnMaterial
            // 
            this.btnMaterial.Caption = "Nguyên liệu";
            this.btnMaterial.Glyph = ((System.Drawing.Image)(resources.GetObject("btnMaterial.Glyph")));
            this.btnMaterial.Id = 6;
            this.btnMaterial.LargeGlyph = ((System.Drawing.Image)(resources.GetObject("btnMaterial.LargeGlyph")));
            this.btnMaterial.Name = "btnMaterial";
            this.btnMaterial.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnMaterial_ItemClick);
            // 
            // btnStock
            // 
            this.btnStock.Caption = "Kho";
            this.btnStock.Glyph = ((System.Drawing.Image)(resources.GetObject("btnStock.Glyph")));
            this.btnStock.Id = 7;
            this.btnStock.LargeGlyph = ((System.Drawing.Image)(resources.GetObject("btnStock.LargeGlyph")));
            this.btnStock.Name = "btnStock";
            this.btnStock.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnStock_ItemClick);
            // 
            // btnCustomer
            // 
            this.btnCustomer.Caption = "Khách";
            this.btnCustomer.Glyph = ((System.Drawing.Image)(resources.GetObject("btnCustomer.Glyph")));
            this.btnCustomer.Id = 8;
            this.btnCustomer.LargeGlyph = ((System.Drawing.Image)(resources.GetObject("btnCustomer.LargeGlyph")));
            this.btnCustomer.Name = "btnCustomer";
            this.btnCustomer.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnCustomer_ItemClick);
            // 
            // btnSetting
            // 
            this.btnSetting.ActAsDropDown = true;
            this.btnSetting.ButtonStyle = DevExpress.XtraBars.BarButtonStyle.DropDown;
            this.btnSetting.Caption = "Cài đặt";
            this.btnSetting.DropDownControl = this.popupMenu1;
            this.btnSetting.Glyph = ((System.Drawing.Image)(resources.GetObject("btnSetting.Glyph")));
            this.btnSetting.Id = 9;
            this.btnSetting.LargeGlyph = ((System.Drawing.Image)(resources.GetObject("btnSetting.LargeGlyph")));
            this.btnSetting.Name = "btnSetting";
            // 
            // popupMenu1
            // 
            this.popupMenu1.Name = "popupMenu1";
            this.popupMenu1.Ribbon = this.ribbon;
            // 
            // barButtonGroup1
            // 
            this.barButtonGroup1.Caption = "barButtonGroup1";
            this.barButtonGroup1.Id = 10;
            this.barButtonGroup1.Name = "barButtonGroup1";
            // 
            // btnRestock
            // 
            this.btnRestock.Caption = "Nhập kho";
            this.btnRestock.Glyph = ((System.Drawing.Image)(resources.GetObject("btnRestock.Glyph")));
            this.btnRestock.Id = 11;
            this.btnRestock.LargeGlyph = ((System.Drawing.Image)(resources.GetObject("btnRestock.LargeGlyph")));
            this.btnRestock.Name = "btnRestock";
            this.btnRestock.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnRestock_ItemClick);
            // 
            // btnStatistic
            // 
            this.btnStatistic.Caption = "Thống kê";
            this.btnStatistic.Glyph = ((System.Drawing.Image)(resources.GetObject("btnStatistic.Glyph")));
            this.btnStatistic.Id = 12;
            this.btnStatistic.LargeGlyph = ((System.Drawing.Image)(resources.GetObject("btnStatistic.LargeGlyph")));
            this.btnStatistic.Name = "btnStatistic";
            this.btnStatistic.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnStatistic_ItemClick);
            // 
            // btnSpend
            // 
            this.btnSpend.Caption = "Khoản chi";
            this.btnSpend.Glyph = ((System.Drawing.Image)(resources.GetObject("btnSpend.Glyph")));
            this.btnSpend.Id = 13;
            this.btnSpend.LargeGlyph = ((System.Drawing.Image)(resources.GetObject("btnSpend.LargeGlyph")));
            this.btnSpend.Name = "btnSpend";
            this.btnSpend.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnSpend_ItemClick);
            // 
            // barSubItem1
            // 
            this.barSubItem1.Caption = "barSubItem1";
            this.barSubItem1.Id = 14;
            this.barSubItem1.Name = "barSubItem1";
            // 
            // barButtonItem1
            // 
            this.barButtonItem1.Caption = "barButtonItem1";
            this.barButtonItem1.Id = 15;
            this.barButtonItem1.Name = "barButtonItem1";
            // 
            // barSubItem2
            // 
            this.barSubItem2.Caption = "barSubItem2";
            this.barSubItem2.Id = 16;
            this.barSubItem2.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(this.barButtonItem2)});
            this.barSubItem2.Name = "barSubItem2";
            // 
            // barButtonItem2
            // 
            this.barButtonItem2.Caption = "barButtonItem2";
            this.barButtonItem2.Id = 17;
            this.barButtonItem2.Name = "barButtonItem2";
            // 
            // btnSetting2
            // 
            this.btnSetting2.Caption = "Cài đặt";
            this.btnSetting2.Glyph = ((System.Drawing.Image)(resources.GetObject("btnSetting2.Glyph")));
            this.btnSetting2.Id = 18;
            this.btnSetting2.LargeGlyph = ((System.Drawing.Image)(resources.GetObject("btnSetting2.LargeGlyph")));
            this.btnSetting2.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(this.btnChangePw)});
            this.btnSetting2.Name = "btnSetting2";
            // 
            // btnChangePw
            // 
            this.btnChangePw.Caption = "Đổi mật khẩu";
            this.btnChangePw.Glyph = ((System.Drawing.Image)(resources.GetObject("btnChangePw.Glyph")));
            this.btnChangePw.Id = 19;
            this.btnChangePw.LargeGlyph = ((System.Drawing.Image)(resources.GetObject("btnChangePw.LargeGlyph")));
            this.btnChangePw.Name = "btnChangePw";
            this.btnChangePw.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnChangePw_ItemClick);
            // 
            // btnTimeKeeping
            // 
            this.btnTimeKeeping.Caption = "Chấm công";
            this.btnTimeKeeping.Glyph = ((System.Drawing.Image)(resources.GetObject("btnTimeKeeping.Glyph")));
            this.btnTimeKeeping.Id = 20;
            this.btnTimeKeeping.LargeGlyph = ((System.Drawing.Image)(resources.GetObject("btnTimeKeeping.LargeGlyph")));
            this.btnTimeKeeping.Name = "btnTimeKeeping";
            this.btnTimeKeeping.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnTimeKeeping_ItemClick);
            // 
            // btnHome
            // 
            this.btnHome.Caption = "Home";
            this.btnHome.Glyph = ((System.Drawing.Image)(resources.GetObject("btnHome.Glyph")));
            this.btnHome.Id = 21;
            this.btnHome.LargeGlyph = ((System.Drawing.Image)(resources.GetObject("btnHome.LargeGlyph")));
            this.btnHome.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(this.barButtonItem3)});
            this.btnHome.Name = "btnHome";
            this.btnHome.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnHome_ItemClick);
            // 
            // barButtonItem3
            // 
            this.barButtonItem3.Caption = "Bán sản phẩm";
            this.barButtonItem3.Glyph = ((System.Drawing.Image)(resources.GetObject("barButtonItem3.Glyph")));
            this.barButtonItem3.Id = 22;
            this.barButtonItem3.LargeGlyph = ((System.Drawing.Image)(resources.GetObject("barButtonItem3.LargeGlyph")));
            this.barButtonItem3.Name = "barButtonItem3";
            this.barButtonItem3.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barButtonItem3_ItemClick);
            // 
            // ribbonPage1
            // 
            this.ribbonPage1.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.ribbonPageGroup1,
            this.ribbonPageGroup2});
            this.ribbonPage1.Name = "ribbonPage1";
            this.ribbonPage1.Text = "ribbonPage1";
            // 
            // ribbonPageGroup1
            // 
            this.ribbonPageGroup1.AllowMinimize = false;
            this.ribbonPageGroup1.AllowTextClipping = false;
            this.ribbonPageGroup1.ItemLinks.Add(this.btnHome);
            this.ribbonPageGroup1.ItemLinks.Add(this.btnEmployee);
            this.ribbonPageGroup1.ItemLinks.Add(this.btnCustomer);
            this.ribbonPageGroup1.ItemLinks.Add(this.btnService);
            this.ribbonPageGroup1.ItemLinks.Add(this.btnMaterial);
            this.ribbonPageGroup1.ItemLinks.Add(this.btnStock);
            this.ribbonPageGroup1.ItemLinks.Add(this.btnRestock);
            this.ribbonPageGroup1.ItemLinks.Add(this.btnSpend);
            this.ribbonPageGroup1.ItemLinks.Add(this.btnTimeKeeping);
            this.ribbonPageGroup1.ItemLinks.Add(this.btnStatistic);
            this.ribbonPageGroup1.Name = "ribbonPageGroup1";
            this.ribbonPageGroup1.ShowCaptionButton = false;
            // 
            // ribbonPageGroup2
            // 
            this.ribbonPageGroup2.AllowMinimize = false;
            this.ribbonPageGroup2.AllowTextClipping = false;
            this.ribbonPageGroup2.ItemLinks.Add(this.btnSetting2);
            this.ribbonPageGroup2.Name = "ribbonPageGroup2";
            this.ribbonPageGroup2.ShowCaptionButton = false;
            // 
            // ribbonStatusBar
            // 
            this.ribbonStatusBar.Location = new System.Drawing.Point(0, 524);
            this.ribbonStatusBar.Margin = new System.Windows.Forms.Padding(2);
            this.ribbonStatusBar.Name = "ribbonStatusBar";
            this.ribbonStatusBar.Ribbon = this.ribbon;
            this.ribbonStatusBar.Size = new System.Drawing.Size(796, 23);
            // 
            // mdiManager
            // 
            this.mdiManager.MdiParent = this;
            // 
            // defaultLookAndFeel1
            // 
            this.defaultLookAndFeel1.LookAndFeel.SkinName = "Office 2013 Dark Gray";
            // 
            // lbStatus
            // 
            this.lbStatus.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lbStatus.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.lbStatus.Appearance.ForeColor = System.Drawing.Color.White;
            this.lbStatus.Appearance.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lbStatus.Location = new System.Drawing.Point(29, 530);
            this.lbStatus.Margin = new System.Windows.Forms.Padding(2);
            this.lbStatus.Name = "lbStatus";
            this.lbStatus.Size = new System.Drawing.Size(0, 13);
            this.lbStatus.TabIndex = 6;
            // 
            // picStatus
            // 
            this.picStatus.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.picStatus.Location = new System.Drawing.Point(5, 528);
            this.picStatus.Margin = new System.Windows.Forms.Padding(2);
            this.picStatus.MenuManager = this.ribbon;
            this.picStatus.Name = "picStatus";
            this.picStatus.Properties.AllowFocused = false;
            this.picStatus.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.picStatus.Properties.Appearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.picStatus.Properties.Appearance.Options.UseBackColor = true;
            this.picStatus.Properties.Appearance.Options.UseBorderColor = true;
            this.picStatus.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.picStatus.Size = new System.Drawing.Size(20, 18);
            this.picStatus.TabIndex = 9;
            // 
            // MainForm
            // 
            this.Appearance.BackColor = System.Drawing.SystemColors.Control;
            this.Appearance.Options.UseBackColor = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(796, 547);
            this.Controls.Add(this.picStatus);
            this.Controls.Add(this.lbStatus);
            this.Controls.Add(this.ribbonStatusBar);
            this.Controls.Add(this.ribbon);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.IsMdiContainer = true;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "MainForm";
            this.Ribbon = this.ribbon;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.StatusBar = this.ribbonStatusBar;
            this.Text = "Du Salon";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainForm_FormClosing);
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.MainForm_FormClosed);
            this.Load += new System.EventHandler(this.MainForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ribbon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.popupMenu1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mdiManager)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picStatus.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraBars.Ribbon.RibbonControl ribbon;
        private DevExpress.XtraBars.Ribbon.RibbonPage ribbonPage1;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup1;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup2;
        private DevExpress.XtraBars.Ribbon.RibbonStatusBar ribbonStatusBar;
        private DevExpress.XtraBars.BarButtonItem btnEmployee;
        private DevExpress.XtraTabbedMdi.XtraTabbedMdiManager mdiManager;
        private DevExpress.XtraBars.BarButtonItem btnService;
        private DevExpress.XtraBars.BarButtonItem btnMaterial;
        private DevExpress.XtraBars.BarButtonItem btnStock;
        private DevExpress.XtraBars.BarButtonItem btnCustomer;
        private DevExpress.LookAndFeel.DefaultLookAndFeel defaultLookAndFeel1;
        private DevExpress.XtraBars.BarButtonItem btnSetting;
        private DevExpress.XtraBars.BarButtonGroup barButtonGroup1;
        private DevExpress.XtraBars.BarButtonItem btnRestock;
        private DevExpress.XtraBars.BarButtonItem btnStatistic;
        private DevExpress.XtraBars.BarButtonItem btnSpend;
        public DevExpress.XtraEditors.LabelControl lbStatus;
        public DevExpress.XtraEditors.PictureEdit picStatus;
        private DevExpress.XtraBars.PopupMenu popupMenu1;
        private DevExpress.XtraBars.BarSubItem barSubItem1;
        private DevExpress.XtraBars.BarButtonItem barButtonItem1;
        private DevExpress.XtraBars.BarSubItem barSubItem2;
        private DevExpress.XtraBars.BarButtonItem barButtonItem2;
        private DevExpress.XtraBars.BarSubItem btnSetting2;
        private DevExpress.XtraBars.BarButtonItem btnChangePw;
        private DevExpress.XtraBars.BarButtonItem btnTimeKeeping;
        private DevExpress.XtraBars.BarSubItem btnHome;
        private DevExpress.XtraBars.BarButtonItem barButtonItem3;
    }
}