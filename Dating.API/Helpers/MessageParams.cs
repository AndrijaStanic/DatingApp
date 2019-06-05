namespace Dating.API.Helpers
{
    public class MessageParams
    {
        private const int MaxPageSize = 50; // stavlja max pageSize da user nemoze unit 10000000
        public int PageNumber { get; set; } = 1; // uvik vraca prvu stranicu 
        private int pageSize = 10;
        public int PageSize
        {
            get { return pageSize ;}
            set { pageSize = (value > MaxPageSize) ? MaxPageSize : value ;} 
            // stavlja je na maxPageSize ako je user odabra broj vise od maxPageSize ili na odabrani value
        }
        
        public int UserId { get; set; }
        public string MessageContainer { get; set; } = "Unread";
    }
}