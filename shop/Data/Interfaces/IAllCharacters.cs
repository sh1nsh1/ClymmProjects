using shop.Data.Models;

namespace shop.Data.Interfaces
{
    public interface IAllCharacters{
        IEnumerable<Character> Characters{get;}
        IEnumerable<Character> FavCharacters{get;}

        Character Char(int CharID);
    }
}