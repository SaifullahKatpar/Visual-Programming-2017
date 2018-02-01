using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Database
{
    class Employee
    {
        public int Id{ set; get; }
        public string Fname { set; get; }
        public string Lname { set; get; }

        public Employee(int id,string fname,string lname)
        {
            this.Id = id;
            this.Fname = fname;
            this.Lname = lname;


        }

       
        public override string ToString()
        {
            return Fname; 
        }
    }
}
