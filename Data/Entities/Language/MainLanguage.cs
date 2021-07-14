using System.Collections.Generic;
using System.IO;
using Newtonsoft.Json;

namespace ScientistPokemon.Entities.Language
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

    public class MainLanguage
    {
        public static MainLanguage[] language;
        [JsonProperty("id")]
        public int Id { get; set; }

        [JsonProperty("iso3166")]
        public string Iso3166 { get; set; }

        [JsonProperty("iso639")]
        public string Iso639 { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("names")]
        public List<Name> Names { get; set; }

        [JsonProperty("official")]
        public bool Official { get; set; }

        public static void createObject(int items)
        {
            language = new MainLanguage[items];

        }

        public static void setAllItems(string content, int item, int count)
        {
            try
            {
                StreamReader stream = new StreamReader($@"..\\ScientistPokemon\\DataFiles\\api\\v2\\{content}\\{item}\\index.json");
                string jsonString = stream.ReadToEnd();
                language[count] = JsonConvert.DeserializeObject<MainLanguage>(jsonString);
            }
            catch
            {

            }
        }
    }
}