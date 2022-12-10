using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Security.Policy;

namespace TermProject.Models
{
    public class Pokemon
    {
        // EF will instruct the database to automatically generate this value
        public int PokemonId { get; set; }

        [Required(ErrorMessage = "Please enter a name.")]
        [StringLength(20, ErrorMessage = "Name length is too long.")]
        [RegularExpression("^[a-zA-Z0-9\\s]*$", ErrorMessage = "Only letters and numbers are allowed.")]
        public string Name { get; set; }

        [Display(Name = "#")]
        [Required(ErrorMessage = "Please enter a PokeDex number.")]
        [Range(1, 9999, ErrorMessage = "PokeDex number must be between 1 and 9999.")]
        [Column("Pokedex Number")]
        public int? PokedexNumber { get; set; }

        [Required(ErrorMessage = "Please enter a stat value.")]
        [Range(1, 255, ErrorMessage = "Stat value must be between 1 and 255.")]
        public int? Hp { get; set; }

        [Required(ErrorMessage = "Please enter a stat value.")]
        [Range(1, 255, ErrorMessage = "Stat value must be between 1 and 255.")]
        public int? Attack { get; set; }

        [Required(ErrorMessage = "Please enter a stat value.")]
        [Range(1, 255, ErrorMessage = "Stat value must be between 1 and 255.")]
        public int? Defense { get; set; }

        [Required(ErrorMessage = "Please enter a stat value.")]
        [Range(1, 255, ErrorMessage = "Stat value must be between 1 and 255.")]
        [Display(Name = "Sp. Atk")]
        public int? SpAttack { get; set; }

        [Required(ErrorMessage = "Please enter a stat value.")]
        [Range(1, 255, ErrorMessage = "Stat value must be between 1 and 255.")]
        [Display(Name = "Sp. Def")]
        public int? SpDefense { get; set; }

        [Required(ErrorMessage = "Please enter a stat value.")]
        [Range(1, 255, ErrorMessage = "Stat value must be between 1 and 255.")]
        public int? Speed { get; set; }

        [Display(Name = "Type")]
        public int? PokemonType1Id { get; set; }
        [Display(Name = "Type")]
        public PokemonType PokemonType1 { get; set; }

        [Display(Name = "Type")]
        public int? PokemonType2Id { get; set; }
        [Display(Name = "Type")]
        public PokemonType PokemonType2 { get; set; }

        [DataType(DataType.DateTime)]
        [Display(Name = "Date Added")]
        public DateTime? DateAdded { get; set; } = DateTime.Now;
    }
}
