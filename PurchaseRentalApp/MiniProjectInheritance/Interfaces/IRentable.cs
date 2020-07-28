namespace MiniProjectInheritance
{
    partial class Program
    {
        public interface IRentable : IIventoryItem
        {
            void Rent();
            void ReturnRental();
        }
    }
}