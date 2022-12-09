using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Xml.Linq;

namespace TermProject.Models
{
    public class TypeWeakness
    {
        public int TypeWeaknessId { get; set; }

        [Display(Name = "Type")]
        public int PokemonTypeId { get; set; }
        [Display(Name = "Type")]
        [Required(ErrorMessage = "Please select a type.")]
        public PokemonType PokemonType { get; set; }

        [Display(Name = "Weakness")]
        public int WeaknessId { get; set; }
        [Display(Name = "Weakness")]
        [Required(ErrorMessage = "Please select a type.")]
        public PokemonType Weakness { get; set; }
    }
}
