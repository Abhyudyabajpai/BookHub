using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BookHub.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class AbstractController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
