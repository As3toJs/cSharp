using System;

namespace Basics
{
    class Orientations
    {
        public static void Compare(int height, int width)
        {
            if (height == width)
            {
                Console.WriteLine("Image is rectangle");
            }
            else if (height > width)
            {
                Console.WriteLine("Image is Portrait");
            }
            else
            {
                Console.WriteLine("Image is Landscape");
            }
            Console.ReadLine();
        }
    }
}
