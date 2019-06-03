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
	public partial class ThongKeBanHang : Form
	{
		string makh = "";
		string ngay = "";
		public ThongKeBanHang()
		{
			InitializeComponent();
			gvdata.DataSource = xuathangDAO.Instance.showalllichsu();
			gvdata.Columns[0].HeaderText = "Mã HH";
			gvdata.Columns[1].HeaderText = "Tên HH";
			gvdata.Columns[2].HeaderText = "Mã KH";
			gvdata.Columns[3].HeaderText = "nhân viên bán";
			gvdata.Columns[4].HeaderText = "Ngày Bán";
			gvdata.Columns[5].HeaderText = "Số Lượng";
			gvdata.Columns[6].HeaderText = "Đơn Giá";
			gvdata.Columns[7].HeaderText = "Thành Tiền";
			// chỉnh format ngày tháng năm
			dtTuNgay.CustomFormat = "yyyy-MM-dd";
			dtDenNgay.CustomFormat = "yyyy-MM-dd";
		}

		private void BtLamMoi_Click(object sender, EventArgs e)
		{
			gvdata.DataSource = xuathangDAO.Instance.showalllichsu();
		}

		private void Inbaocao_Click(object sender, EventArgs e)
		{
			gvdata.DataSource = xuathangDAO.Instance.showlichsu(dtTuNgay.Value, dtDenNgay.Value);
		}

		private void InBaoCao_Click_1(object sender, EventArgs e)
		{
			BaoCaoBanHang baoCaoBanHang = new BaoCaoBanHang(dtTuNgay.Value, dtDenNgay.Value);
			baoCaoBanHang.ShowDialog();
		}

		private void BtInHoaDon_Click(object sender, EventArgs e)
		{
			try
			{
				InHoaDon inHoaDon = new InHoaDon(makh, ngay);
				inHoaDon.ShowDialog();
			}
			catch
			{
				MessageBox.Show("Vui lòng chọn dòng cần xem hóa đơn");
			}
			
		}

		private void Gvdata_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
		{
			makh = gvdata.SelectedRows[0].Cells[2].Value.ToString();
			ngay = gvdata.SelectedRows[0].Cells[4].Value.ToString();
		}
	}
}
