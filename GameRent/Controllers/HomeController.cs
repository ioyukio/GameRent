﻿using GameRent.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace GameRent.Controllers
{
	public class HomeController : Controller
	{
		public IActionResult Index() { return View(); }
        public IActionResult ONas()
        {
            return View();
        }
    }

   

}
