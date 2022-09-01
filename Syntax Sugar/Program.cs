using System;

namespace Syntax_Sugar
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            var answer = 4;
            var response = (answer < 9) ? $"{answer} is less than nine" : $"{answer} is greater than or equal to mine";

            //if (answer < 9)
            //{
                //response = answer + " is less than nine";
            //}
            //else
            //{
                //response = answer + “greater than or equal to nine”;
            //}

        }
    }
}
