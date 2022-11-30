using Microsoft.AspNetCore.Http.Features;
using System.ComponentModel.DataAnnotations;
using ustaTickets.Data.Base;

namespace ustatickets.Models
{
    public class Actor : IEntityBase
    {
        //Actor id 
        [Key]
        public int Id { get; set; }
        [Display(Name ="Profile picture URL")]
        [Required(ErrorMessage ="Profile picture is required")]
        public string ProfilePictureURL { get; set; }
        [Display(Name = "Full Name")]
        [Required(ErrorMessage ="Full name is required")]
        [StringLength(50,MinimumLength =3,ErrorMessage ="Full Name must be between 3 and 50 chars.")]
        public string FullName { get; set; }
        [Display(Name = "Biography")]
        [Required(ErrorMessage ="Biograpy is required")]
        public string Bio { get; set; }

        //RelationShip
        public List<Actor_Movie>? Actor_Movies { get; set; }

    }
}
