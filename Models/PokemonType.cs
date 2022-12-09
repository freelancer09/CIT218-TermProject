using System.Collections;
using System.ComponentModel.DataAnnotations;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

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

        public ICollection<TypeWeakness> TypeWeakness { get; set; }
        public ICollection<TypeWeakness> Weaknesses { get; set; }
    }
}
