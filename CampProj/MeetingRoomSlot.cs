using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CampProj
{
    public class MeetingRoomSlot
    {
        public MeetingRoomSlot()
            {
        
             }
        public MeetingRoomSlot(string start, string end, bool status, int id)
        {
            Start = start;
            End = end;
            Status = status ;
            Id = id;
        }

        public bool Status { get; set; }

        public string Start { get; }

        public string End { get; }

        public int Id { get; }
       
    }
}
