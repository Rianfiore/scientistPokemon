using System.Collections.Generic;
using System.IO;
using Newtonsoft.Json;

namespace ScientistPokemon.Entities.Characteristic
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

    public class HighestStat
    {
        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("url")]
        public string Url { get; set; }
    }

    public class MainCharacteristic
    {
        public static MainCharacteristic[] characteristic;
        [JsonProperty("descriptions")]
        public List<Description> Descriptions { get; set; }

        [JsonProperty("gene_modulo")]
        public int GeneModulo { get; set; }

        [JsonProperty("highest_stat")]
        public HighestStat HighestStat { get; set; }

        [JsonProperty("id")]
        public int Id { get; set; }

        [JsonProperty("possible_values")]
        public List<int> PossibleValues { get; set; }

        public static void createObject(int items)
        {
            characteristic = new MainCharacteristic[items];
        }

        public static void setAllItems(string content, int item, int count)
        {
            try
            {
                StreamReader stream = new StreamReader($@"..\\ScientistPokemon\\DataFiles\\api\\v2\\{content}\\{item}\\index.json");
                string jsonString = stream.ReadToEnd();
                characteristic[count] = JsonConvert.DeserializeObject<MainCharacteristic>(jsonString);
            }
            catch
            {

            }
        }  
    }       
}