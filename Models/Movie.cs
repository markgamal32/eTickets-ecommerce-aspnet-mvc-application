using eTickets.Data.Enums;
using System.ComponentModel.DataAnnotations.Schema;

namespace eTickets.Models
{
    public class Movie
    {
        public int Id { get; set; }

        public string Name { get; set; }
        public string? Description { get; set; }
        public double Price { get; set; }
        public string? ImageURL { get; set; }
        public DateTime? StartDate { get; set; }
        public DateTime? EndDate { get; set; }
        public MovieCategory? MovieCategory { get; set; }

        [ForeignKey("cinemaId")]
        public int cinemaId { get; set; }

        [ForeignKey("producerId")]
        public int producerId { get; set; }
        //relations
        public List<Actor_Movie> actors_Movies { get; set; }
        public Cinema? cinema { get; set; }
        public Producer? producer  { get; set; }
    }
}
