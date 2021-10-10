using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CampProj.Controllers
{
    [ApiController]
    [Route("booking")]
    public class TableBookingController : Controller
    {   
        [HttpGet]
        [HttpPost]
        public IActionResult Index()
        {
            return View();
        }
    }
}
