using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PayrollProgram1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }


        private void checkData()
        {
            if (tb_1.Text == "" || tb_1.Text == null || tb_2.Text == "" || tb_2.Text == null || tb_3.Text == "" || tb_3.Text == null
                || tb_4.Text == "" || tb_4.Text == null || tb_5.Text == "")
            {
                MessageBox.Show("Please make sure all fields all filled out.");
            }

            else
            {
                // write to file
            }
        }
        
        private void btn_create_Click(object sender, EventArgs e)
        {
            checkData();
            //writeText();
        }

        //private void writeText()
        //{
        //    textBoxSide.Visible = true;
        //    firstName = tb_1.Text;
        //    textBoxSide.Text += firstName;

        //    lastName = tb_2.Text;
        //    textBoxSide.Text += lastName + Environment.NewLine;

        //    jobTitle = tb_3.Text;
        //    textBoxSide.Text += jobTitle;

        //    firstName = tb_1.Text;
        //    textBoxSide.Text = firstName;
        //}
    }
}
