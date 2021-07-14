using System.Collections.Generic;
using System.IO;
using Newtonsoft.Json;

namespace ScientistPokemon.Entities.PokemonShape
{// Root myDeserializedClass = JsonConvert.DeserializeObject<Root>(myJsonResponse); 
    public class Language
    {
        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("url")]
        public string Url { get; set; }
    }

    public class AwesomeName
    {
        [JsonProperty("awesome_name")]
        public string awesomeName { get; set; }

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

    public class PokemonSpecy
    {
        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("url")]
        public string Url { get; set; }
    }

    public class MainPokemonShape
    {
        public static MainPokemonShape[] pokemonShape;

        [JsonProperty("awesome_names")]
        public List<AwesomeName> AwesomeNames { get; set; }

        [JsonProperty("id")]
        public int Id { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("names")]
        public List<Name> Names { get; set; }

        [JsonProperty("pokemon_species")]
        public List<PokemonSpecy> PokemonSpecies { get; set; }

        public static void createObject(int items)
        {
            pokemonShape = new MainPokemonShape[items];

        }

        public static void setAllItems(string content, int item, int count)
        {
            try
            {
                StreamReader stream = new StreamReader($@"..\\ScientistPokemon\\DataFiles\\api\\v2\\{content}\\{item}\\index.json");
                string jsonString = stream.ReadToEnd();
                pokemonShape[count] = JsonConvert.DeserializeObject<MainPokemonShape>(jsonString);
            }
            catch
            {

            }
        }
    }
}