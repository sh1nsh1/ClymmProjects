using Microsoft.EntityFrameworkCore;
using shop.Data.Interfaces;
using shop.Data.Models;

namespace shop.Data.Repository{
    public class CharacterRepository : IAllCharacters{
        private readonly AppDbContext appDbContext;

        public IEnumerable<Character> Characters => 
            appDbContext.Characters.Include(c => c.Team);

        public IEnumerable<Character> FavCharacters => 
            appDbContext.Characters.Where(b => b.IsFavorite).Include(c => c.Team);

        public Character Char(int CharID) => 
            appDbContext.Characters.FirstOrDefault(c => c.Id == CharID);

        public CharacterRepository(AppDbContext appDbContext){
            this.appDbContext = appDbContext;
        }
    }
}