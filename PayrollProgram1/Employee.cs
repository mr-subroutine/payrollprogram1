using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PayrollProgram1
{
    class Employee
    {
        protected string firstName = "";
        protected string lastName = "";
        protected string jobTitle = "";
        protected string phNumber = "";
        protected string payRate = "";
        protected string notes = "";
        protected static int employeeID = 1001;
        protected double grossPay;
        protected double netPay;
        protected double yearlyGrossPay;
        protected double yearlyNetPay;

        public Employee(string firstName, string lastName, string jobTitle, string phNumber, string payRate)
        {
            this.firstName = firstName;
            this.lastName = lastName;
            this.jobTitle = jobTitle;
            this.phNumber = phNumber;
            this.payRate = payRate;
            employeeID += 1;
        }

        public Employee(string firstName, string lastName, string jobTitle, string phNumber, string payRate, string notes)
        {
            this.firstName = firstName;
            this.lastName = lastName;
            this.jobTitle = jobTitle;
            this.phNumber = phNumber;
            this.payRate = payRate;
            this.notes = notes;
            employeeID += 1;
        }

        public Employee()
        {
            // default empty constructor
        }

        ~Employee()
        {
            // destructor
        }

        public string FirstName
        {
            get { return firstName; }
            set { firstName = value; }
        }

        public string LastName
        {
            get { return lastName; }
            set { lastName = value; }
        }

        public string JobTitle
        {
            get { return jobTitle; }
            set { jobTitle = value; }
        }

        public string Number
        {
            get { return phNumber; }
            set { phNumber = value; }
        }

        public string PayRate
        {
            get { return payRate; }
            set { payRate = value; }
        }

        public string getConvertedPay()
        {
            int convertedPayRate = Convert.ToInt32(payRate);
            string newConvertedPayRate = convertedPayRate.ToString("c");
            return newConvertedPayRate;
        }

        public string Notes
        {
            get { return notes; }
            set { notes = value; }
        }

        public int getIdNumber
        {
            get { return employeeID; }
        }

        public double formattedPayrate()
        {
            double newPay = Double.Parse(payRate) * 40;
            return newPay;
        }

        public double getGrossPay()
        {
            grossPay = Double.Parse(payRate) * 40;
            return grossPay;
        }

        public double getYearlyGrossPay()
        {
            yearlyGrossPay = Double.Parse(payRate) * 40 * 52;
            return yearlyGrossPay;
        }

        public double getNetPay()
        {
            double percentageValue = 0.20;
            netPay = percentageValue * Convert.ToDouble(grossPay);
            double newNetPay = grossPay - netPay;
            return newNetPay;
        }

        public double getYearlyNetPay()
        {
            yearlyNetPay = 0.00;
            double percentageValue = 0.20;
            netPay = percentageValue * Convert.ToDouble(grossPay);
            yearlyNetPay = grossPay - netPay;
            return yearlyNetPay * 52;
        }
    }
}
