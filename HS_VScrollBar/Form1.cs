using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HS_VScrollBar
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        void ChangeBackColorOfTextBox()
        {
            int r, g, b;
            r = hScrollBarRed.Value;
            g = hScrollBarGreen.Value;
            b = hScrollBarBlue.Value;

            txtRed.Text = r.ToString();
            txtGreen.Text = g.ToString();
            txtBlue.Text = b.ToString();

            txtBox.BackColor = Color.FromArgb(r, g, b); // Tạo màu
        }

        private void hScrollBarRed_ValueChanged(object sender, EventArgs e)
        {
            ChangeBackColorOfTextBox();
        }
    }
}
