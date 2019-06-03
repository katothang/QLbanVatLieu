using QuanLyVatLieu.DAO;
using QuanLyVatLieu.Utils;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyVatLieu.GUI.DANHMUC
{
	public partial class KhachHang : Form
	{
		public KhachHang()
		{
			InitializeComponent();
			gvdata.DataSource = khachhangDAO.Instance.showkhachhang();
			gvdata.Columns[0].HeaderText = "Số CMTND";
			gvdata.Columns[1].HeaderText = "Tên KH";
			gvdata.Columns[2].HeaderText = "Ngày Sinh";
			gvdata.Columns[3].HeaderText = "Địa Chỉ";
			gvdata.Columns[4].HeaderText = "SĐT";
			gvdata.Columns[5].HeaderText = "Giới Tính";
			// chỉnh format ngày tháng năm
			dtNgaySinh.CustomFormat = "dd-MM-yyyy";
		}

		private void Gvdata_CellContentClick(object sender, DataGridViewCellEventArgs e)
		{
			tbMaKH.Text = gvdata.SelectedRows[0].Cells["MaKH"].Value.ToString();
			tbTenKH.Text = gvdata.SelectedRows[0].Cells["tenKh"].Value.ToString();
			dtNgaySinh.Value = DateTime.Parse(gvdata.SelectedRows[0].Cells["NgaySinh"].Value.ToString());
			tbDiaChi.Text = gvdata.SelectedRows[0].Cells["DiaChi"].Value.ToString();
			tbSoDienThoai.Text = gvdata.SelectedRows[0].Cells["SDT"].Value.ToString();
			if (gvdata.SelectedRows[0].Cells["GioiTinh"].Value.ToString() == "Nam")
				cbbGioiTinh.SelectedIndex = 0;
			else
				cbbGioiTinh.SelectedIndex = 1;
		}

		private void PcSave_Click(object sender, EventArgs e)
		{
			//kiểm tra số chhứng minh thư (MaKH) và số điện thoại nhập vào
			if (!chuanhoa.Instance.checkSCM(tbMaKH.Text))
			{
				lbscm.Text = "số chứng minh thư phải là số.!!";

				return;
			}

			if (!rangbuoc.Instance.checkphone(tbSoDienThoai.Text))
			{
				lbSDT.Text = "bạn đã nhập sai số điện thoại.!";
				return;
			}

			if (tbMaKH.Text == "")
			{
				lbscm.Text = "vui lòng nhập số chứng minh thư.!";
				return;
			}

			if (tbDiaChi.Text == "")
			{
				lbdiachi.Text = "vui lòng nhập địa chỉ.!";
				return;
			}

			if (tbTenKH.Text == "")
			{
				lbtenkh.Text = "vui lòng nhập tên khách hàng.!";
				return;
			}
			// end kiểm tra
			try
			{
				khachhangDAO.Instance.themDL(tbMaKH.Text, tbTenKH.Text, cbbGioiTinh.Text, tbDiaChi.Text, tbSoDienThoai.Text, dtNgaySinh.Value);
				MessageBox.Show("thêm thành công");
				gvdata.DataSource = khachhangDAO.Instance.showkhachhang();

			}
			catch (Exception)
			{

				MessageBox.Show("lỗi vui lòng kiểm tra lại");
			}
		}

		private void PcEdit_Click(object sender, EventArgs e)
		{
			//kiểm tra số chhứng minh thư (MaKH) và số điện thoại nhập vào
			if (!chuanhoa.Instance.checkSCM(tbMaKH.Text))
			{
				lbscm.Text = "số chứng minh thư phải là số.!!";

				return;
			}

			if (!rangbuoc.Instance.checkphone(tbSoDienThoai.Text))
			{
				lbSDT.Text = "bạn đã nhập sai số điện thoại.!";
				return;
			}

			if (tbMaKH.Text == "")
			{
				lbscm.Text = "vui lòng nhập số chứng minh thư.!";
				return;
			}

			if (tbDiaChi.Text == "")
			{
				lbdiachi.Text = "vui lòng nhập địa chỉ.!";
				return;
			}

			if (tbTenKH.Text == "")
			{
				lbtenkh.Text = "vui lòng nhập tên khách hàng.!";
				return;
			}

			if (tbMaKH.Text != gvdata.SelectedRows[0].Cells["MaKH"].Value.ToString())
			{
				lbscm.Text = "lỗi.. bạn không đk sửa CMTND.!";
				return;
			}
			// end kiểm tra
			try
			{
				khachhangDAO.Instance.Sua(tbMaKH.Text, tbTenKH.Text, cbbGioiTinh.Text, tbDiaChi.Text, tbSoDienThoai.Text, dtNgaySinh.Value);
				MessageBox.Show("Sửa thành công");
				gvdata.DataSource = khachhangDAO.Instance.showkhachhang();

			}
			catch (Exception)
			{

				MessageBox.Show("lỗi vui lòng kiểm tra lại");
			}
		}

		private void PcDelete_Click(object sender, EventArgs e)
		{
			try
			{
				khachhangDAO.Instance.Xoa(tbMaKH.Text);
				MessageBox.Show("xóa thành công mã khach hàng " + tbMaKH.Text);
				gvdata.DataSource = khachhangDAO.Instance.showkhachhang();
			}
			catch (Exception)
			{

				MessageBox.Show("lỗi vui lòng kiểm tra lại");
			}
		}

		private void PcSearch_Click(object sender, EventArgs e)
		{
			try
			{
				gvdata.DataSource = khachhangDAO.Instance.timkiem(tbTimKiem.Text);
			}
			catch (Exception)
			{

				MessageBox.Show("lỗi..!");
			}
		}

		private void BtLamMoi_Click(object sender, EventArgs e)
		{
			gvdata.DataSource = khachhangDAO.Instance.showkhachhang();
		}
	}
}
