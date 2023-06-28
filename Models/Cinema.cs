namespace eTickets.Models
{
    public class Cinema
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string? Description { get; set; }
        public string? Logo { get; set; }

        //relations
        public List<Movie> movies { get; set; }

    }
}
