
using POKEMONS.Models;
using POKEMONS.Repositories;
using Microsoft.AspNetCore.Mvc;

namespace POKEMONS.Controllers
{
    [Route("[controller]")]
    public class PokemonController : Controller
    {
        private readonly PokemonRepository _repository;

        public PokemonController(PokemonRepository repository)
        {
            _repository = repository;
        }

        public IActionResult Index()
        {
            List<Pokemon> pokemons = _repository.ObterPokemons();
            return View(pokemons);
        }

    }
}