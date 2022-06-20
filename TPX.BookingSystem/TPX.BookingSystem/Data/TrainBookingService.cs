using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TPX.BookingSystem.Models;

namespace TPX.BookingSystem.Data
{
    public class TrainBookingService
    {
        private readonly IServiceScope _serviceScope;
        private readonly ApplicationDbContext _context;

        public TrainBookingService(IServiceProvider serviceProvider)
        {
            _serviceScope = serviceProvider.GetService<IServiceScopeFactory>().CreateScope();
            _context = _serviceScope.ServiceProvider.GetService<ApplicationDbContext>();
        }

        public Task<List<Station>> GetStationList()
        {
            var list = new List<Station>
            {
                new Station() { Name = "Station", Value = "Value"},
                new Station() { Name = "Station1", Value = "Value1"},
                new Station() { Name = "Station2", Value = "Value2"},
                new Station() { Name = "Station3", Value = "Value3"},
                new Station() { Name = "Station4", Value = "Value4"},
                new Station() { Name = "Station5", Value = "Value5"}
            };

            return Task.FromResult(list);
        }


        public Task<List<TrainBooking>> GetTrainBookings()
        {
            try
            {
                return Task.FromResult(_context.TrainBookings.ToList());
            }
            // Most specific:
            catch (ArgumentNullException)
            {
                return Task.FromResult(_context.TrainBookings.ToList());
            }
            // Least specific:
            catch (Exception)
            {
                return Task.FromResult(_context.TrainBookings.ToList());
            }
        }


        public void AddTrainBooking(TrainBooking TrainBooking)
        {
            _context.Add(TrainBooking);
            _context.SaveChangesAsync();
        }
    }
}