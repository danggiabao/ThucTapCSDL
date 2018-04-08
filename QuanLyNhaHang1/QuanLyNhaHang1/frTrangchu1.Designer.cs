namespace QuanLyNhaHang1
{
    partial class frTrangchu1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frTrangchu1));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnKhachHang = new System.Windows.Forms.Button();
            this.btnThanhToan = new System.Windows.Forms.Button();
            this.btnTaiKhoan = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.label1.Location = new System.Drawing.Point(325, 94);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(451, 29);
            this.label1.TabIndex = 1;
            this.label1.Text = "CHƯƠNG TRÌNH QUẢN LÝ NHÀ HÀNG";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.label2.Location = new System.Drawing.Point(405, 224);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(274, 19);
            this.label2.TabIndex = 2;
            this.label2.Text = "XIN MỜI LỰA CHỌN CHỨC NĂNG";
            // 
            // btnKhachHang
            // 
            this.btnKhachHang.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.btnKhachHang.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnKhachHang.ForeColor = System.Drawing.SystemColors.WindowText;
            this.btnKhachHang.Location = new System.Drawing.Point(433, 332);
            this.btnKhachHang.Name = "btnKhachHang";
            this.btnKhachHang.Size = new System.Drawing.Size(202, 45);
            this.btnKhachHang.TabIndex = 3;
            this.btnKhachHang.Text = "PHỤC VỤ KHÁCH HÀNG";
            this.btnKhachHang.UseVisualStyleBackColor = false;
            this.btnKhachHang.Click += new System.EventHandler(this.btnKhachHang_Click);
            // 
            // btnThanhToan
            // 
            this.btnThanhToan.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.btnThanhToan.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThanhToan.Location = new System.Drawing.Point(149, 332);
            this.btnThanhToan.Name = "btnThanhToan";
            this.btnThanhToan.Size = new System.Drawing.Size(204, 45);
            this.btnThanhToan.TabIndex = 7;
            this.btnThanhToan.Text = "QUẢN LÝ HÓA ĐƠN";
            this.btnThanhToan.UseVisualStyleBackColor = false;
            this.btnThanhToan.Click += new System.EventHandler(this.btnThanhToan_Click);
            // 
            // btnTaiKhoan
            // 
            this.btnTaiKhoan.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.btnTaiKhoan.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTaiKhoan.ForeColor = System.Drawing.SystemColors.WindowText;
            this.btnTaiKhoan.Location = new System.Drawing.Point(711, 332);
            this.btnTaiKhoan.Name = "btnTaiKhoan";
            this.btnTaiKhoan.Size = new System.Drawing.Size(202, 45);
            this.btnTaiKhoan.TabIndex = 8;
            this.btnTaiKhoan.Text = "QUẢN LÝ TÀI KHOẢN";
            this.btnTaiKhoan.UseVisualStyleBackColor = false;
            this.btnTaiKhoan.Click += new System.EventHandler(this.btnTaiKhoan_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnTaiKhoan);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.btnThanhToan);
            this.panel1.Controls.Add(this.btnKhachHang);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1071, 604);
            this.panel1.TabIndex = 9;
            // 
            // frTrangchu1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1071, 604);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frTrangchu1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Chương trình quản lý nhà hàng";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnKhachHang;
        private System.Windows.Forms.Button btnThanhToan;
        private System.Windows.Forms.Button btnTaiKhoan;
        private System.Windows.Forms.Panel panel1;
    }
}