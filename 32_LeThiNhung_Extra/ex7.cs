using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace _32_LeThiNhung_Extra
{
    public partial class ex7 : Form
    {
        public ex7()
        {
            InitializeComponent();
        }
        private void ex7_Load(object sender, EventArgs e)
        {

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if ((string.IsNullOrEmpty(txtName.Text)) || (string.IsNullOrEmpty(txtNumber.Text)))
            {
                MessageBox.Show("Please fill full information");
            }
            else
            {
                ListViewItem item = new ListViewItem();
                item.Text = txtName.Text;
                listView1.Items.Add(item);

                ListViewItem.ListViewSubItem subitem = new ListViewItem.ListViewSubItem(item, (txtNumber.Text));
                item.SubItems.Add(subitem);

                txtName.Clear();
                txtNumber.Clear();
                txtName.Focus();
            }
        }

        private void btnDel_Click(object sender, EventArgs e)
        {
            if (listView1.SelectedItems.Count > 0)
            {
                DialogResult dl = MessageBox.Show("Do you want to Delete?", "Warning", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
                if (dl == DialogResult.OK)
                    listView1.Items.Remove(listView1.SelectedItems[0]);
            }
            else MessageBox.Show("Wrong delete");
        }

        private void btnDelAll_Click(object sender, EventArgs e)
        {
            listView1.Items.Clear();
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
