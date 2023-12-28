using Microsoft.EntityFrameworkCore;
using shop.Data.Interfaces;
using shop.Data.Models;

namespace shop.Data.Repository
{
    public class OrderRepository : IAllOrders
    {
        private readonly AppDbContext appDbContext;

        public OrderRepository(AppDbContext appDbContext)
        {
            this.appDbContext = appDbContext;
        }

        public void CreateOrder(Order order, Character Char)
        {
            order.Date = DateTime.Now;
            order.CharID = Char.Id;
            appDbContext.Orders.Add(order);

            appDbContext.SaveChanges();
        }
    }
}
