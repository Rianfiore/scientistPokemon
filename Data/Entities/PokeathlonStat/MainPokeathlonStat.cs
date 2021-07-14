using System.Collections.Generic;
using System.IO;
using Newtonsoft.Json;

namespace ScientistPokemon.Entities.PokeathlonStat
{// Root myDeserializedClass = JsonConvert.DeserializeObject<Root>(myJsonResponse); 
    public class Nature
    {
        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("url")]
        public string Url { get; set; }
    }

    public class Decrease
    {
        [JsonProperty("max_change")]
        public int MaxChange { get; set; }

        [JsonProperty("nature")]
        public Nature Nature { get; set; }
    }

    public class Increase
    {
        [JsonProperty("max_change")]
        public int MaxChange { get; set; }

        [JsonProperty("nature")]
        public Nature Nature { get; set; }
    }

    public class AffectingNatures
    {
        [JsonProperty("decrease")]
        public List<Decrease> Decrease { get; set; }

        [JsonProperty("increase")]
        public List<Increase> Increase { get; set; }
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

    public class MainPokeathlonStat
    {
        public static MainPokeathlonStat[] pokeathlonStat;
        [JsonProperty("affecting_natures")]
        public AffectingNatures AffectingNatures { get; set; }

        [JsonProperty("id")]
        public int Id { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("names")]
        public List<Name> Names { get; set; }

                    public static void createObject(int items)
        {
            pokeathlonStat = new MainPokeathlonStat[items];

        }

        public static void setAllItems(string content, int item, int count)
        {
            try
            {
                StreamReader stream = new StreamReader($@"..\\ScientistPokemon\\DataFiles\\api\\v2\\{content}\\{item}\\index.json");
                string jsonString = stream.ReadToEnd();
                pokeathlonStat[count] = JsonConvert.DeserializeObject<MainPokeathlonStat>(jsonString);
            }
            catch
            {

            }
        }
    }
}