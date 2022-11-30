using System.ComponentModel.DataAnnotations;
using AgroSaleDapper.Validaciones;
using Microsoft.AspNetCore.Mvc;
namespace AgroSaleDapper.Models
{
    public class UserData
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "The {0} field is required")]
        [FirstCapitalLetter]
        public string Name { get; set; }
        [Required(ErrorMessage = "The {0} field is required")]
        [Display(Name ="Last Name")]
        [FirstCapitalLetter]
        public string LastName { get; set; }
        [Required(ErrorMessage = "The {0} field is required")]
        public string Addres { get; set; }
        [Required(ErrorMessage = "The {0} field is required")]
        [Display(Name ="Phone")]
        public string phone { get; set; }
        public int UserId { get; set; }

    }
}
