using CombatApp.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using System.Reflection;
using System.Security.Cryptography.X509Certificates;

namespace CombatApp.Controllers
{
    public class HomeController : Controller
    {

        [HttpGet]
        public IActionResult Index()
        {
            var Protag = new Character();
            ViewBag.Win = true;
            Protag.HP = 15;
            Protag.Skillpoints = 10;
            return View(Protag);
        }

        [HttpPost]
        public IActionResult Index(Character Protag)
        {
            Protag.Skillpoints += 1;
            Protag.Level += 1;

            var Enemy = new Character();
            Enemy.HP = 99;
            Enemy.Attack = 99;
            Enemy.Defense = 99;
            if (Protag.combat(Enemy) == 0)
            {
                ViewBag.Win = "WIN";
                ViewBag.Win = true;
            }
            else
            {
                ViewBag.Win = "LOSE";
                ViewBag.Win = false;
            }
            return View(Protag);

        }

    }
}
