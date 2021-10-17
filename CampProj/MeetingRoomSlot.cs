using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CampProj
{
    public class MeetingRoomSlot
    {
        public MeetingRoomSlot(string start, string end, bool status)
        {
            Start = start;
            End = end;
            Status = status ;
        }

        public bool Status { get; set; }

        public string Start { get; }

        public string End { get; }
       
    }
}
