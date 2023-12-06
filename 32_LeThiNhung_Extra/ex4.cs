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
    public partial class ex4 : Form
    {
        public ex4()
        {
            InitializeComponent();
        }

        private void btnAddInfo_Click(object sender, EventArgs e)
        {
            if(!String.IsNullOrEmpty(btnAddInfo.Text)) 
            {
                lbInfo.Items.Add(txtFullname.Text);
                txtNo.Text = lbInfo.Items.Count.ToString();
                txtFullname.Clear();
                txtFullname.Focus();
            }
            else
            {
                MessageBox.Show("Please Fill all infor!!");
            }
        }

        private void btnDeleteChoose_Click(object sender, EventArgs e)
        {
            int a = Convert.ToInt32(txtNo.Text);
            if(lbInfo.SelectedItem != null) 
            {
                lbInfo.Items.Remove(lbInfo.SelectedItem);
            }
            txtNo.Text = (a-1).ToString();
        }

        private void btnDelFirst_Click(object sender, EventArgs e)
        {
            int a = Convert.ToInt32(txtNo.Text);
            lbInfo.Items.RemoveAt(0);
            txtNo.Text = (a - 1).ToString();
        }

        private void btnDelAll_Click(object sender, EventArgs e)
        {
            lbInfo.Items.Clear();
            txtNo.Text = "0";
        }

        private void btnDelLast_Click(object sender, EventArgs e)
        {
            int a = Convert.ToInt32(txtNo.Text);
            lbInfo.Items.RemoveAt(lbInfo.Items.Count - 1);
            txtNo.Text = (a-1).ToString();
        }
        //red blue green pink black yellow//
        private void btnChangeColor_Click(object sender, EventArgs e)
        {
            if(cbColor.Text=="Yellow")
            {
                btnChangeColor.BackColor = Color.Red;
                btnChangeColor.ForeColor = Color.Yellow;
            }
            if (cbColor.Text == "Red")
            {
                btnChangeColor.BackColor = Color.Pink;
                btnChangeColor.ForeColor = Color.Red;
            }
            if (cbColor.Text == "Blue")
            {
                btnChangeColor.BackColor = Color.Yellow;
                btnChangeColor.ForeColor = Color.Blue;
            }
            if (cbColor.Text == "Pink")
            {
                btnChangeColor.BackColor = Color.Green;
                btnChangeColor.ForeColor = Color.Pink;
            }
            if (cbColor.Text == "Black")
            {
                btnChangeColor.BackColor = Color.Red;
                btnChangeColor.ForeColor = Color.Black;
            }
            if (cbColor.Text == "Green")
            {
                btnChangeColor.BackColor = Color.Yellow;
                btnChangeColor.ForeColor = Color.Green;
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            DialogResult dg = MessageBox.Show("You want to Exit?", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dg == DialogResult.Yes) 
            {
                Application.Exit();
            }
        }
    }
}
