using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Product.MVC.Areas.Admin.Controllers
{
    public class HomeController : Controller
    {
        [Area(areaName:"Admin")]
        public IActionResult Index()
        {
            return View();
        }
    }
}
