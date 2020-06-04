using System;

namespace CalculatorV2
{
    class Program
    {
        static void Main(string[] args)
        {
            string firstName = RequestData.GetaString("What is your name?");

            UserMessages.ApplicationStartMessage(firstName);

            double x = RequestData.GetADouble("Please enter your first number:");
            double y = RequestData.GetADouble("Please enter your second number: ");

            double result = CalculatedData.Add(x, y);

            UserMessages.PrintResultMessage($"The suman of {x} and {y} is {result}");

            
            Console.ReadLine();
        }


    }
}
