using System;
using System.ComponentModel.DataAnnotations;
using System.Security.Policy;

namespace TermProject.Models
{
    public class Pokemon
    {
        // EF will instruct the database to automatically generate this value
        public int PokemonId { get; set; }

        [Required(ErrorMessage = "Please enter a name.")]
        public string Name { get; set; }

        [Display(Name = "#")]
        [Required(ErrorMessage = "Please enter a PokeDex number.")]
        [Range(1, 9999, ErrorMessage = "PokeDex number must be between 1 and 9999.")]
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
        public int? SpAttack { get; set; }

        [Required(ErrorMessage = "Please enter a stat value.")]
        [Range(1, 255, ErrorMessage = "Stat value must be between 1 and 255.")]
        public int? SpDefense { get; set; }

        [Required(ErrorMessage = "Please enter a stat value.")]
        [Range(1, 255, ErrorMessage = "Stat value must be between 1 and 255.")]
        public int? Speed { get; set; }

        [Required(ErrorMessage = "Please enter a type.")]
        public string PokemonType1Id { get; set; }
        [Display(Name = "Type")]
        public PokemonType PokemonType1 { get; set; }

        public string PokemonType2Id { get; set; }
        [Display(Name = "Type")]
        public PokemonType PokemonType2 { get; set; }
    }
}
