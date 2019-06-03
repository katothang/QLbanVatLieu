using QuanLyVatLieu.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;

namespace QuanLyVatLieu.DAO
{
    class hoadonDAO
    {
        private static hoadonDAO instance;

        internal static hoadonDAO Instance
        {
            get { if (instance == null) instance = new hoadonDAO(); return instance; }
            private set { instance = value; }
        }

        public DataTable showHoadon(String maKH)
        {
			String query = "exec thongtinhoadon '"+maKH+"'";
			return SQLconnect.Instance.ExecuteQuery(query);
		}

		public DataTable showInHoadon(String maKH, string date)
		{
			date = date.Substring(0, 10);
			String query = "exec inthongtinhoadon '" + maKH + "', '" + date + "'";
			return SQLconnect.Instance.ExecuteQuery(query);
		}


		public int themDL(String makh, String manv, String mahh, String tenhh,String dongia, String soluong, String thanhtien, string tinhtrang)
        {
            String Query = String.Format("insert into hoadon(makh,MaNV,mahh,tenhh,dongia,soluong,ThanhTien, TinhTrang) values('{0}','{1}','{2}',N'{3}','{4}','{5}','{6}','{7}')", makh, manv, mahh, tenhh,dongia, soluong, thanhtien, tinhtrang);
            return SQLconnect.Instance.ExecuteNonQuery(Query);
        }
    }
}
