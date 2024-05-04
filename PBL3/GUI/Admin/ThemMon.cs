using Guna.UI2.WinForms;
using PBL3.BUS;
using PBL3.DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PBL3.GUI
{
    public partial class ThemMon : Form
    {
        private int maNV;

        public ThemMon()
        {
            InitializeComponent();
            QuanCaPhePBL3Entities db = new QuanCaPhePBL3Entities();
            nguyenLieu.DataSource= db.NguyenLieux.ToList();
            DataTable dt = new DataTable(); 
            dt.Columns.Add("MaNL");
            dt.Columns.Add("TenNL");
            dt.Columns.Add("SoLuong");
            dt.Columns.Add("DonViTinh");
            dinhLuong.DataSource = dt;
            
        }

        public ThemMon(int maNV)
        {
            this.maNV = maNV;
            InitializeComponent();
            QuanCaPhePBL3Entities db = new QuanCaPhePBL3Entities();
            nguyenLieu.DataSource = db.NguyenLieux.ToList();
            DataTable dt = new DataTable();
            dt.Columns.Add("MaNL");
            dt.Columns.Add("TenNL");
            dt.Columns.Add("SoLuong");
            dt.Columns.Add("DonViTinh");
            dinhLuong.DataSource = dt;
        }

        private void guna2DataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            //lấy dòng được chọn, thêm vào dinhluong
            int index = e.RowIndex;
            DataGridViewRow selectedRow = nguyenLieu.Rows[index];
            //kiểm tra đã có nguyên liệu này trong bảng định lượng chưa
            string manl = selectedRow.Cells[0].Value.ToString();
            if (dinhLuong.Rows.Count > 0)
            {
                foreach (DataGridViewRow row in dinhLuong.Rows)
                {
                    if (row.Cells[0].Value != null)
                    {
                        if (row.Cells[0].Value.ToString() == manl)
                        {
                            MessageBox.Show("Nguyên liệu đã tồn tại trong bảng định lượng!");
                            return;
                        }
                    }
                }
            }
           
            string tennl = selectedRow.Cells[1].Value.ToString();
            string donvi = selectedRow.Cells[3].Value.ToString();
            DataTable dt = (DataTable)dinhLuong.DataSource;
            dt.Rows.Add(manl, tennl, "", donvi);
            dinhLuong.DataSource = dt;
            
        }
        private void saveSP_Click(object sender, EventArgs e)
        {
            QuanCaPhePBL3Entities db = new QuanCaPhePBL3Entities();
            var s = db.SanPhams.OrderByDescending(p => p.MaSP).FirstOrDefault();
            string masp = Convert.ToString(s.MaSP + 1);
            string loai;
            if (doUongRb.Checked)
            {
                loai = "Đồ uống";
            }
            else loai = "Món ăn";
            SanPham_BLL.Instance.AddSanPham(masp, tenMon.Text, giaBan.Text, loai, nhomThucDon.Text, donViTinh.Text);
            MessageBox.Show("Thêm món thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            Dispose();
        }

        private void cancelSP_Click(object sender, EventArgs e)
        {
            Dispose();
        }

    }
}
