using Microsoft.AspNetCore.Mvc;
using shop.Data.Interfaces;

namespace shop.Controllers
{
    public class HomeController : Controller
    {
        public HomeController(IAllCharacters allcharacters, IAllTeams allteams)
        {
                
        }

        public ViewResult Index()
        {
            return View();
        }
        
    }
}
