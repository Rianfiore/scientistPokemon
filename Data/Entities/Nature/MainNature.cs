using System.Collections.Generic;
using System.IO;
using Newtonsoft.Json;

namespace ScientistPokemon.Entities.Nature
{// Root myDeserializedClass = JsonConvert.DeserializeObject<Root>(myJsonResponse); 
    public class MoveBattleStyle
    {
        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("url")]
        public string Url { get; set; }
    }

    public class MoveBattleStylePreference
    {
        [JsonProperty("high_hp_preference")]
        public int HighHpPreference { get; set; }

        [JsonProperty("low_hp_preference")]
        public int LowHpPreference { get; set; }

        [JsonProperty("move_battle_style")]
        public MoveBattleStyle MoveBattleStyle { get; set; }
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

    public class PokeathlonStat
    {
        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("url")]
        public string Url { get; set; }
    }

    public class PokeathlonStatChanx
    {
        [JsonProperty("max_change")]
        public int MaxChange { get; set; }

        [JsonProperty("pokeathlon_stat")]
        public PokeathlonStat PokeathlonStat { get; set; }
    }

    public class MainNature
    {
        public static MainNature[] nature;

        [JsonProperty("decreased_stat")]
        public object DecreasedStat { get; set; }

        [JsonProperty("hates_flavor")]
        public object HatesFlavor { get; set; }

        [JsonProperty("id")]
        public int Id { get; set; }

        [JsonProperty("increased_stat")]
        public object IncreasedStat { get; set; }

        [JsonProperty("likes_flavor")]
        public object LikesFlavor { get; set; }

        [JsonProperty("move_battle_style_preferences")]
        public List<MoveBattleStylePreference> MoveBattleStylePreferences { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("names")]
        public List<Name> Names { get; set; }

        [JsonProperty("pokeathlon_stat_changes")]
        public List<PokeathlonStatChanx> PokeathlonStatChanges { get; set; }

        public static void createObject(int items)
        {
            nature = new MainNature[items];

        }

        public static void setAllItems(string content, int item, int count)
        {
            try
            {
                StreamReader stream = new StreamReader($@"..\\ScientistPokemon\\DataFiles\\api\\v2\\{content}\\{item}\\index.json");
                string jsonString = stream.ReadToEnd();
                nature[count] = JsonConvert.DeserializeObject<MainNature>(jsonString);
            }
            catch
            {

            }
        }
    }
}