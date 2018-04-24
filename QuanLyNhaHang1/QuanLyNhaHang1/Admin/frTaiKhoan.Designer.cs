namespace QuanLyNhaHang1
{
    partial class frTaiKhoan
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
            this.label6 = new System.Windows.Forms.Label();
            this.txtbUsername = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txbPassword = new System.Windows.Forms.TextBox();
            this.txbCfPass = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnCapnhat = new System.Windows.Forms.Button();
            this.cb_showPass = new System.Windows.Forms.CheckBox();
            this.btnHuy = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Cambria", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(230, 139);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(135, 22);
            this.label6.TabIndex = 2;
            this.label6.Text = "Tên đăng nhập";
            // 
            // txtbUsername
            // 
            this.txtbUsername.Location = new System.Drawing.Point(429, 139);
            this.txtbUsername.Name = "txtbUsername";
            this.txtbUsername.ReadOnly = true;
            this.txtbUsername.Size = new System.Drawing.Size(288, 22);
            this.txtbUsername.TabIndex = 20;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Cambria", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(230, 235);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(130, 22);
            this.label7.TabIndex = 7;
            this.label7.Text = "Mật khẩu mới";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Cambria", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(230, 334);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(166, 22);
            this.label1.TabIndex = 8;
            this.label1.Text = "Nhập lại mật khẩu";
            // 
            // txbPassword
            // 
            this.txbPassword.Location = new System.Drawing.Point(429, 235);
            this.txbPassword.Name = "txbPassword";
            this.txbPassword.Size = new System.Drawing.Size(288, 22);
            this.txbPassword.TabIndex = 9;
            this.txbPassword.UseSystemPasswordChar = true;
            // 
            // txbCfPass
            // 
            this.txbCfPass.Location = new System.Drawing.Point(429, 335);
            this.txbCfPass.Name = "txbCfPass";
            this.txbCfPass.Size = new System.Drawing.Size(288, 22);
            this.txbCfPass.TabIndex = 10;
            this.txbCfPass.UseSystemPasswordChar = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Cambria", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(423, 41);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(268, 33);
            this.label2.TabIndex = 11;
            this.label2.Text = "Thông tin tài khoản";
            // 
            // btnCapnhat
            // 
            this.btnCapnhat.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnCapnhat.Font = new System.Drawing.Font("Cambria", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCapnhat.Location = new System.Drawing.Point(429, 484);
            this.btnCapnhat.Name = "btnCapnhat";
            this.btnCapnhat.Size = new System.Drawing.Size(130, 41);
            this.btnCapnhat.TabIndex = 12;
            this.btnCapnhat.Text = "Cập nhật";
            this.btnCapnhat.UseVisualStyleBackColor = true;
            this.btnCapnhat.Click += new System.EventHandler(this.btnCapnhat_Click);
            // 
            // cb_showPass
            // 
            this.cb_showPass.AutoSize = true;
            this.cb_showPass.Font = new System.Drawing.Font("Cambria", 10.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cb_showPass.Location = new System.Drawing.Point(429, 401);
            this.cb_showPass.Name = "cb_showPass";
            this.cb_showPass.Size = new System.Drawing.Size(169, 24);
            this.cb_showPass.TabIndex = 14;
            this.cb_showPass.Text = "Hiển thị mật khẩu";
            this.cb_showPass.UseVisualStyleBackColor = true;
            this.cb_showPass.CheckedChanged += new System.EventHandler(this.cb_showPass_CheckedChanged);
            // 
            // btnHuy
            // 
            this.btnHuy.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnHuy.Font = new System.Drawing.Font("Cambria", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHuy.Location = new System.Drawing.Point(587, 484);
            this.btnHuy.Name = "btnHuy";
            this.btnHuy.Size = new System.Drawing.Size(130, 41);
            this.btnHuy.TabIndex = 21;
            this.btnHuy.Text = "Hủy bỏ";
            this.btnHuy.UseVisualStyleBackColor = true;
            // 
            // frTaiKhoan
            // 
            this.AcceptButton = this.btnCapnhat;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.CornflowerBlue;
            this.CancelButton = this.btnHuy;
            this.ClientSize = new System.Drawing.Size(1071, 604);
            this.Controls.Add(this.btnHuy);
            this.Controls.Add(this.cb_showPass);
            this.Controls.Add(this.btnCapnhat);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txbCfPass);
            this.Controls.Add(this.txbPassword);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtbUsername);
            this.Controls.Add(this.label6);
            this.Name = "frTaiKhoan";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Thông tin tài khoản";
            this.Load += new System.EventHandler(this.frTaiKhoan_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtbUsername;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txbPassword;
        private System.Windows.Forms.TextBox txbCfPass;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnCapnhat;
        private System.Windows.Forms.CheckBox cb_showPass;
        private System.Windows.Forms.Button btnHuy;
    }
}