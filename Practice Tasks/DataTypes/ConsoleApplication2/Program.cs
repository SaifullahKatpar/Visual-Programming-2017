using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication2
{
    class Program
    {
        static void Main(string[] args)
        {

            // var variable & getType()
            /*
            var str = "Saifullah";
            var num = 20;
            var dbl = 10.9;
            var sngl = 10.9f;

            Console.WriteLine(str  + " : " + str.GetType());
            Console.WriteLine(num + " : " + num.GetType());
            Console.WriteLine(dbl + " : " + dbl.GetType());
            Console.WriteLine(sngl + " : " + sngl.GetType());

    */
            // nullable var
            /*            int? count = 220;

                        if (count.HasValue)
                        {
                            Console.WriteLine(count);
                        }
                        else
                        {
                            Console.WriteLine("null");

                        }
                        */

            /*
            // value types
            int a = 10;
            int b = a;
            b += 2;
            Console.WriteLine(b);
            Console.WriteLine(a);

            // ref types
            Helper h = new Helper("Saif");
            Helper g = h;

            Console.WriteLine(h.name);
            Console.WriteLine(g.name);
            g.name  = "Paul";
            Console.WriteLine(g.name);
            Console.WriteLine(h.name);
            */

            /*
            int[] customer = { 1,2,3};
            int[] products = { };
            int[] pur =null;

            int? len = customer?.Length;
            int? size = products?.Length;
            
            Console.WriteLine("len : " + len);
            Console.WriteLine("size: " + size);
            size = pur?.Length;
            Console.WriteLine("size of null: " + size);
            Console.WriteLine("null: " + null);
            */


            /*
            // anonymous object/type

            var v = new { Amount = 108, Message = "Hello"};
            Console.WriteLine(v.Amount + "  " +  v.Message);
            */

            //bitwise complement
            SByte one = 1;
            Console.WriteLine(Convert.ToString(one,2));
            Console.WriteLine(Convert.ToString(~one,2));


            Console.ReadLine();
        }
    }
}
