using System;

namespace Dating.API.Dtos
{
    public class MessageToReturnDto
    {
        public int Id { get; set; }
        public int SenderId { get; set; }
        public string SenderKnownAs { get; set; }
        public string SenderPhotoUrl { get; set; }
        public int RecipientId { get; set; }
        public string RecipientKnownAs { get; set; }
        public string RecipientPhotoUrl { get; set; }
        public string content { get; set; }
        public bool isRead { get; set; }
        public DateTime? DateRead { get; set; }
        public DateTime MassageSent { get; set; }
    }
}