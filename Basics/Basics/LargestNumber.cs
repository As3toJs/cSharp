using System;

namespace Basics
{
    class LargestNumber
    {
        public static void Compare(int firstNumber, int secondNumber)
        {
            var max = (firstNumber > secondNumber) ? firstNumber : secondNumber;
            Console.WriteLine("Max is :", max);
            Console.ReadLine();
        }
    }
}
