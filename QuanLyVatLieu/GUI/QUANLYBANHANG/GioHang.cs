using QuanLyVatLieu.DAO;
using QuanLyVatLieu.DTO;
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
	public partial class GioHang : Form
	{
		public GioHang()
		{
			InitializeComponent();
			gvdata.DataSource = giohangDAO.Instance.showALLGiohang();
			//hien thị tổng tiền
			txtTongTien.Text = giohangDAO.Instance.tongtien(biencucbo.taikhoan).ToString();
			cbbgioitinh.SelectedIndex = 0;
			//
			gvdata.Columns[0].HeaderText = "Mã HH";
			gvdata.Columns[1].HeaderText = "Nhân Viên";
			gvdata.Columns[2].HeaderText = "Tên HH";
			gvdata.Columns[3].HeaderText = "Số Lượng";
			gvdata.Columns[4].HeaderText = "Đơn Giá";
			gvdata.Columns[5].HeaderText = "Thành Tiền";

			// chỉnh format ngày tháng năm
			dtngaysinh.CustomFormat = "dd-MM-yyyy";
		}

		private void Gvdata_CellContentClick(object sender, DataGridViewCellEventArgs e)
		{

		}

		private void BtHuy_Click(object sender, EventArgs e)
		{
			try
			{
				giohangDAO.Instance.xoagiohang(gvdata.SelectedRows[0].Cells[0].Value.ToString());
				MessageBox.Show("Xóa Thành công mã hàng " + gvdata.SelectedRows[0].Cells[0].Value.ToString());
				gvdata.DataSource = giohangDAO.Instance.showALLGiohang();
				txtTongTien.Text = giohangDAO.Instance.tongtien(biencucbo.taikhoan).ToString();

			}
			catch (Exception)
			{

				MessageBox.Show("lỗi..!");
			}
		}

		private void BtThanhToan_Click(object sender, EventArgs e)
		{
			if (giohangDAO.Instance.soluongGH(biencucbo.taikhoan) <= 0)
			{
				MessageBox.Show("giỏ hàng đang rỗng không có gì để thanh toán");
				return;
			}
			// kiểm tra trường rỗng 
			if (tbSDT.Text == "" || tbtenkh.Text == "" || tbSCM.Text == "" || tbdiachi.Text == "")
			{
				if (tbSDT.Text == "")
					lbsdt.Text = "Số điện thoại không được để trống";
				if (tbtenkh.Text == "")
					lbtenkh.Text = "tên khách hàng không được để trống.!";
				if (tbSCM.Text == "")
					lbscm.Text = "Số CMTND không được để trống.!";
				if (tbdiachi.Text == "")
					lbdiachi.Text = "Địa chỉ không được để trống.!";
				return;
			}
			//kiem tra rang buộc
			if (!rangbuoc.Instance.checkphone(tbSDT.Text))
			{
				lbsdt.Text = "Số điện thoại không đúng.!";
				return;
			}

			if (!chuanhoa.Instance.checkSCM(tbSCM.Text))
			{
				lbscm.Text = "sai số chứng minh thư nhân dân";
				return;
			}


			//end


			// kiểm tra xem người này đã mua hàng bao giờ chưa 
			if (khachhangDAO.Instance.ktMKH(tbSCM.Text))
			{
				// đã mua rồi thì thêm dl vào bảng hóa đơn
				try
				{
					List<giohangDTO> listgiohang = new List<giohangDTO>();
					listgiohang = giohangDAO.Instance.showGiohang(biencucbo.taikhoan);
					foreach (giohangDTO item in listgiohang)
					{
						hoadonDAO.Instance.themDL(tbSCM.Text, biencucbo.taikhoan, item.MaHH.ToString(), item.TenHH.ToString(), item.DonGia.ToString(), item.Soluong.ToString(), item.Thanhtien.ToString(),tbTinhTrang.Text);
						int slcon = hanghoaDAO.Instance.ktSLhanghoa(item.MaHH.ToString());
						int soluong = 0;
						soluong = slcon - item.Soluong;
						hanghoaDAO.Instance.updateSL(item.MaHH.ToString(), soluong);

					}
					MessageBox.Show("khách hàng này là khách hàng cũ của cử hàng vì thế hệ thống sẽ dùng thông tin cũ để in hóa đơn");
					chuyentoimuchoadon();


				}
				catch (Exception)
				{

					MessageBox.Show("lỗi");
				}

			}
			// chưa mua thì thông báo cho nhân viên là kh mới và tự động thêm dl khách hàng mới vào csdl

			else
			{

				try
				{
					khachhangDAO.Instance.themDL(tbSCM.Text, tbtenkh.Text, cbbgioitinh.Text, tbdiachi.Text, tbSDT.Text, dtngaysinh.Value);
					List<giohangDTO> listgiohang = new List<giohangDTO>();
					listgiohang = giohangDAO.Instance.showGiohang(biencucbo.taikhoan);
					foreach (giohangDTO item in listgiohang)
					{
						hoadonDAO.Instance.themDL(tbSCM.Text, biencucbo.taikhoan, item.MaHH.ToString(), item.TenHH.ToString(), item.DonGia.ToString(), item.Soluong.ToString(), item.Thanhtien.ToString(),tbTinhTrang.Text);
						int slcon = hanghoaDAO.Instance.ktSLhanghoa(item.MaHH.ToString());
						int soluong = 0;
						soluong = slcon - item.Soluong;
						hanghoaDAO.Instance.updateSL(item.MaHH.ToString(), soluong);
					}


					MessageBox.Show("đây là khách hàng mới hệ thống đã tự động thêm thông tin vào CSDL");
					chuyentoimuchoadon();

				}
				catch (Exception)
				{

					MessageBox.Show("lỗi");
				}


			}
			giohangDAO.Instance.deleteall(); // // xóa toàn bộ giỏ hàng khi thanh thoán thành công
											 // update lại số lượng hàng trong kho 
											 //trtr
			gvdata.DataSource = giohangDAO.Instance.showALLGiohang();
		}
		public void chuyentoimuchoadon()
		{
			InHoaDon inhd = new InHoaDon(tbSCM.Text);
			inhd.ShowDialog();



		}

	}
}
