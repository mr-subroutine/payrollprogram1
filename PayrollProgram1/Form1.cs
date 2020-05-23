using System;
using System.IO;
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

        Employee employee;

        private void Form1_Load(object sender, EventArgs e)
        {
            cBoxJob.Items.Add("Software Engineer");
            cBoxJob.Items.Add("Senior Software Engineer");
            cBoxJob.Items.Add("Software Manager");
            cBoxJob.Items.Add("QA Manager");
            cBoxJob.Items.Add("QA Tester");
            cBoxJob.Items.Add("Senior QA Tester");
            cBoxJob.Items.Add("Producer");
            cBoxJob.Items.Add("Designer");
            cBoxJob.Items.Add("Senior Designer");
        }
        
        private void btn_create_Click(object sender, EventArgs e)
        {
            // 1. 
            checkDataFields();

            // 2.
            employee = createEmployee();

            // 3.
        }

        private Employee createEmployee()
        {
            Employee employee = new Employee(tb_1.Text, tb_2.Text, cBoxJob.Text, tb_4.Text, tb_5.Text, tb_6.Text);
            return employee;
        }

        private void checkDataFields()
        {
            if (tb_1.Text == "" || tb_1.Text == null || tb_2.Text == "" || tb_2.Text == null
                || tb_4.Text == "" || tb_4.Text == null || tb_5.Text == "")
            {
                MessageBox.Show("Please make sure all fields all filled out.");
            }
        }

        private void displayData()
        {
            textBoxSide.Visible = true;
        }

        private void writeData(Employee emp)
        {
            textBoxSide.Visible = true;
        }
    }
}
