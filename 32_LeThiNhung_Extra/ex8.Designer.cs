namespace _32_LeThiNhung_Extra
{
    partial class ex8
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.treeView1 = new System.Windows.Forms.TreeView();
            this.txtName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnAddFather = new System.Windows.Forms.Button();
            this.btnAddChild = new System.Windows.Forms.Button();
            this.btnDelAll = new System.Windows.Forms.Button();
            this.btnDelCho = new System.Windows.Forms.Button();
            this.btnCount = new System.Windows.Forms.Button();
            this.btnPlus = new System.Windows.Forms.Button();
            this.btnMinus = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // treeView1
            // 
            this.treeView1.Location = new System.Drawing.Point(12, 33);
            this.treeView1.Name = "treeView1";
            this.treeView1.Size = new System.Drawing.Size(220, 292);
            this.treeView1.TabIndex = 0;
            // 
            // txtName
            // 
            this.txtName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.txtName.Location = new System.Drawing.Point(341, 33);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(184, 26);
            this.txtName.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label1.Location = new System.Drawing.Point(238, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(97, 20);
            this.label1.TabIndex = 2;
            this.label1.Text = "Name Node";
            // 
            // btnAddFather
            // 
            this.btnAddFather.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnAddFather.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btnAddFather.Location = new System.Drawing.Point(259, 83);
            this.btnAddFather.Name = "btnAddFather";
            this.btnAddFather.Size = new System.Drawing.Size(241, 31);
            this.btnAddFather.TabIndex = 3;
            this.btnAddFather.Text = "Add Father Node";
            this.btnAddFather.UseVisualStyleBackColor = true;
            this.btnAddFather.Click += new System.EventHandler(this.btnAddFather_Click);
            // 
            // btnAddChild
            // 
            this.btnAddChild.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnAddChild.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btnAddChild.Location = new System.Drawing.Point(259, 137);
            this.btnAddChild.Name = "btnAddChild";
            this.btnAddChild.Size = new System.Drawing.Size(241, 31);
            this.btnAddChild.TabIndex = 4;
            this.btnAddChild.Text = "Add Child Node";
            this.btnAddChild.UseVisualStyleBackColor = true;
            this.btnAddChild.Click += new System.EventHandler(this.btnAddChild_Click);
            // 
            // btnDelAll
            // 
            this.btnDelAll.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnDelAll.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btnDelAll.Location = new System.Drawing.Point(259, 186);
            this.btnDelAll.Name = "btnDelAll";
            this.btnDelAll.Size = new System.Drawing.Size(241, 31);
            this.btnDelAll.TabIndex = 5;
            this.btnDelAll.Text = "Delete All Node";
            this.btnDelAll.UseVisualStyleBackColor = true;
            this.btnDelAll.Click += new System.EventHandler(this.btnDelAll_Click);
            // 
            // btnDelCho
            // 
            this.btnDelCho.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnDelCho.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btnDelCho.Location = new System.Drawing.Point(259, 239);
            this.btnDelCho.Name = "btnDelCho";
            this.btnDelCho.Size = new System.Drawing.Size(241, 31);
            this.btnDelCho.TabIndex = 6;
            this.btnDelCho.Text = "Delete Choosed Node";
            this.btnDelCho.UseVisualStyleBackColor = true;
            this.btnDelCho.Click += new System.EventHandler(this.btnDelCho_Click);
            // 
            // btnCount
            // 
            this.btnCount.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnCount.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btnCount.Location = new System.Drawing.Point(259, 294);
            this.btnCount.Name = "btnCount";
            this.btnCount.Size = new System.Drawing.Size(241, 31);
            this.btnCount.TabIndex = 7;
            this.btnCount.Text = "Count All Node";
            this.btnCount.UseVisualStyleBackColor = true;
            this.btnCount.Click += new System.EventHandler(this.btnCount_Click);
            // 
            // btnPlus
            // 
            this.btnPlus.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnPlus.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btnPlus.Location = new System.Drawing.Point(259, 351);
            this.btnPlus.Name = "btnPlus";
            this.btnPlus.Size = new System.Drawing.Size(57, 31);
            this.btnPlus.TabIndex = 8;
            this.btnPlus.Text = "+";
            this.btnPlus.UseVisualStyleBackColor = true;
            this.btnPlus.Click += new System.EventHandler(this.btnPlus_Click);
            // 
            // btnMinus
            // 
            this.btnMinus.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnMinus.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btnMinus.Location = new System.Drawing.Point(443, 351);
            this.btnMinus.Name = "btnMinus";
            this.btnMinus.Size = new System.Drawing.Size(57, 31);
            this.btnMinus.TabIndex = 9;
            this.btnMinus.Text = "-";
            this.btnMinus.UseVisualStyleBackColor = true;
            this.btnMinus.Click += new System.EventHandler(this.btnMinus_Click);
            // 
            // ex8
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.ClientSize = new System.Drawing.Size(532, 394);
            this.Controls.Add(this.btnMinus);
            this.Controls.Add(this.btnPlus);
            this.Controls.Add(this.btnCount);
            this.Controls.Add(this.btnDelCho);
            this.Controls.Add(this.btnDelAll);
            this.Controls.Add(this.btnAddChild);
            this.Controls.Add(this.btnAddFather);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.treeView1);
            this.Name = "ex8";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ex8";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TreeView treeView1;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnAddFather;
        private System.Windows.Forms.Button btnAddChild;
        private System.Windows.Forms.Button btnDelAll;
        private System.Windows.Forms.Button btnDelCho;
        private System.Windows.Forms.Button btnCount;
        private System.Windows.Forms.Button btnPlus;
        private System.Windows.Forms.Button btnMinus;
    }
}