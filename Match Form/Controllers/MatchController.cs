using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Match_Form.Models;
namespace Match_Form.Controllers
{
    public class MatchController : Controller
    {

        List<Player> playerList = new List<Player>();
        public IActionResult Index()
        {
            return View();
        }


        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind("Name,Type,Position,Team")] Player player)
        {
            Singleton s1 = Singleton.GetInstance;
            s1.addPlayer(player);
            ViewData["PlayerData"] =s1.getPlayer();
            return View("index");
        }
    }
}
