using System.Collections.Generic;
using System.IO;
using Newtonsoft.Json;

namespace ScientistPokemon.Entities.PalParkArea
{// Root myDeserializedClass = JsonConvert.DeserializeObject<Root>(myJsonResponse); 
    public class Language
    {
        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("url")]
        public string Url { get; set; }
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

    public class PokemonEncounter
    {
        [JsonProperty("base_score")]
        public int BaseScore { get; set; }

        [JsonProperty("pokemon_species")]
        public PokemonSpecies PokemonSpecies { get; set; }

        [JsonProperty("rate")]
        public int Rate { get; set; }
    }

    public class MainPalParkArea
    {
        public static MainPalParkArea[] palParkArea;

        [JsonProperty("id")]
        public int Id { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("names")]
        public List<Name> Names { get; set; }

        [JsonProperty("pokemon_encounters")]
        public List<PokemonEncounter> PokemonEncounters { get; set; }

        public static void createObject(int items)
        {
            palParkArea = new MainPalParkArea[items];

        }

        public static void setAllItems(string content, int item, int count)
        {
            try
            {
                StreamReader stream = new StreamReader($@"..\\ScientistPokemon\\DataFiles\\api\\v2\\{content}\\{item}\\index.json");
                string jsonString = stream.ReadToEnd();
                palParkArea[count] = JsonConvert.DeserializeObject<MainPalParkArea>(jsonString);
            }
            catch
            {

            }
        }
    }
}