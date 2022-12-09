using System.Collections.Generic;

namespace TermProject.Models
{
    public class TypeWeaknessViewModel
    {
        public PokemonType PokemonType { get; set; }
       
        public IEnumerable<TypeWeakness> Weaknesses { get; set; }   
    }
}
