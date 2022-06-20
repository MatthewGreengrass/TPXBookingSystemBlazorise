using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace TPX.BookingSystem.Models
{
    public class HotelBooking
    {
        public HotelBooking()
        {
            DepartureDateTime = DateTime.Now.AddDays(1);
            ReturnDateTime = DateTime.Now.AddDays(1);
        }

        [Key]
        public int HotelBookingID { get; set; }
        public CentralBooking CentralBooking { get; set; }

        [Required]
        [DataType(DataType.Text)]
        public string HotelLocation { get; set; }

        [Required]
        [DataType(DataType.DateTime)]
        public DateTime DepartureDateTime { get; set; }

        [Required]
        [DataType(DataType.DateTime)]
        public DateTime ReturnDateTime { get; set; }
    }

    internal enum HotelLocation
    {
        London,
        Bristol,
        Manchester,
        Nottingham
    }
}