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
            get { return lastName; }
            set { lastName = value; }
        }

        public string PayRate
        {
            get { return payRate; }
            set { payRate = value; }
        }

        public int getConvertedPay()
        {
            int convertedPayRate = Convert.ToInt32(payRate);
            return convertedPayRate;
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

        // need accessors and mutator (get/set)

        public void saveEmployee()
        {
            // method that saves employee by writing to a file
        }
    }
}
