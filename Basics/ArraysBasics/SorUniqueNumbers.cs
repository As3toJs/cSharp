using System;
using System.Collections.Generic;

namespace ArrayBasics
{
    public class SorUniqueNumbers
    {
        public static void Numbers()
        {
            var uniqueList = new List<int>();

            while(uniqueList.Count < 5) {
                Console.WriteLine("Enter a number :");
                var enteredNumber = Convert.ToInt32(Console.ReadLine());
                if(!uniqueList.Contains(enteredNumber)){
                    uniqueList.Add(enteredNumber);
                }
            }

            uniqueList.Sort();
            Console.WriteLine("Entered numbers in sort order :");
            foreach(var number in uniqueList)
                Console.WriteLine(number);
        }
    }
}
