
using POKEMONS.Models;
using POKEMONS.Repositories;
using Microsoft.AspNetCore.Mvc;

namespace POKEMONS.Controllers
{
    //[Route("[controller]")]
    public class PokemonController : Controller
    {
        private readonly PokemonRepository _repository;

        public PokemonController(PokemonRepository repository)
        {
            _repository = repository;
        }
        
        [HttpGet]
        public IActionResult Index()
        {
            List<Pokemon> pokemons = _repository.ObterPokemons();
            return View(pokemons);
        }

        [HttpGet]
        public IActionResult Cadastro()
        {
            ViewData["Title"] = "Cadastro";
            return View();
        }
        
        [HttpPost]
        public IActionResult Cadastro(Pokemon p)
        {
            string ataqueString = Request.Form["ataque"].ToString().Replace(".", ",");
            string defesaString = Request.Form["defesa"].ToString().Replace(".", ",");

            if(decimal.TryParse(ataqueString, out var ataqueConvertido))
            {
                p.Ataque = ataqueConvertido;    
            }

            if(decimal.TryParse(defesaString, out var defesaConvertida))
            {
                p.Defesa = defesaConvertida;    
            }

            
            _repository.Adicionar(p);
            
            return RedirectToAction("Index");

        }
        
        [HttpPost]
        public IActionResult Deletar(int id)
        {
            _repository.Remover(id);
            return RedirectToAction("Index");
        }

    }   

    }   
    
