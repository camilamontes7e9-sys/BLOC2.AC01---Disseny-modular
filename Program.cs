using System;

namespace Program
{
    public class Program
    {
        public static void Main()
        {
            const string InitialMsg = "This program will convert a decimal number for a temperature to another temperature system";
            const string ChooseOp = "Choose an option to convert: ";
            const string OptionOne = "1-From Celsius to Fahrenheit";
            const string OptionTwo = "2-From Fahrenheit to Celsius";
            const string OptionThree = "3-From Celsius to Kelvin";
            const string ErrorMsg = "Error, enter a valid input.";
            const string EnterDecimal = "Enter the decimal number to convert it";
            const string TryAgainMsg = "Try again: ";

            Console.WriteLine(InitialMsg);
            Console.WriteLine(ChooseOp);
            Console.WriteLine(OptionOne);
            Console.WriteLine(OptionTwo);
            Console.WriteLine(OptionThree);

            int input = 0;
            float decimalNumberTwo = 0;
            bool validOption = false;
            while (!validOption)
            {
                try
                {
                    input = Convert.ToInt32(Console.ReadLine());

                    if (input < 1 || input > 3)
                    {
                        Console.WriteLine(ErrorMsg);
                        Console.Write(TryAgainMsg);
                    }
                    else
                    {
                        validOption = true;
                    }
                }
                catch (FormatException)
                {
                    Console.WriteLine(ErrorMsg);
                    Console.Write(TryAgainMsg);
                }
                catch (Exception)
                {
                    Console.WriteLine(ErrorMsg);
                    Console.Write(TryAgainMsg);
                }
            }
            Console.WriteLine(EnterDecimal);
            bool validFloat = false;
            while (!validFloat)
            {
                
                try
                {
                    decimalNumberTwo = Convert.ToSingle(Console.ReadLine());

                    if (decimalNumberTwo % 1 == 0)
                    {
                        Console.WriteLine(ErrorMsg);
                        Console.Write(TryAgainMsg);
                        continue;
                    }

                    validFloat = true;
                }
                catch (FormatException)
                {
                    Console.WriteLine(ErrorMsg);
                }
                catch (Exception)
                {
                    Console.WriteLine(ErrorMsg);
                }
            }

            ConvertTemperature(input, decimalNumberTwo);
        }
        public static float ConvertTemperature(int input, float decimalNumber)
        {
            
            float original = decimalNumber;
            switch (input)
            {
                case 1:
                    decimalNumber = decimalNumber * 9 / 5 + 32;
                    Console.WriteLine($"You converted {original}°C to {decimalNumber:F2}°F");
                    break;
                case 2:
                    decimalNumber = (decimalNumber - 32) * 5 / 9;
                    Console.WriteLine($"You converted {original}°F to {decimalNumber:F2}°C");
                    break;
                case 3:
                    decimalNumber = decimalNumber + 273.15f;
                    Console.WriteLine($"You converted {original}°C to {decimalNumber:F2} K");
                    break;
            }
            return decimalNumber;
        }
    }
}
