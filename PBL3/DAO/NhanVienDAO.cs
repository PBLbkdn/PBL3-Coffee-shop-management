//lấy thông tin trong bảng NhanVien và hiển thị lên màn hình console//lấy thông tin trong bảng NhanVien và hiển thị lên màn hình console
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using PBL3.DTO;
using System.Data;
namespace PBL3.DAO
{
    internal class NhanVienDAO
    {
        private static NhanVienDAO instance;
        internal static NhanVienDAO Instance
        {
            get { if (instance == null) instance = new NhanVienDAO(); return instance; }
            private set { instance = value; }
        }
        private NhanVienDAO() { }
        public List<NhanVien> GetListNhanVien()
        {
            List<NhanVien> list = new List<NhanVien>();
            string s = @"Data Source=DESKTOP-9SBKOG0\NGUYET;Initial Catalog=QuanCaPhe;Integrated Security=True";
            SqlConnection cnn = new SqlConnection(s);
            string query = "select * from NhanVien";
            SqlCommand cmd = new SqlCommand(query, cnn);
            cnn.Open();
            SqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                NhanVien nv = new NhanVien();
                nv.MaNV = dr.GetInt32(0);
                nv.MaCV = dr.GetInt32(1);
                nv.HoTenNV = dr.GetString(2);
                nv.NgaySinh = dr.GetDateTime(3);
                nv.SDT = dr.GetString(4);
                nv.Luong = dr.GetDouble(5);
                nv.GioiTinh = dr.GetString(6);

                list.Add(nv);
            }
            return list;
        }
    }
}