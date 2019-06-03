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
	public partial class VatLieu : Form
	{
		public VatLieu()
		{
			InitializeComponent();
			gvdata.DataSource = hanghoaDAO.Instance.showhanghoa();
			gvdata.Columns[0].HeaderText = "Mã HH";
			gvdata.Columns[1].HeaderText = "Tên HH";
			gvdata.Columns[2].HeaderText = "Mã NCC";
			gvdata.Columns[3].HeaderText = "Loại Hàng";
			gvdata.Columns[4].HeaderText = "Nhãn Hiệu";
			gvdata.Columns[5].HeaderText = "Giá Bán";
			gvdata.Columns[6].HeaderText = "Giá Nhập";
			gvdata.Columns[7].HeaderText = "Số Lượng";
			gvdata.Columns[8].HeaderText = "Mô Tả";
			cbbmancc.DataSource = nhacungcapDAO.Instance.shownhacc();
			cbbmancc.ValueMember = "mancc";
		}

		private void Gvdata_CellContentClick(object sender, DataGridViewCellEventArgs e)
		{
			tbMaVatLieu.Text = gvdata.SelectedRows[0].Cells["MaHH"].Value.ToString();
			tbTenVatLieu.Text = gvdata.SelectedRows[0].Cells["TenHH"].Value.ToString();
			cbbmancc.SelectedValue = gvdata.SelectedRows[0].Cells["MaNCC"].Value.ToString();
			tbLoaiHang.Text = gvdata.SelectedRows[0].Cells["LoaiHang"].Value.ToString();
			tbNhanHieu.Text = gvdata.SelectedRows[0].Cells["NhanHieu"].Value.ToString();
			tbDonGia.Text = gvdata.SelectedRows[0].Cells["DonGia"].Value.ToString();
			rtbMoTa.Text = gvdata.SelectedRows[0].Cells["MoTa"].Value.ToString();
			tbSoLuong.Text = gvdata.SelectedRows[0].Cells["SoLuongcon"].Value.ToString();
			tbgianhap.Text = gvdata.SelectedRows[0].Cells["dongianhap"].Value.ToString();
		}

		private void PcSave_Click(object sender, EventArgs e)
		{
			float gianhap = 0;
			float.TryParse(tbgianhap.Text, out gianhap);
			float giaxuat = 0;
			float.TryParse(tbDonGia.Text, out giaxuat);
			int soluong = 0;
			Int32.TryParse(tbSoLuong.Text, out soluong);

			if (gianhap <= 0)
			{
				lbgianhap.Text = "Sai Giá nhập";
				return;
			}
			else
				lbgianhap.Text = "";


			if (giaxuat <= 0)
			{
				lbdongia.Text = "Sai  Đơn Giá";
				return;
			}
			else
				lbdongia.Text = "";
			if (soluong <= 0)
			{
				lbsoluong.Text = "Sai số lượng";
				return;
			}
			else
				lbsoluong.Text = "";
			if (!chuanhoa.Instance.chuanhoamaHH(tbMaVatLieu.Text))
			{
				lbmalk.Text = " mã hàng phải có 2 từ đầu là HH và các kí tự sau là số";
				return;
			}
			else
				lbmalk.Text = "";

			if (!chuanhoa.Instance.chuanhoamancc(cbbmancc.Text))
			{
				lbmancc.Text = "mã nhà cung cấp phải có 3 kí tự đầu là NCC và các kí tự sau là số";
				return;
			}
			else
				lbmancc.Text = "";

			//kiem tra
			if (tbDonGia.Text == "" || tbgianhap.Text == "" || tbLoaiHang.Text == "" || tbMaVatLieu.Text == "" || tbNhanHieu.Text == "" || tbSoLuong.Text == "" || tbTenVatLieu.Text == "")
			{
				MessageBox.Show("Các trường không được để trống");
				return;
			}


			try
			{

				hanghoaDAO.Instance.themDL(tbMaVatLieu.Text, tbTenVatLieu.Text, cbbmancc.Text, tbLoaiHang.Text, tbNhanHieu.Text, tbDonGia.Text, tbgianhap.Text, tbSoLuong.Text, rtbMoTa.Text);
				MessageBox.Show("thêm thành công");
				//insert vao bang nhap hàng
				


			}
			catch (Exception)
			{

				MessageBox.Show("dữ liệu nhập không chính xác hoặc Mã nhà cung cấp không tồn tại trong CSDL");
			}
			nhaphangDAO.Instance.insertnhap(biencucbo.taikhoan, tbMaVatLieu.Text, tbTenVatLieu.Text, float.Parse(tbgianhap.Text), Int32.Parse(tbSoLuong.Text.ToString()));
			gvdata.DataSource = hanghoaDAO.Instance.showhanghoa();
		}

		private void PcEdit_Click(object sender, EventArgs e)
		{
			float gianhap = 0;
			float.TryParse(tbgianhap.Text, out gianhap);
			float giaxuat = 0;
			float.TryParse(tbDonGia.Text, out giaxuat);
			int soluong = 0;
			Int32.TryParse(tbSoLuong.Text, out soluong);

			if (gianhap <= 0)
			{
				lbgianhap.Text = "Sai Giá nhập";
				return;
			}
			else
				lbgianhap.Text = "";


			if (giaxuat <= 0)
			{
				lbdongia.Text = "Sai  Đơn Giá";
				return;
			}
			else
				lbdongia.Text = "";
			if (soluong <= 0)
			{
				lbsoluong.Text = "Sai số lượng";
				return;
			}
			else
				lbsoluong.Text = "";
			if (!chuanhoa.Instance.chuanhoamaHH(tbMaVatLieu.Text))
			{
				lbmalk.Text = " mã hàng phải có 2 từ đầu là HH và các kí tự sau là số";
				return;
			}
			else
				lbmalk.Text = "";

			if (!chuanhoa.Instance.chuanhoamancc(cbbmancc.Text))
			{
				lbmancc.Text = "mã nhà cung cấp phải có 3 kí tự đầu là NCC và các kí tự sau là số";
				return;
			}
			else
				lbmancc.Text = "";

			//kiem tra
			if (tbDonGia.Text == "" || tbgianhap.Text == "" || tbLoaiHang.Text == "" || tbMaVatLieu.Text == "" || tbNhanHieu.Text == "" || tbSoLuong.Text == "" || tbTenVatLieu.Text == "")
			{
				MessageBox.Show("Các trường không được để trống");
				return;
			}
			if (tbMaVatLieu.Text != gvdata.Rows[gvdata.CurrentCell.RowIndex].Cells[0].Value.ToString())
			{
				MessageBox.Show("bạn không được sửa mã hàng");
				return;
			}
			//end chuân hóa

			try
			{
				hanghoaDAO.Instance.Sua(tbMaVatLieu.Text, tbTenVatLieu.Text, cbbmancc.Text, tbLoaiHang.Text, tbNhanHieu.Text, tbDonGia.Text, tbgianhap.Text, tbSoLuong.Text, rtbMoTa.Text);
				MessageBox.Show("Sửa thành công mã " + tbMaVatLieu.Text);
				gvdata.DataSource = hanghoaDAO.Instance.showhanghoa();
			}
			catch (Exception)
			{

				MessageBox.Show("dữ liệu nhập không chính xác");
			}
		}

		private void PcDelete_Click(object sender, EventArgs e)
		{
			try
			{
				hanghoaDAO.Instance.Xoa(tbMaVatLieu.Text);
				MessageBox.Show("xóa thành công");
				gvdata.DataSource = hanghoaDAO.Instance.showhanghoa();
			}
			catch (Exception)
			{

				MessageBox.Show("thất bại");
			}
		}

		private void PcSearch_Click(object sender, EventArgs e)
		{
			try
			{
				gvdata.DataSource = hanghoaDAO.Instance.timkiem(tbTimKiem.Text);
			}
			catch (Exception)
			{

				MessageBox.Show("Lỗi..!");
			}
		}

		private void BtLamMoi_Click(object sender, EventArgs e)
		{
			gvdata.DataSource = hanghoaDAO.Instance.showhanghoa();
		}
	}
}
