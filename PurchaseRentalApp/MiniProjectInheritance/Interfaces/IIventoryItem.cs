namespace MiniProjectInheritance
{
    partial class Program
    {
        public interface IIventoryItem
        {
            string ProductName { get; set; }
            int QuantityInStock { get; set; }
        }
    }
}