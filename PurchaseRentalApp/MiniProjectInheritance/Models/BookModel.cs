using System;

namespace MiniProjectInheritance
{
    partial class Program
    {
        public class BookModel : InventoryItemModel, IPurchasable
        {
            public int NumOfPages { get; set; }

            public void Purchase()
            {
                QuantityInStock -= 1;
                Console.WriteLine("This book has been purchased");
            }
        }
    }
}