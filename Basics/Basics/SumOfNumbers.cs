using System;

namespace Basics
{
    class SumOfNumbers
    {
        public static void Count()
        {
            var sum = 0;
            while (true)
            {
                Console.WriteLine("Enter a number or 'ok' to exit :");
                var input = Console.ReadLine();
                if (input.ToLower() == "ok")
                    break;
                sum += Convert.ToInt32(input);
            }
            Console.WriteLine("Sum of numbers :" + sum);

        }
    }
}
