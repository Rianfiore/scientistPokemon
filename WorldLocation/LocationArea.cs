using System;
using System.Collections.Generic;
using Objects;
using ScientistPokemon.World;

namespace ScientistPokemon.WorldLocation
{
    public class LocationArea
    {
        public int id;
        public string name;
        
        public List<EncounterMethod> EncounterMethods = new List<EncounterMethod>();

        public List<EncounterCondition> EncounterConditions = new List<EncounterCondition>();

        public List<Pokemon> PokemonEncounters = new List<Pokemon>();

        void createPokemonEncounters()
        {
            PokemonEncounters.Add(new Pokemon("pidgey", 80));
            PokemonEncounters.Add(new Pokemon("pidgeotto",40));
            PokemonEncounters.Add(new Pokemon("pidgeot", 10));
            PokemonEncounters.Add(new Pokemon("hoothoot", 75));
            PokemonEncounters.Add(new Pokemon("ledyba", 80));
            PokemonEncounters.Add(new Pokemon("bulbasaur", 15));
            PokemonEncounters.Add(new Pokemon("charmander", 15));
            PokemonEncounters.Add(new Pokemon("pikachu", 15));
            PokemonEncounters.Add(new Pokemon("rattata", 80));
            PokemonEncounters.Add(new Pokemon("raticate", 45));
            PokemonEncounters.Add(new Pokemon("sentret", 70));
            PokemonEncounters.Add(new Pokemon("furret", 40));
            PokemonEncounters.Add(new Pokemon("poochyena", 75));
            PokemonEncounters.Add(new Pokemon("plusle", 65));
            PokemonEncounters.Add(new Pokemon("minun", 65));
            PokemonEncounters.Add(new Pokemon("shinx", 50));
            PokemonEncounters.Add(new Pokemon("wurmple", 80));
            PokemonEncounters.Add(new Pokemon("spinarak", 80));
            PokemonEncounters.Add(new Pokemon("pineco", 70));
            PokemonEncounters.Add(new Pokemon("krabby", 70));
            PokemonEncounters.Add(new Pokemon("kingler", 40));
            PokemonEncounters.Add(new Pokemon("psyduck", 55));
            PokemonEncounters.Add(new Pokemon("poliwag", 60));
            PokemonEncounters.Add(new Pokemon("magikarp", 90));
            PokemonEncounters.Add(new Pokemon("goldeen", 75));
            PokemonEncounters.Add(new Pokemon("tentacool", 70));
            PokemonEncounters.Add(new Pokemon("tentacruel", 35));
            PokemonEncounters.Add(new Pokemon("staryu", 50));
            PokemonEncounters.Add(new Pokemon("shellder", 70));
            PokemonEncounters.Add(new Pokemon("chinchou", 65));
            PokemonEncounters.Add(new Pokemon("lanturn", 35));
            PokemonEncounters.Add(new Pokemon("gyarados", 10));
            PokemonEncounters.Add(new Pokemon("horsea", 70));
            PokemonEncounters.Add(new Pokemon("seadra", 35));
        }

        void createEncounterMethods()
        {
            EncounterMethods.Add(new EncounterMethod(PokemonEncounters, "Avistamento Aéreo", new List<string> {"flying"}, new List<string> {}));
            EncounterMethods.Add(new EncounterMethod(PokemonEncounters, "Encontro terrestre", new List<string> {"normal", "fighting", "ground","dragon","fairy"}, new List<string> {"flying", "poison", "rock", "steel", "fire", "electric", "psychic"}));
            EncounterMethods.Add(new EncounterMethod(PokemonEncounters, "Encontro nas árvores", new List<string> {"bug"}, new List<string> {"grass"}));
            EncounterMethods.Add(new EncounterMethod(PokemonEncounters, "Avistamento na floresta",new List<string> {"grass, bug"}, new List<string> {"normal", "fighting", "flying", "ground", "rock", "steel", "electric", "dragon", "fairy"}));
            EncounterMethods.Add(new EncounterMethod(PokemonEncounters, "Pesca", new List<string> {"water"}, new List<string> {"ice"}));
            EncounterMethods.Add(new EncounterMethod(PokemonEncounters, "Mergulho", new List<string> {"water"}, new List<string> {"ice"}));
        }

        void createEncounterConditions()
        {
            EncounterConditions.Add(new EncounterCondition("swarm"));
            EncounterConditions.Add(new EncounterCondition("time"));
            EncounterConditions.Add(new EncounterCondition("season"));
        }

        void CalculateSpawnRate()
        {
           bool FirstTimeLoad = true; 
           WorldAlgorithms.CalculateSpawnRate(PokemonEncounters,EncounterMethods, FirstTimeLoad);
           
        }

        public LocationArea(int id, string name)
        {
            this.id = id;
            this.name = name;
            createPokemonEncounters();
            createEncounterMethods();
            createEncounterConditions();
            CalculateSpawnRate();
            LocationAreaMenuOptions.locationArea = this;
        }
    }

    public class LocationAreaMenuOptions
    {
        public static LocationArea locationArea;

        public static void MainMenu()
        {
            Console.Clear();
            Console.WriteLine("O que você deseja fazer?");
            Console.WriteLine();
            Console.WriteLine("1- Procurar Pokémons");
            Console.WriteLine("2- Consultar Pokédex");
            Console.WriteLine("3- Menu de Jogo");
            Console.WriteLine();
        }
        public static void EncounterMethodOptions()
        {
            Console.Clear();
            Console.WriteLine("Como você gostaria de procurar pokémons?");
            Console.WriteLine();
            for (int i = 0; i < locationArea.EncounterMethods.Count; i++)
            {
                Console.WriteLine($"{i+1}- {locationArea.EncounterMethods[i].locationName}");
            }
        }
    }
}
