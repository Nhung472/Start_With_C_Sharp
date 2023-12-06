using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _32_LeThiNhung_Extra
{
    public partial class ex2 : Form
    {
        public ex2()
        {
            InitializeComponent();
        }



        private void txt1num_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(e.KeyChar >= '0' && e.KeyChar <= '9' || e.KeyChar == (char)8))
            {
                e.Handled = true;
            }
        }

        private void txt2num_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(e.KeyChar >= '0' && e.KeyChar <= '9' || e.KeyChar == (char)8))
            {
                e.Handled = true;
            }
        }

        private void btnPlus_Click(object sender, EventArgs e)
        {
            int result = Convert.ToInt32(txt1num.Text) + Convert.ToInt32(txt2num.Text);
            txtResult.Text = result.ToString();
        }

        private void btnMinus_Click(object sender, EventArgs e)
        {
            int result = Convert.ToInt32(txt1num.Text) - Convert.ToInt32(txt2num.Text);
            txtResult.Text = result.ToString();
        }

        private void btnTime_Click(object sender, EventArgs e)
        {
            int result = Convert.ToInt32(txt1num.Text) * Convert.ToInt32(txt2num.Text);
            txtResult.Text = result.ToString();
        }

        private void btnDevide_Click(object sender, EventArgs e)
        {
            double result = Convert.ToDouble(txt1num.Text) / Convert.ToDouble(txt2num.Text);
            txtResult.Text = result.ToString();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            txt1num.Clear();
            txt2num.Clear();
            txtResult.Clear();
        }
    }
}
