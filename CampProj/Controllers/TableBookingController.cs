using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Http;
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
        [HttpGet("get")]
        public IEnumerable<TablePlace> Get()
        {
            List<TablePlace> placesList = new List<TablePlace> { };

            for (int i = 1; i <= 30; i++)
            {
                TablePlace place = new TablePlace(false, false, false, null, i);
                placesList.Add(place);

               
                if (place.Halfday)
                {
                    place.Fullday = false;
                }
                else if (place.Fullday)
                {
                    place.Halfday = false;
                }

                if (!place.Booked)
                {
                    place.BookerName = null;
                }
            }

            placesList[6].Booked = true;
            placesList[6].BookerName = "Tim";

            return placesList;
        }

        [HttpPost]
        public IEnumerable<TablePlace> Post(List<TablePlace> list)
        {
            return list;
        }

        [HttpDelete]
        public List<TablePlace> Delete(List<TablePlace> list)
        {
            foreach(var i in list)
            {
                Console.WriteLine(i);
            }

            return list;
        }
    }
}
