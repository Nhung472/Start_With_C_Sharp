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
    public partial class ex3 : Form
    {
        public ex3()
        {
            InitializeComponent();
        }

        private void btnFavor_Click(object sender, EventArgs e)
        {
            string str = "";
            if (cbGame.Checked == true)
            {
                str = cbGame.Text + "\n";
            }
            if (cbMusic.Checked == true)
            {
                str = cbMusic.Text + "\n";
            }
            if (cbWatch.Checked == true)
            {
                str = cbWatch.Text + "\n";
            }
            if (cbShopping.Checked == true)
            {
                str = cbShopping.Text + "\n";
            }
            if (cbVisit.Checked == true)
            {
                str = cbVisit.Text + "\n";
            }
            if (str.Length > 0)
            {
                MessageBox.Show("Your favor is: \n" + str);
            }
            else
            {
                MessageBox.Show("No favor you choose.");
            }
        }

        private void btnColor_Click(object sender, EventArgs e)
        {
            string str = "";
            if (rbBlue.Checked == true)
            {
                str = rbBlue.Text + "\n";
            }
            if (rbPink.Checked == true)
            {
                str = rbPink.Text + "\n";
            }
            if (rbRed.Checked == true)
            {
                str = rbRed.Text + "\n";
            }
            if (rbWhite.Checked == true)
            {
                str = rbWhite.Text + "\n";
            }
            if (rbYellow.Checked == true)
            {
                str = rbYellow.Text + "\n";
            }
            if (str.Length > 0)
            {
                MessageBox.Show("Your favor color is: \n" + str);
            }
            else
            {
                MessageBox.Show("No color you choose.");
            }
        }
    }
}
