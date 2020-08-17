using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WrapUpDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            List<PersonModel> people = new List<PersonModel>
            {
                new PersonModel{FirstName = "Lola", LastName = "Ponce", Email = "lola@gmail.com"},
                new PersonModel{FirstName = "Juli", LastName = "Peters", Email = "jp@hotmail.com"},
                new PersonModel{FirstName = "Jesus", LastName = "Buda", Email = "jesus&buda@gmail.com"}
            };

            List<CarModel> cars = new List<CarModel>
            {
                new CarModel{Manufacturer = "Ford", Model = "Ka"},
                new CarModel{Manufacturer = "Suzuki", Model = "Fiesta"},
                new CarModel{Manufacturer = "Toyota", Model = "Corolla"}

            };

            people.SaveToCSV(@"C:\SaveFiles\people.csv");
            cars.SaveToCSV(@"C:\SaveFiles\cars.csv");


            Console.ReadLine();
        }
    }

    public static class DataAccess
    {
        public static void SaveToCSV<T>(this List<T> items, string filePath) where T: new()
        {
            List<string> rows = new List<string>();
            T entry = new T();
            var cols = entry.GetType().GetProperties();

            string row = "";
            foreach (var col in cols)
            {
                row += $",{col.Name}";
            }
            row = row.Substring(1);
            rows.Add(row);

            foreach (var item in items)
            {
                row = "";
                foreach (var col in cols)
                {
                    row += $",{col.GetValue(item, null)}";
                }

                row = row.Substring(1);
                rows.Add(row);
            }
            File.WriteAllLines(filePath, rows);
        }

        private static bool BadWordDetector(string stringToTest)
        {
            bool output = false;

            string lowerCaseTest = stringToTest.ToLower();

            if (lowerCaseTest.Contains("darn") || lowerCaseTest.Contains("heck"))
            {
                output = true;
            }

            return output;
        }

    }


}
