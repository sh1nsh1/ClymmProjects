using shop.Data.Interfaces;
using shop.Data.Models; 

namespace shop.Data.Mocks
{
    public class MockTeam : IAllTeams
    {
        public IEnumerable<Team> AllTeams{
            get{
                return new List<Team>{
                    new Team {Id = 1, TeamName = "Пираты", Desc = "Самые известные пираты с наградой более 5000000 Белли. Однако накама мугивары Луффи по имени Чоппер тоже будет входить в этот список"},
                    new Team {Id = 2, TeamName = "Дозорные", Desc = "Лучшие из лучших. Большинство борятся с пиратами и защищают мирных жителей"}
                };
            }
        }
    }
}