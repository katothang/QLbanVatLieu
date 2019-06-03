using QuanLyVatLieu.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;

namespace QuanLyVatLieu.DAO
{
    class nhaphangDAO
    {
        private static nhaphangDAO instance;

        internal static nhaphangDAO Instance
        {
            get { if (instance == null) instance = new nhaphangDAO(); return instance; }
            set { instance = value; }
        }


        public int insertnhap(String MaNV, String MaHH, String TenHH, float DonGia, int soluong)
        {
            float thanhtien = 0;
            thanhtien = DonGia * soluong;
            String Query = String.Format("insert into nhaphang(MaNV,MaHH,TenHH,DonGia,soluong,thanhtien) values('{0}','{1}',N'{2}','{3}','{4}','{5}')", MaNV, MaHH, TenHH, DonGia, soluong, thanhtien);
            return SQLconnect.Instance.ExecuteNonQuery(Query);
        }

        public List<nhaphangDTO> shownhaphang()
        {
            List<nhaphangDTO> list = new List<nhaphangDTO>();
            String Query = "select * from nhaphang";
            DataTable data = new DataTable();
            data = SQLconnect.Instance.ExecuteQuery(Query);
            foreach (DataRow item in data.Rows)
            {
                nhaphangDTO nh = new nhaphangDTO(item);
                list.Add(nh);

            }
            return list;

        }

        public List<nhaphangDTO> loctheongay(DateTime tungay, DateTime denngay)
        {
            string tungay1 = tungay.ToString("yyyy-MM-dd");
            string denngay1 = tungay.ToString("yyyy-MM-dd");
            List<nhaphangDTO> list = new List<nhaphangDTO>();
            String Query = String.Format("select * from nhaphang where ngaynhap >= '{0}' and ngaynhap <= '{1}'", tungay1, denngay1);
            DataTable data = new DataTable();
            data = SQLconnect.Instance.ExecuteQuery(Query);
            foreach (DataRow item in data.Rows)
            {
                nhaphangDTO nh = new nhaphangDTO(item);
                list.Add(nh);

            }
            return list;

        }

		public DataTable inBaoCao(DateTime tungay, DateTime denngay)
		{
            string tungay1 = tungay.ToString("yyyy-MM-dd");
            string denngay1 = tungay.ToString("yyyy-MM-dd");
            List<nhaphangDTO> list = new List<nhaphangDTO>();
			String Query = String.Format("select * from nhaphang where ngaynhap >= '{0}' and ngaynhap <= '{1}'", tungay1, denngay1);
			DataTable data = new DataTable();
			data = SQLconnect.Instance.ExecuteQuery(Query);
			return data;
		}

		public List<nhaphangDTO> loctheongaytheoten(DateTime tungay, DateTime denngay,String noidung)
        {
            string tungay1 = tungay.ToString("yyyy-MM-dd");
            string denngay1 = tungay.ToString("yyyy-MM-dd");
            List<nhaphangDTO> list = new List<nhaphangDTO>();
            String Query = String.Format("select * from nhaphang where ngaynhap >= '{0}' and ngaynhap <= '{1}' and mahh like '%{2}%' or tenhh like '%{2}%'", tungay1, denngay1,noidung);
            DataTable data = new DataTable();
            data = SQLconnect.Instance.ExecuteQuery(Query);
            foreach (DataRow item in data.Rows)
            {
                nhaphangDTO nh = new nhaphangDTO(item);
                list.Add(nh);

            }
            return list;

        }
        public float tongtien()
        {
            float tongtien = 0;
            String Query = String.Format("select * from nhaphang");
            DataTable data = new DataTable();
            data = SQLconnect.Instance.ExecuteQuery(Query);
            foreach (DataRow item in data.Rows)
            {
                nhaphangDTO nh = new nhaphangDTO(item);
                tongtien = tongtien + nh.Thanhtien;

            }
            return tongtien;
        }
        //xóa hàng 

        public int xoa(string manh)
        {
            String Query = String.Format("delete nhaphang where STT = '{0}'", manh);
            return SQLconnect.Instance.ExecuteNonQuery(Query);
        }
    }
}
