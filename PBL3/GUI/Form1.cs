using PBL3.DAO;
using PBL3.DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.ComponentModel.DataAnnotations.Schema;
using System.Runtime.Remoting.Contexts;

namespace PBL3.GUI
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            QuanCaPhe db = new QuanCaPhe();

            //1 list nhân viên thêm vào ca trực
            List<NhanVien> listNV = db.NhanViens.ToList();
            //thêm vào ca trực mã 1, ngày 01/01/2021, đã có trong bảng CaTruc
            CaTruc ct = db.CaTrucs.Where(p => p.MaCT == 1 && p.NgayTruc == new DateTime(2021, 1, 1)).FirstOrDefault();
            ct.NhanViens = listNV;
            db.SaveChanges();
            dataGridView1.DataSource= ct.NhanViens.ToList();








        }
    }
}