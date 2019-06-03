using QuanLyVatLieu.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Globalization;
using System.Linq;
using System.Text;

namespace QuanLyVatLieu.DAO
{
    class xuathangDAO
    {
        private static xuathangDAO instance;

        internal static xuathangDAO Instance
        {
            get { if (instance == null) instance = new xuathangDAO(); return instance; }
            private set { instance = value; }
        }

        public List<xuathangDTO> showalllichsu()
        {
            String Query = "select * from hoadon";
            DataTable data = new DataTable();
            List<xuathangDTO> list = new List<xuathangDTO>();
            data = SQLconnect.Instance.ExecuteQuery(Query);
            foreach (DataRow item in data.Rows)
            {
                xuathangDTO ls = new xuathangDTO(item);
                list.Add(ls);
            }
            return list;
        }
        // loc ngay 
        public List<xuathangDTO> showlichsu(DateTime tungay, DateTime denngay)
        {
            string tungay1 = tungay.ToString("yyyy-MM-dd");
            string denngay1 = tungay.ToString("yyyy-MM-dd");
            String Query = String.Format("select * from hoadon where ngayban >='{0}' and ngayban<='{1}'", tungay1, denngay1);
            DataTable data = new DataTable();
            List<xuathangDTO> list = new List<xuathangDTO>();
            data = SQLconnect.Instance.ExecuteQuery(Query);
            foreach (DataRow item in data.Rows)
            {
                xuathangDTO ls = new xuathangDTO(item);
                list.Add(ls);
            }
            return list;
        }

		public DataTable inHoaDon(DateTime tungay, DateTime denngay)
		{
            string tungay1 = tungay.ToString("yyyy-MM-dd");
            string denngay1 = tungay.ToString("yyyy-MM-dd");
            String Query = String.Format("select * from hoadon where ngayban >='{0}' and ngayban<='{1}'", tungay1, denngay1);
			DataTable data = new DataTable();
			List<xuathangDTO> list = new List<xuathangDTO>();
			data = SQLconnect.Instance.ExecuteQuery(Query);
			
			return data;
		}

		public List<xuathangDTO> showlichsutim(DateTime tungay, DateTime denngay,String noidung)
        {
            String Query = String.Format("select * from hoadon where ngayban >='{0}' and ngayban<='{1}' and mahh like '%{2}%' or tenhh like '%{2}%' or manv like '%{2}%' ", tungay, denngay,noidung);
            DataTable data = new DataTable();
            List<xuathangDTO> list = new List<xuathangDTO>();
            data = SQLconnect.Instance.ExecuteQuery(Query);
            foreach (DataRow item in data.Rows)
            {
                xuathangDTO ls = new xuathangDTO(item);
                list.Add(ls);
            }
            return list;
        }
    }
}
