using System.Collections.Generic;
using System.IO;
using Newtonsoft.Json;

namespace ScientistPokemon.Entities.BerryFlavor
{// Root myDeserializedClass = JsonConvert.DeserializeObject<Root>(myJsonResponse); 
    public class Berry2
    {
        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("url")]
        public string Url { get; set; }
    }

    public class Berry
    {
        [JsonProperty("berry")]
        public Berry berry { get; set; }

        [JsonProperty("potency")]
        public int Potency { get; set; }
    }

    public class ContestType
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

    public class MainBerryFlavor
    {
        public static MainBerryFlavor[] berryFlavor;
        [JsonProperty("berries")]
        public List<Berry> Berries { get; set; }

        [JsonProperty("contest_type")]
        public ContestType ContestType { get; set; }

        [JsonProperty("id")]
        public int Id { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("names")]
        public List<Name> Names { get; set; }
        public MainBerryFlavor(){}
        public static void createObject(int items)
        {
        berryFlavor = new MainBerryFlavor[items];
        }

        public static void setAllItems(string content, int item, int count)
        {
            try
            {
                StreamReader stream = new StreamReader($@"..\\ScientistPokemon\\DataFiles\\api\\v2\\{content}\\{item}\\index.json");
                string jsonString = stream.ReadToEnd();
                berryFlavor[count] = JsonConvert.DeserializeObject<MainBerryFlavor>(jsonString);
            }
            catch
            {

            }
        }
    }         
}