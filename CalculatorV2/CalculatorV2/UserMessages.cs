using System;
using System.Collections.Generic;
using System.Text;

namespace CalculatorV2
{
    public static class UserMessages
    {
        public static void ApplicationStartMessage(string firstName)
        {
            int hourOfDay = DateTime.Now.Hour;

            if(hourOfDay < 12)
            {
                Console.WriteLine($"Good Morning {firstName}");
            }
            else if(hourOfDay < 19)
            {
                Console.WriteLine($"Good Afternoon {firstName}");
            }
            else
            {
                Console.WriteLine($"Good Night {firstName}");
            }
        }
        public static void PrintResultMessage(string message)
        {
            Console.WriteLine(message);
            Console.WriteLine();
            Console.WriteLine("Thank you for use our app.");
        }
    }
}
