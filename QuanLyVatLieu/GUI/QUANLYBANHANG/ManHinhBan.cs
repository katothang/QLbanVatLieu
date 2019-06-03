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

namespace QuanLyVatLieu.GUI.QUANLYBANHANG
{
	public partial class ManHinhBan : Form
	{
		public ManHinhBan()
		{
			InitializeComponent();
			gvdata.DataSource = hanghoaDAO.Instance.showhangban();
			gvdata.Columns[0].HeaderText = "Mã HH";
			gvdata.Columns[1].HeaderText = "Tên HH";
			gvdata.Columns[2].HeaderText = "Mã NCC";
			gvdata.Columns[3].HeaderText = "Loại Hàng";
			gvdata.Columns[4].HeaderText = "Nhãn Hiệu";
			gvdata.Columns[5].HeaderText = "Đơn Giá";
			gvdata.Columns[6].HeaderText = "Số Lượng";
			gvdata.Columns[7].HeaderText = "Mô Tả";
		}

		private void BtnThanhToan_Click(object sender, EventArgs e)
		{
			GioHang gioHang = new GioHang();
			biencucbo.home.showForm(gioHang);
		}

		private void BtnThemVaoGio_Click(object sender, EventArgs e)
		{
			if (giohangDAO.Instance.ktGioHang(gvdata.SelectedRows[0].Cells["mahh"].Value.ToString(), biencucbo.taikhoan))
			{
				MessageBox.Show("mã đơn hàng đã có trong giỏ hàng");
				return;
			}
			if (nbsoluong.Value <= 0)
			{
				MessageBox.Show("số lượng mua hàng phải lớn hơn 0");
				return;
			}
			if (Int32.Parse(gvdata.SelectedRows[0].Cells["soluongcon"].Value.ToString()) <= 0)
			{
				MessageBox.Show("hàng bạn chọn hiện tại đã hết hàng");
				return;
			}
			//kiêm tra xem số lượng thêm vào gio hàng có lớn hơn số lượng hàng hóa đang có ko

			int soluongcon = 0;
			soluongcon = hanghoaDAO.Instance.ktSLhanghoa(gvdata.SelectedRows[0].Cells["mahh"].Value.ToString());
			if (soluongcon < nbsoluong.Value)
			{
				MessageBox.Show("Số lượng thêm vào giỏ hàng phải bé hoặc bằng số lượng trong kho hàng");
				return;
			}

			try
			{
				giohangDAO.Instance.themvaogiohang(gvdata.SelectedRows[0].Cells["mahh"].Value.ToString(), biencucbo.taikhoan, gvdata.SelectedRows[0].Cells["tenhh"].Value.ToString(), nbsoluong.Value.ToString());
				MessageBox.Show("Thêm hàng thành công");
				gvdata.DataSource = hanghoaDAO.Instance.showhangban();

			}
			catch (Exception)
			{

				MessageBox.Show("thêm hàng thất bại");
			}
		}

		private void PcSearch_Click(object sender, EventArgs e)
		{
			gvdata.DataSource = hanghoaDAO.Instance.timkiemhangban(tbTimKiem.Text);
		}

		private void BtLamMoi_Click(object sender, EventArgs e)
		{
			gvdata.DataSource = hanghoaDAO.Instance.showhangban();
		}

		private void BtnThongKeBanHang_Click(object sender, EventArgs e)
		{
			// check quyền truy cập

			if (!biencucbo.loaitaikhoan.Equals("Quản Lý Kho") && !biencucbo.loaitaikhoan.Equals("admin"))
			{
				MessageBox.Show("Bạn không có quyền truy cập mục này");
				return;
			}
			ThongKeBanHang thongKeBanHang = new ThongKeBanHang();
			biencucbo.home.showForm(thongKeBanHang);
		}
	}
}
