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
            this.components = new System.ComponentModel.Container();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource1 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.QLNH2DataSet = new QuanLyNhaHang1.QLNH2DataSet();
            this.DoanhThuBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.DoanhThuTableAdapter = new QuanLyNhaHang1.QLNH2DataSetTableAdapters.DoanhThuTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.QLNH2DataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DoanhThuBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.DoanhThuBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "QuanLyNhaHang1.Report1.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(1083, 604);
            this.reportViewer1.TabIndex = 0;
            // 
            // QLNH2DataSet
            // 
            this.QLNH2DataSet.DataSetName = "QLNH2DataSet";
            this.QLNH2DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // DoanhThuBindingSource
            // 
            this.DoanhThuBindingSource.DataMember = "DoanhThu";
            this.DoanhThuBindingSource.DataSource = this.QLNH2DataSet;
            // 
            // DoanhThuTableAdapter
            // 
            this.DoanhThuTableAdapter.ClearBeforeFill = true;
            // 
            // frThongKe
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.CornflowerBlue;
            this.ClientSize = new System.Drawing.Size(1083, 604);
            this.Controls.Add(this.reportViewer1);
            this.Name = "frThongKe";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Báo cáo - Thống kê";
            this.Load += new System.EventHandler(this.frThongKe_Load);
            ((System.ComponentModel.ISupportInitialize)(this.QLNH2DataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DoanhThuBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource DoanhThuBindingSource;
        private QLNH2DataSet QLNH2DataSet;
        private QLNH2DataSetTableAdapters.DoanhThuTableAdapter DoanhThuTableAdapter;
    }
}