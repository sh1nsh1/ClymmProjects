using Microsoft.AspNetCore.Mvc;
using shop.Data.Interfaces;

namespace shop.Controllers{
    public class CharactersController : Controller {
        private readonly IAllCharacters _allcharacters;
        private readonly IAllTeams _allteams;

        public CharactersController(IAllCharacters allcharacters, IAllTeams allteams)
        {
            _allcharacters = allcharacters;
            _allteams = allteams;
        }
        [Route("Characters/All")]
        public ViewResult All(){
            ViewBag.Title = "Все персонажи";
            var characters = _allcharacters.Characters;
            return View(characters);
        }
        public ViewResult Pirates()
        {
            ViewBag.Title = "Пираты";
            var characters = _allcharacters.Characters;
            return View(characters);
        }
        public ViewResult Marines()
        {
            ViewBag.Title = "Дозорные";
            var characters = _allcharacters.Characters;
            return View(characters);
        }

        [Route("Characters/All/{id}")]
        public ViewResult CharDet(int id) {
            var character = _allcharacters.Characters.Where(c => c.Id == id).Select(c => c).ToList();
            ViewBag.Title = character[0].Name;
            return View(character);
        }
    }
}