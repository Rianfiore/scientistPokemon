using System.Collections.Generic;
using ScientistPokemon.Object.Pokemons;
using ScientistPokemon.Object.EncounterMethods;
using ScientistPokemon.Object.EncounterConditions;

namespace ScientistPokemon.Object.Kanto.PalletTown.LocationAreas
{
    public class PalletTownArea
    {
        public static int id = 1;
        public static string name = "Área da Cidade de Pallet";

        public static string city = PalletTown.name;
        
        public static List<EncounterMethodObject> EncounterMethods = new List<EncounterMethodObject>();

        public static List<EncounterConditionObject> EncounterConditions = new List<EncounterConditionObject>();

        public static List<PokemonObject> PokemonEncounters = new List<PokemonObject>();

        public static void createPokemonEncounters()
        {
            PokemonEncounters.Add(new PokemonObject("pidgey", 20));
            PokemonEncounters.Add(new PokemonObject("pidgeotto", 20));
            PokemonEncounters.Add(new PokemonObject("pidgeot", 20));
            PokemonEncounters.Add(new PokemonObject("hoothoot", 20));
            PokemonEncounters.Add(new PokemonObject("ledyba", 20));
            PokemonEncounters.Add(new PokemonObject("bulbasaur", 20));
            PokemonEncounters.Add(new PokemonObject("charmander", 20));
            PokemonEncounters.Add(new PokemonObject("pikachu", 20));
            PokemonEncounters.Add(new PokemonObject("rattata", 20));
            PokemonEncounters.Add(new PokemonObject("raticate", 20));
            PokemonEncounters.Add(new PokemonObject("sentret", 20));
            PokemonEncounters.Add(new PokemonObject("furret", 20));
            PokemonEncounters.Add(new PokemonObject("poochyena", 20));
            PokemonEncounters.Add(new PokemonObject("plusle", 20));
            PokemonEncounters.Add(new PokemonObject("minum", 20));
            PokemonEncounters.Add(new PokemonObject("shinx", 20));
            PokemonEncounters.Add(new PokemonObject("wurmple", 20));
            PokemonEncounters.Add(new PokemonObject("spinarak", 20));
            PokemonEncounters.Add(new PokemonObject("pineco", 20));
            PokemonEncounters.Add(new PokemonObject("poochyne", 20));
            PokemonEncounters.Add(new PokemonObject("krabby", 20));
            PokemonEncounters.Add(new PokemonObject("kingler", 20));
            PokemonEncounters.Add(new PokemonObject("psyduck", 20));
            PokemonEncounters.Add(new PokemonObject("poliwag", 20));
            PokemonEncounters.Add(new PokemonObject("magikarp", 20));
            PokemonEncounters.Add(new PokemonObject("goldeen", 20));
            PokemonEncounters.Add(new PokemonObject("tentacool", 20));
            PokemonEncounters.Add(new PokemonObject("tentacruel", 20));
            PokemonEncounters.Add(new PokemonObject("staryu", 20));
            PokemonEncounters.Add(new PokemonObject("shellder", 20));
            PokemonEncounters.Add(new PokemonObject("chinchou", 20));
            PokemonEncounters.Add(new PokemonObject("lantum", 20));
            PokemonEncounters.Add(new PokemonObject("gyarados", 20));
            PokemonEncounters.Add(new PokemonObject("horsea", 20));
            PokemonEncounters.Add(new PokemonObject("seadra", 20));
        }

        public static void createEncounterMethods()
        {
            EncounterMethods.Add(new EncounterMethodObject("Avistamento Aéreo", new string[] {"flying"}, new string[] {"bug"}));
            EncounterMethods.Add(new EncounterMethodObject("Encontro terrestre", new string[] {"normal", "fighting", "ground","dragon","fairy"}, new string[] {"flying", "poison", "rock", "steel", "fire", "electric", "psychic"}));
            EncounterMethods.Add(new EncounterMethodObject("Encontro nas árvores", new string[] {"bug"}, new string[] {"grass"}));
            EncounterMethods.Add(new EncounterMethodObject("Avistamento na floresta",new string[] {"grass, bug"}, new string[] {"normal", "fighting", "flying", "ground", "rock", "steel", "electric", "dragon", "fairy"}));
            EncounterMethods.Add(new EncounterMethodObject("Pesca", new string[] {"water"}, new string[] {"ice"}));
            EncounterMethods.Add(new EncounterMethodObject("Mergulho", new string[] {"water"}, new string[] {"ice"}));
        }

        public static void createEncounterConditions()
        {
            EncounterConditions.Add(new EncounterConditionObject("swarm"));
            EncounterConditions.Add(new EncounterConditionObject("time"));
            EncounterConditions.Add(new EncounterConditionObject("season"));
        }
    }
}