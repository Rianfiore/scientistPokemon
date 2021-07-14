using System.Collections.Generic;
using System.IO;
using Newtonsoft.Json;

namespace ScientistPokemon.Entities.Item
{// Root myDeserializedClass = JsonConvert.DeserializeObject<Root>(myJsonResponse); 
    public class Attribute
    {
        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("url")]
        public string Url { get; set; }
    }

    public class Category
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

    public class EffectEntry
    {
        [JsonProperty("effect")]
        public string Effect { get; set; }

        [JsonProperty("language")]
        public Language Language { get; set; }

        [JsonProperty("short_effect")]
        public string ShortEffect { get; set; }
    }

    public class VersionGroup
    {
        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("url")]
        public string Url { get; set; }
    }

    public class FlavorTextEntry
    {
        [JsonProperty("language")]
        public Language Language { get; set; }

        [JsonProperty("text")]
        public string Text { get; set; }

        [JsonProperty("version_group")]
        public VersionGroup VersionGroup { get; set; }
    }

    public class Generation
    {
        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("url")]
        public string Url { get; set; }
    }

    public class GameIndice
    {
        [JsonProperty("game_index")]
        public int GameIndex { get; set; }

        [JsonProperty("generation")]
        public Generation Generation { get; set; }
    }

    public class Name
    {
        [JsonProperty("language")]
        public Language Language { get; set; }

        [JsonProperty("name")]
        public string name { get; set; }
    }

    public class Sprites
    {
        [JsonProperty("default")]
        public string Default { get; set; }
    }

    public class MainItem
    {
        public static MainItem[] item;

        [JsonProperty("attributes")]
        public List<Attribute> Attributes { get; set; }

        [JsonProperty("baby_trigger_for")]
        public object BabyTriggerFor { get; set; }

        [JsonProperty("category")]
        public Category Category { get; set; }

        [JsonProperty("cost")]
        public int Cost { get; set; }

        [JsonProperty("effect_entries")]
        public List<EffectEntry> EffectEntries { get; set; }

        [JsonProperty("flavor_text_entries")]
        public List<FlavorTextEntry> FlavorTextEntries { get; set; }

        [JsonProperty("fling_effect")]
        public object FlingEffect { get; set; }

        [JsonProperty("fling_power")]
        public object FlingPower { get; set; }

        [JsonProperty("game_indices")]
        public List<GameIndice> GameIndices { get; set; }

        [JsonProperty("held_by_pokemon")]
        public List<object> HeldByPokemon { get; set; }

        [JsonProperty("id")]
        public int Id { get; set; }

        [JsonProperty("machines")]
        public List<object> Machines { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("names")]
        public List<Name> Names { get; set; }

        [JsonProperty("sprites")]
        public Sprites Sprites { get; set; }

        public static void createObject(int items)
        {
            item = new MainItem[items];

        }

        public static void setAllItems(string content, int itemValue, int count)
        {
            try
            {
                StreamReader stream = new StreamReader($@"..\\ScientistPokemon\\DataFiles\\api\\v2\\{content}\\{itemValue}\\index.json");
                string jsonString = stream.ReadToEnd();
                item[count] = JsonConvert.DeserializeObject<MainItem>(jsonString);
            }
            catch
            {

            }
        }
    }
}