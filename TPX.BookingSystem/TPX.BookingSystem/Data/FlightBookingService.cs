﻿using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TPX.BookingSystem.Models;

namespace TPX.BookingSystem.Data
{
    public class FlightBookingService
    {
        private readonly IServiceScope _serviceScope;
        private readonly ApplicationDbContext _context;

        public FlightBookingService(IServiceProvider serviceProvider)
        {
            _serviceScope = serviceProvider.GetService<IServiceScopeFactory>().CreateScope();
            _context = _serviceScope.ServiceProvider.GetService<ApplicationDbContext>();
        }

        public Task<List<Flight>> GetFlightList()
        {
            var list = new List<Flight>
            {
                new Flight() { Name = "Station", Value = "Value"},
                new Flight() { Name = "Station1", Value = "Value1"},
                new Flight() { Name = "Station2", Value = "Value2"},
                new Flight() { Name = "Station3", Value = "Value3"},
                new Flight() { Name = "Station4", Value = "Value4"},
                new Flight() { Name = "Station5", Value = "Value5"}
            };

            return Task.FromResult(list);
        }


        public Task<List<FlightBooking>> GetFlightBookings()
        {
            return Task.FromResult(_context.FlightBookings.ToList());
        }


        public void AddFlightBooking(FlightBooking FlightBooking)
        {
            _context.Add(FlightBooking);
            _context.SaveChangesAsync();
        }
    }
}