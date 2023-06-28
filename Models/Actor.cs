using System.ComponentModel.DataAnnotations;

namespace eTickets.Models
{
    public class Actor
    {
        //[Key]
        public int id { get; set; }
        public string? ProfilePicURL { get; set; }
        public string FullName { get; set;}
        public string? Bio { get; set;}

        //relations
        public List<Actor_Movie> actors_Movies { get; set;}

    }
}
