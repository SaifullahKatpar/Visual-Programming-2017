using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    public class Demo1 : Person
    {


        private bool alive = false;
        int age;
        string name;


        public void haveChild(string child,string gender, int childAge)
        {
            name = child;
        }

        public int Age
        {
            get
            {
                return age;
            }

            set
            {
                age = value;
            }
        }

        public string Name
        {
            get
            {
                return name;
            }

            set
            {
                name = value;
            }
        }


        /*
        public void setAlive()
        {
            alive = (alive) ? false : true; 
        } 


        public bool getALive()
        
            return alive;
        }

    */

        public double DivideWithoutOperator(int divisor, int dividend)
        {
            double rem = dividend - divisor;
            int count = 0;
            while (rem>= divisor)
            {
                rem = dividend - divisor;
                count++;
            }

            return rem;
        }
    }
}
