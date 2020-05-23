namespace PayrollProgram1
{
    partial class Form1
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
            this.tb_1 = new System.Windows.Forms.TextBox();
            this.tb_2 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.tb_5 = new System.Windows.Forms.TextBox();
            this.btn_create = new System.Windows.Forms.Button();
            this.btn_clear = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.tb_6 = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.tb_4 = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.textBoxSide = new System.Windows.Forms.TextBox();
            this.cBoxJob = new System.Windows.Forms.ComboBox();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(18, 44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "First Name:";
            // 
            // tb_1
            // 
            this.tb_1.Location = new System.Drawing.Point(118, 44);
            this.tb_1.MaxLength = 32;
            this.tb_1.Name = "tb_1";
            this.tb_1.Size = new System.Drawing.Size(205, 20);
            this.tb_1.TabIndex = 1;
            // 
            // tb_2
            // 
            this.tb_2.Location = new System.Drawing.Point(118, 80);
            this.tb_2.MaxLength = 32;
            this.tb_2.Name = "tb_2";
            this.tb_2.Size = new System.Drawing.Size(205, 20);
            this.tb_2.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(18, 117);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(50, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Job Title:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(18, 197);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(46, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Payrate:";
            // 
            // tb_5
            // 
            this.tb_5.Location = new System.Drawing.Point(118, 197);
            this.tb_5.MaxLength = 6;
            this.tb_5.Name = "tb_5";
            this.tb_5.Size = new System.Drawing.Size(54, 20);
            this.tb_5.TabIndex = 6;
            // 
            // btn_create
            // 
            this.btn_create.Location = new System.Drawing.Point(21, 428);
            this.btn_create.Name = "btn_create";
            this.btn_create.Size = new System.Drawing.Size(139, 35);
            this.btn_create.TabIndex = 7;
            this.btn_create.Text = "Add Employee to File";
            this.btn_create.UseVisualStyleBackColor = true;
            this.btn_create.Click += new System.EventHandler(this.btn_create_Click);
            // 
            // btn_clear
            // 
            this.btn_clear.Location = new System.Drawing.Point(166, 428);
            this.btn_clear.Name = "btn_clear";
            this.btn_clear.Size = new System.Drawing.Size(148, 35);
            this.btn_clear.TabIndex = 8;
            this.btn_clear.Text = "Clear Form";
            this.btn_clear.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(18, 80);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(61, 13);
            this.label4.TabIndex = 11;
            this.label4.Text = "Last Name:";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(345, 44);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(248, 21);
            this.comboBox1.TabIndex = 13;
            this.comboBox1.Visible = false;
            // 
            // tb_6
            // 
            this.tb_6.Location = new System.Drawing.Point(21, 258);
            this.tb_6.MaxLength = 300;
            this.tb_6.Multiline = true;
            this.tb_6.Name = "tb_6";
            this.tb_6.Size = new System.Drawing.Size(293, 141);
            this.tb_6.TabIndex = 14;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(18, 242);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(86, 13);
            this.label5.TabIndex = 15;
            this.label5.Text = "Notes: (Optional)";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(18, 157);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(81, 13);
            this.label6.TabIndex = 16;
            this.label6.Text = "Phone Number:";
            // 
            // tb_4
            // 
            this.tb_4.Location = new System.Drawing.Point(118, 157);
            this.tb_4.MaxLength = 10;
            this.tb_4.Name = "tb_4";
            this.tb_4.Size = new System.Drawing.Size(100, 20);
            this.tb_4.TabIndex = 17;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(63, 197);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(46, 13);
            this.label7.TabIndex = 18;
            this.label7.Text = "($ an hr)";
            // 
            // textBoxSide
            // 
            this.textBoxSide.BackColor = System.Drawing.SystemColors.Control;
            this.textBoxSide.Location = new System.Drawing.Point(345, 117);
            this.textBoxSide.Multiline = true;
            this.textBoxSide.Name = "textBoxSide";
            this.textBoxSide.Size = new System.Drawing.Size(248, 282);
            this.textBoxSide.TabIndex = 19;
            this.textBoxSide.Visible = false;
            // 
            // cBoxJob
            // 
            this.cBoxJob.FormattingEnabled = true;
            this.cBoxJob.Location = new System.Drawing.Point(118, 117);
            this.cBoxJob.MaxDropDownItems = 4;
            this.cBoxJob.Name = "cBoxJob";
            this.cBoxJob.Size = new System.Drawing.Size(205, 21);
            this.cBoxJob.TabIndex = 20;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(445, 428);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(148, 35);
            this.button1.TabIndex = 21;
            this.button1.Text = "Cancel";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(616, 485);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.cBoxJob);
            this.Controls.Add(this.textBoxSide);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.tb_4);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.tb_6);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btn_clear);
            this.Controls.Add(this.btn_create);
            this.Controls.Add(this.tb_5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tb_2);
            this.Controls.Add(this.tb_1);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Payroll Home v1.0";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tb_1;
        private System.Windows.Forms.TextBox tb_2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tb_5;
        private System.Windows.Forms.Button btn_create;
        private System.Windows.Forms.Button btn_clear;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.TextBox tb_6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox tb_4;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox textBoxSide;
        private System.Windows.Forms.ComboBox cBoxJob;
        private System.Windows.Forms.Button button1;
    }
}

