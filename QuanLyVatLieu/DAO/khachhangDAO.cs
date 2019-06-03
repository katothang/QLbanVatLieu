using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;

namespace QuanLyVatLieu.DAO
{
    class khachhangDAO
    {
        private static khachhangDAO instance;

        public static khachhangDAO Instance
        {
            get { if (instance == null) instance = new khachhangDAO(); return instance; }
            private set { instance = value; }
        }


        public DataTable showkhachhang()
        {
            String query = "select * from khachhang";
            return SQLconnect.Instance.ExecuteQuery(query);
        }

        public int themDL(String MaKH, String TenKH, String GioiTinh, String DiaChi, String Sdt, DateTime NgaySinh)
        {
         
            string NgaySinh1 = NgaySinh.ToString("yyyy-MM-dd");
            String query = String.Format("insert into KHACHHANG(MaKH,TenKH,GioiTinh,DiaChi,Sdt,NgaySinh) values('{0}',N'{1}',N'{2}',N'{3}','{4}','{5}')", MaKH, TenKH, GioiTinh, DiaChi, Sdt, NgaySinh1);
            return SQLconnect.Instance.ExecuteNonQuery(query);

        }

        public void Xoa(String makh)
        {
            String query = String.Format("delete KHACHHANG where MaKH='{0}'", makh);
            SQLconnect.Instance.ExecuteNonQuery(query);
        }

        //
        public int Sua(String MaKH, String TenKH, String GioiTinh, String DiaChi, String Sdt, DateTime NgaySinh)
        {
            string NgaySinh1 = NgaySinh.ToString("yyyy-MM-dd");
            String query = String.Format("update KHACHHANG  set TenKH=N'{1}',GioiTinh=N'{2}',DiaChi=N'{3}',Sdt='{4}',NgaySinh='{5}' where makh='{0}'", MaKH, TenKH, GioiTinh, DiaChi, Sdt, NgaySinh1);
            return SQLconnect.Instance.ExecuteNonQuery(query);

        }

        // kiểm tra xem mã khach hàng (SCMTND ) có trong bảng khách hàng chưa

        public bool ktMKH(String scm)
        {
            String Query = String.Format("select * from khachhang where makh='{0}'", scm);
            DataTable data = new DataTable();
            data = SQLconnect.Instance.ExecuteQuery(Query);
            if (data.Rows.Count > 0)
                return true;
            return false;
        }

        public DataTable timkiem(String noidung)
        {
            String query = String.Format("select * from khachhang where makh like '%{0}%' or tenkh like '%{0}%'",noidung);
            return SQLconnect.Instance.ExecuteQuery(query);
        }

    }
}
