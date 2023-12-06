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
    public partial class ex6 : Form
    {
        public ex6()
        {
            InitializeComponent();
        } //NOT OKE

        private void timer1_Tick(object sender, EventArgs e)
        {
            DateTime dt = DateTime.Now.Add(new TimeSpan());
            lbTime.Text = String.Format("{0:hh:mm:ss tt", dt);
            lbDate.Text = String.Format("{0:dd//MM/yyyy}", dt);
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            ex6 frm = new ex6();
            progressBar1.Increment(1);
            lbComplete.Text = "Connecting to from " + progressBar1.Value.ToString() + "%";
            if(progressBar1.Value == progressBar1.Maximum)
            {
                timer2.Enabled = false;
                frm.ShowDialog();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (progressBar1.Enabled == true)
            {
                progressBar1.Enabled = false;
                timer2.Start();
                timer1.Start();
            }

            else
            {
                progressBar1.Enabled = true;
                timer2.Stop();
                timer1.Stop();
            }
        }
    }
}
