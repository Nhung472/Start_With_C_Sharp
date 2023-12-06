namespace _32_LeThiNhung_Extra
{
    partial class ex2
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
            this.lb1num = new System.Windows.Forms.Label();
            this.txt1num = new System.Windows.Forms.TextBox();
            this.lb2num = new System.Windows.Forms.Label();
            this.txt2num = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtResult = new System.Windows.Forms.TextBox();
            this.btnPlus = new System.Windows.Forms.Button();
            this.btnMinus = new System.Windows.Forms.Button();
            this.btnTime = new System.Windows.Forms.Button();
            this.btnDevide = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lb1num
            // 
            this.lb1num.AutoSize = true;
            this.lb1num.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb1num.Location = new System.Drawing.Point(22, 48);
            this.lb1num.Name = "lb1num";
            this.lb1num.Size = new System.Drawing.Size(104, 20);
            this.lb1num.TabIndex = 0;
            this.lb1num.Text = "First number";
            // 
            // txt1num
            // 
            this.txt1num.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt1num.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt1num.Location = new System.Drawing.Point(187, 48);
            this.txt1num.Name = "txt1num";
            this.txt1num.Size = new System.Drawing.Size(294, 27);
            this.txt1num.TabIndex = 1;
            this.txt1num.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt1num_KeyPress);
            // 
            // lb2num
            // 
            this.lb2num.AutoSize = true;
            this.lb2num.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb2num.Location = new System.Drawing.Point(22, 106);
            this.lb2num.Name = "lb2num";
            this.lb2num.Size = new System.Drawing.Size(126, 20);
            this.lb2num.TabIndex = 2;
            this.lb2num.Text = "Second number";
            // 
            // txt2num
            // 
            this.txt2num.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt2num.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt2num.Location = new System.Drawing.Point(187, 104);
            this.txt2num.Name = "txt2num";
            this.txt2num.Size = new System.Drawing.Size(294, 27);
            this.txt2num.TabIndex = 3;
            this.txt2num.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt2num_KeyPress);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(40, 259);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 20);
            this.label1.TabIndex = 4;
            this.label1.Text = "Result";
            // 
            // txtResult
            // 
            this.txtResult.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtResult.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtResult.Location = new System.Drawing.Point(187, 252);
            this.txtResult.Name = "txtResult";
            this.txtResult.Size = new System.Drawing.Size(294, 27);
            this.txtResult.TabIndex = 5;
            // 
            // btnPlus
            // 
            this.btnPlus.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnPlus.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPlus.Location = new System.Drawing.Point(85, 178);
            this.btnPlus.Name = "btnPlus";
            this.btnPlus.Size = new System.Drawing.Size(41, 33);
            this.btnPlus.TabIndex = 6;
            this.btnPlus.Text = "+";
            this.btnPlus.UseVisualStyleBackColor = true;
            this.btnPlus.Click += new System.EventHandler(this.btnPlus_Click);
            // 
            // btnMinus
            // 
            this.btnMinus.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnMinus.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMinus.Location = new System.Drawing.Point(187, 178);
            this.btnMinus.Name = "btnMinus";
            this.btnMinus.Size = new System.Drawing.Size(41, 33);
            this.btnMinus.TabIndex = 7;
            this.btnMinus.Text = "-";
            this.btnMinus.UseVisualStyleBackColor = true;
            this.btnMinus.Click += new System.EventHandler(this.btnMinus_Click);
            // 
            // btnTime
            // 
            this.btnTime.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTime.Location = new System.Drawing.Point(306, 178);
            this.btnTime.Name = "btnTime";
            this.btnTime.Size = new System.Drawing.Size(41, 33);
            this.btnTime.TabIndex = 8;
            this.btnTime.Text = "*";
            this.btnTime.UseVisualStyleBackColor = true;
            this.btnTime.Click += new System.EventHandler(this.btnTime_Click);
            // 
            // btnDevide
            // 
            this.btnDevide.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnDevide.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDevide.Location = new System.Drawing.Point(398, 178);
            this.btnDevide.Name = "btnDevide";
            this.btnDevide.Size = new System.Drawing.Size(41, 33);
            this.btnDevide.TabIndex = 9;
            this.btnDevide.Text = "/";
            this.btnDevide.UseVisualStyleBackColor = true;
            this.btnDevide.Click += new System.EventHandler(this.btnDevide_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelete.Location = new System.Drawing.Point(470, 178);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(100, 33);
            this.btnDelete.TabIndex = 10;
            this.btnDelete.Text = "Del";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // ex2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ClientSize = new System.Drawing.Size(582, 353);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnDevide);
            this.Controls.Add(this.btnTime);
            this.Controls.Add(this.btnMinus);
            this.Controls.Add(this.btnPlus);
            this.Controls.Add(this.txtResult);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txt2num);
            this.Controls.Add(this.lb2num);
            this.Controls.Add(this.txt1num);
            this.Controls.Add(this.lb1num);
            this.Name = "ex2";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ex2";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lb1num;
        private System.Windows.Forms.TextBox txt1num;
        private System.Windows.Forms.Label lb2num;
        private System.Windows.Forms.TextBox txt2num;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtResult;
        private System.Windows.Forms.Button btnPlus;
        private System.Windows.Forms.Button btnMinus;
        private System.Windows.Forms.Button btnTime;
        private System.Windows.Forms.Button btnDevide;
        private System.Windows.Forms.Button btnDelete;
    }
}