using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.UI.WebControls;
using System.Windows.Forms;

namespace PBL3.GUI
{
    public partial class ThatBai : Form
    {
        public ThatBai(string s)
        {
            InitializeComponent();
            label2.Text = s;
            label2.AutoSize = true;
            label2.TextAlign = ContentAlignment.MiddleCenter;
            UpdateLabelPosition();
        }
        
        private void UpdateLabelPosition()
        {
            int x = (guna2Panel1.ClientSize.Width - label2.Width) / 2;
            int y = (guna2Panel1.ClientSize.Height - label2.Height) / 2;
            label2.Location = new Point(x, y);
        }
        private void pictureBox1_Click(object sender, EventArgs e)
        {
            
        }

        

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
