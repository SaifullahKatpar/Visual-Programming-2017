using System;

namespace Simple
{
    
    /// <summary>
    ///      program class
    ///      project starts form Main method of this class
    /// </summary>

    public class program
    {

        int num = 0;

        /// <summary>
        ///      Main method
        ///      Entry point of project
        /// </summary>

        public static void Main()
        {
            Console.WriteLine("Eneter the name of a shape (C,R )");
            string shape = Console.ReadLine();
            if (shape.Equals("C"))
            {

                areaCircle();
            }
            else
            {
                Console.WriteLine("Rectangle");
            }
        }
        private static void areaCircle()
        {
            rect();
            Console.WriteLine("Bog Circle --> O");
        }
        private static void rect()
        {
            Console.WriteLine("Rect");
        }
    }

}
