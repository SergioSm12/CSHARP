using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using ustatickets.Data.Enum;
using ustaTickets.Data.Base;

namespace ustatickets.Models
{
    public class Movie: IEntityBase
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public double Price { get; set; }
        public string ImageUrl { get; set; }
        public DateTime StartTimme { get; set; }
        public DateTime EndTime { get; set; }
        public MovieCategory MovieCategory { get; set; }

        //relationships

        public List<Actor_Movie> Actor_Movies { get; set; }

        public int CinemaId { get; set; }
        [ForeignKey("CinemaId")]
        public Cinema Cinema { get; set; }


        public int DirectorId { get; set; }
        [ForeignKey("DirectorId")]
        public Director Director { get; set; }
        
    }
}
