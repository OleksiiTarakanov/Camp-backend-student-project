using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace CampProj.Controllers
{
    [ApiController]
    [Route("booking")]
    public class TableBookingController : Controller
    {
        List<TablePlace> placesList = new List<TablePlace>();
        private readonly AppDbContext _context;

        public TableBookingController(AppDbContext context) {
            for (int i = 1; i <= 30; i++)
            {
                TablePlace place = new TablePlace(false, false, false, null);
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

            _context = context;
        }

        [HttpGet]
        public async Task<List<TablePlace>> Get()
        {
            var result = await _context.TablePlaces.ToListAsync();
            return result;
            //placesList[6].Booked = true;
            //placesList[6].BookerName = "Tim";

            //return placesList;
        }

        [HttpPost]
        public async Task<IActionResult> Post()
        {
            TablePlace place = new TablePlace(false, false, true, "Test");
            _context.TablePlaces.Add(place);
            await _context.SaveChangesAsync();
            return NoContent();
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
