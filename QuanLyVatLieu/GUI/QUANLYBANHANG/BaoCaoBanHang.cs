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
	public partial class BaoCaoBanHang : Form
	{
		public BaoCaoBanHang(DateTime tungay, DateTime denngay)
		{
			InitializeComponent();
			baoCaoBanHang1BindingSource.DataSource = xuathangDAO.Instance.inHoaDon(tungay, denngay);
			this.reportViewer1.RefreshReport();
		}

		private void BaoCaoBanHang_Load(object sender, EventArgs e)
		{

			this.reportViewer1.RefreshReport();
		}
	}
}
