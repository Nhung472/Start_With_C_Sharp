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
    public partial class ex1 : Form
    {
        public ex1()
        {
            InitializeComponent();
        }

        private void ex1_Load(object sender, EventArgs e)
        {
            if(MessageBox.Show("Do you want to open the program?", "Ask", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.Cancel)
            {
                Dispose();
            }
        }

        private void btnShow_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Your Full Name is: " + txtName.Text);
        }

        private void ex1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Modifiers == Keys.Alt && e.KeyCode == Keys.H)
            {
                txtName.Text = "Hello Freetuts.net !!!";
            }
        }

        private void ex1_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                MessageBox.Show("You are already click on Left Mouse");
            }

            if (e.Button == MouseButtons.Right)
            {
                MessageBox.Show("You are already click on Right Mouse");
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            DialogResult dg = MessageBox.Show("Do you want to EXIT?", "Ask", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (dg == DialogResult.Yes)
            {
                Application.Exit();
            }
        }
    }
}
