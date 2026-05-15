
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

        public void Adicionar(Pokemon p)
        {
            _context.Pokemon.Add(p);
            _context.SaveChanges();
        }
        public void Remover(int id)
        {
            var pokemon = _context.Pokemon.FirstOrDefault(p => p.Id == id);

            if (pokemon == null)
            {
                return;
            }
                           
                _context.Pokemon.Remove(pokemon);
                _context.SaveChanges();
        }
    }
}
    