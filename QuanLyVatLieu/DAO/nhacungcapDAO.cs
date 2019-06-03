using QuanLyVatLieu.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;

namespace QuanLyVatLieu.DAO
{
    class nhacungcapDAO
    {
        private static nhacungcapDAO instance;

        internal static nhacungcapDAO Instance
        {
            get { if (instance == null) instance = new nhacungcapDAO(); return nhacungcapDAO.instance; }
            private set { nhacungcapDAO.instance = value; }
        }

        public List<nhacungcapDTO> shownhacc()
        {
            List<nhacungcapDTO> listncc = new List<nhacungcapDTO>();
            String query = "select * from nhacungcap";
            DataTable data = new DataTable();
            data = SQLconnect.Instance.ExecuteQuery(query);
            foreach (DataRow item in data.Rows)
            {
                nhacungcapDTO ncc = new nhacungcapDTO(item);
                listncc.Add(ncc);
            }
            return listncc;
        }

        //thêm sửa xóa dl nhà cung cấp

        public int ThemDL(String mancc, String tenNCC, String diachi, String SDT, String email)
        {
            String query = String.Format("insert into nhacungcap values('{0}',N'{1}',N'{2}','{3}','{4}')", mancc, tenNCC, diachi, SDT, email);
            return SQLconnect.Instance.ExecuteNonQuery(query);
        }
        /////
        public int SuaDL(String mancc, String tenNCC, String diachi, String SDT, String email)
        {
            String query = String.Format("update nhacungcap set tenncc=N'{1}', diachi=N'{2}',SoDT ='{3}',email = '{4}' where mancc='{0}'", mancc, tenNCC, diachi, SDT, email);
            return SQLconnect.Instance.ExecuteNonQuery(query);
        }

        ////
        public int xoaDL(String mancc)
        {
            String query = String.Format("delete nhacungcap where mancc='{0}'", mancc);
            return SQLconnect.Instance.ExecuteNonQuery(query);
        }


        public List<nhacungcapDTO> timkiem(String noidung)
        {
            List<nhacungcapDTO> listncc = new List<nhacungcapDTO>();
            String query = String.Format("select * from nhacungcap where mancc like '%{0}%' or tenncc like '%{0}%'", noidung);
            DataTable data = new DataTable();
            data = SQLconnect.Instance.ExecuteQuery(query);
            foreach (DataRow item in data.Rows)
            {
                nhacungcapDTO ncc = new nhacungcapDTO(item);
                listncc.Add(ncc);
            }
            return listncc;
        }
    }
}
