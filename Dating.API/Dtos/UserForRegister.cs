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
    }
}