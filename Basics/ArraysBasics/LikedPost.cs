using System;
using System.Collections.Generic;

namespace ArrayBasics
{
    public class LikedPost
    {
        public void post()
        {
            var nameList = new List<String>();

            while (true)
            {
                Console.WriteLine("Press Enter any Time to exit :");
                Console.WriteLine("Enter the name :");
                var enteredNumber = Console.ReadLine();

                if (String.IsNullOrEmpty(enteredNumber))
                {
                    break;
                }

                nameList.Add(enteredNumber);
            }

            if (nameList.Count == 1)
            {
                Console.WriteLine("{0} likes your post", nameList[0]);
            }
            else if (nameList.Count == 2)
            {
                Console.WriteLine("{0}, {1} likes your post", nameList[0], nameList[1]);
            }
            else if (nameList.Count > 2)
            {
                Console.WriteLine("{0}, {1}, {2} of ther people, likes your post", nameList[0], nameList[1], (nameList.Count - 2));
            }
            else
            {
                Console.WriteLine("");
            }
        }
    }
}
