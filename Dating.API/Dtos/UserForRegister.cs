using System;
using System.ComponentModel.DataAnnotations;

namespace Dating.API.Dtos
{
    public class UserForRegister
    {
        [Required]
        public string Username { get; set; }
        [Required]
        [StringLength(14, MinimumLength = 4, ErrorMessage = "You must specify password between 4 and 14 charachters")]
        public string  Password { get; set; }
        [Required]
        public string Gender { get; set; }
        [Required]
        public string KnownAs { get; set; }
        [Required]
        public DateTime DateOfBirth { get; set; }
        [Required]
        public string Country { get; set; }
        [Required]
        public string City { get; set; }
        public DateTime Created { get; set; }
        public DateTime LastActive { get; set; }

        public UserForRegister()
        {
            Created = DateTime.Now;
            LastActive = DateTime.Now;

        }
    }
}