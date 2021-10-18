using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;

namespace CampProj.Controllers
{
    [ApiController]
    [Route("booking")]
    public class TableBookingController : Controller
    {
        List<TablePlace> placesList = new List<TablePlace>();

        TableBookingController() {
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
        }

        [HttpGet("get")]
        public IEnumerable<TablePlace> Get()
        {
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
            foreach (var i in list)
            {
                Console.WriteLine(i);
            }

            return list;
        }
    }
}
