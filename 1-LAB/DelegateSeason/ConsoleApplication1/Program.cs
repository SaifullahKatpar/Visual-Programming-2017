using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Program
    {

        // expression lambda 
        public delegate void calculateSeason(int month);



        static void Main(string[] args)
        {
            //            calculateSeason del_lambda = (int month) => month == 1 ? "winter" : "nothing";


            calculateSeason del_lambda = (int month) =>
            {
                if (month == 12 || month == 1 || month == 2)
                    Console.WriteLine("Winter");
            };

            del_lambda(1);
        }
    }
}
