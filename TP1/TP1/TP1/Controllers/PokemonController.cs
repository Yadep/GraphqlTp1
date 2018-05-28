using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace TP1.Controllers
{
    public class PokemonController : Controller
    {
        public IActionResult Index()
        {
            return PartialView("PV_Pokemon");
        }


    }
}