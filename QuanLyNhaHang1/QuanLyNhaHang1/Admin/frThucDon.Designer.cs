namespace QuanLyNhaHang1
{
    partial class frThucDon
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
            this.lvThucDon = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.label1 = new System.Windows.Forms.Label();
            this.txtmamon = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.cbbNM = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txttenmon = new System.Windows.Forms.TextBox();
            this.txtdongia = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btnThemMon = new System.Windows.Forms.Button();
            this.btnXoaMon = new System.Windows.Forms.Button();
            this.btnSuaMon = new System.Windows.Forms.Button();
            this.searchbox1 = new System.Windows.Forms.TextBox();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.btnlammoi = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnlm = new System.Windows.Forms.Button();
            this.btnXoaNM = new System.Windows.Forms.Button();
            this.btnSuaNM = new System.Windows.Forms.Button();
            this.btnThemNM = new System.Windows.Forms.Button();
            this.txttennma = new System.Windows.Forms.TextBox();
            this.txtmanma = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lvNhomMon = new System.Windows.Forms.ListView();
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader6 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lvThucDon
            // 
            this.lvThucDon.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4});
            this.lvThucDon.FullRowSelect = true;
            this.lvThucDon.GridLines = true;
            this.lvThucDon.Location = new System.Drawing.Point(4, 23);
            this.lvThucDon.Margin = new System.Windows.Forms.Padding(2);
            this.lvThucDon.Name = "lvThucDon";
            this.lvThucDon.Size = new System.Drawing.Size(804, 303);
            this.lvThucDon.TabIndex = 1;
            this.lvThucDon.UseCompatibleStateImageBehavior = false;
            this.lvThucDon.View = System.Windows.Forms.View.Details;
            this.lvThucDon.SelectedIndexChanged += new System.EventHandler(this.lvThucDon_SelectedIndexChanged);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Mã món";
            this.columnHeader1.Width = 100;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Tên món ăn";
            this.columnHeader2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader2.Width = 200;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Đơn giá";
            this.columnHeader3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader3.Width = 150;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Nhóm món";
            this.columnHeader4.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader4.Width = 200;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(17, 356);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 15);
            this.label1.TabIndex = 2;
            this.label1.Text = "Mã món";
            // 
            // txtmamon
            // 
            this.txtmamon.Location = new System.Drawing.Point(98, 354);
            this.txtmamon.Margin = new System.Windows.Forms.Padding(2);
            this.txtmamon.Name = "txtmamon";
            this.txtmamon.Size = new System.Drawing.Size(174, 21);
            this.txtmamon.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(17, 410);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(68, 15);
            this.label4.TabIndex = 7;
            this.label4.Text = "Nhóm món";
            // 
            // cbbNM
            // 
            this.cbbNM.FormattingEnabled = true;
            this.cbbNM.Location = new System.Drawing.Point(98, 409);
            this.cbbNM.Margin = new System.Windows.Forms.Padding(2);
            this.cbbNM.Name = "cbbNM";
            this.cbbNM.Size = new System.Drawing.Size(174, 23);
            this.cbbNM.TabIndex = 13;
            this.cbbNM.SelectedIndexChanged += new System.EventHandler(this.cbbNM_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(305, 356);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(73, 15);
            this.label2.TabIndex = 14;
            this.label2.Text = "Tên món ăn";
            // 
            // txttenmon
            // 
            this.txttenmon.Location = new System.Drawing.Point(388, 354);
            this.txttenmon.Margin = new System.Windows.Forms.Padding(2);
            this.txttenmon.Name = "txttenmon";
            this.txttenmon.Size = new System.Drawing.Size(174, 21);
            this.txttenmon.TabIndex = 15;
            // 
            // txtdongia
            // 
            this.txtdongia.Location = new System.Drawing.Point(388, 407);
            this.txtdongia.Margin = new System.Windows.Forms.Padding(2);
            this.txtdongia.Name = "txtdongia";
            this.txtdongia.Size = new System.Drawing.Size(174, 21);
            this.txtdongia.TabIndex = 16;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(305, 409);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(52, 15);
            this.label3.TabIndex = 17;
            this.label3.Text = "Đơn giá";
            // 
            // btnThemMon
            // 
            this.btnThemMon.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThemMon.Location = new System.Drawing.Point(604, 352);
            this.btnThemMon.Margin = new System.Windows.Forms.Padding(2);
            this.btnThemMon.Name = "btnThemMon";
            this.btnThemMon.Size = new System.Drawing.Size(70, 27);
            this.btnThemMon.TabIndex = 18;
            this.btnThemMon.Text = "Thêm";
            this.btnThemMon.UseVisualStyleBackColor = true;
            this.btnThemMon.Click += new System.EventHandler(this.btnThemMon_Click);
            // 
            // btnXoaMon
            // 
            this.btnXoaMon.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXoaMon.Location = new System.Drawing.Point(604, 403);
            this.btnXoaMon.Margin = new System.Windows.Forms.Padding(2);
            this.btnXoaMon.Name = "btnXoaMon";
            this.btnXoaMon.Size = new System.Drawing.Size(70, 27);
            this.btnXoaMon.TabIndex = 19;
            this.btnXoaMon.Text = "Xóa";
            this.btnXoaMon.UseVisualStyleBackColor = true;
            this.btnXoaMon.Click += new System.EventHandler(this.btnXoaMon_Click);
            // 
            // btnSuaMon
            // 
            this.btnSuaMon.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSuaMon.Location = new System.Drawing.Point(722, 352);
            this.btnSuaMon.Margin = new System.Windows.Forms.Padding(2);
            this.btnSuaMon.Name = "btnSuaMon";
            this.btnSuaMon.Size = new System.Drawing.Size(70, 27);
            this.btnSuaMon.TabIndex = 20;
            this.btnSuaMon.Text = "Sửa";
            this.btnSuaMon.UseVisualStyleBackColor = true;
            this.btnSuaMon.Click += new System.EventHandler(this.btnSuaMon_Click);
            // 
            // searchbox1
            // 
            this.searchbox1.Location = new System.Drawing.Point(658, 1);
            this.searchbox1.Margin = new System.Windows.Forms.Padding(2);
            this.searchbox1.Name = "searchbox1";
            this.searchbox1.Size = new System.Drawing.Size(150, 21);
            this.searchbox1.TabIndex = 21;
            this.searchbox1.Enter += new System.EventHandler(this.searchbox1_Enter);
            this.searchbox1.Leave += new System.EventHandler(this.searchbox1_Leave);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabControl1.Location = new System.Drawing.Point(0, 1);
            this.tabControl1.Margin = new System.Windows.Forms.Padding(2);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(819, 503);
            this.tabControl1.TabIndex = 24;
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.Color.CornflowerBlue;
            this.tabPage1.Controls.Add(this.btnlammoi);
            this.tabPage1.Controls.Add(this.label8);
            this.tabPage1.Controls.Add(this.searchbox1);
            this.tabPage1.Controls.Add(this.btnXoaMon);
            this.tabPage1.Controls.Add(this.lvThucDon);
            this.tabPage1.Controls.Add(this.btnSuaMon);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Controls.Add(this.txtmamon);
            this.tabPage1.Controls.Add(this.btnThemMon);
            this.tabPage1.Controls.Add(this.cbbNM);
            this.tabPage1.Controls.Add(this.label3);
            this.tabPage1.Controls.Add(this.label4);
            this.tabPage1.Controls.Add(this.txtdongia);
            this.tabPage1.Controls.Add(this.txttenmon);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.ForeColor = System.Drawing.Color.Black;
            this.tabPage1.Location = new System.Drawing.Point(4, 24);
            this.tabPage1.Margin = new System.Windows.Forms.Padding(2);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(2);
            this.tabPage1.Size = new System.Drawing.Size(811, 475);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Danh sách món ăn";
            // 
            // btnlammoi
            // 
            this.btnlammoi.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnlammoi.Location = new System.Drawing.Point(717, 406);
            this.btnlammoi.Name = "btnlammoi";
            this.btnlammoi.Size = new System.Drawing.Size(75, 23);
            this.btnlammoi.TabIndex = 24;
            this.btnlammoi.Text = "Làm mới";
            this.btnlammoi.UseVisualStyleBackColor = true;
            this.btnlammoi.Click += new System.EventHandler(this.btnlammoi_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.label8.Location = new System.Drawing.Point(6, 6);
            this.label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(126, 15);
            this.label8.TabIndex = 23;
            this.label8.Text = "Thông tin thực đơn";
            // 
            // tabPage2
            // 
            this.tabPage2.BackColor = System.Drawing.Color.CornflowerBlue;
            this.tabPage2.Controls.Add(this.splitContainer1);
            this.tabPage2.Location = new System.Drawing.Point(4, 24);
            this.tabPage2.Margin = new System.Windows.Forms.Padding(2);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(2);
            this.tabPage2.Size = new System.Drawing.Size(811, 475);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Danh sách nhóm món";
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(2, 2);
            this.splitContainer1.Margin = new System.Windows.Forms.Padding(2);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.panel1);
            this.splitContainer1.Panel1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.splitContainer1.Panel1MinSize = 10;
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.groupBox1);
            this.splitContainer1.Panel2.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.splitContainer1.Panel2MinSize = 40;
            this.splitContainer1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.splitContainer1.Size = new System.Drawing.Size(807, 471);
            this.splitContainer1.SplitterDistance = 223;
            this.splitContainer1.SplitterWidth = 3;
            this.splitContainer1.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.CornflowerBlue;
            this.panel1.Controls.Add(this.btnlm);
            this.panel1.Controls.Add(this.btnXoaNM);
            this.panel1.Controls.Add(this.btnSuaNM);
            this.panel1.Controls.Add(this.btnThemNM);
            this.panel1.Controls.Add(this.txttennma);
            this.panel1.Controls.Add(this.txtmanma);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(223, 471);
            this.panel1.TabIndex = 1;
            // 
            // btnlm
            // 
            this.btnlm.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnlm.Location = new System.Drawing.Point(138, 279);
            this.btnlm.Name = "btnlm";
            this.btnlm.Size = new System.Drawing.Size(82, 26);
            this.btnlm.TabIndex = 32;
            this.btnlm.Text = "Làm mới";
            this.btnlm.UseVisualStyleBackColor = true;
            this.btnlm.Click += new System.EventHandler(this.btnlm_Click);
            // 
            // btnXoaNM
            // 
            this.btnXoaNM.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXoaNM.Location = new System.Drawing.Point(44, 278);
            this.btnXoaNM.Margin = new System.Windows.Forms.Padding(2);
            this.btnXoaNM.Name = "btnXoaNM";
            this.btnXoaNM.Size = new System.Drawing.Size(84, 27);
            this.btnXoaNM.TabIndex = 31;
            this.btnXoaNM.Text = "Xóa";
            this.btnXoaNM.UseVisualStyleBackColor = true;
            this.btnXoaNM.Click += new System.EventHandler(this.btnXoaNM_Click);
            // 
            // btnSuaNM
            // 
            this.btnSuaNM.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSuaNM.Location = new System.Drawing.Point(138, 224);
            this.btnSuaNM.Margin = new System.Windows.Forms.Padding(2);
            this.btnSuaNM.Name = "btnSuaNM";
            this.btnSuaNM.Size = new System.Drawing.Size(84, 27);
            this.btnSuaNM.TabIndex = 30;
            this.btnSuaNM.Text = "Sửa";
            this.btnSuaNM.UseVisualStyleBackColor = true;
            this.btnSuaNM.Click += new System.EventHandler(this.btnSuaNM_Click);
            // 
            // btnThemNM
            // 
            this.btnThemNM.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThemNM.Location = new System.Drawing.Point(44, 224);
            this.btnThemNM.Margin = new System.Windows.Forms.Padding(2);
            this.btnThemNM.Name = "btnThemNM";
            this.btnThemNM.Size = new System.Drawing.Size(82, 27);
            this.btnThemNM.TabIndex = 29;
            this.btnThemNM.Text = "Thêm";
            this.btnThemNM.UseVisualStyleBackColor = true;
            this.btnThemNM.Click += new System.EventHandler(this.btnThemNM_Click);
            // 
            // txttennma
            // 
            this.txttennma.Location = new System.Drawing.Point(40, 151);
            this.txttennma.Margin = new System.Windows.Forms.Padding(2);
            this.txttennma.Name = "txttennma";
            this.txttennma.Size = new System.Drawing.Size(180, 21);
            this.txttennma.TabIndex = 27;
            // 
            // txtmanma
            // 
            this.txtmanma.Location = new System.Drawing.Point(40, 81);
            this.txtmanma.Margin = new System.Windows.Forms.Padding(2);
            this.txtmanma.Name = "txtmanma";
            this.txtmanma.Size = new System.Drawing.Size(180, 21);
            this.txtmanma.TabIndex = 26;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(40, 132);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(123, 17);
            this.label6.TabIndex = 4;
            this.label6.Text = "Tên nhóm món ăn";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(40, 63);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(117, 17);
            this.label5.TabIndex = 3;
            this.label5.Text = "Mã nhóm món ăn";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lvNhomMon);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox1.Size = new System.Drawing.Size(581, 471);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông tin nhóm món";
            // 
            // lvNhomMon
            // 
            this.lvNhomMon.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader5,
            this.columnHeader6});
            this.lvNhomMon.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lvNhomMon.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lvNhomMon.FullRowSelect = true;
            this.lvNhomMon.GridLines = true;
            this.lvNhomMon.Location = new System.Drawing.Point(2, 19);
            this.lvNhomMon.Margin = new System.Windows.Forms.Padding(2);
            this.lvNhomMon.Name = "lvNhomMon";
            this.lvNhomMon.Size = new System.Drawing.Size(577, 450);
            this.lvNhomMon.TabIndex = 0;
            this.lvNhomMon.UseCompatibleStateImageBehavior = false;
            this.lvNhomMon.View = System.Windows.Forms.View.Details;
            this.lvNhomMon.SelectedIndexChanged += new System.EventHandler(this.lvNhomMon_SelectedIndexChanged);
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "Mã nhóm món";
            this.columnHeader5.Width = 150;
            // 
            // columnHeader6
            // 
            this.columnHeader6.Text = "Tên nhóm món";
            this.columnHeader6.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader6.Width = 150;
            // 
            // frThucDon
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.CornflowerBlue;
            this.ClientSize = new System.Drawing.Size(820, 503);
            this.Controls.Add(this.tabControl1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "frThucDon";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Thực đơn";
            this.Load += new System.EventHandler(this.frThucDon_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView lvThucDon;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtmamon;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cbbNM;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txttenmon;
        private System.Windows.Forms.TextBox txtdongia;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnThemMon;
        private System.Windows.Forms.Button btnXoaMon;
        private System.Windows.Forms.Button btnSuaMon;
        private System.Windows.Forms.TextBox searchbox1;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnXoaNM;
        private System.Windows.Forms.Button btnSuaNM;
        private System.Windows.Forms.Button btnThemNM;
        private System.Windows.Forms.TextBox txttennma;
        private System.Windows.Forms.TextBox txtmanma;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ListView lvNhomMon;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.ColumnHeader columnHeader6;
        private System.Windows.Forms.Button btnlm;
        private System.Windows.Forms.Button btnlammoi;
    }
}