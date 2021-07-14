using System.Collections.Generic;
using System.IO;
using Newtonsoft.Json;

namespace ScientistPokemon.Entities.SuperContestEffect
{// Root myDeserializedClass = JsonConvert.DeserializeObject<Root>(myJsonResponse); 
    public class Language
    {
        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("url")]
        public string Url { get; set; }
    }

    public class FlavorTextEntry
    {
        [JsonProperty("flavor_text")]
        public string FlavorText { get; set; }

        [JsonProperty("language")]
        public Language Language { get; set; }
    }

    public class Move
    {
        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("url")]
        public string Url { get; set; }
    }

    public class MainSuperContestEffect
    {
        public static MainSuperContestEffect[] superContestEffect;

        [JsonProperty("appeal")]
        public int Appeal { get; set; }

        [JsonProperty("flavor_text_entries")]
        public List<FlavorTextEntry> FlavorTextEntries { get; set; }

        [JsonProperty("id")]
        public int Id { get; set; }

        [JsonProperty("moves")]
        public List<Move> Moves { get; set; }

        public static void createObject(int items)
        {
            superContestEffect = new MainSuperContestEffect[items];

        }

        public static void setAllItems(string content, int item, int count)
        {
            try
            {
                StreamReader stream = new StreamReader($@"..\\ScientistPokemon\\DataFiles\\api\\v2\\{content}\\{item}\\index.json");
                string jsonString = stream.ReadToEnd();
                superContestEffect[count] = JsonConvert.DeserializeObject<MainSuperContestEffect>(jsonString);
            }
            catch
            {

            }
        }
    }
}