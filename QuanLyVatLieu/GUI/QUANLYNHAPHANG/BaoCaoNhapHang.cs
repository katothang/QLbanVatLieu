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
	public partial class BaoCaoNhapHang : Form
	{
		public BaoCaoNhapHang(DateTime tungay, DateTime denngay)
		{
			InitializeComponent();
			baoCaoNhapHang1BindingSource.DataSource = nhaphangDAO.Instance.inBaoCao(tungay, denngay);
			this.reportViewer1.RefreshReport();
		}

		private void BaoCaoNhapHang_Load(object sender, EventArgs e)
		{

			this.reportViewer1.RefreshReport();
		}
	}
}
