using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CampProj.Controllers
{
    [ApiController]
    [Route("meeting-room")]
    public class MeetingRoomController : ControllerBase
    {
        [HttpGet("get")]
        public IEnumerable<MeetingRoomSlot> Get()
        {
            List<MeetingRoomSlot> meetingRoomTimeSlots = new List<MeetingRoomSlot> { };

            for (int i = 9; i <= 17; i++)
            {
                var date = new DateTime(0, 0, 0, i, 30, 00);
                MeetingRoomSlot firstSlot = new MeetingRoomSlot($"{i}:00", $"{i}:30", false);
                MeetingRoomSlot secondSlot = new MeetingRoomSlot($"{i}:30", $"{i+1}:00", false);

                meetingRoomTimeSlots.Add(firstSlot);
                meetingRoomTimeSlots.Add(secondSlot);
            }
           

            return meetingRoomTimeSlots;
        }

        [HttpPost]
        public IEnumerable<MeetingRoomSlot> Post(List<MeetingRoomSlot> list)
        {
            return list;
        }
    }
}
