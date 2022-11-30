using System.ComponentModel.DataAnnotations;
using ustaTickets.Data.Base;

namespace ustatickets.Models
{
    public class Cinema :IEntityBase
    {
        [Key]
        public int Id { get; set; }

        [Display(Name ="Logo")]
        [Required(ErrorMessage = "Logo is required")]
        public string Logo { get; set; }
        [Display(Name="Name Cinema")]
        [Required(ErrorMessage = "Name is required")]
        public string Name { get; set; }

        [Display(Name ="Description of Cinema")]
        [Required(ErrorMessage = "Description is required")]
        public string Description { get; set; }

        //RealtionShips
        public List<Movie> Movies { get; set; }

    }
}
