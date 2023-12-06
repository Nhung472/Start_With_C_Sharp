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
    public partial class ex9 : Form
    {
        public ex9()
        {
            InitializeComponent();
        }

        private void txtName_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!((e.KeyChar >= 'a' && e.KeyChar <= 'z') || (e.KeyChar == ' ') || (e.KeyChar >= 'A' && e.KeyChar <= 'Z') || e.KeyChar == (char)8))
                e.Handled = true;
        }

        private void txtPhone_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(e.KeyChar >= '0' && e.KeyChar <= '9' || e.KeyChar == (char)8))
                e.Handled = true;
        }

        private void ex9_Load(object sender, EventArgs e)
        {
            dateTimePicker1.MinDate = DateTime.Now;
            int dayofmonth = DateTime.DaysInMonth(DateTime.Now.Year, DateTime.Now.Month);
            dateTimePicker1.MaxDate = new DateTime(DateTime.Now.Year, DateTime.Now.Month, dayofmonth);
        }

        private void btnSub_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtName.Text) || string.IsNullOrEmpty(txtPhone.Text) || string.IsNullOrEmpty(txtEmail.Text))
            {
                MessageBox.Show("Please fill full information");
            }
            else if (!string.IsNullOrEmpty(txtName.Text) || !string.IsNullOrEmpty(txtPhone.Text) || !string.IsNullOrEmpty(txtEmail.Text) == true)
            {
                MessageBox.Show("Congrat: " + txtName.Text + "\nPhone: " + txtPhone.Text + "\nEmail: " + txtEmail.Text + "\nTime: " + dateTimePicker1.Value.ToShortDateString());
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
