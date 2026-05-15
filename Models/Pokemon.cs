
using System.ComponentModel.DataAnnotations;

namespace POKEMONS.Models
{
    public class Pokemon
    {
        public int Id {get; set;}

        [Required]
        public int NumeroPokedex { get; set; }
        [Required]
        public string Nome { get; set; }
        [Required]
        public string Descricao { get; set; }
        [Required]
        public int Geracao { get; set; }
        
        public decimal Ataque { get; set; }
        
        public decimal Defesa { get; set; }

    }
}

// git add .
// git commit
// git push