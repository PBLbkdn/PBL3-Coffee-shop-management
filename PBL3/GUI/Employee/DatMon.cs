using Guna.UI2.WinForms;
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
        private List<SelectedDrink> s = new List<SelectedDrink>();
        public DatMon()
        {
            InitializeComponent();
            LoadFoodItems();
            guna2DataGridView1.Columns.Add("Name", "Tên sản phẩm");
            guna2DataGridView1.Columns.Add("Quantity", "Số lượng");
        }
        private void LoadFoodItems()
        {
            QuanCaPhePBL3Entities db = new QuanCaPhePBL3Entities();
            //List<SanPham> foodItems = db.SanPhams.ToList();
            int columnCount = 3;
            int rowCount = (int)Math.Ceiling((double)(db.SanPhams.Count()) / columnCount);

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

            // Load và scale hình ảnh vào kích thước cố định
            Image originalImage = Image.FromFile(foodItem.DuongDanAnh);
            pictureBox.Image = ScaleImage(originalImage, imageSize, imageSize);
            pictureBox.Click += (sender, e) =>
            {
                // Kiểm tra xem mặt hàng đã tồn tại trong danh sách chưa
                SelectedDrink selectedItem = s.Find(item => item.TenMon == foodItem.TenSP);
                if (selectedItem != null)
                {
                    // Nếu đã tồn tại, tăng số lượng lên 1
                    selectedItem.SoLuong++;
                }
                else
                {
                    // Nếu chưa tồn tại, thêm mặt hàng mới vào danh sách
                    s.Add(new SelectedDrink { TenMon = foodItem.TenSP, SoLuong = 1 });
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
            // Xóa hết dữ liệu cũ trước khi cập nhật
            guna2DataGridView1.Rows.Clear();

            // Duyệt qua danh sách các mặt hàng đã chọn và cập nhật DataGridView
            foreach (var item in s)
            {
                guna2DataGridView1.Rows.Add(item.TenMon, item.SoLuong);
            }
        }
        private void guna2Button1_Click(object sender, EventArgs e)
        {
            ChonBan f = new ChonBan();
            this.Hide();
            f.ShowDialog();
            this.Show();
        }
        private void guna2Button2_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
