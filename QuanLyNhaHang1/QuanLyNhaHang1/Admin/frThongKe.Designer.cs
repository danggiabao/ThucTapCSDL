namespace QuanLyNhaHang1
{
    partial class frThongKe
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
            System.Windows.Forms.ListViewItem listViewItem2 = new System.Windows.Forms.ListViewItem(new string[] {
            ""}, -1, System.Drawing.Color.Empty, System.Drawing.SystemColors.ControlLightLight, null);
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.listView1 = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mónĂnĐượcSửDụngNhiềuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mónĂnĐượcDùngNhiềuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.hóaĐơnThanhToánToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.hóaĐơnToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btnWord = new System.Windows.Forms.Button();
            this.btnExcel = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.label1.Location = new System.Drawing.Point(318, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(422, 29);
            this.label1.TabIndex = 1;
            this.label1.Text = "Thống kê món ăn được dùng nhiều";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.listView1);
            this.panel1.Location = new System.Drawing.Point(1, 76);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1070, 417);
            this.panel1.TabIndex = 2;
            // 
            // listView1
            // 
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4});
            this.listView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listView1.FullRowSelect = true;
            this.listView1.GridLines = true;
            this.listView1.Items.AddRange(new System.Windows.Forms.ListViewItem[] {
            listViewItem2});
            this.listView1.Location = new System.Drawing.Point(0, 0);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(1070, 417);
            this.listView1.TabIndex = 0;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "       Mã món ăn";
            this.columnHeader1.Width = 140;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Tên món ăn";
            this.columnHeader2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader2.Width = 250;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Nhóm món";
            this.columnHeader3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader3.Width = 250;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Đơn giá";
            this.columnHeader4.Width = 150;
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.mónĂnĐượcSửDụngNhiềuToolStripMenuItem,
            this.hóaĐơnToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1071, 28);
            this.menuStrip1.TabIndex = 3;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.saveToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(44, 24);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // saveToolStripMenuItem
            // 
            this.saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            this.saveToolStripMenuItem.Size = new System.Drawing.Size(115, 26);
            this.saveToolStripMenuItem.Text = "Save";
            // 
            // mónĂnĐượcSửDụngNhiềuToolStripMenuItem
            // 
            this.mónĂnĐượcSửDụngNhiềuToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mónĂnĐượcDùngNhiềuToolStripMenuItem,
            this.hóaĐơnThanhToánToolStripMenuItem});
            this.mónĂnĐượcSửDụngNhiềuToolStripMenuItem.Name = "mónĂnĐượcSửDụngNhiềuToolStripMenuItem";
            this.mónĂnĐượcSửDụngNhiềuToolStripMenuItem.Size = new System.Drawing.Size(53, 24);
            this.mónĂnĐượcSửDụngNhiềuToolStripMenuItem.Text = "View";
            // 
            // mónĂnĐượcDùngNhiềuToolStripMenuItem
            // 
            this.mónĂnĐượcDùngNhiềuToolStripMenuItem.Name = "mónĂnĐượcDùngNhiềuToolStripMenuItem";
            this.mónĂnĐượcDùngNhiềuToolStripMenuItem.Size = new System.Drawing.Size(250, 26);
            this.mónĂnĐượcDùngNhiềuToolStripMenuItem.Text = "Món ăn được dùng nhiều";
            // 
            // hóaĐơnThanhToánToolStripMenuItem
            // 
            this.hóaĐơnThanhToánToolStripMenuItem.Name = "hóaĐơnThanhToánToolStripMenuItem";
            this.hóaĐơnThanhToánToolStripMenuItem.Size = new System.Drawing.Size(250, 26);
            this.hóaĐơnThanhToánToolStripMenuItem.Text = "Hóa đơn thanh toán";
            // 
            // hóaĐơnToolStripMenuItem
            // 
            this.hóaĐơnToolStripMenuItem.Name = "hóaĐơnToolStripMenuItem";
            this.hóaĐơnToolStripMenuItem.Size = new System.Drawing.Size(53, 24);
            this.hóaĐơnToolStripMenuItem.Text = "Help";
            this.hóaĐơnToolStripMenuItem.Click += new System.EventHandler(this.hóaĐơnToolStripMenuItem_Click);
            // 
            // btnWord
            // 
            this.btnWord.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnWord.Image = global::QuanLyNhaHang1.Properties.Resources.excel;
            this.btnWord.Location = new System.Drawing.Point(597, 518);
            this.btnWord.Name = "btnWord";
            this.btnWord.Size = new System.Drawing.Size(64, 64);
            this.btnWord.TabIndex = 5;
            this.btnWord.UseVisualStyleBackColor = true;
            // 
            // btnExcel
            // 
            this.btnExcel.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExcel.Image = global::QuanLyNhaHang1.Properties.Resources.word__1_;
            this.btnExcel.Location = new System.Drawing.Point(407, 518);
            this.btnExcel.Name = "btnExcel";
            this.btnExcel.Size = new System.Drawing.Size(64, 64);
            this.btnExcel.TabIndex = 4;
            this.btnExcel.UseVisualStyleBackColor = true;
            // 
            // frThongKe
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1071, 604);
            this.Controls.Add(this.btnWord);
            this.Controls.Add(this.btnExcel);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "frThongKe";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Báo cáo - Thống kê";
            this.panel1.ResumeLayout(false);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mónĂnĐượcSửDụngNhiềuToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem hóaĐơnToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mónĂnĐượcDùngNhiềuToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem hóaĐơnThanhToánToolStripMenuItem;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.Button btnExcel;
        private System.Windows.Forms.Button btnWord;
    }
}