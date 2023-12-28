using shop.Data.Models;

namespace shop.Data.Interfaces

{
    public interface IAllTeams{
        IEnumerable<Team> AllTeams { get; }
    }
}