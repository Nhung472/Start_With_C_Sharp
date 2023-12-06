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
    public partial class ex11 : Form
    {
        public ex11()
        {
            InitializeComponent();
        }

        private void displayTimeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DateTime dt = DateTime.Now.Add(new TimeSpan());
            lable1.Text = String.Format("{0:hh:mm:ss tt}", dt);
        }

        private void displayDateToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DateTime dt = DateTime.Now.Add(new TimeSpan());
            lable2.Text = String.Format("{0:dd/MM/yyyy}", dt);
        }

        private void menuExitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult dt = MessageBox.Show("Do you want to Exit?", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (dt == DialogResult.Yes)

            {

                Application.Exit();

            }
        }

        private void ex11_Load(object sender, EventArgs e)
        {

        }
    }
}
