using System;

namespace ExtensionMethods
{
    public static class ConsoleHelper
    {
        public static string RequestString(this string message)
        {
            string output = "";

            while (string.IsNullOrEmpty(output))
            {
                Console.WriteLine(message);
                output = Console.ReadLine();
            }

            return output;
        }

        public static int RequestInt(this string messageInt)
        {
            return messageInt.RequestInt(false);
        }

        public static int RequestInt(this string messageInt, int minValue, int maxValue)
        {
            return messageInt.RequestInt(true, minValue, maxValue);
        }

        private static int RequestInt(this string messageInt, bool useMinMax, int minValue = 0, int maxValue = 0)
        {
            int output = 0;
            bool isValidInt = false;
            bool isValidRange = true;

            while (isValidInt == false || isValidRange == false)
            {
                Console.WriteLine(messageInt);
                isValidInt = int.TryParse(Console.ReadLine(), out output);

                if (useMinMax == true)
                {
                    isValidRange = (output >= minValue && output <= maxValue);
                }
            }

            return output;
        }
    }
}