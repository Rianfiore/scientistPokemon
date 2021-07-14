using System.Collections.Generic;
using System.IO;
using Newtonsoft.Json;
using System.Text.RegularExpressions;
using System;

namespace ScientistPokemon.Entities.Stat
{// Root myDeserializedClass = JsonConvert.DeserializeObject<Root>(myJsonResponse); 
    public class Move
    {
        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("url")]
        public string Url { get; set; }
    }

    public class Increase
    {
        [JsonProperty("change")]
        public int Change { get; set; }

        [JsonProperty("move")]
        public Move Move { get; set; }
    }

    public class AffectingMoves
    {
        [JsonProperty("decrease")]
        public List<object> Decrease { get; set; }

        [JsonProperty("increase")]
        public List<Increase> Increase { get; set; }
    }

    public class AffectingNatures
    {
        [JsonProperty("decrease")]
        public List<object> Decrease { get; set; }

        [JsonProperty("increase")]
        public List<object> Increase { get; set; }
    }

    public class Characteristic
    {
        [JsonProperty("url")]
        public string Url { get; set; }

        public Entities.Characteristic.MainCharacteristic characteristic;
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

    public class MainStat
    {
        public static MainStat[] stat;

        [JsonProperty("affecting_moves")]
        public AffectingMoves AffectingMoves { get; set; }

        [JsonProperty("affecting_natures")]
        public AffectingNatures AffectingNatures { get; set; }

        [JsonProperty("characteristics")]
        public List<Characteristic> Characteristics { get; set; }

        [JsonProperty("game_index")]
        public int GameIndex { get; set; }

        [JsonProperty("id")]
        public int Id { get; set; }

        [JsonProperty("is_battle_only")]
        public bool IsBattleOnly { get; set; }

        [JsonProperty("move_damage_class")]
        public object MoveDamageClass { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("names")]
        public List<Name> Names { get; set; }

        public static void createObject(int items)
        {
            stat = new MainStat[items];

        }

        public static void setAllItems(string content, int item, int count)
        {
            try
            {
                StreamReader stream = new StreamReader($@"..\\ScientistPokemon\\DataFiles\\api\\v2\\{content}\\{item}\\index.json");
                string jsonString = stream.ReadToEnd();
                stat[count] = JsonConvert.DeserializeObject<MainStat>(jsonString);
            }
            catch
            {

            }
        }

        public static void linkAllContents (int count, string rootPath)
        {

            #region Characteristics

            string url, path = rootPath + "characteristic/";

            int index;

                for (int i = 0; i < stat[count].Characteristics.Count;i++)
                {

                    url = stat[count].Characteristics[i].Url;

                    index = Int32.Parse(String.Concat(Regex.Split(url.Remove(0, path.Length),@"[^0-9]")));

                    stat[count].Characteristics[i].characteristic = Array.Find(Entities.Characteristic.MainCharacteristic.characteristic, p => p.Id == index);

                }

            #endregion
        }
    }
}