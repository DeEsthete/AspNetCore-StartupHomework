using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace AspNetCoreHomeWork.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            Response.StatusCode = 400;
            throw new Exception("Index exception");
            return View();
        }
    }
}