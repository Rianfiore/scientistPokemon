using System.Collections.Generic;
using System.IO;
using Newtonsoft.Json;

namespace ScientistPokemon.Entities.Type
{// Root myDeserializedClass = JsonConvert.DeserializeObject<Root>(myJsonResponse); 
    public class DoubleDamageFrom
    {
        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("url")]
        public string Url { get; set; }
    }

    public class HalfDamageTo
    {
        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("url")]
        public string Url { get; set; }
    }

    public class NoDamageFrom
    {
        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("url")]
        public string Url { get; set; }
    }

    public class NoDamageTo
    {
        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("url")]
        public string Url { get; set; }
    }

    public class DamageRelations
    {
        [JsonProperty("double_damage_from")]
        public List<DoubleDamageFrom> DoubleDamageFrom { get; set; }

        [JsonProperty("double_damage_to")]
        public List<object> DoubleDamageTo { get; set; }

        [JsonProperty("half_damage_from")]
        public List<object> HalfDamageFrom { get; set; }

        [JsonProperty("half_damage_to")]
        public List<HalfDamageTo> HalfDamageTo { get; set; }

        [JsonProperty("no_damage_from")]
        public List<NoDamageFrom> NoDamageFrom { get; set; }

        [JsonProperty("no_damage_to")]
        public List<NoDamageTo> NoDamageTo { get; set; }
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

    public class MoveDamageClass
    {
        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("url")]
        public string Url { get; set; }
    }

    public class Move
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

    public class Pokemon
    {
        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("url")]
        public string Url { get; set; }

        [JsonProperty("pokemon")]
        public Pokemon pokemon { get; set; }

        [JsonProperty("slot")]
        public int Slot { get; set; }
    }

    public class MainType
    {
        public static MainType[] type;

        [JsonProperty("damage_relations")]
        public DamageRelations DamageRelations { get; set; }

        [JsonProperty("game_indices")]
        public List<GameIndice> GameIndices { get; set; }

        [JsonProperty("generation")]
        public Generation Generation { get; set; }

        [JsonProperty("id")]
        public int Id { get; set; }

        [JsonProperty("move_damage_class")]
        public MoveDamageClass MoveDamageClass { get; set; }

        [JsonProperty("moves")]
        public List<Move> Moves { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("names")]
        public List<Name> Names { get; set; }

        [JsonProperty("pokemon")]
        public List<Pokemon> Pokemon { get; set; }

                    public static void createObject(int items)
        {
            type = new MainType[items];

        }

        public static void setAllItems(string content, int item, int count)
        {
            try
            {
                StreamReader stream = new StreamReader($@"..\\ScientistPokemon\\DataFiles\\api\\v2\\{content}\\{item}\\index.json");
                string jsonString = stream.ReadToEnd();
                type[count] = JsonConvert.DeserializeObject<MainType>(jsonString);
            }
            catch
            {

            }
        }
    }
}