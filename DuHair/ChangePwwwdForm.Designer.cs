namespace DuHair
{
    partial class ChangePwwwdForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ChangePwwwdForm));
            this.btnSubmit = new DevExpress.XtraEditors.SimpleButton();
            this.lblError = new DevExpress.XtraEditors.LabelControl();
            this.label6 = new System.Windows.Forms.Label();
            this.txtReNewPass = new DevExpress.XtraEditors.TextEdit();
            this.label7 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtNewPass = new DevExpress.XtraEditors.TextEdit();
            this.label4 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.txtOldPass = new DevExpress.XtraEditors.TextEdit();
            this.label5 = new System.Windows.Forms.Label();
            this.tmError = new System.Windows.Forms.Timer(this.components);
            this.btnClose = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.txtReNewPass.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtNewPass.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtOldPass.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // btnSubmit
            // 
            this.btnSubmit.Cursor = System.Windows.Forms.Cursors.Default;
            this.btnSubmit.Image = ((System.Drawing.Image)(resources.GetObject("btnSubmit.Image")));
            this.btnSubmit.Location = new System.Drawing.Point(260, 84);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(77, 27);
            this.btnSubmit.TabIndex = 80;
            this.btnSubmit.Text = "Lưu";
            this.btnSubmit.Click += new System.EventHandler(this.btnSubmit_Click);
            // 
            // lblError
            // 
            this.lblError.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblError.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblError.Appearance.ForeColor = System.Drawing.Color.Red;
            this.lblError.Appearance.Image = global::DuHair.Properties.Resources.busy;
            this.lblError.Appearance.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblError.ImageAlignToText = DevExpress.XtraEditors.ImageAlignToText.LeftCenter;
            this.lblError.Location = new System.Drawing.Point(16, 91);
            this.lblError.Name = "lblError";
            this.lblError.Size = new System.Drawing.Size(133, 20);
            this.lblError.TabIndex = 79;
            this.lblError.Text = "(*) Bắt buộc phải có";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.ForeColor = System.Drawing.Color.Red;
            this.label6.Location = new System.Drawing.Point(412, 61);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(13, 13);
            this.label6.TabIndex = 78;
            this.label6.Text = "*";
            // 
            // txtReNewPass
            // 
            this.txtReNewPass.Location = new System.Drawing.Point(81, 59);
            this.txtReNewPass.Name = "txtReNewPass";
            this.txtReNewPass.Properties.PasswordChar = '*';
            this.txtReNewPass.Size = new System.Drawing.Size(325, 20);
            this.txtReNewPass.TabIndex = 77;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(27, 61);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(51, 13);
            this.label7.TabIndex = 76;
            this.label7.Text = "Xác nhận";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.Red;
            this.label3.Location = new System.Drawing.Point(412, 37);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(13, 13);
            this.label3.TabIndex = 75;
            this.label3.Text = "*";
            // 
            // txtNewPass
            // 
            this.txtNewPass.Location = new System.Drawing.Point(81, 36);
            this.txtNewPass.Name = "txtNewPass";
            this.txtNewPass.Properties.PasswordChar = '*';
            this.txtNewPass.Size = new System.Drawing.Size(325, 20);
            this.txtNewPass.TabIndex = 74;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 37);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(70, 13);
            this.label4.TabIndex = 73;
            this.label4.Text = "Mật khẩu mới";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.ForeColor = System.Drawing.Color.Red;
            this.label11.Location = new System.Drawing.Point(412, 13);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(13, 13);
            this.label11.TabIndex = 69;
            this.label11.Text = "*";
            // 
            // txtOldPass
            // 
            this.txtOldPass.Location = new System.Drawing.Point(81, 12);
            this.txtOldPass.Name = "txtOldPass";
            this.txtOldPass.Properties.PasswordChar = '*';
            this.txtOldPass.Size = new System.Drawing.Size(325, 20);
            this.txtOldPass.TabIndex = 68;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(27, 13);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(51, 13);
            this.label5.TabIndex = 67;
            this.label5.Text = "Mật khẩu";
            // 
            // tmError
            // 
            this.tmError.Tick += new System.EventHandler(this.tmError_Tick);
            // 
            // btnClose
            // 
            this.btnClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnClose.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnClose.Image = ((System.Drawing.Image)(resources.GetObject("btnClose.Image")));
            this.btnClose.Location = new System.Drawing.Point(342, 84);
            this.btnClose.Margin = new System.Windows.Forms.Padding(2);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(64, 27);
            this.btnClose.TabIndex = 81;
            this.btnClose.Text = "Đóng";
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // ChangePwwwdForm
            // 
            this.AcceptButton = this.btnSubmit;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnClose;
            this.ClientSize = new System.Drawing.Size(429, 120);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnSubmit);
            this.Controls.Add(this.lblError);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtReNewPass);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtNewPass);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.txtOldPass);
            this.Controls.Add(this.label5);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "ChangePwwwdForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Đổi mật khẩu";
            ((System.ComponentModel.ISupportInitialize)(this.txtReNewPass.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtNewPass.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtOldPass.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.SimpleButton btnSubmit;
        private DevExpress.XtraEditors.LabelControl lblError;
        private System.Windows.Forms.Label label6;
        private DevExpress.XtraEditors.TextEdit txtReNewPass;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label3;
        private DevExpress.XtraEditors.TextEdit txtNewPass;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label11;
        private DevExpress.XtraEditors.TextEdit txtOldPass;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Timer tmError;
        private DevExpress.XtraEditors.SimpleButton btnClose;
    }
}