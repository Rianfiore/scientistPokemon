using System.Collections.Generic;
using System.IO;
using Newtonsoft.Json;

namespace ScientistPokemon.Entities.MoveCategory
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

    public class Move
    {
        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("url")]
        public string Url { get; set; }
    }

    public class MainMoveCategory
    {
        public static MainMoveCategory[] moveCategory;

        [JsonProperty("descriptions")]
        public List<Description> Descriptions { get; set; }

        [JsonProperty("id")]
        public int Id { get; set; }

        [JsonProperty("moves")]
        public List<Move> Moves { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

               public static void createObject(int items)
        {
            moveCategory = new MainMoveCategory[items];

        }

        public static void setAllItems(string content, int item, int count)
        {
            try
            {
                StreamReader stream = new StreamReader($@"..\\ScientistPokemon\\DataFiles\\api\\v2\\{content}\\{item}\\index.json");
                string jsonString = stream.ReadToEnd();
                moveCategory[count] = JsonConvert.DeserializeObject<MainMoveCategory>(jsonString);
            }
            catch
            {

            }
        }
    }
}