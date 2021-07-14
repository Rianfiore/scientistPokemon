using System.Collections.Generic;
using System.IO;
using Newtonsoft.Json;

namespace ScientistPokemon.Entities.Berry
{// Root myDeserializedClass = JsonConvert.DeserializeObject<Root>(myJsonResponse); 
    public class Firmness
    {
        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("url")]
        public string Url { get; set; }
    }

    public class Flavor2
    {
        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("url")]
        public string Url { get; set; }
    }

    public class Flavor
    {
        [JsonProperty("flavor")]
        public BerryFlavor.MainBerryFlavor BerryFlavor { get; set; }

        [JsonProperty("potency")]
        public int Potency { get; set; }
    }

    public class Item
    {
        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("url")]
        public string Url { get; set; }
    }

    public class NaturalGiftType
    {
        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("url")]
        public string Url { get; set; }
    }

    public class MainBerry
    {
        public static MainBerry[] berry;
        
        [JsonProperty("firmness")]
        public Firmness Firmness { get; set; }

        [JsonProperty("flavors")]
        public List<Flavor> Flavors { get; set; }

        [JsonProperty("growth_time")]
        public int GrowthTime { get; set; }

        [JsonProperty("id")]
        public int Id { get; set; }

        [JsonProperty("item")]
        public Item Item { get; set; }

        [JsonProperty("max_harvest")]
        public int MaxHarvest { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("natural_gift_power")]
        public int NaturalGiftPower { get; set; }

        [JsonProperty("natural_gift_type")]
        public NaturalGiftType NaturalGiftType { get; set; }

        [JsonProperty("size")]
        public int Size { get; set; }

        [JsonProperty("smoothness")]
        public int Smoothness { get; set; }

        [JsonProperty("soil_dryness")]
        public int SoilDryness { get; set; }

        public MainBerry(){}
        public static void createObject(int items)
        {
            berry = new MainBerry[items];
        }

        public static void setAllItems(string content, int item, int count)
        {
            try
            {
                StreamReader stream = new StreamReader($@"..\\ScientistPokemon\\DataFiles\\api\\v2\\{content}\\{item}\\index.json");
                string jsonString = stream.ReadToEnd();
                berry[count] = JsonConvert.DeserializeObject<MainBerry>(jsonString);
            }
            catch
            {

            }
        }         
    }
}