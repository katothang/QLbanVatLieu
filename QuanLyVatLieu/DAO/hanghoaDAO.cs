using QuanLyVatLieu.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;

namespace QuanLyVatLieu.DAO
{
    class hanghoaDAO
    {
        private static hanghoaDAO instance;

        public static hanghoaDAO Instance
        {
            get { if (instance == null) instance = new hanghoaDAO(); return hanghoaDAO.instance; }
            private set { hanghoaDAO.instance = value; }
        }

        public DataTable showhanghoa()
        {
            String query = "select * from hanghoa";
            return SQLconnect.Instance.ExecuteQuery(query);
        }
		public DataRow getTenHangHoa(string mahh)
		{
			String query = "select * from hanghoa where MaHH = '"+mahh+"'";
			DataTable dataTable =  SQLconnect.Instance.ExecuteQuery(query);
			try
			{
				foreach (DataRow item in dataTable.Rows)
				{
					return item;
				}
				return null;
			}
			catch
			{
				return null;
			}
			

		}

		public DataTable showhangban()
        {
            String query = "select MaHH,MaNCC,TenHH,LoaiHang,NhanHieu,DonGia,soluongcon,MoTa from hanghoa";
            return SQLconnect.Instance.ExecuteQuery(query);
        }
        public int themDL(String mahang, String tenhang, String mancc, String loaihang, String nhanhieu, String dongia,String gianhap, String soluongcon, String mota)
        {
            String query = String.Format("insert into HANGHOA(MaHH,MaNCC,TenHH,LoaiHang,NhanHieu,DonGia,dongianhap,soluongcon,MoTa) values('{0}','{1}',N'{2}',N'{3}',N'{4}','{5}','{6}','{7}','{8}')", mahang, mancc, tenhang, loaihang, nhanhieu, dongia,gianhap, soluongcon, mota);
            return SQLconnect.Instance.ExecuteNonQuery(query);

        }

        public void Xoa(String mahang)
        {
            String query = String.Format("delete HANGHOA where maHH='{0}'", mahang);
            SQLconnect.Instance.ExecuteNonQuery(query);
        }

        //
        public int Sua(String mahang, String tenhang, String mancc, String loaihang, String nhanhieu, String dongia,String gianhap, String soluongcon, String mota)
        {
            String query = String.Format("update HANGHOA set MaNCC='{0}',TenHH=N'{1}',LoaiHang=N'{2}',NhanHieu=N'{3}',DonGia='{4}',MoTa=N'{5}',soluongcon='{7}',dongianhap = '{8}' where maHH='{6}'", mancc, tenhang, loaihang, nhanhieu, dongia, mota, mahang, soluongcon,gianhap);
            return SQLconnect.Instance.ExecuteNonQuery(query);

        }


        public int ktSLhanghoa(String mahh)
        {
            String query = String.Format("select soluongcon from hanghoa where mahh='{0}'", mahh);
            DataTable data = new DataTable();
            data = SQLconnect.Instance.ExecuteQuery(query);
            hanghoaDTO hh = new hanghoaDTO(data.Rows[0]);
            return hh.Soluong;

        }


        // update lại số lượng khi ấn thanh toán 

        public int updateSL(String mahh, int soluong)
        {
            
            String Query = String.Format("update hanghoa set soluongcon='{0}' where mahh= '{1}'", soluong, mahh);
            return SQLconnect.Instance.ExecuteNonQuery(Query);
        }


        public DataTable timkiem(String noidung)
        {
            String query = String.Format("select * from hanghoa where mahh like '%{0}%' or tenhh like '%{0}%'",noidung);
            return SQLconnect.Instance.ExecuteQuery(query);
        }

        public DataTable timkiemhangban(String noidung)
        {
            String query = String.Format("select MaHH,MaNCC,TenHH,LoaiHang,NhanHieu,DonGia,soluongcon,MoTa from hanghoa where mahh like '%{0}%' or tenhh like '%{0}%'", noidung);
            return SQLconnect.Instance.ExecuteQuery(query);
        }
    }
}
