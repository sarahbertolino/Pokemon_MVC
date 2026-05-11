using POKEMONS.Models;
using Microsoft.EntityFrameworkCore;

namespace POKEMONS.Contexts
{
    public class PokemonsContext : DbContext
    {
        public PokemonsContext(DbContextOptions<PokemonsContext> options) : base(options){}

        public DbSet<Pokemon> Pokemon{ get; set;}
        
    }
}