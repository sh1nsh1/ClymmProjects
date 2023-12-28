using shop.Data.Models;

namespace shop.Data.Interfaces
{
    public interface IAllOrders
    {
        void CreateOrder(Order order, Character Char);
    }
}
