using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication2
{
   public class Helper
    {
       public string name;

        public Helper(string n)
        {
            name = n;

        }

        Helper()
        {
            name ="Def";

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
    }
}
