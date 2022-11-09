using System.ComponentModel.DataAnnotations;

namespace TermProject.Models
{
    public class PokemonType
    {
        public int PokemonTypeId { get; set; }

        [Display(Name = "Type")]
        [Required(ErrorMessage = "Please enter a name.")]
        public string Name { get; set; }
    }
}
