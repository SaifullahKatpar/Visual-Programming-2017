using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    public static class Methods
    {

        public static string upper(this string obj)
        {
            return obj.toupper();
        }
    }
}
