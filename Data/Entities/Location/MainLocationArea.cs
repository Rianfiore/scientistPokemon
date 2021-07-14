using System.Collections.Generic;
using System.IO;
using Newtonsoft.Json;

namespace ScientistPokemon.Entities.LocationArea
{// Root myDeserializedClass = JsonConvert.DeserializeObject<Root>(myJsonResponse); 
    public class EncounterMethod
    {
        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("url")]
        public string Url { get; set; }
    }

    public class Version
    {
        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("url")]
        public string Url { get; set; }
    }

    public class VersionDetail
    {
        [JsonProperty("rate")]
        public int Rate { get; set; }

        [JsonProperty("version")]
        public Version Version { get; set; }

        [JsonProperty("encounter_details")]
        public List<EncounterDetail> EncounterDetails { get; set; }

        [JsonProperty("max_chance")]
        public int MaxChance { get; set; }
    }

    public class EncounterMethodRate
    {
        [JsonProperty("encounter_method")]
        public EncounterMethod EncounterMethod { get; set; }

        [JsonProperty("version_details")]
        public List<VersionDetail> VersionDetails { get; set; }
    }

    public class Location
    {
        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("url")]
        public string Url { get; set; }
    }

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

    public class Pokemon
    {
        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("url")]
        public string Url { get; set; }
    }

    public class Method
    {
        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("url")]
        public string Url { get; set; }
    }

    public class EncounterDetail
    {
        [JsonProperty("chance")]
        public int Chance { get; set; }

        [JsonProperty("condition_values")]
        public List<object> ConditionValues { get; set; }

        [JsonProperty("max_level")]
        public int MaxLevel { get; set; }

        [JsonProperty("method")]
        public Method Method { get; set; }

        [JsonProperty("min_level")]
        public int MinLevel { get; set; }
    }

    public class PokemonEncounter
    {
        [JsonProperty("pokemon")]
        public Pokemon Pokemon { get; set; }

        [JsonProperty("version_details")]
        public List<VersionDetail> VersionDetails { get; set; }
    }

    public class MainLocationArea
    {
        public static MainLocationArea[] locationArea;

        [JsonProperty("encounter_method_rates")]
        public List<EncounterMethodRate> EncounterMethodRates { get; set; }

        [JsonProperty("game_index")]
        public int GameIndex { get; set; }

        [JsonProperty("id")]
        public int Id { get; set; }

        [JsonProperty("location")]
        public Location Location { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("names")]
        public List<Name> Names { get; set; }

        [JsonProperty("pokemon_encounters")]
        public List<PokemonEncounter> PokemonEncounters { get; set; }

        public static void createObject(int items)
        {
            locationArea = new MainLocationArea[items];
        }

        public static void setAllItems(string content, int item, int count)
        {
            try
            {
                StreamReader stream = new StreamReader($@"..\\ScientistPokemon\\DataFiles\\api\\v2\\{content}\\{item}\\index.json");
                string jsonString = stream.ReadToEnd();
                locationArea[count] = JsonConvert.DeserializeObject<MainLocationArea>(jsonString);
            }
            catch
            {

            }
        }
    }
}