using System;
using System.ComponentModel.DataAnnotations;

namespace TPX.BookingSystem.Models
{
    public class Profile
    {
        public int Id { get; set; }
        [Required]
        [DataType(DataType.EmailAddress)]
        [EmailAddress]
        public string EmailAddress { get; set; }
        [Required]
        [DataType(DataType.Password)]
        public string Password { get; set; }
        [Required]
        [DataType(DataType.DateTime)]
        public DateTime DateTime { get; set; }

        public Profile()
        {
            DateTime = DateTime.Now.AddDays(1);
        }
    }
}