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

namespace QuanLyVatLieu.GUI.QUANLYNHAPHANG
{
	public partial class NhapHang : Form
	{
		public NhapHang()
		{
			InitializeComponent();
			gvdata.DataSource = nhaphangDAO.Instance.shownhaphang();
			gvdata.Columns[0].HeaderText = "Mã Nhập";
			gvdata.Columns[1].HeaderText = "Người Nhập";
			gvdata.Columns[2].HeaderText = "ngày nhập";
			gvdata.Columns[3].HeaderText = "Mã Hàng";
			gvdata.Columns[4].HeaderText = "Tên Hàng";
			gvdata.Columns[5].HeaderText = "Số Lượng";
			gvdata.Columns[6].HeaderText = "Giá Nhập";
			gvdata.Columns[7].HeaderText = "Thành Tiền";
			cbbmahang.ValueMember = "MaHH";
			cbbmahang.DataSource = hanghoaDAO.Instance.showhanghoa();
			txtTongTien.Text = nhaphangDAO.Instance.tongtien().ToString();
			try
			{
				lbTenHang.Text = hanghoaDAO.Instance.getTenHangHoa(cbbmahang.Text)["TenHH"].ToString();
			}
			catch
			{
				lbTenHang.Text = "";
			}
			
		}

		private void BtnNhapHang_Click(object sender, EventArgs e)
		{
			if (nbsoluong.Value <= 0)
			{
				lbsoluong.Text = "Số lượng nhập phải lớn hơn 0";
				return;
			}

			try
			{
				int soluongcon = hanghoaDAO.Instance.ktSLhanghoa(cbbmahang.Text);
				int soluong = 0;
				soluong = (int)soluongcon + (int)nbsoluong.Value;
				hanghoaDAO.Instance.updateSL(cbbmahang.Text, soluong);
				string tenHH = hanghoaDAO.Instance.getTenHangHoa(cbbmahang.Text)["TenHH"].ToString();
				string dongia = hanghoaDAO.Instance.getTenHangHoa(cbbmahang.Text)["DonGiaNhap"].ToString();
				// insert vào bảng nhập hàng
				nhaphangDAO.Instance.insertnhap(biencucbo.taikhoan, cbbmahang.Text, tenHH, float.Parse(dongia), soluong);
				MessageBox.Show("nhập hàng thành công với số lượng " + nbsoluong.Value + " cho mã hàng " + cbbmahang.Text);
			}
			catch (Exception)
			{

				MessageBox.Show("lỗi vui lòng kiểm tra lại");
			}
		}

		private void BtnHuy_Click(object sender, EventArgs e)
		{

			try
			{
				nhaphangDAO.Instance.xoa(gvdata.SelectedRows[0].Cells[0].Value.ToString());
				MessageBox.Show("xóa thành công");
				gvdata.DataSource = nhaphangDAO.Instance.shownhaphang();
			}
			catch (Exception)
			{

				MessageBox.Show("lỗi ..!");
			}
		}

		private void BtnThongKe_Click(object sender, EventArgs e)
		{
			ThongKeNhapHang thongKeNhapHang = new ThongKeNhapHang();
			biencucbo.home.showForm(thongKeNhapHang);
		}

		private void Cbbmahang_SelectedIndexChanged(object sender, EventArgs e)
		{
			try
			{
				lbTenHang.Text = hanghoaDAO.Instance.getTenHangHoa(cbbmahang.Text)["TenHH"].ToString();
			}
			catch
			{
				lbTenHang.Text = "";
			}
		}
	}
}
