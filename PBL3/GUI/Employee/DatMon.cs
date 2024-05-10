using PBL3.BUS;
using PBL3.DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PBL3.GUI.Employee
{
    public partial class DatMon : Form
    {
        private int maNV, maCheck;
        private List<SelectedDrink> s = new List<SelectedDrink>();
        private List<SelectedDrink> s123 = new List<SelectedDrink>();
      
        public DatMon(int maNV)
        {
            InitializeComponent();
            this.maNV = maNV;
            ten.Text = NhanVien_BLL.Instance.getTenNV(maNV);
            LoadFoodItems();
            guna2DataGridView1.Columns.Add("Name", "Tên sản phẩm");
            guna2DataGridView1.Columns.Add("Quantity", "Số lượng");
        }
        public DatMon(int maNV, List<SelectedDrink> selectedDrinks, int maCheck)
        {
            this.maNV = maNV;
            this.maCheck = maCheck;
            InitializeComponent();
            ten.Text = NhanVien_BLL.Instance.getTenNV(maNV);
            this.s = selectedDrinks;
            foreach (SelectedDrink drink in s)
            {
                s123.Add(new SelectedDrink(drink)); // Thêm một bản sao của mỗi đối tượng SelectedDrink vào s123
            }
            LoadFoodItems();
            guna2DataGridView1.Columns.Add("Name", "Tên sản phẩm");
            guna2DataGridView1.Columns.Add("Quantity", "Số lượng");
            foreach (var item in s)
            {
                guna2DataGridView1.Rows.Add(item.TenMon, item.SoLuong);
            }
        }
        private void LoadFoodItems()
        {
            QuanCaPhePBL3Entities db = new QuanCaPhePBL3Entities();
            int columnCount = 3;
            int rowCount = (int)Math.Ceiling((double)(SanPham_BLL.Instance.SLsp()) / columnCount);

            flowLayoutPanel1.Controls.Clear(); // Xóa các điều khiển hiện có

            for (int i = 0; i < rowCount; i++)
            {
                FlowLayoutPanel rowPanel = new FlowLayoutPanel
                {
                    FlowDirection = FlowDirection.LeftToRight,
                    Dock = DockStyle.Top,
                    AutoSize = true,
                    WrapContents = false
                };

                for (int j = 0; j < columnCount; j++)
                {
                    int index = i * columnCount + j;
                    if (index >= (db.SanPhams.Count()))
                        break;

                    SanPham foodItem = db.SanPhams.ToList()[index];
                    Panel panel = CreateFoodItemPanel(foodItem);
                    rowPanel.Controls.Add(panel);
                }

                flowLayoutPanel1.Controls.Add(rowPanel);
            }
        }
        private Panel CreateFoodItemPanel(SanPham foodItem)
        {
            int imageSize = 200; // Kích thước ảnh cố định
            int panelWidth = imageSize + 20; // Kích thước panel = kích thước ảnh + khoảng cách lề

            Panel panel = new Panel
            {
                Size = new Size(panelWidth, 250), // Kích thước panel lớn hơn để chứa các điều khiển con
                Margin = new Padding(10)
            };

            PictureBox pictureBox = new PictureBox
            {
                Size = new Size(imageSize, imageSize), // Kích thước ảnh cố định
                SizeMode = PictureBoxSizeMode.Zoom,
                Dock = DockStyle.Top // Ảnh sẽ nằm trên cùng của panel
            };
            Image originalImage = Image.FromFile(foodItem.DuongDanAnh);
            pictureBox.Image = ScaleImage(originalImage, imageSize, imageSize);
            pictureBox.Click += (sender, e) =>
            {
                SelectedDrink selectedItem = s.Find(item => item.TenMon == foodItem.TenSP);
                if (selectedItem != null)
                {
                    // Nếu đã tồn tại, tăng số lượng lên 1
                    selectedItem.SoLuong++;
                }
                else
                {
                    s.Add(new SelectedDrink { MaSP = foodItem.MaSP, TenMon = foodItem.TenSP, SoLuong = 1, GiaSP = (long)foodItem.GiaSP });
                }

                UpdateDataGridView();
            };

            Label nameLabel = new Label
            {
                Text = foodItem.TenSP,
                TextAlign = ContentAlignment.MiddleCenter,
                Dock = DockStyle.Bottom,
                AutoSize = false, // Tắt AutoSize để có thể chỉnh kích thước Label
                Size = new Size(panel.Width, 40), // Kích thước Label
                Padding = new Padding(0, 5, 0, 0) // Padding để tạo khoảng cách với ảnh
            };

            Label priceLabel = new Label
            {
                Text = foodItem.GiaSP.ToString() + " VND",
                TextAlign = ContentAlignment.MiddleCenter,
                Dock = DockStyle.Bottom, // Hiển thị giá tiền ở dưới
                AutoSize = false, // Tắt AutoSize để có thể chỉnh kích thước Label
                Size = new Size(panel.Width, 20), // Kích thước Label
                Padding = new Padding(0, 0, 0, 5) // Padding để tạo khoảng cách với tên món
            };

            panel.Controls.Add(nameLabel);
            panel.Controls.Add(priceLabel);
            panel.Controls.Add(pictureBox);

            return panel;
        }
        private Image ScaleImage(Image image, int width, int height)
        {
            Bitmap scaledImage = new Bitmap(width, height);
            using (Graphics g = Graphics.FromImage(scaledImage))
            {
                g.InterpolationMode = System.Drawing.Drawing2D.InterpolationMode.HighQualityBicubic;
                g.DrawImage(image, 0, 0, width, height);
            }
            return scaledImage;
        }
        private void UpdateDataGridView()
        {
            guna2DataGridView1.Rows.Clear();
            foreach (var item in s)
            {
                guna2DataGridView1.Rows.Add(item.TenMon, item.SoLuong);
            }
        }
        private void guna2Button1_Click(object sender, EventArgs e)
        {
            if (guna2DataGridView1.RowCount == 1)
            {
                MessageBox.Show("Đơn hàng chưa có sản phầm nào.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                /*Employee.ThemMon f = new Employee.ThemMon(maNV, s);
                f.Show();
                this.Close();*/
                ThemMon f = new ThemMon(maNV, s);
                this.Hide();
                f.ShowDialog();
                this.Close();
            }
        }

        private void guna2Button2_Click(object sender, EventArgs e)
        {
            if (this.maCheck == 1)
            {
                ThemMon f = new ThemMon(maNV, s123);
                this.Hide();
                f.ShowDialog();
                this.Close();
            }
            else
            {
                ManHinhChinh_NV manHinhChinh = new ManHinhChinh_NV(maNV);
                this.Hide();
                manHinhChinh.ShowDialog();
                this.Close();
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            ManHinhChinh_NV manHinhChinh = new ManHinhChinh_NV(maNV);
            this.Hide();
            manHinhChinh.ShowDialog();
            this.Close();
        }

        private void TimkiemMon(object sender, EventArgs e)
        {
            string searchText = guna2TextBox1.Text.Trim().ToLower();
            List<SanPham> filteredFoodItems = SanPham_BLL.Instance.GetListSanPham(searchText);
            flowLayoutPanel1.Controls.Clear();
            foreach (SanPham foodItem in filteredFoodItems)
            {
                Panel panel = CreateFoodItemPanel(foodItem);
                flowLayoutPanel1.Controls.Add(panel);
            }
        }

        private void TDExit_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Bạn có chắc chắn muốn thoát?", "Thông báo", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                DangNhap dangNhap = new DangNhap();
                this.Hide();
                dangNhap.ShowDialog();
                this.Close();
            }
        }
    }
}
