namespace abdullah_portfolio.Entities.interfaces
{
    public interface IUser
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public string PhoneNumber { get; set; }
        public string LinkedinAccount { get; set; }
        public string WebsiteUrl { get; set; }

    }
}
