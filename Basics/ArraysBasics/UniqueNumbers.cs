using System;
using System.Collections.Generic;

namespace ArrayBasics
{
    public class UniqueNumbers
    {
        public static void Numbers()
        {
            var numbers = new List<int>();

            while(true){
                Console.WriteLine("enter a number or type 'Quit' to exit");
                var entered = Console.ReadLine();
                if(entered.ToLower() == "quit") {
                    break;
                }

                var number = Convert.ToInt32(entered);
                numbers.Add(number);
            }

            var unique = new List<int>();

            foreach(var num in numbers)
            {
                if(!unique.Contains(num)){
                    unique.Add(num);
                }
            }

            foreach (var num in unique)
                Console.WriteLine(num);
        }
    }
}
