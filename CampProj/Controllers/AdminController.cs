using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Swashbuckle.AspNetCore;

namespace CampProj.Controllers
{
    [ApiController]
    [Route("admin")]
    public class AdminController : Controller
    {
        [HttpGet]
        [HttpPost]
        public IEnumerable<string> Get()
        {
            List<string> adminList = new List<string> {"admin"};
            return adminList;
        }
    }
}
