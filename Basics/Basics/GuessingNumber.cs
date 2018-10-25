using System;

namespace Basics
{
    class GuessingNumber
    {
        public static void Guess()
        {
            var random = new Random();
            var randomNumber = random.Next(1, 10);

            for (var i = 0; i < 4; i++)
            {
                Console.WriteLine("Enter the secret number:");
                var guess = Convert.ToInt32(Console.ReadLine());
                if (guess == randomNumber)
                {
                    Console.WriteLine("You won");
                    break;
                }

                Console.WriteLine("You lost");
            }
        }
    }
}
