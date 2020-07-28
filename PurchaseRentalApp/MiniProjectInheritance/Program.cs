using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Security.Permissions;
using System.Text;
using System.Threading.Tasks;

namespace MiniProjectInheritance
{
    partial class Program
    {
        static void Main(string[] args)
        {
            //List<InventoryItemModel> inventory = new List<InventoryItemModel>();
            //inventory.Add(new VehicleModel { DealerFee = 25, ProductName = "Ford Gold" });
            //inventory.Add(new BookModel { NumOfPages = 300, ProductName = "La Bella y la Bestia" });


            List<IPurchasable> purchasables = new List<IPurchasable>();
            List<IRentable> rentables = new List<IRentable>();

            var vehicle = new VehicleModel {DealerFee = 25, ProductName = "Ford Gold"};
            var book = new BookModel {NumOfPages = 300, ProductName = "La Bella y la Bestia"};
            var excavator = new ExcavatorModel {ProductName = "Bulldozer", QuantityInStock = 2};

            rentables.Add(vehicle);
            rentables.Add(excavator);

            purchasables.Add(book);
            purchasables.Add(vehicle);

            Console.WriteLine("Do you want to rent or purchase something? Chosee purchase / rent");
            string rentalDesicion = Console.ReadLine();

            if (rentalDesicion.ToLower() == "rent")
            {
                foreach (var item in rentables)
                {
                    Console.WriteLine($"Iem: {item.ProductName}");
                    Console.Write("Do you want to rent this item? yes/no");
                    string wantToRent = Console.ReadLine();

                    if (wantToRent.ToLower() == "yes")
                    {
                        item.Rent();
                    }

                    Console.Write("Do you want to return this item? yes/no");
                    string wantToReturn = Console.ReadLine();

                    if (wantToReturn.ToLower() == "yes")
                    {
                        item.ReturnRental();
                    }
                }
            }
            else
            {
                foreach (var item in purchasables)
                {
                    Console.WriteLine($"Item: {item.ProductName}");
                    Console.Write("Do you want to purchase this item? yes/no");
                    string wantToPurchase = Console.ReadLine();

                    if (wantToPurchase.ToLower() == "yes")
                    {
                        item.Purchase();
                    }
                }

                Console.ReadLine();
            }
        }
    }
}
