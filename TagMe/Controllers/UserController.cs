using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using TagMe.Models;

namespace TagMe.Controllers
{
    public class UserController : Controller
    {
        public IActionResult Index()
        {
            return View();

        }
    }
}