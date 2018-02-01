using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication3
{
    // practice delegates
    public delegate void simpleDelegate();
    public delegate string calculateSeason(int month);  // declaration



    class TAC1
    {

        // 
        // A delegate example
        //
        delegate void CustomDel(string s);

        public static string season(int month)
        {
            string season = "";

            switch (month)
            {
                case 1:
                case 12:
                case 2:
                    season = "winter";
                    break;
                case 3:
                case 4:
                case 5:
                    season = "spring";
                    break;
                default:
                    break;
            }
            return season;
        }

        public static void callDelegate(calculateSeason passDelegate)
        {
            Console.WriteLine(passDelegate(1));   // invokation
        }



        //
        // another example
        //

            public static void MyFunction()
        {
            Console.WriteLine("I was called by delegate..!");
        }




        static void Logger(string s)
        {
            Console.WriteLine(s);
        }




        static void Hello(string s)
        {
            Console.WriteLine("Hello {0} !", s);
        }

        static void GoodBye(string s)
        {
            Console.WriteLine("Good Bye {0} !", s);
        }






        static void Main(string[] args)
        {
            //1. 
            calculateSeason delegateSeason = new calculateSeason(season);
            callDelegate(delegateSeason);

            //2.
            simpleDelegate simDel = new simpleDelegate(MyFunction );
            simDel();

            //3.
            TAC2.LogHandler myLogger = new TAC2.LogHandler(Logger);
            TAC2.Process(myLogger);


            //4.
            CustomDel hiDel, byeDel, multiDel, multiMinusDel;
            hiDel = Hello;
            byeDel = GoodBye;
            multiDel = hiDel + byeDel;
            multiMinusDel = multiDel - hiDel;
            Console.WriteLine("Invoking delegate hiDel");
            hiDel("A");
            Console.WriteLine("Invoking delegate byeDel");
            byeDel("B");
            Console.WriteLine("Invoking delegate multiDel");
            multiDel("C");
            Console.WriteLine("Invoking delegate multiMinusDel");
            hiDel("D");
        }
    }

    public class TAC2
    {


        public delegate void LogHandler(string message);

        //
        public static void Process(LogHandler logHandler)
        {
            logHandler?.Invoke("Process() begin");
            logHandler?.Invoke("Process() ends");

        }


    }


    class TAC3
    {
    }

}
