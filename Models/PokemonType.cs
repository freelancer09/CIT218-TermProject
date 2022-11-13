using System.ComponentModel.DataAnnotations;

namespace TermProject.Models
{
    public class PokemonType
    {
        public int PokemonTypeId { get; set; }

        [Display(Name = "Type")]
        [Required(ErrorMessage = "Please enter a name.")]
        [StringLength(20, ErrorMessage = "Name length is too long.")]
        [RegularExpression("^[a-zA-Z0-9]*$", ErrorMessage = "Only letters and numbers are allowed.")]
        public string Name { get; set; }
    }
}
