namespace PBL3.GUI.Admin
{
    partial class ThongKeCa
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.CaCb = new Guna.UI2.WinForms.Guna2ComboBox();
            this.ngayTK = new Guna.UI2.WinForms.Guna2DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.guna2TextBox1 = new Guna.UI2.WinForms.Guna2TextBox();
            this.TkeCaData = new System.Windows.Forms.DataGridView();
            this.guna2Panel1 = new Guna.UI2.WinForms.Guna2Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.pictureBox6 = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.TkeCb = new Guna.UI2.WinForms.Guna2ComboBox();
            this.guna2Panel2 = new Guna.UI2.WinForms.Guna2Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.pictureBox9 = new System.Windows.Forms.PictureBox();
            this.pictureBox8 = new System.Windows.Forms.PictureBox();
            this.pictureBox7 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox10 = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TkeCaData)).BeginInit();
            this.guna2Panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            this.guna2Panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox9)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox8)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox10)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(155)))), ((int)(((byte)(132)))), ((int)(((byte)(132)))));
            this.panel1.Controls.Add(this.CaCb);
            this.panel1.Controls.Add(this.ngayTK);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.guna2TextBox1);
            this.panel1.Location = new System.Drawing.Point(90, 263);
            this.panel1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1899, 91);
            this.panel1.TabIndex = 19;
            // 
            // CaCb
            // 
            this.CaCb.BackColor = System.Drawing.Color.Transparent;
            this.CaCb.BorderRadius = 5;
            this.CaCb.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.CaCb.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CaCb.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.CaCb.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.CaCb.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.CaCb.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.CaCb.ItemHeight = 30;
            this.CaCb.Location = new System.Drawing.Point(83, 18);
            this.CaCb.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.CaCb.Name = "CaCb";
            this.CaCb.Size = new System.Drawing.Size(248, 36);
            this.CaCb.TabIndex = 17;
            this.CaCb.SelectedIndexChanged += new System.EventHandler(this.CaCb_SelectedIndexChanged);
            // 
            // ngayTK
            // 
            this.ngayTK.BorderRadius = 5;
            this.ngayTK.Checked = true;
            this.ngayTK.CustomFormat = "MM/dd/yyyy";
            this.ngayTK.FillColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ngayTK.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.ngayTK.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.ngayTK.Location = new System.Drawing.Point(1041, 18);
            this.ngayTK.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.ngayTK.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.ngayTK.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.ngayTK.Name = "ngayTK";
            this.ngayTK.Size = new System.Drawing.Size(300, 55);
            this.ngayTK.TabIndex = 18;
            this.ngayTK.Value = new System.DateTime(2024, 4, 21, 11, 54, 4, 708);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(972, 34);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(59, 28);
            this.label4.TabIndex = 5;
            this.label4.Text = "Ngày";
            // 
            // guna2TextBox1
            // 
            this.guna2TextBox1.BorderRadius = 5;
            this.guna2TextBox1.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.guna2TextBox1.DefaultText = "";
            this.guna2TextBox1.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.guna2TextBox1.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.guna2TextBox1.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.guna2TextBox1.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.guna2TextBox1.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.guna2TextBox1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.guna2TextBox1.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.guna2TextBox1.IconLeft = global::PBL3.Properties.Resources.entypo_magnifying_glass;
            this.guna2TextBox1.Location = new System.Drawing.Point(1506, 18);
            this.guna2TextBox1.Margin = new System.Windows.Forms.Padding(6, 8, 6, 8);
            this.guna2TextBox1.Name = "guna2TextBox1";
            this.guna2TextBox1.PasswordChar = '\0';
            this.guna2TextBox1.PlaceholderText = "";
            this.guna2TextBox1.SelectedText = "";
            this.guna2TextBox1.Size = new System.Drawing.Size(300, 55);
            this.guna2TextBox1.TabIndex = 3;
            // 
            // TkeCaData
            // 
            this.TkeCaData.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(235)))), ((int)(((byte)(235)))));
            this.TkeCaData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.TkeCaData.Location = new System.Drawing.Point(90, 352);
            this.TkeCaData.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.TkeCaData.Name = "TkeCaData";
            this.TkeCaData.RowHeadersWidth = 62;
            this.TkeCaData.Size = new System.Drawing.Size(1899, 703);
            this.TkeCaData.TabIndex = 18;
            // 
            // guna2Panel1
            // 
            this.guna2Panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(155)))), ((int)(((byte)(132)))), ((int)(((byte)(132)))));
            this.guna2Panel1.Controls.Add(this.panel2);
            this.guna2Panel1.Controls.Add(this.pictureBox4);
            this.guna2Panel1.Controls.Add(this.pictureBox5);
            this.guna2Panel1.Location = new System.Drawing.Point(0, 0);
            this.guna2Panel1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.guna2Panel1.Name = "guna2Panel1";
            this.guna2Panel1.Size = new System.Drawing.Size(2079, 83);
            this.guna2Panel1.TabIndex = 17;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(231)))), ((int)(((byte)(231)))));
            this.panel2.Controls.Add(this.pictureBox6);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Location = new System.Drawing.Point(93, 0);
            this.panel2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(270, 83);
            this.panel2.TabIndex = 3;
            // 
            // pictureBox6
            // 
            this.pictureBox6.Image = global::PBL3.Properties.Resources.Vector__3_;
            this.pictureBox6.Location = new System.Drawing.Point(27, 20);
            this.pictureBox6.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pictureBox6.Name = "pictureBox6";
            this.pictureBox6.Size = new System.Drawing.Size(40, 45);
            this.pictureBox6.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox6.TabIndex = 2;
            this.pictureBox6.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(231)))), ((int)(((byte)(231)))));
            this.label2.Font = new System.Drawing.Font("Cambria", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(78, 23);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(152, 37);
            this.label2.TabIndex = 0;
            this.label2.Text = "Thống kê";
            // 
            // pictureBox4
            // 
            this.pictureBox4.Image = global::PBL3.Properties.Resources.nút_tắt;
            this.pictureBox4.Location = new System.Drawing.Point(1974, 20);
            this.pictureBox4.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(45, 46);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox4.TabIndex = 2;
            this.pictureBox4.TabStop = false;
            // 
            // pictureBox5
            // 
            this.pictureBox5.Image = global::PBL3.Properties.Resources.bàn_Tầng_1__004;
            this.pictureBox5.Location = new System.Drawing.Point(22, 22);
            this.pictureBox5.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(50, 43);
            this.pictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox5.TabIndex = 2;
            this.pictureBox5.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(206)))), ((int)(((byte)(181)))), ((int)(((byte)(181)))));
            this.label1.Font = new System.Drawing.Font("Cambria", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(84, 160);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(204, 34);
            this.label1.TabIndex = 21;
            this.label1.Text = "Thống kê theo";
            // 
            // TkeCb
            // 
            this.TkeCb.BackColor = System.Drawing.Color.Transparent;
            this.TkeCb.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.TkeCb.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.TkeCb.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.TkeCb.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.TkeCb.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.TkeCb.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.TkeCb.ItemHeight = 30;
            this.TkeCb.Location = new System.Drawing.Point(296, 158);
            this.TkeCb.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.TkeCb.Name = "TkeCb";
            this.TkeCb.Size = new System.Drawing.Size(268, 36);
            this.TkeCb.TabIndex = 22;
            // 
            // guna2Panel2
            // 
            this.guna2Panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(155)))), ((int)(((byte)(132)))), ((int)(((byte)(132)))));
            this.guna2Panel2.Controls.Add(this.label3);
            this.guna2Panel2.Controls.Add(this.pictureBox9);
            this.guna2Panel2.Controls.Add(this.pictureBox8);
            this.guna2Panel2.Controls.Add(this.pictureBox7);
            this.guna2Panel2.Controls.Add(this.pictureBox1);
            this.guna2Panel2.Controls.Add(this.pictureBox2);
            this.guna2Panel2.Controls.Add(this.pictureBox3);
            this.guna2Panel2.Location = new System.Drawing.Point(90, 1055);
            this.guna2Panel2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.guna2Panel2.Name = "guna2Panel2";
            this.guna2Panel2.Size = new System.Drawing.Size(1899, 57);
            this.guna2Panel2.TabIndex = 23;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label3.Location = new System.Drawing.Point(236, 15);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(95, 28);
            this.label3.TabIndex = 7;
            this.label3.Text = "Trang 1/7";
            // 
            // pictureBox9
            // 
            this.pictureBox9.Image = global::PBL3.Properties.Resources.Line_5;
            this.pictureBox9.Location = new System.Drawing.Point(380, 9);
            this.pictureBox9.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pictureBox9.Name = "pictureBox9";
            this.pictureBox9.Size = new System.Drawing.Size(21, 38);
            this.pictureBox9.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox9.TabIndex = 5;
            this.pictureBox9.TabStop = false;
            // 
            // pictureBox8
            // 
            this.pictureBox8.Image = global::PBL3.Properties.Resources.Line_5;
            this.pictureBox8.Location = new System.Drawing.Point(160, 9);
            this.pictureBox8.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pictureBox8.Name = "pictureBox8";
            this.pictureBox8.Size = new System.Drawing.Size(21, 38);
            this.pictureBox8.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox8.TabIndex = 4;
            this.pictureBox8.TabStop = false;
            // 
            // pictureBox7
            // 
            this.pictureBox7.Image = global::PBL3.Properties.Resources.bytesize_chevron_top__1_;
            this.pictureBox7.Location = new System.Drawing.Point(410, 14);
            this.pictureBox7.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pictureBox7.Name = "pictureBox7";
            this.pictureBox7.Size = new System.Drawing.Size(39, 31);
            this.pictureBox7.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox7.TabIndex = 3;
            this.pictureBox7.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::PBL3.Properties.Resources.Group_171;
            this.pictureBox1.Location = new System.Drawing.Point(458, 14);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(56, 31);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::PBL3.Properties.Resources.bytesize_chevron_top;
            this.pictureBox2.Location = new System.Drawing.Point(112, 14);
            this.pictureBox2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(39, 31);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 1;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = global::PBL3.Properties.Resources.Group_170;
            this.pictureBox3.Location = new System.Drawing.Point(48, 14);
            this.pictureBox3.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(56, 31);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 0;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox10
            // 
            this.pictureBox10.Image = global::PBL3.Properties.Resources.Vector__2_;
            this.pictureBox10.Location = new System.Drawing.Point(1929, 148);
            this.pictureBox10.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pictureBox10.Name = "pictureBox10";
            this.pictureBox10.Size = new System.Drawing.Size(60, 62);
            this.pictureBox10.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox10.TabIndex = 20;
            this.pictureBox10.TabStop = false;
            // 
            // ThongKeCa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(206)))), ((int)(((byte)(181)))), ((int)(((byte)(181)))));
            this.ClientSize = new System.Drawing.Size(1946, 1106);
            this.Controls.Add(this.guna2Panel2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.TkeCb);
            this.Controls.Add(this.pictureBox10);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.TkeCaData);
            this.Controls.Add(this.guna2Panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "ThongKeCa";
            this.Text = "ThongKeCa";
            this.Load += new System.EventHandler(this.ThongKeCa_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TkeCaData)).EndInit();
            this.guna2Panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            this.guna2Panel2.ResumeLayout(false);
            this.guna2Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox9)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox8)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox10)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private Guna.UI2.WinForms.Guna2ComboBox CaCb;
        private Guna.UI2.WinForms.Guna2DateTimePicker ngayTK;
        private System.Windows.Forms.Label label4;
        private Guna.UI2.WinForms.Guna2TextBox guna2TextBox1;
        private System.Windows.Forms.DataGridView TkeCaData;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel1;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.PictureBox pictureBox5;
        private System.Windows.Forms.PictureBox pictureBox10;
        private System.Windows.Forms.Label label1;
        private Guna.UI2.WinForms.Guna2ComboBox TkeCb;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.PictureBox pictureBox9;
        private System.Windows.Forms.PictureBox pictureBox8;
        private System.Windows.Forms.PictureBox pictureBox7;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.PictureBox pictureBox6;
        private System.Windows.Forms.Label label2;
    }
}