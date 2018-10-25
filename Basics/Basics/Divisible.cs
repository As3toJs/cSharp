using System;

namespace Basics
{
    class Divisible
    {
        public static void Count()
        {
            var count = 0;
            for (var i = 1; i <= 100; i++)
            {
                if (i % 3 == 0)
                {
                    count++;
                }
            }
            Console.WriteLine("There are " + count + " numbers between 1 and 100 are divisible by 3 with no remainder.");
            Console.ReadLine();
        }
    }
}
