using System.Collections.Generic;
using System.IO;
using Newtonsoft.Json;

namespace ScientistPokemon.Entities.MoveLearnMethod
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

    public class VersionGroup
    {
        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("url")]
        public string Url { get; set; }
    }

    public class MainMoveLearnMethod
    {
        public static MainMoveLearnMethod[] moveLearnMethod;

        [JsonProperty("descriptions")]
        public List<Description> Descriptions { get; set; }

        [JsonProperty("id")]
        public int Id { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("names")]
        public List<Name> Names { get; set; }

        [JsonProperty("version_groups")]
        public List<VersionGroup> VersionGroups { get; set; }

        public static void createObject(int items)
        {
            moveLearnMethod = new MainMoveLearnMethod[items];

        }

        public static void setAllItems(string content, int item, int count)
        {
            try
            {
                StreamReader stream = new StreamReader($@"..\\ScientistPokemon\\DataFiles\\api\\v2\\{content}\\{item}\\index.json");
                string jsonString = stream.ReadToEnd();
                moveLearnMethod[count] = JsonConvert.DeserializeObject<MainMoveLearnMethod>(jsonString);
            }
            catch
            {

            }
        }
    }
}