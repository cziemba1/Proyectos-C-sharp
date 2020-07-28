namespace MiniProjectInheritance
{
    partial class Program
    {
        public interface IPurchasable : IIventoryItem
        {
            void Purchase();
        }
    }
}