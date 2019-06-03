using QuanLyVatLieu;

namespace QuanLyVatLieu.GUI.QUANLYBANHANG
{
	partial class InHoaDon
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
			this.baoCaoBanHangBindingSource = new System.Windows.Forms.BindingSource(this.components);
			this.baoCaoBanHang = new QuanLyVatLieu.BaoCaoBanHang();
			this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
			this.quanLyVatLieuDataSet = new QuanLyVatLieu.QuanLyVatLieuDataSet();
			this.quanLyVatLieuDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
			((System.ComponentModel.ISupportInitialize)(this.baoCaoBanHangBindingSource)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.baoCaoBanHang)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.quanLyVatLieuDataSet)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.quanLyVatLieuDataSetBindingSource)).BeginInit();
			this.SuspendLayout();
			// 
			// baoCaoBanHangBindingSource
			// 
			this.baoCaoBanHangBindingSource.DataSource = this.baoCaoBanHang;
			this.baoCaoBanHangBindingSource.Position = 0;
			// 
			// baoCaoBanHang
			// 
			this.baoCaoBanHang.DataSetName = "BaoCaoBanHang";
			this.baoCaoBanHang.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
			// 
			// reportViewer1
			// 
			reportDataSource1.Name = "ThongTinHoaDon";
			reportDataSource1.Value = this.quanLyVatLieuDataSetBindingSource;
			this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
			this.reportViewer1.LocalReport.ReportEmbeddedResource = "QuanLyVatLieu.HoaDonThanhToan.rdlc";
			this.reportViewer1.Location = new System.Drawing.Point(2, 12);
			this.reportViewer1.Name = "reportViewer1";
			this.reportViewer1.ServerReport.BearerToken = null;
			this.reportViewer1.Size = new System.Drawing.Size(953, 544);
			this.reportViewer1.TabIndex = 0;
			// 
			// quanLyVatLieuDataSet
			// 
			this.quanLyVatLieuDataSet.DataSetName = "QuanLyVatLieuDataSet";
			this.quanLyVatLieuDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
			// 
			// quanLyVatLieuDataSetBindingSource
			// 
			this.quanLyVatLieuDataSetBindingSource.DataSource = this.quanLyVatLieuDataSet;
			this.quanLyVatLieuDataSetBindingSource.Position = 0;
			// 
			// InHoaDon
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(967, 560);
			this.Controls.Add(this.reportViewer1);
			this.Name = "InHoaDon";
			this.Text = "InHoaDon";
			this.Load += new System.EventHandler(this.InHoaDon_Load);
			((System.ComponentModel.ISupportInitialize)(this.baoCaoBanHangBindingSource)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.baoCaoBanHang)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.quanLyVatLieuDataSet)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.quanLyVatLieuDataSetBindingSource)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion

		private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
		private System.Windows.Forms.BindingSource baoCaoBanHangBindingSource;
		private QuanLyVatLieu.BaoCaoBanHang baoCaoBanHang;
		private System.Windows.Forms.BindingSource quanLyVatLieuDataSetBindingSource;
		private QuanLyVatLieuDataSet quanLyVatLieuDataSet;
	}
}