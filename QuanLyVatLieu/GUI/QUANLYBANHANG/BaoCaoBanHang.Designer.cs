namespace QuanLyVatLieu.GUI.QUANLYBANHANG
{
	partial class BaoCaoBanHang
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
			this.baoCaoBanHang1 = new QuanLyVatLieu.BaoCaoBanHang();
			this.baoCaoBanHang1BindingSource = new System.Windows.Forms.BindingSource(this.components);
			((System.ComponentModel.ISupportInitialize)(this.baoCaoBanHang1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.baoCaoBanHang1BindingSource)).BeginInit();
			this.SuspendLayout();
			// 
			// reportViewer1
			// 
			reportDataSource1.Name = "BaoCaoBanHangDataSet";
			reportDataSource1.Value = this.baoCaoBanHang1BindingSource;
			this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
			this.reportViewer1.LocalReport.ReportEmbeddedResource = "QuanLyVatLieu.BaoCaoBanHang.rdlc";
			this.reportViewer1.Location = new System.Drawing.Point(3, 12);
			this.reportViewer1.Name = "reportViewer1";
			this.reportViewer1.ServerReport.BearerToken = null;
			this.reportViewer1.Size = new System.Drawing.Size(903, 447);
			this.reportViewer1.TabIndex = 0;
			// 
			// baoCaoBanHang1
			// 
			this.baoCaoBanHang1.DataSetName = "BaoCaoBanHang";
			this.baoCaoBanHang1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
			// 
			// baoCaoBanHang1BindingSource
			// 
			this.baoCaoBanHang1BindingSource.DataSource = this.baoCaoBanHang1;
			this.baoCaoBanHang1BindingSource.Position = 0;
			// 
			// BaoCaoBanHang
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(918, 471);
			this.Controls.Add(this.reportViewer1);
			this.Name = "BaoCaoBanHang";
			this.Text = "BaoCaoBanHang";
			this.Load += new System.EventHandler(this.BaoCaoBanHang_Load);
			((System.ComponentModel.ISupportInitialize)(this.baoCaoBanHang1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.baoCaoBanHang1BindingSource)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion

		private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
		private System.Windows.Forms.BindingSource baoCaoBanHang1BindingSource;
		private QuanLyVatLieu.BaoCaoBanHang baoCaoBanHang1;
	}
}