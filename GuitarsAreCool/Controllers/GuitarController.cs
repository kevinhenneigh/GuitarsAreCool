using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Server.IIS.Core;

namespace GuitarsAreCool.Controllers
{
    public class GuitarController : Controller
    {
        [HttpGet]
        public IActionResult Add()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Add(IFormCollection form)
        {
            Guitar guitar = new Guitar();
            guitar.Brand = form["guitar"];
            guitar.Style = form["style"];

            //Add to DataBase

            ViewData["Added"] = true;

            return View();
        }

        [HttpGet]
        public IActionResult AddWithBinding()
        {
            return View();
        }

        [HttpPost]
        public IActionResult AddWithBinding(Guitar guitar)
        {
            if (ModelState.IsValid)
            {
                ViewData["Message"] = $"{guitar.Brand} {guitar.Style} was added!"; 
                // Add to Db HERE!!
            }
            return View();
        }
    }
}
