﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace BankOfBrabant.Controllers
{
    public class LogInController : Controller
    {
        // GET: /<controller>/
        public IActionResult LoginScreen()
        {
            return View();
        }

        public IActionResult LoginPress()
        {
            ViewBag.Message = "Hallo";
            //hallo//
            return View();
        }
    }
}