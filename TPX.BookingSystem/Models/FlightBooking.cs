using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace TPX.BookingSystem.Models
{
    public class FlightBooking
    {
        public FlightBooking()
        {
            DepartureDateTime = DateTime.Now.AddDays(1);
            ReturnDateTime = DateTime.Now.AddDays(1);
        }

        [Key]
        public int FlightBookingID { get; set; }
        public CentralBooking CentralBooking { get; set; }

        [Required]
        [DataType(DataType.Text)]
        public string DepartureAirport { get; set; }

        [Required]
        [DataType(DataType.Text)]
        public string ArrivalAirport { get; set; }

        [Required]
        [DataType(DataType.DateTime)]
        public DateTime DepartureDateTime { get; set; }

        [Required]
        [DataType(DataType.DateTime)]
        public DateTime ReturnDateTime { get; set; }
    }

    internal enum DepartureAirport
    {
        London,
        Bristol,
        Manchester,
        Nottingham
    }

    internal enum ArrivalAirport
    {
        London,
        Bristol,
        Manchester,
        Nottingham
    }
}