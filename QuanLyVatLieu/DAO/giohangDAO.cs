using QuanLyVatLieu.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;

namespace QuanLyVatLieu.DAO
{
    class giohangDAO
    {
        private static giohangDAO instance;

        public static giohangDAO Instance
        {
            get { if (instance == null) instance = new giohangDAO(); return giohangDAO.instance; }
            set { giohangDAO.instance = value; }
        }


        public int themvaogiohang(String mahh, String manv, String tenhh, String soluong)
        {
            String query = String.Format("insert into GIOHANG(mahh,manv,tenhh,soluong) values('{0}','{1}','{2}','{3}')", mahh, manv, tenhh, soluong);
            return SQLconnect.Instance.ExecuteNonQuery(query);
        }

        public bool ktGioHang(String mahh, String Manv)
        {
            String query = String.Format("select * from giohang where mahh='{0}' and manv ='{1}'", mahh, Manv);
            DataTable data = new DataTable();
            data = SQLconnect.Instance.ExecuteQuery(query);
            if (data.Rows.Count > 0)
                return true;
            return false;
        }

        public int soluongGH(String manv)
        {
            String query = "select * from giohang where manv='" + manv + "'";
            DataTable data = new DataTable();
            data = SQLconnect.Instance.ExecuteQuery(query);
            return data.Rows.Count;
        }

        public List<giohangDTO> showGiohang(String manv)
        {
            List<giohangDTO> listgiohang = new List<giohangDTO>();
            DataTable data = new DataTable();
            String query = @"select GIOHANG.MaHH,HANGHOA.TenHH,GIOHANG.SoLuong,HANGHOA.DonGia,GIOHANG.manv from giohang join hanghoa on HANGHOA.MaHH=GIOHANG.MaHH where GIOHANG.MaNV = '" + manv + "'";
            data = SQLconnect.Instance.ExecuteQuery(query);
            foreach (DataRow item in data.Rows)
            {
                giohangDTO gh = new giohangDTO(item);
                listgiohang.Add(gh);
            }

            return listgiohang;

        }
        //
        public List<giohangDTO> showALLGiohang()
        {
            List<giohangDTO> listgiohang = new List<giohangDTO>();
            DataTable data = new DataTable();
            String query = @"select GIOHANG.MaHH,HANGHOA.TenHH,GIOHANG.SoLuong,HANGHOA.DonGia,GIOHANG.manv from giohang join hanghoa on HANGHOA.MaHH=GIOHANG.MaHH";
            data = SQLconnect.Instance.ExecuteQuery(query);
            foreach (DataRow item in data.Rows)
            {
                giohangDTO gh = new giohangDTO(item);
                listgiohang.Add(gh);
            }

            return listgiohang;

        }
        //
        public int suaSLgiohang(String mahh, String soluong)
        {
            String Query = String.Format("update giohang set soluong ='{0}' where mahh='{1}'", soluong, mahh);
            return SQLconnect.Instance.ExecuteNonQuery(Query);
        }

        public int xoagiohang(String mahh)
        {
            String Query = String.Format("delete giohang where mahh='{0}'", mahh);
            return SQLconnect.Instance.ExecuteNonQuery(Query);
        }

        // xóa toàn bộ giỏ hàng 

        public int deleteall()
        {
            return SQLconnect.Instance.ExecuteNonQuery("delete giohang");
        }

        //tìm kiếm
        public List<giohangDTO> timkiem(String noidung)
        {
            List<giohangDTO> listgiohang = new List<giohangDTO>();
            DataTable data = new DataTable();
            String query = String.Format("select GIOHANG.MaHH,HANGHOA.TenHH,GIOHANG.SoLuong,HANGHOA.DonGia,GIOHANG.manv from giohang join hanghoa on HANGHOA.MaHH=GIOHANG.MaHH where  HANGHOA.TenHH like '%{0}%' or GIOHANG.SoLuong like '%{0}%' or HANGHOA.DonGia like '%{0}%' or GIOHANG.manv like '%{0}%'", noidung);
            data = SQLconnect.Instance.ExecuteQuery(query);
            foreach (DataRow item in data.Rows)
            {
                giohangDTO gh = new giohangDTO(item);
                listgiohang.Add(gh);
            }

            return listgiohang;

        }

        //tính tổng tiền
        public float tongtien(String manv)
        {
            float tongtien = 0;
            List<giohangDTO> listgiohang = new List<giohangDTO>();
            DataTable data = new DataTable();
            String query = @"select GIOHANG.MaHH,HANGHOA.TenHH,GIOHANG.SoLuong,HANGHOA.DonGia,GIOHANG.manv from giohang join hanghoa on HANGHOA.MaHH=GIOHANG.MaHH where GIOHANG.MaNV = '" + manv + "'";
            data = SQLconnect.Instance.ExecuteQuery(query);
            foreach (DataRow item in data.Rows)
            {
                giohangDTO gh = new giohangDTO(item);
                tongtien = tongtien + gh.Thanhtien;
            }
            return tongtien;

            

        }
    }
}
