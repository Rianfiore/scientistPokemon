using System.Collections.Generic;
using System.IO;
using Newtonsoft.Json;

namespace ScientistPokemon.Entities.MoveBattleStyle
{// Root myDeserializedClass = JsonConvert.DeserializeObject<Root>(myJsonResponse); 
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

    public class MainMoveBattleStyle
    {
        public static MainMoveBattleStyle[] moveBattleStyle;
        [JsonProperty("id")]
        public int Id { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("names")]
        public List<Name> Names { get; set; }

        public static void createObject(int items)
        {
            moveBattleStyle = new MainMoveBattleStyle[items];

        }

        public static void setAllItems(string content, int item, int count)
        {
            try
            {
                StreamReader stream = new StreamReader($@"..\\ScientistPokemon\\DataFiles\\api\\v2\\{content}\\{item}\\index.json");
                string jsonString = stream.ReadToEnd();
                moveBattleStyle[count] = JsonConvert.DeserializeObject<MainMoveBattleStyle>(jsonString);
            }
            catch
            {

            }
        }
    }
}