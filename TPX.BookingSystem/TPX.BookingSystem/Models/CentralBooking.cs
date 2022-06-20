using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace TPX.BookingSystem.Models
{
    public class CentralBooking
    {
        public int CentralBookingID { get; set; }

        public ICollection<FlightBooking> FlightBookings { get; set; }

        public ICollection<HotelBooking> HotelBookings { get; set; }

        public ICollection<TrainBooking> TrainBookings { get; set; }

    }
}