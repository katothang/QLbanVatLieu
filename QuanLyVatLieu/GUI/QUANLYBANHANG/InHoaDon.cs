using QuanLyVatLieu.DAO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyVatLieu.GUI.QUANLYBANHANG
{
	public partial class InHoaDon : Form
	{
		
		public InHoaDon(string mahoadon)
		{
			InitializeComponent();
			this.quanLyVatLieuDataSetBindingSource.DataSource = hoadonDAO.Instance.showHoadon(mahoadon);
			this.reportViewer1.RefreshReport();
		}
		public InHoaDon(string mahoadon, string dateTime)
		{
			InitializeComponent();
			this.quanLyVatLieuDataSetBindingSource.DataSource = hoadonDAO.Instance.showInHoadon(mahoadon, dateTime);
			this.reportViewer1.RefreshReport();
		}

		private void InHoaDon_Load(object sender, EventArgs e)
		{

			this.reportViewer1.RefreshReport();
			this.reportViewer1.RefreshReport();
		}

		private void ReportViewer1_Load(object sender, EventArgs e)
		{
			
		}
	}
}
