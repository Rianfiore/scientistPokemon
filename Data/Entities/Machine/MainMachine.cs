using System.Collections.Generic;
using System.IO;
using Newtonsoft.Json;

namespace ScientistPokemon.Entities.Machine
{// Root myDeserializedClass = JsonConvert.DeserializeObject<Root>(myJsonResponse); 
    public class Item
    {
        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("url")]
        public string Url { get; set; }
    }

    public class Move
    {
        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("url")]
        public string Url { get; set; }
    }

    public class VersionGroup
    {
        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("url")]
        public string Url { get; set; }
    }

    public class MainMachine
    {
        public static MainMachine[] machine;
        [JsonProperty("id")]
        public int Id { get; set; }

        [JsonProperty("item")]
        public Item Item { get; set; }

        [JsonProperty("move")]
        public Move Move { get; set; }

        [JsonProperty("version_group")]
        public VersionGroup VersionGroup { get; set; }

        public static void createObject(int items)
        {
            machine = new MainMachine[items];

        }

        public static void setAllItems(string content, int item, int count)
        {
            try
            {
                StreamReader stream = new StreamReader($@"..\\ScientistPokemon\\DataFiles\\api\\v2\\{content}\\{item}\\index.json");
                string jsonString = stream.ReadToEnd();
                machine[count] = JsonConvert.DeserializeObject<MainMachine>(jsonString);
            }
            catch
            {

            }
        }
    }
}