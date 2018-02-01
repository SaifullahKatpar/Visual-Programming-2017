using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dcAccessApp
{
    class Student
    {
        public int  id { get; set; }
        public string name { get; set; }
        public string city { get; set; }
        public string state { get; set; }

        public Student(int id, string name,string city, string state )
        {
            this.id = id;
            this.name = name;
            this.city = city;
            this.state = state;

        }


        public override string ToString()
        {
            return name;
        }

    }
}
