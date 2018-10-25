using System;

namespace Basics
{
    class Factorial
    {
        public static void Count()
        {
            Console.WriteLine("Enter a number:");
            var number = Convert.ToInt32(Console.ReadLine());
            var fact = 1;
            for (var i = 1; i <= number; i++)
            {
                fact *= i;
            }

            Console.WriteLine("Factorial of the number : " + fact);
            Console.ReadLine();
        }
    }
}
