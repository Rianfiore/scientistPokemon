using System;
using System.Collections.Generic;
using System.IO;
using Newtonsoft.Json;

namespace ScientistPokemon.Entities.EncounterCondition
{
    // Root myDeserializedClass = JsonConvert.DeserializeObject<Root>(myJsonResponse); 
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

    public class Value
    {
        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("url")]
        public string Url { get; set; }
    }

    public class MainEncounterCondition
    {
        public static MainEncounterCondition[] encounterCondition;
        
        [JsonProperty("id")]
        public int Id { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("names")]
        public List<Name> Names { get; set; }

        [JsonProperty("values")]
        public List<Value> Values { get; set; }

        public static void createObject(int items)
        {
            encounterCondition = new MainEncounterCondition[items];

        }

        public static void setAllItems(string content, int item, int count)
        {
            try
            {
                StreamReader stream = new StreamReader($@"..\\ScientistPokemon\\DataFiles\\api\\v2\\{content}\\{item}\\index.json");
                string jsonString = stream.ReadToEnd();
                encounterCondition[count] = JsonConvert.DeserializeObject<MainEncounterCondition>(jsonString);
            }
            catch
            {

            }
        }
    }
}