using System.Collections.Generic;
using System.IO;
using Newtonsoft.Json;

namespace ScientistPokemon.Entities.GrowthRate

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

    public class Level
    {
        [JsonProperty("experience")]
        public int Experience { get; set; }

        [JsonProperty("level")]
        public int level { get; set; }
    }

    public class PokemonSpecies
    {
        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("url")]
        public string Url { get; set; }
    }

    public class MainGrowthRate
    {
        public static MainGrowthRate[] growthRate;

        [JsonProperty("descriptions")]
        public List<Description> Descriptions { get; set; }

        [JsonProperty("formula")]
        public string Formula { get; set; }

        [JsonProperty("id")]
        public int Id { get; set; }

        [JsonProperty("levels")]
        public List<Level> Levels { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("pokemon_species")]
        public List<PokemonSpecies> PokemonSpecies { get; set; }

        public static void createObject(int items)
        {
            growthRate = new MainGrowthRate[items];

        }

        public static void setAllItems(string content, int item, int count)
        {
            try
            {
                StreamReader stream = new StreamReader($@"..\\ScientistPokemon\\DataFiles\\api\\v2\\{content}\\{item}\\index.json");
                string jsonString = stream.ReadToEnd();
                growthRate[count] = JsonConvert.DeserializeObject<MainGrowthRate>(jsonString);
            }
            catch
            {

            }
        }
    }
}