using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace Alliai.Controllers
{
    public class TrackOrderController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}