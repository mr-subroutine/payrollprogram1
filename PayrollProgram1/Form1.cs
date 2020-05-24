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
using System.Runtime.CompilerServices;

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
 
        }
        
        private void btn_create_Click(object sender, EventArgs e)
        {
            btn_create.Enabled = false;
            checkDataFields();
            employee = createEmployee();
            // display data and calculated numbers
            displayData(employee);
            // write data to file

            // save to combo box to display later (clicking user name will populate box again.

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

        private void displayData(Employee emp)
        {
            textBoxSide.Text += "--Employee Data--";
            textBoxSide.Text = "Employee Identification Number: " + emp.getIdNumber;
            textBoxSide.Text += Environment.NewLine;
            textBoxSide.Text += "First Name and Last Name: " + emp.FirstName + " " + emp.LastName;
            textBoxSide.Text += Environment.NewLine;
            textBoxSide.Text += "Job Title: " + emp.JobTitle;
            textBoxSide.Text += Environment.NewLine;
            textBoxSide.Text += "Phone Number: " + emp.Number;
            textBoxSide.Visible = true;
            textBoxSide.Text += Environment.NewLine;
            textBoxSide.Text += "--Payroll Data--";
            textBoxSide.Text += Environment.NewLine;
            textBoxSide.Text += "Payrate: " + emp.getConvertedPay();
            textBoxSide.Text += Environment.NewLine;
            textBoxSide.Text += "Weekly Gross Pay: " + emp.getGrossPay().ToString("c");
            textBoxSide.Text += Environment.NewLine;
            textBoxSide.Text += "Weekly Net Pay: " + emp.getNetPay().ToString("c");
            textBoxSide.Text += Environment.NewLine;
            textBoxSide.Text += "Yearly Gross Pay: " + emp.getYearlyGrossPay().ToString("c");
            textBoxSide.Text += Environment.NewLine;
            textBoxSide.Text += "Yearly Net Pay: " + emp.getYearlyNetPay().ToString("c");
        }

        private void writeData(Employee emp)
        {
            
        }
    }
}
