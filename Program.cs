using System;
using Tools;

namespace Project1
{
    public static class Program
    {
        public static void Main()
        {
            const string InitialMsg = "You had used the parking for x time, enter how many time to calculate the price for the stay";
            const string EnterHours = "Enter how many hours you have stayed";
            const string EnterMinutes = "Now, enter how many minutes have you stayed";
            const string ErrorMsg = "Error, enter a valid input";
            const string FinalMsg = $"You final price is {0}";
            float numOne = 0, numTwo = 0;
            
            Console.WriteLine(InitialMsg);
            Console.WriteLine(EnterHours);
            Console.WriteLine(EnterMinutes);

                try
                {
                    numOne = Convert.ToInt32(Console.ReadLine());
                    numTwo = Convert.ToInt32(Console.ReadLine());
                }
                catch (FormatException)
                {
                    Console.WriteLine(ErrorMsg);
                }
                catch (Exception) 
                {
                    Console.WriteLine(ErrorMsg);
                }

            CalculateCost(numOne, numTwo);

            Console.WriteLine($"Your price is{0}");
        }
        
        public static float CalculateCost(int hours, int minuts)
        {
            const int MaxMinuts = 60;
            float pricePerHour = 0;
            float pricePerMinutes = 2.50f /MaxMinuts;
            float totalPrice = pricePerHour + pricePerMinutes;

            

            if (hours == 1)
            {
                pricePerHour += 3.50f;
            }
            else if (hours == 2 && hours == 5)
            {
                for (int i = 0; i < hours; i++)
                {
                    pricePerHour += 2;
                }
            }
            else if (hours >= 6)
            {
                for (int i = 0; i < hours; i++)
                {
                    pricePerHour += 1.5f;
                }
            }

            
            if (minuts >= 1 && minuts <= MaxMinuts)
            {
                pricePerMinutes += minuts; 
            }



            return totalPrice;
        }
        
    }
}
