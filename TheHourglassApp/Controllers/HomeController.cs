using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using TheHourglass.RestaurantRepository;
using TheHourglassApp.Models;

namespace TheHourglassApp.Controllers
{
    public class HomeController : Controller
    {
        private readonly IRestaurantRepo _repo;

        public HomeController(IRestaurantRepo repo)
        {
            _repo = repo;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult About()
        {
            var rest = _repo.GetRestaurantWithId(0);

            //ViewData["Message"] = $"Your restaurant name is {rest.Name}";

            return View();
        }

        public IActionResult Contact()
        {
            ViewData["Message"] = "Your contact page.";

            return View();
        }

        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
