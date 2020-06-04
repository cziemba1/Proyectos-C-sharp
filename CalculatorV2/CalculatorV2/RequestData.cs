using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Text;

namespace CalculatorV2
{
    public static class RequestData
    { 
        public static string GetaString(string message)
        {
            Console.WriteLine(message);
            string output = Console.ReadLine();
            return output;
        }
        
        public static double GetADouble(string message)
        {
            Console.Write(message);
            string numberText = Console.ReadLine();
            double output;
            bool isDouble = double.TryParse(numberText, out output);

            while (isDouble == false)
            {
                Console.WriteLine("That is not a valid number. Try again.");
                Console.WriteLine(message);
                numberText = Console.ReadLine();
                isDouble = double.TryParse(numberText, out output);
            }

            return output;
        }
    }
}
