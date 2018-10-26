using System;
using System.Collections.Generic;

namespace ArrayBasics
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("1: Liked Post");
            Console.WriteLine("2: Reverse Name");
            Console.WriteLine("3: Sort 5 Unique Number");
            Console.WriteLine("4: Unique Number");
            Console.WriteLine("5: Invalid Number");
            Console.WriteLine("Enter your choice :");

            var choice = Convert.ToInt32(Console.ReadLine());

            switch(choice) {
                case 1:
                    var liked = new LikedPost();
                    liked.post();
                    break;
                case 2:
                    var name = ReverseName.Name();
                    Console.WriteLine("Reverse Name : " + name);
                    break;
                case 3:
                    SorUniqueNumbers.Numbers();
                    break;
                case 4:
                    UniqueNumbers.Numbers();
                    break;
                case 5:
                    InvalidNumbers.Numbers();
                    break;
                default :
                    break;
            }
        }
    }
};
