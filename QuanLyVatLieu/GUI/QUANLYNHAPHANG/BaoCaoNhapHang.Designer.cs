namespace QuanLyVatLieu.GUI.QUANLYNHAPHANG
{
	partial class BaoCaoNhapHang
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
			this.baoCaoNhapHang1 = new QuanLyVatLieu.BaoCaoNhapHang();
			this.baoCaoNhapHang1BindingSource = new System.Windows.Forms.BindingSource(this.components);
			((System.ComponentModel.ISupportInitialize)(this.baoCaoNhapHang1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.baoCaoNhapHang1BindingSource)).BeginInit();
			this.SuspendLayout();
			// 
			// reportViewer1
			// 
			reportDataSource1.Name = "BaoCaoNhapHangDataset";
			reportDataSource1.Value = this.baoCaoNhapHang1BindingSource;
			this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
			this.reportViewer1.LocalReport.ReportEmbeddedResource = "QuanLyVatLieu.BaoCaoNhapHang.rdlc";
			this.reportViewer1.Location = new System.Drawing.Point(12, 12);
			this.reportViewer1.Name = "reportViewer1";
			this.reportViewer1.ServerReport.BearerToken = null;
			this.reportViewer1.Size = new System.Drawing.Size(928, 455);
			this.reportViewer1.TabIndex = 0;
			// 
			// baoCaoNhapHang1
			// 
			this.baoCaoNhapHang1.DataSetName = "BaoCaoNhapHang";
			this.baoCaoNhapHang1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
			// 
			// baoCaoNhapHang1BindingSource
			// 
			this.baoCaoNhapHang1BindingSource.DataSource = this.baoCaoNhapHang1;
			this.baoCaoNhapHang1BindingSource.Position = 0;
			// 
			// BaoCaoNhapHang
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(952, 479);
			this.Controls.Add(this.reportViewer1);
			this.Name = "BaoCaoNhapHang";
			this.Text = "BaoCaoNhapHang";
			this.Load += new System.EventHandler(this.BaoCaoNhapHang_Load);
			((System.ComponentModel.ISupportInitialize)(this.baoCaoNhapHang1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.baoCaoNhapHang1BindingSource)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion

		private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
		private System.Windows.Forms.BindingSource baoCaoNhapHang1BindingSource;
		private QuanLyVatLieu.BaoCaoNhapHang baoCaoNhapHang1;
	}
}