using System.Collections.Generic;
using System.IO;
using Newtonsoft.Json;

namespace ScientistPokemon.Entities.Pokedex
{// Root myDeserializedClass = JsonConvert.DeserializeObject<Root>(myJsonResponse); 
    public class Language
    {
        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("url")]
        public string Url { get; set; }
    }

    public class Description
    {
        [JsonProperty("description")]
        public string description { get; set; }

        [JsonProperty("language")]
        public Language Language { get; set; }
    }

    public class Name
    {
        [JsonProperty("language")]
        public Language Language { get; set; }

        [JsonProperty("name")]
        public string name { get; set; }
    }

    public class PokemonSpecies
    {
        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("url")]
        public string Url { get; set; }
    }

    public class PokemonEntry
    {
        [JsonProperty("entry_number")]
        public int EntryNumber { get; set; }

        [JsonProperty("pokemon_species")]
        public PokemonSpecies PokemonSpecies { get; set; }
    }

    public class MainPokedex
    {
        public static MainPokedex[] pokedex;
        [JsonProperty("descriptions")]
        public List<Description> Descriptions { get; set; }

        [JsonProperty("id")]
        public int Id { get; set; }

        [JsonProperty("is_main_series")]
        public bool IsMainSeries { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("names")]
        public List<Name> Names { get; set; }

        [JsonProperty("pokemon_entries")]
        public List<PokemonEntry> PokemonEntries { get; set; }

        [JsonProperty("region")]
        public object Region { get; set; }

        [JsonProperty("version_groups")]
        public List<object> VersionGroups { get; set; }

                    public static void createObject(int items)
        {
            pokedex = new MainPokedex[items];

        }

        public static void setAllItems(string content, int item, int count)
        {
            try
            {
                StreamReader stream = new StreamReader($@"..\\ScientistPokemon\\DataFiles\\api\\v2\\{content}\\{item}\\index.json");
                string jsonString = stream.ReadToEnd();
                pokedex[count] = JsonConvert.DeserializeObject<MainPokedex>(jsonString);
            }
            catch
            {

            }
        }
    }
}