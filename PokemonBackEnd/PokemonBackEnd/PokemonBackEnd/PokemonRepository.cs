namespace PokemonBackEnd
{
    public class PokemonRepository
    {
        private static List<Pokemon> _pokemon = new List<Pokemon>();

        public static void Initialize()
        {
            _pokemon.Add(new Pokemon
            {
                Name = "Pikachu",
                Type = "Electric",
                Height = 0.4f,
                Weight = 6.0f
            });
            _pokemon.Add(new Pokemon
            {
                Name = "Bulbasaur",
                Type = "Grass",
                Height = 0.4f,
                Weight = 6.0f
            });
            _pokemon.Add(new Pokemon
            {
                Name = "Charmander",
                Type = "Fire",
                Height = 0.6f,
                Weight = 8.5f
            });
            _pokemon.Add(new Pokemon
            {
                Name = "Squirtle",
                Type = "Water",
                Height = 0.5f,
                Weight = 9.0f
            });
            _pokemon.Add(new Pokemon
            {
                Name = "Eevee",
                Type = "Normal",
                Height = 0.3f,
                Weight = 6.5f
            });
            _pokemon.Add(new Pokemon
            {
                Name = "Jigglypuff",
                Type = "Fairy",
                Height = 0.5f,
                Weight = 5.5f
            });
            _pokemon.Add(new Pokemon
            {
                Name = "Meowth",
                Type = "Normal",
                Height = 0.4f,
                Weight = 4.2f
            });
            _pokemon.Add(new Pokemon
            {
                Name = "Psyduck",
                Type = "Water",
                Height = 0.8f,
                Weight = 19.6f
            });
            _pokemon.Add(new Pokemon
            {
                Name = "Machop",
                Type = "Fighting",
                Height = 0.8f,
                Weight = 19.5f
            });
            _pokemon.Add(new Pokemon
            {
                Name = "Magnemite",
                Type = "Electric",
                Height = 0.3f,
                Weight = 6.0f
            });
            _pokemon.Add(new Pokemon
            {
                Name = "Gastly",
                Type = "Ghost",
                Height = 1.3f,
                Weight = 0.1f
            });
            _pokemon.Add(new Pokemon
            {
                Name = "Onix",
                Type = "Rock",
                Height = 8.8f,
                Weight = 210.0f
            });
            _pokemon.Add(new Pokemon
            {
                Name = "Zubat",
                Type = "Poison",
                Height = 0.8f,
                Weight = 7.5f
            });
            _pokemon.Add(new Pokemon
            {
                Name = "Geodude",
                Type = "Rock",
                Height = 0.4f,
                Weight = 20.0f
            });
            _pokemon.Add(new Pokemon
            {
                Name = "Rattata",
                Type = "Normal",
                Height = 0.3f,
                Weight = 3.5f
            });
            _pokemon.Add(new Pokemon
            {
                Name = "Poliwag",
                Type = "Water",
                Height = 0.6f,
                Weight = 12.4f
            });
            _pokemon.Add(new Pokemon
            {
                Name = "Diglett",
                Type = "Ground",
                Height = 0.2f,
                Weight = 0.8f
            });
            _pokemon.Add(new Pokemon
            {
                Name = "Growlithe",
                Type = "Fire",
                Height = 0.6f,
                Weight = 19.0f
            });
            _pokemon.Add(new Pokemon
            {
                Name = "Vulpix",
                Type = "Fire",
                Height = 0.6f,
                Weight = 9.9f
            });
            _pokemon.Add(new Pokemon
            {
                Name = "Poliwhirl",
                Type = "Water",
                Height = 1.0f,
                Weight = 20.0f
            });
            _pokemon.Add(new Pokemon
            {
                Name = "Alakazam",
                Type = "Psychic",
                Height = 1.5f,
                Weight = 48.0f
            });
            _pokemon.Add(new Pokemon
            {
                Name = "Nidoking",
                Type = "Poison",
                Height = 1.4f,
                Weight = 62.0f
            });
            _pokemon.Add(new Pokemon
            {
                Name = "Nidoqueen",
                Type = "Poison",
                Height = 1.3f,
                Weight = 60.0f
            });
            _pokemon.Add(new Pokemon
            {
                Name = "Kingler",
                Type = "Water",
                Height = 1.3f,
                Weight = 60.0f
            });
            _pokemon.Add(new Pokemon
            {
                Name = "Exeggutor",
                Type = "Grass",
                Height = 2.0f,
                Weight = 120.0f
            });
            _pokemon.Add(new Pokemon
            {
                Name = "Seaking",
                Type = "Water",
                Height = 1.3f,
                Weight = 39.0f
            });
            _pokemon.Add(new Pokemon
            {
                Name = "Butterfree",
                Type = "Bug",
                Height = 1.1f,
                Weight = 32.0f
            });
            _pokemon.Add(new Pokemon
            {
                Name = "Beedrill",
                Type = "Bug",
                Height = 1.0f,
                Weight = 29.5f
            });
            _pokemon.Add(new Pokemon
            {
                Name = "Fearow",
                Type = "Normal",
                Height = 1.2f,
                Weight = 38.0f
            });
            _pokemon.Add(new Pokemon
            {
                Name = "Pidgeot",
                Type = "Normal",
                Height = 1.5f,
                Weight = 39.5f
            });
            _pokemon.Add(new Pokemon
            {
                Name = "Caterpie",
                Type = "Bug",
                Height = 0.3f,
                Weight = 2.9f
            });
            _pokemon.Add(new Pokemon
            {
                Name = "Rhydon",
                Type = "Ground",
                Height = 1.0f,
                Weight = 41.0f
            });
            _pokemon.Add(new Pokemon
            {
                Name = "Mankey",
                Type = "Fighting",
                Height = 0.5f,
                Weight = 28.0f
            });
            _pokemon.Add(new Pokemon
            {
                Name = "Lickitung",
                Type = "Normal",
                Height = 1.2f,
                Weight = 65.5f
            });
            _pokemon.Add(new Pokemon
            {
                Name = "Machoke",
                Type = "Fighting",
                Height = 1.5f,
                Weight = 70.5f
            });
            _pokemon.Add(new Pokemon
            {
                Name = "Machamp",
                Type = "Fighting",
                Height = 1.6f,
                Weight = 130.0f
            });
            _pokemon.Add(new Pokemon
            {
                Name = "Togepi",
                Type = "Fairy",
                Height = 0.3f,
                Weight = 1.5f
            });
            _pokemon.Add(new Pokemon
            {
                Name = "Totodile",
                Type = "Water",
                Height = 0.6f,
                Weight = 9.5f
            });
            _pokemon.Add(new Pokemon
            {
                Name = "Chikorita",
                Type = "Grass",
                Height = 0.9f,
                Weight = 6.4f
            });
            _pokemon.Add(new Pokemon
            {
                Name = "Bayleef",
                Type = "Grass",
                Height = 1.2f,
                Weight = 15.8f
            });
            _pokemon.Add(new Pokemon
            {
                Name = "Cyndaquil",
                Type = "Fire",
                Height = 0.6f,
                Weight = 7.9f
            });
            _pokemon.Add(new Pokemon
            {
                Name = "Quilava",
                Type = "Fire",
                Height = 0.8f,
                Weight = 19.0f
            });
            _pokemon.Add(new Pokemon
            {
                Name = "Totodile",
                Type = "Water",
                Height = 0.6f,
                Weight = 9.5f
            });
            _pokemon.Add(new Pokemon
            {
                Name = "Croconaw",
                Type = "Water",
                Height = 1.1f,
                Weight = 25.0f
            });
        }

        public static List<Pokemon> GetPokemonList()
        {
            if (_pokemon.Count == 0)
            {
                Initialize();
            }
            return _pokemon;
        }

        public static void AddPokemon(Pokemon pokemon)
        {
            _pokemon.Add(pokemon);
        }
    }
}
