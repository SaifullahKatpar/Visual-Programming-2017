using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class MathClass
    {
        string op;
        int firstValue;
        int secondValue;

        public int SecondValue
        {
            get
            {
                return secondValue;
            }

            set
            {
                secondValue = value;
            }
        }

        public int FirstValue
        {
            get
            {
                return firstValue;
            }

            set
            {
                firstValue = value;
            }
        }
    }
}
