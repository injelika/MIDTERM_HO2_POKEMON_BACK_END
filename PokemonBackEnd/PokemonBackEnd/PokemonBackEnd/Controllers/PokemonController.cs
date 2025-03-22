using Microsoft.AspNetCore.Mvc;
using System.Linq;

namespace PokemonBackEnd.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PokemonController : ControllerBase
    {
        public PokemonController()
        {
            PokemonRepository.Initialize();
        }

        // Get Pokémon by type
        [HttpGet]
        [Route("get-by-type")]
        public IActionResult GetByType(string type)
        {
            var result = PokemonRepository.GetPokemonList()
                .Where(x => x.Type.ToLower() == type.ToLower())
                .ToList();

            return Ok(result);
        }

        // Search Pokémon by name
        [HttpGet]
        [Route("search")]
        public IActionResult SearchByName(string name)
        {
            var result = PokemonRepository.GetPokemonList()
                .Where(x => x.Name.ToLower() == name.ToLower())
                .ToList();

            return result.Any() ? Ok(result) : NoContent();
        }

        // Update an existing Pokémon by name
        [HttpPut]
        [Route("update/{name}")]
        public IActionResult Update(string name, [FromBody] Pokemon updatedPokemon)
        {
            var existingPokemon = PokemonRepository.GetPokemonList()
                .FirstOrDefault(x => x.Name.ToLower() == name.ToLower());

            if (existingPokemon == null)
                return NotFound("Pokemon not found to update.");

            existingPokemon.Name = updatedPokemon.Name;
            existingPokemon.Type = updatedPokemon.Type;
            existingPokemon.Height = updatedPokemon.Height;
            existingPokemon.Weight = updatedPokemon.Weight;

            return Ok(existingPokemon);
        }

        // Delete a Pokémon by name
        [HttpDelete]
        [Route("delete/{name}")]
        public IActionResult Delete(string name)
        {
            var pokemonToDelete = PokemonRepository.GetPokemonList()
                .FirstOrDefault(x => x.Name.ToLower() == name.ToLower());

            if (pokemonToDelete == null)
                return NotFound("Pokemon not found to delete.");

            PokemonRepository.GetPokemonList().Remove(pokemonToDelete);
            return Ok($"Pokémon {name} deleted.");
        }
    }
}
