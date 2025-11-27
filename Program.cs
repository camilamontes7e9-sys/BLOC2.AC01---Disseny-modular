using System;
using System.Security.Cryptography.X509Certificates;

namespace Program
{
    public class Program
    {
        public static void Main() 
        {
            const string InitialMsg = "This program will convert a decimal number for a temperature to another temperature system";
            const string ChooseOp = "Choose an option to convert: ";
            const string OptionOne = "1-From Celsius to Fahrenheit";
            const string OptionTwo = "2-From Fahrenheit to Celcius";
            const string OptionTree = "3-From Celcius to Kelvin";
            const string ErrorMsg = "Error, enter a valid input.";
            const string EnterDecimal = "Enter the decimal number to convert it";

            Console.WriteLine(InitialMsg);
            Console.WriteLine(ChooseOp);
            Console.WriteLine(OptionOne);
            Console.WriteLine(OptionTwo);
            Console.WriteLine(OptionTree);
            Console.WriteLine(OptionOne);

            int input;
            float decimalNumberTwo;

            try
            {
                input = Convert.ToInt32(Console.ReadLine());
            }
            catch (Exception)
            {
                Console.WriteLine(ErrorMsg);
            }


            switch (input)
            {
                case 1:
                    Console.WriteLine(EnterDecimal);
                    try
                    {
                        decimalNumberTwo = Convert.ToSingle(Console.ReadLine());
                    }
                    catch
                    {
                        Console.WriteLine(ErrorMsg);
                    }
                    ConvertTemperature(decimalNumberTwo);
                    break;
                case 2:
                    Console.WriteLine(EnterDecimal);
                    try
                    {
                        decimalNumberTwo = Convert.ToSingle(Console.ReadLine());
                    }
                    catch
                    {
                        Console.WriteLine(ErrorMsg);
                    }
                    ConvertTemperature(decimalNumberTwo);
                    break;
                case 3:
                    Console.WriteLine(EnterDecimal);
                    try
                    {
                        decimalNumberTwo = Convert.ToSingle(Console.ReadLine());
                    }
                    catch
                    {
                        Console.WriteLine(ErrorMsg);
                    }
                    ConvertTemperature(decimalNumberTwo);
                    break;
            }
           
        }
        public static float ConvertTemperature(float decimalNumberTwo)
        {
            const string CelciusToFahrenheit = "You converted {0}Cº to {1}ºF";
            const string FahrenheitToCelcius = "You conveted {0}ºF to {1}Cº";
            const string CelciusToKelvin = "You converted {0}Cº to {1}K";
            
            int input;
            float decimalNumber;
            float secondNum = decimalNumber;

            switch (input)
            {
                case 1:
                    decimalNumber = decimalNumber * 9 / 5 + 32;
                    Math.Round(decimalNumber, 2);
                    Console.WriteLine(CelciusToFahrenheit, secondNum, decimalNumber);
                    break;
                case 2:
                    decimalNumber = (decimalNumber - 32) * 5 / 9;
                    Math.Round(decimalNumber, 2);
                    Console.WriteLine(FahrenheitToCelcius, secondNum, decimalNumber);
                    break;
                case 3:
                    decimalNumber = decimalNumber + 273.15f;
                    Math.Round(decimalNumber, 2);
                    Console.WriteLine(CelciusToKelvin, secondNum, decimalNumber);
                    break;
            }
            return decimalNumber;
        }
    }
}
