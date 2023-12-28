using shop.Data.Interfaces;
using shop.Data.Models;

namespace shop.Data.Mocks
{
    public class MockCharater : IAllCharacters
    {
        readonly IAllTeams _teams = new MockTeam();
        public IEnumerable<Character> Characters{
            get{
                return new List<Character>{ //Luffy Nami
                    new Character{
                        Name = "Монки Д. Луффи",
                        ShortDesc = "Капитан пиратов Соломенной Шляпы",
                        LongDesc = "Монки Д. Луффи, также известный как «Соломенная Шляпа Луффи» или просто «Соломенная Шляпа» («Мугивара»), — главный герой аниме и манги One Piece. Основатель капитан Пиратов Соломенной Шляпы, а также один из четырёх лучших бойцов.\r\n\r\nЕго мечта — стать Королём Пиратов, и найти легендарное сокровище Ван Пис, оставленное покойным Королём Пиратов — Гол Д. Роджером. Он верит, что став Королём Пиратов, он станет самым свободным человеком в мире. Он съел Дьявольский плод Гому Гому но Ми, обретя возможность растягивать своё тело подобно резине.[28]. После его вторжения в Тотто Лэнд и действий против Ёнко Большая Мамочка он долгое время считался мировой прессой Пятым Императором,[29] но после победы над Кайдо Луффи официально занял его место в числе Ёнко.",
                        Img = "/img/luffy.jpg",
                        Price = 43000,
                        IsFavorite = true,
                        IsAvailable = true,
                        Team = _teams.AllTeams.First()
                    }
                    
                };
            }
        }

        public IEnumerable<Character> FavCharacters { get; set; }

        public Character Char(int CharID)
        {
            return new Character(); //todo
        }
    }
}