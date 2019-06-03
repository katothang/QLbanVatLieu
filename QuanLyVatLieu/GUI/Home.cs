using QuanLyVatLieu.GUI.DANHMUC;
using QuanLyVatLieu.GUI.QUANLYBANHANG;
using QuanLyVatLieu.GUI.QUANLYNHAPHANG;
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

namespace QuanLyVatLieu.GUI
{
    public partial class Home : Form
    {
        public Home()
        {
			InitializeComponent();
			biencucbo.home = this;
			lbAccount.Text = biencucbo.taikhoan;
			// mở trang bán hàng làm mặc định
			BtnBanHang_Click(new object(), new EventArgs());

		}

		private void BtnBanHang_Click(object sender, EventArgs e)
		{
			// reset lại toàn bộ menu và set lại màu khi click vào menu
			un_btHeader_Click();
			pnContent.Controls.Clear();
			ManHinhBan manHinhBan = new ManHinhBan();
			manHinhBan.TopLevel = false;
			pnContent.Controls.Add(manHinhBan);
			manHinhBan.Show();
			this.btnBanHang.BackColor = Color.FromArgb(255, 127, 80);
			iconBanHang.BackColor = Color.FromArgb(255, 127, 80);
			btnBanHang.FlatAppearance.BorderColor = Color.White;
		}
		private void un_btHeader_Click()
		{
			this.btnBanHang.BackColor = Color.OrangeRed;
			iconBanHang.BackColor = Color.OrangeRed;
			btnBanHang.FlatAppearance.BorderColor = Color.OrangeRed;

			this.btnNhapHang.BackColor = Color.OrangeRed;
			iconNhapHang.BackColor = Color.OrangeRed;
			btnNhapHang.FlatAppearance.BorderColor = Color.OrangeRed;

			this.btnKhachHang.BackColor = Color.OrangeRed;
			iconKhachHang.BackColor = Color.OrangeRed;
			btnKhachHang.FlatAppearance.BorderColor = Color.OrangeRed;

			this.btnNhaCC.BackColor = Color.OrangeRed;
			iconNhaCC.BackColor = Color.OrangeRed;
			btnNhaCC.FlatAppearance.BorderColor = Color.OrangeRed;

			this.btnTaiKhoan.BackColor = Color.OrangeRed;
			iconTaiKhoan.BackColor = Color.OrangeRed;
			btnTaiKhoan.FlatAppearance.BorderColor = Color.OrangeRed;

			this.btnVatLieu.BackColor = Color.OrangeRed;
			iconVatLieu.BackColor = Color.OrangeRed;
			btnVatLieu.FlatAppearance.BorderColor = Color.OrangeRed;

			this.btnDangXuat.BackColor = Color.OrangeRed;
			iconDangXuat.BackColor = Color.OrangeRed;
			btnDangXuat.FlatAppearance.BorderColor = Color.OrangeRed;
		}

		private void BtnNhapHang_Click(object sender, EventArgs e)
		{	
			// kiểm tra quyền truy cập
			if(!biencucbo.loaitaikhoan.Equals("Quản Lý Kho") && !biencucbo.loaitaikhoan.Equals("admin"))
			{
				MessageBox.Show("Bạn không có quyền truy cập mục này");
				return;
			}
			// reset lại toàn bộ menu và set lại màu khi click vào menu
			un_btHeader_Click();
			pnContent.Controls.Clear();
			QUANLYNHAPHANG.NhapHang nhapHang = new QUANLYNHAPHANG.NhapHang();
			nhapHang.TopLevel = false;
			pnContent.Controls.Add(nhapHang);
			nhapHang.Show();
			this.btnNhapHang.BackColor = Color.FromArgb(255, 127, 80);
			iconNhapHang.BackColor = Color.FromArgb(255, 127, 80);
			btnNhapHang.FlatAppearance.BorderColor = Color.White;
		}

		private void BtnKhachHang_Click(object sender, EventArgs e)
		{
			// kiểm tra quyền truy cập
			if (!biencucbo.loaitaikhoan.Equals("Nhân Viên") && !biencucbo.loaitaikhoan.Equals("admin"))
			{
				MessageBox.Show("Bạn không có quyền truy cập mục này");
				return;
			}
			un_btHeader_Click();
			pnContent.Controls.Clear();
			KhachHang khachHang = new KhachHang();
			khachHang.TopLevel = false;
			pnContent.Controls.Add(khachHang);
			khachHang.Show();
			this.btnKhachHang.BackColor = Color.FromArgb(255, 127, 80);
			iconKhachHang.BackColor = Color.FromArgb(255, 127, 80);
			btnKhachHang.FlatAppearance.BorderColor = Color.White;
		}

		private void BtnNhaCC_Click(object sender, EventArgs e)
		{
			// kiểm tra quyền truy cập
			if (!biencucbo.loaitaikhoan.Equals("Quản Lý Kho") && !biencucbo.loaitaikhoan.Equals("admin"))
			{
				MessageBox.Show("Bạn không có quyền truy cập mục này");
				return;
			}
			un_btHeader_Click();
			pnContent.Controls.Clear();
			NhaCungCap nhaCungCap = new NhaCungCap();
			nhaCungCap.TopLevel = false;
			pnContent.Controls.Add(nhaCungCap);
			nhaCungCap.Show();
			this.btnNhaCC.BackColor = Color.FromArgb(255, 127, 80);
			iconNhaCC.BackColor = Color.FromArgb(255, 127, 80);
			btnNhaCC.FlatAppearance.BorderColor = Color.White;
		}

		private void BtnTaiKhoan_Click(object sender, EventArgs e)
		{
			// kiểm tra quyền truy cập
			if (!biencucbo.loaitaikhoan.Equals("admin"))
			{
				MessageBox.Show("Bạn không có quyền truy cập mục này");
				return;
			}
			un_btHeader_Click();
			pnContent.Controls.Clear();
			NhanVien nhanVien = new NhanVien();
			nhanVien.TopLevel = false;
			pnContent.Controls.Add(nhanVien);
			nhanVien.Show();
			this.btnTaiKhoan.BackColor = Color.FromArgb(255, 127, 80);
			iconTaiKhoan.BackColor = Color.FromArgb(255, 127, 80);
			btnTaiKhoan.FlatAppearance.BorderColor = Color.White;
		}

		private void BtnDangXuat_Click(object sender, EventArgs e)
		{
			DangNhap dangNhap = new DangNhap();
			biencucbo.taikhoan = null;
			biencucbo.loaitaikhoan = null;
			this.Hide();
			dangNhap.ShowDialog();

		}

		private void BtnVatLieu_Click(object sender, EventArgs e)
		{
			// kiểm tra quyền truy cập
			if (!biencucbo.loaitaikhoan.Equals("Quản Lý Kho") && !biencucbo.loaitaikhoan.Equals("admin"))
			{
				MessageBox.Show("Bạn không có quyền truy cập mục này");
				return;
			}
			un_btHeader_Click();
			pnContent.Controls.Clear();
			VatLieu vatLieu = new VatLieu();
			vatLieu.TopLevel = false;
			pnContent.Controls.Add(vatLieu);
			vatLieu.Show();
			this.btnVatLieu.BackColor = Color.FromArgb(255, 127, 80);
			iconVatLieu.BackColor = Color.FromArgb(255, 127, 80);
			btnVatLieu.FlatAppearance.BorderColor = Color.White;
		}
		// hàm hiển thị với 1 form được truuyền vào lên trang chủ
		public void showForm(Form form)
		{
			pnContent.Controls.Clear();
			form.TopLevel = false;
			pnContent.Controls.Add(form);
			form.Show();
		}




	}
}
