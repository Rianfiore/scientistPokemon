using System.Collections.Generic;
using System.IO;
using Newtonsoft.Json;

namespace ScientistPokemon.Entities.Gender
{// Root myDeserializedClass = JsonConvert.DeserializeObject<Root>(myJsonResponse); 
    public class PokemonSpecies
    {
        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("url")]
        public string Url { get; set; }
    }

    public class PokemonSpeciesDetail
    {
        [JsonProperty("pokemon_species")]
        public PokemonSpecies PokemonSpecies { get; set; }

        [JsonProperty("rate")]
        public int Rate { get; set; }
    }

    public class RequiredForEvolution
    {
        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("url")]
        public string Url { get; set; }
    }

    public class MainGender
    {
        public static MainGender[] gender;
        [JsonProperty("id")]
        public int Id { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("pokemon_species_details")]
        public List<PokemonSpeciesDetail> PokemonSpeciesDetails { get; set; }

        [JsonProperty("required_for_evolution")]
        public List<RequiredForEvolution> RequiredForEvolution { get; set; }

        public static void createObject(int items)
        {
            gender = new MainGender[items];

        }

        public static void setAllItems(string content, int item, int count)
        {
            try
            {
                StreamReader stream = new StreamReader($@"..\\ScientistPokemon\\DataFiles\\api\\v2\\{content}\\{item}\\index.json");
                string jsonString = stream.ReadToEnd();
                gender[count] = JsonConvert.DeserializeObject<MainGender>(jsonString);
            }
            catch
            {

            }
        }
    }
}