using System;
using System.Collections.Generic;
using System.IO;
using Newtonsoft.Json;

namespace ScientistPokemon.Entities.Ability
{ // Root myDeserializedClass = JsonConvert.DeserializeObject<Root>(myJsonResponse); 
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

    public class EffectChanx
    {
        [JsonProperty("effect_entries")]
        public List<EffectEntry> EffectEntries { get; set; }

        [JsonProperty("version_group")]
        public VersionGroup VersionGroup { get; set; }
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

    public class Name
    {
        [JsonProperty("language")]
        public Language Language { get; set; }

        [JsonProperty("name")]
        public string name { get; set; }
    }

    public class Pokemon2
    {
        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("url")]
        public string Url { get; set; }

        [JsonProperty("is_hidden")]
        public bool IsHidden { get; set; }

        [JsonProperty("pokemon")]
        public Pokemon.MainPokemon Pokemon { get; set; }

        [JsonProperty("slot")]
        public int Slot { get; set; }
    }

    public class MainAbility
    {
        public static MainAbility[] ability;
        [JsonProperty("effect_changes")]
        public List<EffectChanx> EffectChanges { get; set; }

        [JsonProperty("effect_entries")]
        public List<EffectEntry> EffectEntries { get; set; }

        [JsonProperty("flavor_text_entries")]
        public List<FlavorTextEntry> FlavorTextEntries { get; set; }

        [JsonProperty("generation")]
        public Entities.Generation.MainGeneration Generation { get; set; }

        [JsonProperty("id")]
        public int Id { get; set; }

        [JsonProperty("is_main_series")]
        public bool IsMainSeries { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("names")]
        public List<Name> Names { get; set; }

        [JsonProperty("pokemon")]
        public List<Pokemon2> Pokemons { get; set; }

        public static void createObject(int items)
        {
            ability = new MainAbility[items];
        }

        public static void setAllItems(string content, int item, int count)
        {
            try
            {
                StreamReader stream = new StreamReader($@"..\\ScientistPokemon\\DataFiles\\api\\v2\\{content}\\{item}\\index.json");
                string jsonString = stream.ReadToEnd();
                ability[count] = JsonConvert.DeserializeObject<MainAbility>(jsonString);
            }
            catch
            {

            }
        }

        public static void linkAllContents (int count)
        {

            #region Generation

                ability[count].Generation = Array.Find(Entities.Generation.MainGeneration.generation, p => p.Name == ability[count].Generation.Name);

            #endregion

            #region Pokemon

                for(int i = 0; i < ability[count].Pokemons.Count;i++)
                {
                    ability[count].Pokemons[i].Pokemon = Array.Find(Pokemon.MainPokemon.pokemon, p => p.Name == ability[count].Pokemons[i].Pokemon.Name);
                }     

            #endregion       
        }         
    }
}