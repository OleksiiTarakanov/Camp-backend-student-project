using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CampProj.Controllers
{
    [ApiController]
    [Route("meeting-room")]
    public class MeetingRoomController : Controller
    {
        [HttpGet]
        [HttpPost]
        public IEnumerable<double> Get()
        {
            List<double> meetingRoomTimeSlots = new List<double> { };

            for (double i = 9; i <= 18; i+=0.5)
            {
               meetingRoomTimeSlots.Add(i);
            }

            return meetingRoomTimeSlots;
        }
    }
}
