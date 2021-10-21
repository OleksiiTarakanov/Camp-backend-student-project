using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CampProj
{
    public class TablePlace
    {

        public TablePlace(bool halfday, bool fullday, bool booked, string bookerName)
        {
            Halfday = halfday;
            Fullday = fullday;
            Booked = booked;
            BookerName = bookerName;
        }

        public bool Halfday { get; set; }

        public bool Fullday { get; set; }

        public bool Booked { get; set; }

        public string BookerName { get; set; }

        public int Id { get; set; }
    }
}
