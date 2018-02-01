using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentManagement
{
    public class StudentClass
    {

       public string name, lastName, address,city, mobileNo;

        public StudentClass(params string[] data)
        {
            name = data[0];
            lastName = data[1];
            address = data[2];
            city = data[3];
            mobileNo = data[4];

        }

        public override string ToString()
        {
            return String.Format("\nName:{0}\nLast Name: {1}\nAddress: {2}\nCity: {3}\nMobile Number: {4}",name,lastName,address,city,mobileNo);
        }

    }
}
