using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace _32_LeThiNhung_Extra
{
    public partial class ex8 : Form
    {
        public ex8()
        {
            InitializeComponent();
        }

        private void btnAddFather_Click(object sender, EventArgs e)
        {
            bool t = false;
            if (!string.IsNullOrEmpty(txtName.Text))
            {
                TreeNode Node = new TreeNode();
                Node.Text = txtName.Text;
                foreach (TreeNode nodex in treeView1.Nodes)
                {
                    if (string.Equals(Node.Text, nodex.Text))
                    {
                        MessageBox.Show("Node đã tồn tại");
                        t = true;
                    }
                }
                if (t == false) treeView1.Nodes.Add(Node);
                txtName.Clear();
                txtName.Focus();
            }
            else
                MessageBox.Show("Node must be filled");
        }

        private void btnAddChild_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtName.Text))
            {
                if (treeView1.SelectedNode != null)
                {
                    TreeNode Subnode = new TreeNode();
                    Subnode.Text = txtName.Text;
                    treeView1.SelectedNode.Nodes.Add(Subnode);
                    txtName.Clear();
                    txtName.Focus();
                }
                else
                    MessageBox.Show("You are not choose the location of child Node");
            }
            else
                MessageBox.Show("Node kmust be filled");
        }

        private void btnDelAll_Click(object sender, EventArgs e)
        {
            treeView1.Nodes.Clear();
        }

        private void btnDelCho_Click(object sender, EventArgs e)
        {
            if (treeView1.SelectedNode != null)
            {
                treeView1.SelectedNode.Remove();
            }
        }

        private void btnPlus_Click(object sender, EventArgs e)
        {
            treeView1.ExpandAll();
        }

        private void btnMinus_Click(object sender, EventArgs e)
        {
            treeView1.CollapseAll();
        }

        private void btnCount_Click(object sender, EventArgs e)
        {
            int n = treeView1.GetNodeCount(true);
            MessageBox.Show("Sum of the Node : " +n);
        }
    }
}
