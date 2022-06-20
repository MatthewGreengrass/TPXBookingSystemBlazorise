using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace TPX.BookingSystem.Models
{
    public class Conversations
    {
        public Conversations()
        {
            DateTime = DateTime.Now;
        }

        [Key]
        public int ConversationID { get; set; }

        //public CentralBooking CentralBooking { get; set; }

        //[ForeignKey("FK_FlightBooking")]
        //public int FlightBookingID { get; set; }

        //[ForeignKey("FK_HotelBooking")]
        //public int HotelBookingID { get; set; }

        //[ForeignKey("FK_TrainBooking")]
        //public int TrainBookingID { get; set; }

        [Required]
        [DataType(DataType.Text)]
        public string RequestType { get; set; }

        [Required]
        [DataType(DataType.Text)]
        public string BookingLink { get; set; }

        [Required]
        [DataType(DataType.Text)]
        public string TextEntry { get; set; }

        [Required]
        [DataType(DataType.DateTime)]
        public DateTime DateTime { get; set; }
    }
}