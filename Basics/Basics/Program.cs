using System;

namespace Basics
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("1. Valid Number");
            Console.WriteLine("2. Maximum of two Numbers");
            Console.WriteLine("3. Image orientation");
            Console.WriteLine("4. Divisible by 3");
            Console.WriteLine("5. Sum of all entered numbers");
            Console.WriteLine("6. Factorial of number");
            Console.WriteLine("7. Guess a Number");

            Console.WriteLine("Enter your choice:");
            var choice = Convert.ToInt32(Console.ReadLine());

            switch (choice)
            {
                case 1:
                    Console.WriteLine("Enter the number:");
                    var enteredNumber = Convert.ToInt32(Console.ReadLine());

                    var validNumber = new ValidNumber();
                    validNumber.IsValid(enteredNumber);
                    break;
                case 2:
                    Console.WriteLine("Enter first number:");
                    var firstNumber = Convert.ToInt32(Console.ReadLine());

                    Console.WriteLine("Enter second number:");
                    var secondNumber = Convert.ToInt32(Console.ReadLine());

                    LargestNumber.Compare(firstNumber, secondNumber);
                    break;

                case 3:
                    Console.WriteLine("Enter image height :");
                    var height = Convert.ToInt32(Console.ReadLine());

                    Console.WriteLine("Enter image width :");
                    var width = Convert.ToInt32(Console.ReadLine());

                    Orientations.Compare(height, width);
                    break;
                case 4:
                    Divisible.Count();
                    break;
                case 5:
                    SumOfNumbers.Count();
                    break;
                case 6:
                    Factorial.Count();
                    break;
                case 7:
                    GuessingNumber.Guess();
                    break;
            }

        }
    }
}
