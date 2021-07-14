using System.Collections.Generic;
using ScientistPokemon.Entities.Pokemon;

namespace ScientistPokemon.Object.Kanto.PalletTown.LocationAreas
{
    public class PalletTownArea
    {
        public static int id = 1;
        public static string name = "Área da Cidade de Pallet";

        public static string city = PalletTown.name;
        
        public static List<object> EncounterMethods = new List<object>();

        public static List<MainPokemon> PokemonEncounters = new List<MainPokemon>();

        public static void createPokemonEncounters()
        {
            string[] pokemons = new string[]{

            "pidgey", "pidgeotto", "pidgeot", "hoothoot", "ledyba", "bulbasaur", 
            "charmander", "pikachu", "rattata", "raticate", "sentret", "furret", 
            "poochyena", "plusle", "minum", "shinx", "wurmple", "spinarak",
            "pineco", "poochyne", "krabby", "kingler", "psyduck", "slowpoke",
            "poliwag", "magikarp", "goldeen", "tentacool", "tentacruel", "staryu",
            "shellder", "chinchou", "lantum", "gyarados", "horsea", "seadra"};

            for (int i = 0; i < MainPokemon.pokemon.Length;i++)
            {
                for (int j = 0; j < pokemons.Length;j++)
                {
                    if (pokemons[j] == (MainPokemon.pokemon[i].Name))
                    {
                        PokemonEncounters.Add(MainPokemon.pokemon[i]);
                        i++;
                    }
                }
            }
        }
    }
}