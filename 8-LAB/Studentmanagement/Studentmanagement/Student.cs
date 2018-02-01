using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Studentmanagement
{
    class Student
    {
        public int id { set; get; }
        public string firstName { set; get; }
        public string lastName { set; get; }
        public string city { set; get; }
        public string state { set; get; }
        public string country { set; get; }
        public string nationality { set; get; }

        public Student(int id, params string[] info)
        {
            this.id = id;
            this.firstName = info[0];
            this.lastName = info[1];
            this.city = info[2];
            this.state = info[3];
            this.country = info[4];
            this.nationality = info[5];
        }

        public override string ToString()
        {
            return firstName;
        }

    }
}
