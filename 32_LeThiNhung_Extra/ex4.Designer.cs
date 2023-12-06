namespace _32_LeThiNhung_Extra
{
    partial class ex4
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
            this.label1 = new System.Windows.Forms.Label();
            this.cbColor = new System.Windows.Forms.ComboBox();
            this.btnChangeColor = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.btnAddInfo = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.btnDeleteChoose = new System.Windows.Forms.Button();
            this.btnDelAll = new System.Windows.Forms.Button();
            this.btnDelFirst = new System.Windows.Forms.Button();
            this.btnDelLast = new System.Windows.Forms.Button();
            this.txtNo = new System.Windows.Forms.TextBox();
            this.lbInfo = new System.Windows.Forms.ListBox();
            this.txtFullname = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(144, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Choose a color";
            // 
            // cbColor
            // 
            this.cbColor.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.cbColor.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.cbColor.FormattingEnabled = true;
            this.cbColor.Items.AddRange(new object[] {
            "Red",
            "Blue",
            "Green",
            "Pink",
            "Black",
            "Yellow"});
            this.cbColor.Location = new System.Drawing.Point(200, 12);
            this.cbColor.Name = "cbColor";
            this.cbColor.Size = new System.Drawing.Size(168, 33);
            this.cbColor.TabIndex = 1;
            // 
            // btnChangeColor
            // 
            this.btnChangeColor.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnChangeColor.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btnChangeColor.Location = new System.Drawing.Point(62, 71);
            this.btnChangeColor.Name = "btnChangeColor";
            this.btnChangeColor.Size = new System.Drawing.Size(130, 32);
            this.btnChangeColor.TabIndex = 2;
            this.btnChangeColor.Text = "Change Color";
            this.btnChangeColor.UseVisualStyleBackColor = true;
            this.btnChangeColor.Click += new System.EventHandler(this.btnChangeColor_Click);
            // 
            // btnExit
            // 
            this.btnExit.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btnExit.Location = new System.Drawing.Point(256, 71);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(130, 32);
            this.btnExit.TabIndex = 3;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label2.Location = new System.Drawing.Point(35, 176);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(100, 25);
            this.label2.TabIndex = 4;
            this.label2.Text = "Full Name";
            // 
            // btnAddInfo
            // 
            this.btnAddInfo.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnAddInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btnAddInfo.Location = new System.Drawing.Point(25, 278);
            this.btnAddInfo.Name = "btnAddInfo";
            this.btnAddInfo.Size = new System.Drawing.Size(116, 31);
            this.btnAddInfo.TabIndex = 5;
            this.btnAddInfo.Text = "Add Info";
            this.btnAddInfo.UseVisualStyleBackColor = true;
            this.btnAddInfo.Click += new System.EventHandler(this.btnAddInfo_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label3.Location = new System.Drawing.Point(97, 357);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(215, 25);
            this.label3.TabIndex = 6;
            this.label3.Text = "N.O of people Declared";
            // 
            // btnDeleteChoose
            // 
            this.btnDeleteChoose.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnDeleteChoose.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btnDeleteChoose.Location = new System.Drawing.Point(40, 407);
            this.btnDeleteChoose.Name = "btnDeleteChoose";
            this.btnDeleteChoose.Size = new System.Drawing.Size(172, 31);
            this.btnDeleteChoose.TabIndex = 7;
            this.btnDeleteChoose.Text = "Delete Info Choosed";
            this.btnDeleteChoose.UseVisualStyleBackColor = true;
            this.btnDeleteChoose.Click += new System.EventHandler(this.btnDeleteChoose_Click);
            // 
            // btnDelAll
            // 
            this.btnDelAll.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnDelAll.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btnDelAll.Location = new System.Drawing.Point(40, 464);
            this.btnDelAll.Name = "btnDelAll";
            this.btnDelAll.Size = new System.Drawing.Size(172, 31);
            this.btnDelAll.TabIndex = 8;
            this.btnDelAll.Text = "Delete All Info";
            this.btnDelAll.UseVisualStyleBackColor = true;
            this.btnDelAll.Click += new System.EventHandler(this.btnDelAll_Click);
            // 
            // btnDelFirst
            // 
            this.btnDelFirst.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnDelFirst.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btnDelFirst.Location = new System.Drawing.Point(241, 407);
            this.btnDelFirst.Name = "btnDelFirst";
            this.btnDelFirst.Size = new System.Drawing.Size(172, 31);
            this.btnDelFirst.TabIndex = 9;
            this.btnDelFirst.Text = "Delete First Info";
            this.btnDelFirst.UseVisualStyleBackColor = true;
            this.btnDelFirst.Click += new System.EventHandler(this.btnDelFirst_Click);
            // 
            // btnDelLast
            // 
            this.btnDelLast.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnDelLast.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btnDelLast.Location = new System.Drawing.Point(241, 464);
            this.btnDelLast.Name = "btnDelLast";
            this.btnDelLast.Size = new System.Drawing.Size(172, 31);
            this.btnDelLast.TabIndex = 10;
            this.btnDelLast.Text = "Delete Last Info";
            this.btnDelLast.UseVisualStyleBackColor = true;
            this.btnDelLast.Click += new System.EventHandler(this.btnDelLast_Click);
            // 
            // txtNo
            // 
            this.txtNo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtNo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.txtNo.Location = new System.Drawing.Point(339, 356);
            this.txtNo.Name = "txtNo";
            this.txtNo.Size = new System.Drawing.Size(124, 26);
            this.txtNo.TabIndex = 11;
            // 
            // lbInfo
            // 
            this.lbInfo.FormattingEnabled = true;
            this.lbInfo.ItemHeight = 16;
            this.lbInfo.Location = new System.Drawing.Point(226, 189);
            this.lbInfo.Name = "lbInfo";
            this.lbInfo.Size = new System.Drawing.Size(222, 132);
            this.lbInfo.TabIndex = 12;
            // 
            // txtFullname
            // 
            this.txtFullname.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtFullname.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.txtFullname.Location = new System.Drawing.Point(17, 223);
            this.txtFullname.Name = "txtFullname";
            this.txtFullname.Size = new System.Drawing.Size(175, 26);
            this.txtFullname.TabIndex = 13;
            // 
            // ex4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.ClientSize = new System.Drawing.Size(538, 548);
            this.Controls.Add(this.txtFullname);
            this.Controls.Add(this.lbInfo);
            this.Controls.Add(this.txtNo);
            this.Controls.Add(this.btnDelLast);
            this.Controls.Add(this.btnDelFirst);
            this.Controls.Add(this.btnDelAll);
            this.Controls.Add(this.btnDeleteChoose);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnAddInfo);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnChangeColor);
            this.Controls.Add(this.cbColor);
            this.Controls.Add(this.label1);
            this.Name = "ex4";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ex4";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbColor;
        private System.Windows.Forms.Button btnChangeColor;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnAddInfo;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnDeleteChoose;
        private System.Windows.Forms.Button btnDelAll;
        private System.Windows.Forms.Button btnDelFirst;
        private System.Windows.Forms.Button btnDelLast;
        private System.Windows.Forms.TextBox txtNo;
        private System.Windows.Forms.ListBox lbInfo;
        private System.Windows.Forms.TextBox txtFullname;
    }
}