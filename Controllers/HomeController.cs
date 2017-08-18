using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using codenames.Models;

namespace codenames.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Error()
        {
            return View();
        }

        [HttpGet]
        [Route("get_deck")]
        public JsonResult GetDeck()
        {
            Random rand = new Random();
            int randColor = rand.Next(0,2);
            string firstTeam = randColor == 0 ? "red" : "blue";
            System.Console.WriteLine(firstTeam);
            Deck newDeck = new Deck(firstTeam);
            return Json(newDeck);
        }
    }
}
