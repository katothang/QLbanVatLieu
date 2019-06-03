using QuanLyVatLieu.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;

namespace QuanLyVatLieu.DAO
{
    class nhanvienDAO
    {
        private static nhanvienDAO instance;

        internal static nhanvienDAO Instance
        {
            get { if (instance == null) instance = new nhanvienDAO(); return nhanvienDAO.instance; }
            set { nhanvienDAO.instance = value; }
        }
        public List<nhanvienDTO> showtaikhoan()
        {
            String Query = "select * from nhanvien";
            DataTable data = new DataTable();
            data = SQLconnect.Instance.ExecuteQuery(Query);
            List<nhanvienDTO> listtaikhoan = new List<nhanvienDTO>();
            foreach (DataRow item in data.Rows)
            {
                nhanvienDTO dt = new nhanvienDTO(item);
                dt.Matkhau = "******";
                listtaikhoan.Add(dt);
            }

            return listtaikhoan;
        }

        public int themDL(String MaNV, String MatKhau, String TenNV, String quyentruycap, DateTime NgaySinh, String SDT, String DiaChi, bool gioitinh)
        {
            string NgaySinh1 = NgaySinh.ToString("yyyy-MM-dd");
            String query = String.Format("insert into NHANVIEN(MaNV,MatKhau,TenNV,quyentruycap,NgaySinh,SDT,DiaChi,gioitinh) values('{0}','{1}',N'{2}',N'{3}','{4}','{5}',N'{6}','{7}')", MaNV, MatKhau, TenNV, quyentruycap, NgaySinh1, SDT, DiaChi, gioitinh);
            return SQLconnect.Instance.ExecuteNonQuery(query);

        }

        public void Xoa(String manv)
        {
            String query = String.Format("delete nhanvien where manv='{0}'", manv);
            SQLconnect.Instance.ExecuteNonQuery(query);
        }

        //
        public int Sua(String MaNV, String MatKhau, String TenNV, String quyentruycap, DateTime NgaySinh, String SDT, String DiaChi, bool gioitinh)
        {
            string NgaySinh1 = NgaySinh.ToString("yyyy-MM-dd");
            String query = String.Format("update nhanvien set MatKhau='{1}',TenNV=N'{2}',quyentruycap='{3}',NgaySinh='{4}',SDT='{5}',DiaChi=N'{6}',gioitinh='{7}' where manv ='{0}'", MaNV, MatKhau, TenNV, quyentruycap, NgaySinh1, SDT, DiaChi, gioitinh);
            return SQLconnect.Instance.ExecuteNonQuery(query);

        }

        public nhanvienDTO thongtintaikhoan(String usename)
        {
            String Query = "select * from nhanvien where manv ='" + usename + "'";
            DataTable data = new DataTable();
            data = SQLconnect.Instance.ExecuteQuery(Query);
            nhanvienDTO dt = new nhanvienDTO(data.Rows[0]);
            return dt;
        }

        public List<nhanvienDTO> timkiem(String noidung)
        {
            String Query = String.Format("select * from nhanvien where manv like '%{0}%' or tennv like '%{1}%'", noidung,noidung);
            DataTable data = new DataTable();
            data = SQLconnect.Instance.ExecuteQuery(Query);
            List<nhanvienDTO> listtaikhoan = new List<nhanvienDTO>();
            foreach (DataRow item in data.Rows)
            {
                nhanvienDTO dt = new nhanvienDTO(item);
                dt.Matkhau = "******";
                listtaikhoan.Add(dt);
            }

            return listtaikhoan;
        }
    }
}
