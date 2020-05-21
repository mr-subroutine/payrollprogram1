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
        protected string number = "";
        protected string payRate = "";
        protected string notes = "";
        protected static int employeeID = 1001;


        public Employee(string firstName, string lastName, string jobTitle, string number, string payRate)
        {
            this.firstName = firstName;
            this.lastName = lastName;
            this.jobTitle = jobTitle;
            this.number = number;
            this.payRate = payRate;
            employeeID += 1;
        }

        public Employee(string firstName, string lastName, string jobTitle, string number, string payRate, string notes)
        {
            this.firstName = firstName;
            this.lastName = lastName;
            this.jobTitle = jobTitle;
            this.number = number;
            this.payRate = payRate;
            this.notes = notes;
            employeeID += 1;
        }

        ~Employee()
        {

        }


    }
}
