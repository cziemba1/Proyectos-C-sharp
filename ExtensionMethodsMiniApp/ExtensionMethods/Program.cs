using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExtensionMethods
{
    class Program
    {
        static void Main(string[] args)
        {
            PersonModel person = new PersonModel();

            person.FirstName = "What is your first name?".RequestString();

            person.LastName = "What is your lastname?".RequestString();

            person.Age = "What is your age?".RequestInt(12, 120);

            person.NumberOfChildren = "How many children do you have?".RequestInt();


            Console.WriteLine($"Name: {person.FirstName}, LastName: {person.LastName}, Age: {person.Age}, Children: {person.NumberOfChildren}");
            Console.ReadLine();
        }
    }
}
