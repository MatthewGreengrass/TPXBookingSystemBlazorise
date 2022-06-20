using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TPX.BookingSystem.Models;

namespace TPX.BookingSystem.Data
{
    public class HotelBookingService
    {
        private readonly IServiceScope _serviceScope;
        private readonly ApplicationDbContext _context;

        public HotelBookingService(IServiceProvider serviceProvider)
        {
            _serviceScope = serviceProvider.GetService<IServiceScopeFactory>().CreateScope();
            _context = _serviceScope.ServiceProvider.GetService<ApplicationDbContext>();
        }

        public Task<List<Hotel>> GetHotelList()
        {
            var list = new List<Hotel>
            {
                new Hotel() { Name = "Station", Value = "Value"},
                new Hotel() { Name = "Station1", Value = "Value1"},
                new Hotel() { Name = "Station2", Value = "Value2"},
                new Hotel() { Name = "Station3", Value = "Value3"},
                new Hotel() { Name = "Station4", Value = "Value4"},
                new Hotel() { Name = "Station5", Value = "Value5"}
            };

            return Task.FromResult(list);
        }


        public Task<List<HotelBooking>> GetHotelBookings()
        {
            return Task.FromResult(_context.HotelBookings.ToList());
        }


        public void AddHotelBooking(HotelBooking HotelBooking)
        {
            _context.Add(HotelBooking);
            _context.SaveChangesAsync();
        }
    }
}