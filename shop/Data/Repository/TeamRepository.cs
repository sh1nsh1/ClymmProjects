using System.Security;
using Microsoft.EntityFrameworkCore;
using shop.Data.Interfaces;
using shop.Data.Models;

namespace shop.Data.Repository{
    public class TeamRepository : IAllTeams{
        private readonly AppDbContext appDbContext;
        
        public TeamRepository(AppDbContext appDbContext){
            this.appDbContext = appDbContext;
        }

        public IEnumerable<Team> AllTeams => appDbContext.Teams;
    }
}