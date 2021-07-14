using System.Collections.Generic;
using System.IO;
using Newtonsoft.Json;

namespace ScientistPokemon.Entities.VersionGroup
{// Root myDeserializedClass = JsonConvert.DeserializeObject<Root>(myJsonResponse); 
    public class Generation
    {
        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("url")]
        public string Url { get; set; }
    }

    public class MoveLearnMethod
    {
        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("url")]
        public string Url { get; set; }
    }

    public class Pokedex
    {
        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("url")]
        public string Url { get; set; }
    }

    public class Region
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

    public class MainVersionGroup
    {
        public static MainVersionGroup[] versionGroup;

        [JsonProperty("generation")]
        public Generation Generation { get; set; }

        [JsonProperty("id")]
        public int Id { get; set; }

        [JsonProperty("move_learn_methods")]
        public List<MoveLearnMethod> MoveLearnMethods { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("order")]
        public int Order { get; set; }

        [JsonProperty("pokedexes")]
        public List<Pokedex> Pokedexes { get; set; }

        [JsonProperty("regions")]
        public List<Region> Regions { get; set; }

        [JsonProperty("versions")]
        public List<Version> Versions { get; set; }

        public static void createObject(int items)
        {
            versionGroup = new MainVersionGroup[items];

        }

        public static void setAllItems(string content, int item, int count)
        {
            try
            {
                StreamReader stream = new StreamReader($@"..\\ScientistPokemon\\DataFiles\\api\\v2\\{content}\\{item}\\index.json");
                string jsonString = stream.ReadToEnd();
                versionGroup[count] = JsonConvert.DeserializeObject<MainVersionGroup>(jsonString);
            }
            catch
            {

            }
        }
    }
}