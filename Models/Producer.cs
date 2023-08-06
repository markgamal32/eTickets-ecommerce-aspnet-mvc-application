namespace eTickets.Models
{
    public class Producer
    {
        public int id { get; set; }
        public string? ProfilePicURL { get; set; }
        public string FullName { get; set; }
        public string? Bio { get; set; }

        //relations
        public List<Movie> movies { get; set; }

    }
}
