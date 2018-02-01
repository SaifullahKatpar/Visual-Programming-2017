using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
//            NewMethod();
            parametersRefactoring(1,1);
        }

        public static void parametersRefactoring(int a, int b)
        {

        }

        private static void NewMethod()
        {
            Console.WriteLine("extract method refactoring");
        }
    }
}


/*
 
    

            Demo1 life = new ConsoleApplication1.Demo1();
            //---------------------
            Console.WriteLine("op1: ");
            int num1
                 = int.Parse(Console.ReadLine());
            Console.WriteLine("op2: ");
            int num2 = int.Parse(Console.ReadLine());
            Console.WriteLine("operand: ");
            string op = Console.ReadLine();
            switch (op)
            {
                case "+":
                    Console.WriteLine(num1 + num2);
                    break;
                case "-":
                    Console.WriteLine(num1 - num2);
                    break;
                case "/":
                    Console.WriteLine(num1 / num2);
                    break;
                case "*":
                    Console.WriteLine(num1 * num2);
                    break;


            }
            //----------------------
            //            life.setAlive();

            MathClass.calc();



    */
