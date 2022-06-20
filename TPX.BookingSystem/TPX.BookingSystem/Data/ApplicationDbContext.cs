using Microsoft.EntityFrameworkCore;
using TPX.BookingSystem.Models;
using System;

namespace TPX.BookingSystem.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        public DbSet<TrainBooking> TrainBookings { get; set; }
        
        public DbSet<HotelBooking> HotelBookings { get; set; }

        public DbSet<FlightBooking> FlightBookings { get; set; }
        
        public DbSet<CentralBooking> CentralBookings { get; set; }

        public DbSet<Conversations> Conversations { get; set; }
    }
}