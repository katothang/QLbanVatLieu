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

namespace QuanLyVatLieu.GUI.QUANLYNHAPHANG
{
	public partial class ThongKeNhapHang : Form
	{
		public ThongKeNhapHang()
		{
			InitializeComponent();
			// chỉnh format ngày tháng năm
			dtTuNgay.CustomFormat = "dd-MM-yyyy";
			dtDenNgay.CustomFormat = "dd-MM-yyyy";
		}

		private void BtnXemThongKe_Click(object sender, EventArgs e)
		{
			gvdata.DataSource = nhaphangDAO.Instance.loctheongay(dtTuNgay.Value, dtDenNgay.Value);
		}

		private void BtLamMoi_Click(object sender, EventArgs e)
		{
			gvdata.DataSource = nhaphangDAO.Instance.shownhaphang();

		}

		private void InBaoCao_Click(object sender, EventArgs e)
		{
			BaoCaoNhapHang baoCaoNhapHang = new BaoCaoNhapHang(dtTuNgay.Value, dtDenNgay.Value);
			baoCaoNhapHang.ShowDialog();
		}
	}
}
