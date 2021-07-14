using System.Collections.Generic;
using System.IO;
using Newtonsoft.Json;

namespace ScientistPokemon.Entities.EncounterConditionValue
{// Root myDeserializedClass = JsonConvert.DeserializeObject<Root>(myJsonResponse); 
    public class Condition
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

    public class MainEncounterConditionValue
    {
        public static MainEncounterConditionValue[] encounterConditionValue;

        [JsonProperty("condition")]
        public Condition Condition { get; set; }

        [JsonProperty("id")]
        public int Id { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("names")]
        public List<Name> Names { get; set; }

                public static void createObject(int items)
        {
            encounterConditionValue = new MainEncounterConditionValue[items];

        }

        public static void setAllItems(string content, int item, int count)
        {
            try
            {
                StreamReader stream = new StreamReader($@"..\\ScientistPokemon\\DataFiles\\api\\v2\\{content}\\{item}\\index.json");
                string jsonString = stream.ReadToEnd();
                encounterConditionValue[count] = JsonConvert.DeserializeObject<MainEncounterConditionValue>(jsonString);
            }
            catch
            {

            }
        }
    }        
}