using System;
using System.Security.Cryptography.X509Certificates;

namespace Program
{
    public class Program
    {
        public static void Main() 
        {
            const string InitialMsg = "This program will tell if a integer number is in a range";
            const string InputMsg = "Enter a number: ";

            Console.WriteLine(InitialMsg);

            int num1, minValue1, maxValue1;

            Console.WriteLine(InputMsg);
            num1 = Convert.ToInt32(Console.ReadLine());

            minValue1 = 5;
            maxValue1 = 35;

            InRange(num1, minValue1, maxValue1);

           
        }

        public static bool InRange(int num, int minValue, int maxValue)
        {
            //5-35
            const string IsSmaller = "The number it's out of the range, it's smaller than the minimum number of the range.";
            const string IsBigger = "The number it's out of the range, it's bigger than the maximum number of the range.";
            const string IsInRangeMsg ="Congrats! Your number is in the range!";
            bool isInRange;
            if (num < minValue) 
            {
                Console.WriteLine(IsSmaller);
                isInRange = false;
            }
            else if (num > maxValue)
            {
                Console.WriteLine(IsBigger);
                isInRange = false;
            }
            else
            {
                Console.WriteLine(IsInRangeMsg);
                isInRange = true;
            }
            return isInRange;
        }
       
    }
}
