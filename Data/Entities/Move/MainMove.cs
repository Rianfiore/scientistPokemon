using System.Collections.Generic;
using System.IO;
using Newtonsoft.Json;

namespace ScientistPokemon.Entities.Move
{
// Root myDeserializedClass = JsonConvert.DeserializeObject<Root>(myJsonResponse); 
    public class UseBefore
    {
        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("url")]
        public string Url { get; set; }
    }

    public class Normal
    {
        [JsonProperty("use_after")]
        public object UseAfter { get; set; }

        [JsonProperty("use_before")]
        public List<UseBefore> UseBefore { get; } = new List<UseBefore>();
    }

    public class Super
    {
        [JsonProperty("use_after")]
        public object UseAfter { get; set; }

        [JsonProperty("use_before")]
        public object UseBefore { get; set; }
    }

    public class ContestCombos
    {
        [JsonProperty("normal")]
        public Normal Normal { get; set; }

        [JsonProperty("super")]
        public Super Super { get; set; }
    }

    public class ContestEffect
    {
        [JsonProperty("url")]
        public string Url { get; set; }
    }

    public class ContestType
    {
        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("url")]
        public string Url { get; set; }
    }

    public class DamageClass
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
        [JsonProperty("flavor_text")]
        public string FlavorText { get; set; }

        [JsonProperty("language")]
        public Language Language { get; set; }

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

    public class LearnedByPokemon
    {
        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("url")]
        public string Url { get; set; }
    }

    public class Ailment
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

    public class Meta
    {
        [JsonProperty("ailment")]
        public Ailment Ailment { get; set; }

        [JsonProperty("ailment_chance")]
        public int AilmentChance { get; set; }

        [JsonProperty("category")]
        public Category Category { get; set; }

        [JsonProperty("crit_rate")]
        public int CritRate { get; set; }

        [JsonProperty("drain")]
        public int Drain { get; set; }

        [JsonProperty("flinch_chance")]
        public int FlinchChance { get; set; }

        [JsonProperty("healing")]
        public int Healing { get; set; }

        [JsonProperty("max_hits")]
        public object MaxHits { get; set; }

        [JsonProperty("max_turns")]
        public object MaxTurns { get; set; }

        [JsonProperty("min_hits")]
        public object MinHits { get; set; }

        [JsonProperty("min_turns")]
        public object MinTurns { get; set; }

        [JsonProperty("stat_chance")]
        public int StatChance { get; set; }
    }

    public class Name
    {
        [JsonProperty("language")]
        public Language Language { get; set; }

        [JsonProperty("name")]
        public string name { get; set; }
    }

    public class SuperContestEffect
    {
        [JsonProperty("url")]
        public string Url { get; set; }
    }

    public class Target
    {
        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("url")]
        public string Url { get; set; }
    }

    public class Type
    {
        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("url")]
        public string Url { get; set; }
    }

    public class MainMove
    {
        public static MainMove[] move;
        
        [JsonProperty("accuracy")]
        public int? Accuracy { get; set; }

        [JsonProperty("contest_combos")]
        public ContestCombos ContestCombos { get; set; }

        [JsonProperty("contest_effect")]
        public ContestEffect ContestEffect { get; set; }

        [JsonProperty("contest_type")]
        public ContestType ContestType { get; set; }

        [JsonProperty("damage_class")]
        public DamageClass DamageClass { get; set; }

        [JsonProperty("effect_chance")]
        public object EffectChance { get; set; }

        [JsonProperty("effect_changes")]
        public List<object> EffectChanges { get; } = new List<object>();

        [JsonProperty("effect_entries")]
        public List<EffectEntry> EffectEntries { get; } = new List<EffectEntry>();

        [JsonProperty("flavor_text_entries")]
        public List<FlavorTextEntry> FlavorTextEntries { get; } = new List<FlavorTextEntry>();

        [JsonProperty("generation")]
        public Generation Generation { get; set; }

        [JsonProperty("id")]
        public int Id { get; set; }

        [JsonProperty("learned_by_pokemon")]
        public List<LearnedByPokemon> LearnedByPokemon { get; } = new List<LearnedByPokemon>();

        [JsonProperty("machines")]
        public List<object> Machines { get; } = new List<object>();

        [JsonProperty("meta")]
        public Meta Meta { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("names")]
        public List<Name> Names { get; } = new List<Name>();

        [JsonProperty("past_values")]
        public List<object> PastValues { get; } = new List<object>();

        [JsonProperty("power")]
        public int? Power { get; set; }

        [JsonProperty("pp")]
        public int Pp { get; set; }

        [JsonProperty("priority")]
        public int Priority { get; set; }

        [JsonProperty("stat_changes")]
        public List<object> StatChanges { get; } = new List<object>();

        [JsonProperty("super_contest_effect")]
        public SuperContestEffect SuperContestEffect { get; set; }

        [JsonProperty("target")]
        public Target Target { get; set; }

        [JsonProperty("type")]
        public Type Type { get; set; }

        public static void createObject(int items)
        {
           move = new MainMove[items];
        }

        public static void setAllItems(string content, int item, int count)
        {
            try
            {
                StreamReader stream = new StreamReader($@"..\\ScientistPokemon\\DataFiles\\api\\v2\\{content}\\{item}\\index.json");
                string jsonString = stream.ReadToEnd();
                move[count] = JsonConvert.DeserializeObject<MainMove>(jsonString);
            }
            catch
            {

            }
        }
    }
}