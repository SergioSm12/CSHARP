using System.ComponentModel.DataAnnotations;

namespace ustatickets.Models
{
    public class Actor
    {
        //Actor id 
        [Key]
        public int Id { get; set; }
        public string ProfilePictureURL { get; set; }
        public string FullName { get; set; }
        public string Bio { get; set; }

        //RelationShip
        public List<Actor_Movie> Actor_Movies { get; set; }

    }
}
