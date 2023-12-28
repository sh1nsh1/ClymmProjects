using Microsoft.EntityFrameworkCore;
namespace shop.Data.Models{
    public class AppDbContext : DbContext {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {
            
        }
        public DbSet<Character> Characters {get;set;}
        public DbSet<Team> Teams { get; set; }
        public DbSet<Order> Orders{ get; set; }
    }
}