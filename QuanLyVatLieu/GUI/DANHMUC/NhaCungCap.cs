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
	public partial class NhaCungCap : Form
	{
		public NhaCungCap()
		{
			InitializeComponent();
			gvdata.DataSource = nhacungcapDAO.Instance.shownhacc();
			//tieu đề
			gvdata.Columns["mancc"].HeaderText = "Mã Nhà CC";
			gvdata.Columns["tenncc"].HeaderText = "Tên Nhà CC";
			gvdata.Columns["diachi"].HeaderText = "Địa Chỉ";
			gvdata.Columns["email"].HeaderText = "Email";
			//end tieu de
		}

		private void Gvdata_CellContentClick(object sender, DataGridViewCellEventArgs e)
		{
			tbMaNCC.Text = gvdata.SelectedRows[0].Cells["mancc"].Value.ToString();
			tbTenNCC.Text = gvdata.SelectedRows[0].Cells["tenncc"].Value.ToString();
			tbDiaChi.Text = gvdata.SelectedRows[0].Cells["diachi"].Value.ToString();
			tbEmail.Text = gvdata.SelectedRows[0].Cells["email"].Value.ToString();
			tbSDT.Text = gvdata.SelectedRows[0].Cells["sdt"].Value.ToString();
		}

		private void PcSearch_Click(object sender, EventArgs e)
		{
			try
			{
				gvdata.DataSource = nhacungcapDAO.Instance.timkiem(tbTimKiem.Text);
			}
			catch (Exception)
			{

				MessageBox.Show("Lỗi..!");
			}
		}

		private void BtLamMoi_Click(object sender, EventArgs e)
		{
			gvdata.DataSource = nhacungcapDAO.Instance.shownhacc();
		}

		private void PcSave_Click(object sender, EventArgs e)
		{
			if (tbDiaChi.Text == "" || tbEmail.Text == "" || tbMaNCC.Text == "" || tbTenNCC.Text == "")
			{
				if (tbDiaChi.Text == "")
					lbdiachi.Text = "Vui lòng nhập địa chỉ.!";
				if (tbEmail.Text == "")
					lbemail.Text = "vui lòng nhập Email.!";
				if (tbMaNCC.Text == "")
					lbmncc.Text = "Vui lòng nhập mã nhà cung cấp.!";
				if (tbTenNCC.Text == "")
					lbtenncc.Text = "vui lòng nhập tên nhà cung cấp.!";
				return;
			}
			// kiểm tra email  va SDT nhập vào và định dạng mã NCC
			if (!rangbuoc.Instance.checkemail(tbEmail.Text))
			{
				lbemail.Text = "Định dạng email bạn nhập sai.!";
				return;
			}

			if (!rangbuoc.Instance.checkphone(tbSDT.Text))
			{
				lbSDT.Text = "Bạn Đã Nhập Sai SĐT";
				return;
			}

			if (!chuanhoa.Instance.chuanhoamancc(tbMaNCC.Text))
			{
				lbmncc.Text = "Mã nhà cung cấp phải bắt đầu bằng NCC và các kí tự sau là số";
				return;
			}
			//end kt eamil;


			try
			{
				nhacungcapDAO.Instance.ThemDL(tbMaNCC.Text, tbTenNCC.Text, tbDiaChi.Text, tbSDT.Text, tbEmail.Text);
				MessageBox.Show("thêm thành công mã nhà cung cấp " + tbMaNCC.Text);
				gvdata.DataSource = nhacungcapDAO.Instance.shownhacc();
			}
			catch (Exception)
			{

				MessageBox.Show("lỗi vui lòng kiểm tra lại dữ liệu");
			}
		}

		private void PcEdit_Click(object sender, EventArgs e)
		{
			if (tbMaNCC.Text != gvdata.SelectedRows[0].Cells["mancc"].Value.ToString())
			{
				lbmncc.Text = "không được sửa mã nhà cũng cấp.!";
				return;
			}

			if (tbDiaChi.Text == "" || tbEmail.Text == "" || tbMaNCC.Text == "" || tbTenNCC.Text == "")
			{
				if (tbDiaChi.Text == "")
					lbdiachi.Text = "Vui lòng nhập địa chỉ.!";
				if (tbEmail.Text == "")
					lbemail.Text = "vui lòng nhập Email.!";
				if (tbMaNCC.Text == "")
					lbmncc.Text = "Vui lòng nhập mã nhà cung cấp.!";
				if (tbTenNCC.Text == "")
					lbtenncc.Text = "vui lòng nhập tên nhà cung cấp.!";
				return;
			}
			// kiểm tra email  va SDT nhập vào và định dạng mã NCC
			if (!rangbuoc.Instance.checkemail(tbEmail.Text))
			{
				lbemail.Text = "Định dạng email bạn nhập sai.!";
				return;
			}

			if (!rangbuoc.Instance.checkphone(tbSDT.Text))
			{
				lbSDT.Text = "Bạn Đã Nhập Sai SĐT";
				return;
			}

			if (!chuanhoa.Instance.chuanhoamancc(tbMaNCC.Text))
			{
				lbmncc.Text = "Mã nhà cung cấp phải bắt đầu bằng NCC và các kí tự sau là số";
				return;
			}
			//end kt eamil;


			try
			{
				nhacungcapDAO.Instance.SuaDL(tbMaNCC.Text, tbTenNCC.Text, tbDiaChi.Text, tbSDT.Text, tbEmail.Text);
				MessageBox.Show("sửa thành công mã nhà cung cấp " + tbMaNCC.Text);
				gvdata.DataSource = nhacungcapDAO.Instance.shownhacc();
			}
			catch (Exception)
			{

				MessageBox.Show("lỗi vui lòng kiểm tra lại dữ liệu");
			}
		}

		private void PcDelete_Click(object sender, EventArgs e)
		{
			try
			{
				nhacungcapDAO.Instance.xoaDL(tbMaNCC.Text);
				MessageBox.Show("xóa thành công mã nhà cung cấp " + tbMaNCC.Text);
				gvdata.DataSource = nhacungcapDAO.Instance.shownhacc();
			}
			catch (Exception)
			{

				MessageBox.Show("lỗi vui lòng kiểm tra lại");
			}
		}
	}
}
