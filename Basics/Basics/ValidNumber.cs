using System;

namespace Basics
{
    class ValidNumber
    {
        public void IsValid(int number)
        {
            if (number > 0 && number <= 10)
            {
                Console.WriteLine("Number is valid number");
            }
            else
            {
                Console.WriteLine("Invalid Number");
            }
            Console.ReadLine();
        }
    }
}
