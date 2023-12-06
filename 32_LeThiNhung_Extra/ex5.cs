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
    public partial class ex5 : Form
    {
        public ex5()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if(!string.IsNullOrWhiteSpace(txtName.Text) || !string.IsNullOrWhiteSpace(txtPass.Text)) 
            {
                MessageBox.Show("Login Successfully");
            }
            else
            {
                MessageBox.Show("Please enter full info");
            }
        }

        private void txtName_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(e.KeyChar >= '0' && e.KeyChar <= '9' || e.KeyChar == (char)8))
                e.Handled = true;
        }

        private void cbShow_CheckedChanged(object sender, EventArgs e)
        {
            if(cbShow.Checked ==true) 
            {
                txtPass.PasswordChar = (char)0;
            }
            else
            {
                txtPass.PasswordChar = '*';
            }
        }

        private void ex5_Load(object sender, EventArgs e)
        {
            toolTip1.SetToolTip(txtName, "Just enter letter from a-z and 0-9");
            toolTip1.SetToolTip(txtPass, "Just enter letter from 0-9");
            helpProvider1.HelpNamespace = "....";
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
