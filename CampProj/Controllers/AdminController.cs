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
        public IEnumerable<string> Get()
        {
            List<string> admin = new List<string> {"admin"};
            return admin;
        }
    }
}
