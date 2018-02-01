using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinqExamples
{
    public class Employee
    {
        public string firstName { set; get; }
        public string lastName { set; get; }
        public string city { set; get; }

        public Employee(string firstName,string lastName,string city)
        {
            this.firstName = firstName;
            this.lastName = lastName;
            this.city = city;

        }

        public override string ToString()
        {
            return "First Name: " + firstName + "  Last Name: " + lastName + " City: " + city;
        }

    }
}
