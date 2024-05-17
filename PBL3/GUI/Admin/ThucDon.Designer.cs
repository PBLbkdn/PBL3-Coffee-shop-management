namespace PBL3.GUI
{
    partial class ThucDon
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.guna2Panel1 = new Guna.UI2.WinForms.Guna2Panel();
            this.TDExit = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.AddButton = new Guna.UI2.WinForms.Guna2Button();
            this.EditButton = new Guna.UI2.WinForms.Guna2Button();
            this.ClearButton = new Guna.UI2.WinForms.Guna2Button();
            this.ThucDonData = new System.Windows.Forms.DataGridView();
            this.ten = new System.Windows.Forms.Label();
            this.dsMon = new Guna.UI2.WinForms.Guna2Button();
            this.findButton = new Guna.UI2.WinForms.Guna2Button();
            this.findTextbox = new Guna.UI2.WinForms.Guna2TextBox();
            this.pictureBox10 = new System.Windows.Forms.PictureBox();
            this.guna2Panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TDExit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ThucDonData)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox10)).BeginInit();
            this.SuspendLayout();
            // 
            // guna2Panel1
            // 
            this.guna2Panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(155)))), ((int)(((byte)(132)))), ((int)(((byte)(132)))));
            this.guna2Panel1.Controls.Add(this.TDExit);
            this.guna2Panel1.Controls.Add(this.pictureBox1);
            this.guna2Panel1.Controls.Add(this.panel1);
            this.guna2Panel1.Location = new System.Drawing.Point(0, 0);
            this.guna2Panel1.Margin = new System.Windows.Forms.Padding(5);
            this.guna2Panel1.Name = "guna2Panel1";
            this.guna2Panel1.Size = new System.Drawing.Size(1848, 66);
            this.guna2Panel1.TabIndex = 1;
            // 
            // TDExit
            // 
            this.TDExit.Image = global::PBL3.Properties.Resources.nút_tắt;
            this.TDExit.Location = new System.Drawing.Point(1756, 15);
            this.TDExit.Margin = new System.Windows.Forms.Padding(5);
            this.TDExit.Name = "TDExit";
            this.TDExit.Size = new System.Drawing.Size(40, 37);
            this.TDExit.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.TDExit.TabIndex = 2;
            this.TDExit.TabStop = false;
            this.TDExit.Click += new System.EventHandler(this.exitSP_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::PBL3.Properties.Resources.icons8_home_50;
            this.pictureBox1.Location = new System.Drawing.Point(20, 17);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(5);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(44, 34);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(231)))), ((int)(((byte)(231)))));
            this.panel1.Controls.Add(this.pictureBox2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(80, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(5);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(240, 66);
            this.panel1.TabIndex = 0;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::PBL3.Properties.Resources.icon_thực_đơn1;
            this.pictureBox2.Location = new System.Drawing.Point(24, 16);
            this.pictureBox2.Margin = new System.Windows.Forms.Padding(5);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(36, 36);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 2;
            this.pictureBox2.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(231)))), ((int)(((byte)(231)))));
            this.label1.Font = new System.Drawing.Font("Cambria", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(69, 18);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(135, 32);
            this.label1.TabIndex = 0;
            this.label1.Text = "Thực đơn";
            // 
            // AddButton
            // 
            this.AddButton.BorderColor = System.Drawing.Color.WhiteSmoke;
            this.AddButton.BorderRadius = 10;
            this.AddButton.BorderThickness = 2;
            this.AddButton.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.AddButton.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.AddButton.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.AddButton.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.AddButton.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(228)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.AddButton.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddButton.ForeColor = System.Drawing.Color.Black;
            this.AddButton.Location = new System.Drawing.Point(77, 106);
            this.AddButton.Margin = new System.Windows.Forms.Padding(5);
            this.AddButton.Name = "AddButton";
            this.AddButton.Size = new System.Drawing.Size(143, 49);
            this.AddButton.TabIndex = 2;
            this.AddButton.Text = "Thêm";
            this.AddButton.Click += new System.EventHandler(this.addSp_Click);
            // 
            // EditButton
            // 
            this.EditButton.BorderColor = System.Drawing.Color.WhiteSmoke;
            this.EditButton.BorderRadius = 10;
            this.EditButton.BorderThickness = 2;
            this.EditButton.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.EditButton.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.EditButton.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.EditButton.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.EditButton.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(228)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.EditButton.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EditButton.ForeColor = System.Drawing.Color.Black;
            this.EditButton.Location = new System.Drawing.Point(251, 106);
            this.EditButton.Margin = new System.Windows.Forms.Padding(5);
            this.EditButton.Name = "EditButton";
            this.EditButton.Size = new System.Drawing.Size(153, 49);
            this.EditButton.TabIndex = 3;
            this.EditButton.Text = "Sửa";
            this.EditButton.Click += new System.EventHandler(this.editSP_Click);
            // 
            // ClearButton
            // 
            this.ClearButton.BorderColor = System.Drawing.Color.WhiteSmoke;
            this.ClearButton.BorderRadius = 10;
            this.ClearButton.BorderThickness = 2;
            this.ClearButton.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.ClearButton.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.ClearButton.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.ClearButton.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.ClearButton.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(228)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.ClearButton.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ClearButton.ForeColor = System.Drawing.Color.Black;
            this.ClearButton.Location = new System.Drawing.Point(435, 106);
            this.ClearButton.Margin = new System.Windows.Forms.Padding(5);
            this.ClearButton.Name = "ClearButton";
            this.ClearButton.Size = new System.Drawing.Size(149, 49);
            this.ClearButton.TabIndex = 4;
            this.ClearButton.Text = "Xóa";
            this.ClearButton.Click += new System.EventHandler(this.deleteSP_Click);
            // 
            // ThucDonData
            // 
            this.ThucDonData.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.ThucDonData.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(235)))), ((int)(((byte)(235)))));
            this.ThucDonData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ThucDonData.Location = new System.Drawing.Point(77, 196);
            this.ThucDonData.Margin = new System.Windows.Forms.Padding(5);
            this.ThucDonData.Name = "ThucDonData";
            this.ThucDonData.RowHeadersWidth = 51;
            this.ThucDonData.Size = new System.Drawing.Size(1688, 651);
            this.ThucDonData.TabIndex = 5;
            // 
            // ten
            // 
            this.ten.AutoSize = true;
            this.ten.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(206)))), ((int)(((byte)(181)))), ((int)(((byte)(181)))));
            this.ten.Font = new System.Drawing.Font("Cambria", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ten.ForeColor = System.Drawing.Color.Black;
            this.ten.Location = new System.Drawing.Point(1429, 116);
            this.ten.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.ten.Name = "ten";
            this.ten.Size = new System.Drawing.Size(133, 32);
            this.ten.TabIndex = 48;
            this.ten.Text = "Đơn hàng";
            // 
            // dsMon
            // 
            this.dsMon.BorderColor = System.Drawing.Color.WhiteSmoke;
            this.dsMon.BorderRadius = 10;
            this.dsMon.BorderThickness = 2;
            this.dsMon.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.dsMon.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.dsMon.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.dsMon.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.dsMon.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(228)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.dsMon.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dsMon.ForeColor = System.Drawing.Color.Black;
            this.dsMon.Location = new System.Drawing.Point(615, 106);
            this.dsMon.Margin = new System.Windows.Forms.Padding(5);
            this.dsMon.Name = "dsMon";
            this.dsMon.Size = new System.Drawing.Size(187, 49);
            this.dsMon.TabIndex = 51;
            this.dsMon.Text = "Danh sách món";
            this.dsMon.Click += new System.EventHandler(this.dsMon_Click);
            // 
            // findButton
            // 
            this.findButton.BorderColor = System.Drawing.Color.WhiteSmoke;
            this.findButton.BorderRadius = 10;
            this.findButton.BorderThickness = 2;
            this.findButton.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.findButton.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.findButton.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.findButton.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.findButton.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(228)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.findButton.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.findButton.ForeColor = System.Drawing.Color.Black;
            this.findButton.Location = new System.Drawing.Point(831, 106);
            this.findButton.Margin = new System.Windows.Forms.Padding(5);
            this.findButton.Name = "findButton";
            this.findButton.Size = new System.Drawing.Size(151, 49);
            this.findButton.TabIndex = 50;
            this.findButton.Text = "Tìm kiếm";
            this.findButton.Click += new System.EventHandler(this.findButton_Click);
            // 
            // findTextbox
            // 
            this.findTextbox.BorderRadius = 5;
            this.findTextbox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.findTextbox.DefaultText = "";
            this.findTextbox.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.findTextbox.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.findTextbox.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.findTextbox.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.findTextbox.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.findTextbox.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.findTextbox.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.findTextbox.IconLeft = global::PBL3.Properties.Resources.entypo_magnifying_glass;
            this.findTextbox.Location = new System.Drawing.Point(1037, 111);
            this.findTextbox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.findTextbox.Name = "findTextbox";
            this.findTextbox.PasswordChar = '\0';
            this.findTextbox.PlaceholderText = "Nhập tên món";
            this.findTextbox.SelectedText = "";
            this.findTextbox.Size = new System.Drawing.Size(267, 44);
            this.findTextbox.TabIndex = 49;
            this.findTextbox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.enter);
            // 
            // pictureBox10
            // 
            this.pictureBox10.Image = global::PBL3.Properties.Resources.Vector__2_;
            this.pictureBox10.Location = new System.Drawing.Point(1712, 106);
            this.pictureBox10.Margin = new System.Windows.Forms.Padding(5);
            this.pictureBox10.Name = "pictureBox10";
            this.pictureBox10.Size = new System.Drawing.Size(53, 49);
            this.pictureBox10.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox10.TabIndex = 16;
            this.pictureBox10.TabStop = false;
            // 
            // ThucDon
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(206)))), ((int)(((byte)(181)))), ((int)(((byte)(181)))));
            this.ClientSize = new System.Drawing.Size(1848, 970);
            this.Controls.Add(this.dsMon);
            this.Controls.Add(this.findButton);
            this.Controls.Add(this.findTextbox);
            this.Controls.Add(this.ten);
            this.Controls.Add(this.pictureBox10);
            this.Controls.Add(this.ThucDonData);
            this.Controls.Add(this.ClearButton);
            this.Controls.Add(this.EditButton);
            this.Controls.Add(this.AddButton);
            this.Controls.Add(this.guna2Panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "ThucDon";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "ThucDon";
            this.guna2Panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.TDExit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ThucDonData)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox10)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Panel guna2Panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox TDExit;
        private Guna.UI2.WinForms.Guna2Button AddButton;
        private Guna.UI2.WinForms.Guna2Button EditButton;
        private Guna.UI2.WinForms.Guna2Button ClearButton;
        private System.Windows.Forms.DataGridView ThucDonData;
        private System.Windows.Forms.PictureBox pictureBox10;
        private System.Windows.Forms.Label ten;
        private Guna.UI2.WinForms.Guna2TextBox findTextbox;
        private Guna.UI2.WinForms.Guna2Button dsMon;
        private Guna.UI2.WinForms.Guna2Button findButton;
    }
}