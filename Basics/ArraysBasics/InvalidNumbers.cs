using System;
namespace ArrayBasics
{
    public class InvalidNumbers
    {
        public static void Numbers()
        {
            Console.WriteLine("A list of comma separated numbers:");
            var enteredNumbers = Console.ReadLine();

            var numbersArr = enteredNumbers.Split(',');
            if (numbersArr.Length < 5) {
                Console.WriteLine("Invalid List");
            }

            Array.Sort(numbersArr);

            for (var i = 0; i < numbersArr.Length; i++){
                if(i<3) {
                    Console.WriteLine(numbersArr[i]);
                }else{
                    break;
                }
            }
        }
    }
}
