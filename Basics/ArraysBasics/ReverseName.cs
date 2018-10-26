using System;
using System.Collections.Generic;

namespace ArrayBasics
{
    public class ReverseName
    {
        public static String Name()
        {
            Console.WriteLine("Enter your full name :");
            var readValue = Console.ReadLine();
            var stringArr = readValue.Split(' ');
            var reverseName = new List<String>();

            for (var i = stringArr.Length - 1; i >= 0; i--)
            {
                if (!String.IsNullOrEmpty(stringArr[i]))
                {
                    reverseName.Add(stringArr[i]);
                }
            }

            return String.Join(" ", reverseName);
            // Console.WriteLine("Reverse Name :" + rName);
        }
    }
}
