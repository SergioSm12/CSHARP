using System.ComponentModel.DataAnnotations;
using ustatickets.Data.Enum;

namespace ustatickets.Models
{
    public class Movie
    {
        [Key]
        public int id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public double Price { get; set; }
        public string imageUrl { get; set; }
        public DateTime StartTimme { get; set; }
        public DateTime EndTime { get; set; }
        public MovieCategory MovieCategory { get; set; }


    }
}
