namespace QuanLyNhaHang1
{
    partial class frTrangchu2
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frTrangchu2));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnThongKe = new System.Windows.Forms.Button();
            this.btnTaiKhoan = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.label1.Location = new System.Drawing.Point(309, 82);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(451, 29);
            this.label1.TabIndex = 2;
            this.label1.Text = "CHƯƠNG TRÌNH QUẢN LÝ NHÀ HÀNG";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.label2.Location = new System.Drawing.Point(408, 214);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(274, 19);
            this.label2.TabIndex = 3;
            this.label2.Text = "XIN MỜI LỰA CHỌN CHỨC NĂNG";
            // 
            // btnThongKe
            // 
            this.btnThongKe.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.btnThongKe.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThongKe.ForeColor = System.Drawing.SystemColors.WindowText;
            this.btnThongKe.Location = new System.Drawing.Point(314, 314);
            this.btnThongKe.Name = "btnThongKe";
            this.btnThongKe.Size = new System.Drawing.Size(202, 45);
            this.btnThongKe.TabIndex = 5;
            this.btnThongKe.Text = "BÁO CÁO THỐNG KÊ";
            this.btnThongKe.UseVisualStyleBackColor = false;
            this.btnThongKe.Click += new System.EventHandler(this.btnThongKe_Click);
            // 
            // btnTaiKhoan
            // 
            this.btnTaiKhoan.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.btnTaiKhoan.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTaiKhoan.ForeColor = System.Drawing.SystemColors.WindowText;
            this.btnTaiKhoan.Location = new System.Drawing.Point(558, 314);
            this.btnTaiKhoan.Name = "btnTaiKhoan";
            this.btnTaiKhoan.Size = new System.Drawing.Size(202, 45);
            this.btnTaiKhoan.TabIndex = 8;
            this.btnTaiKhoan.Text = "QUẢN LÝ TÀI KHOẢN";
            this.btnTaiKhoan.UseVisualStyleBackColor = false;
            this.btnTaiKhoan.Click += new System.EventHandler(this.btnTaiKhoan_Click);
            // 
            // frTrangchu2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1071, 604);
            this.Controls.Add(this.btnTaiKhoan);
            this.Controls.Add(this.btnThongKe);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frTrangchu2";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Chương trình quản lý nhà hàng";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnThongKe;
        private System.Windows.Forms.Button btnTaiKhoan;
    }
}