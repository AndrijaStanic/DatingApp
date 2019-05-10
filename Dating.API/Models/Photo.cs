using System;

namespace Dating.API.Models
{
    public class Photo
    {
        public int Id { get; set; } //id u memoriji
        public string Url { get; set; }
        public string Description { get; set; }
        public DateTime DateAdded { get; set; }
        public bool IsMain { get; set; }
        public string PublicId { get; set; } //id u url-u
        public User User { get; set; } //info o useru
        public int UserId { get; set; } //Photo.UserId = User.Id
    }
}