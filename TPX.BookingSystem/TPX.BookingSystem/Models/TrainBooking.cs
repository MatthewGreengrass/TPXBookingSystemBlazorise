using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace TPX.BookingSystem.Models
{
    public class TrainBooking
    {
        public TrainBooking()
        {
            DepartureDateTime = DateTime.Now.AddDays(1);
            ReturnDateTime = DateTime.Now.AddDays(1);
        }

        [Key]
        public int TrainBookingID { get; set; }
        public CentralBooking CentralBooking { get; set; }

        [Required]
        [DataType(DataType.Text)]
        public string DepartureStation { get; set; }

        [Required]
        [DataType(DataType.Text)]
        public string ArrivalStation { get; set; }

        [Required]
        [DataType(DataType.DateTime)]
        public DateTime DepartureDateTime { get; set; }

        [Required]
        [DataType(DataType.DateTime)]
        public DateTime ReturnDateTime { get; set; }

        [DataType(DataType.Text)]
        public bool ReturnDateTimeOpen { get; set; }
    }

    internal enum DepartureStation
    {
        London,
        Bristol,
        Manchester,
        Nottingham
    }

    internal enum ArrivalStation
    {
        London,
        Bristol,
        Manchester,
        Nottingham
    }
}