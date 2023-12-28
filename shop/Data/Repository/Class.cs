using Microsoft.EntityFrameworkCore;
using shop.Data.Interfaces;
using shop.Data.Models;

namespace shop.Data.Repository
{
    public class ItemRepository 
    {
        private readonly AppDbContext appDbContext;

        public ItemRepository(AppDbContext appDbContext)
        {
            this.appDbContext = appDbContext;
        }

        
    }
}