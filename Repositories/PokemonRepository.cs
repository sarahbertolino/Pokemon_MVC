
using POKEMONS.Contexts;
using POKEMONS.Models;
using Microsoft.EntityFrameworkCore.Query.SqlExpressions;

namespace POKEMONS.Repositories
{
    public class PokemonRepository
    {
        private readonly PokemonsContext _context;

        public PokemonRepository(PokemonsContext context)
        {
            _context = context;
        }

        public List<Pokemon> ObterPokemons()
        {
            return _context.Pokemon.ToList();
        }
        
    }
}