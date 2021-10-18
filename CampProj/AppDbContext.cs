using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;


namespace CampProj
{
    public class AppDbContext: DbContext
    {
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<TablePlace>().HasKey(a => a.Id);
        }

       public DbSet<TablePlace> TablePlaces { get; set; }

       //public DbSet<MeetingRoomSlot> MeetingRoomSlots { get; set; }

       public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {

        }
    }
}
