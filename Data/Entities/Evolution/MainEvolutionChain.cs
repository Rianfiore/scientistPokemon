using System;
using System.Collections.Generic;
using System.IO;
using Newtonsoft.Json;
using System.Text.RegularExpressions;
using System.Reflection;

namespace ScientistPokemon.Entities.EvolutionChain
{// Root myDeserializedClass = JsonConvert.DeserializeObject<Root>(myJsonResponse); 

    public class Trigger
    {
        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("url")]
        public string Url { get; set; }

        public Entities.EvolutionTrigger.MainEvolutionTrigger trigger;
    }

    public class EvolutionDetail
    {
        [JsonProperty("gender")]
        public object Gender { get; set; }

        [JsonProperty("held_item")]
        public object HeldItem { get; set; }

        [JsonProperty("item")]
        public object Item { get; set; }

        [JsonProperty("known_move")]
        public object KnownMove { get; set; }

        [JsonProperty("known_move_type")]
        public object KnownMoveType { get; set; }

        [JsonProperty("location")]
        public object Location { get; set; }

        [JsonProperty("min_affection")]
        public object MinAffection { get; set; }

        [JsonProperty("min_beauty")]
        public object MinBeauty { get; set; }

        [JsonProperty("min_happiness")]
        public object MinHappiness { get; set; }

        [JsonProperty("min_level")]
        public int MinLevel { get; set; }

        [JsonProperty("needs_overworld_rain")]
        public bool NeedsOverworldRain { get; set; }

        [JsonProperty("party_species")]
        public object PartySpecies { get; set; }

        [JsonProperty("party_type")]
        public object PartyType { get; set; }

        [JsonProperty("relative_physical_stats")]
        public object RelativePhysicalStats { get; set; }

        [JsonProperty("time_of_day")]
        public string TimeOfDay { get; set; }

        [JsonProperty("trade_species")]
        public object TradeSpecies { get; set; }

        [JsonProperty("trigger")]
        public Trigger Trigger { get; set; }

        [JsonProperty("turn_upside_down")]
        public bool TurnUpsideDown { get; set; }
    }

    public class Species
    {
        [JsonProperty("name")]
        public static string Name { get; set; }

        [JsonProperty("url")]
        public static string Url { get; set; }

        public static Entities.PokemonSpecies.MainPokemonSpecies species;

        public static void FindSpecies () {
            
            try
            {
            string rootPath = "/api/v2/";
            string speciesURL = Url;
            speciesURL = speciesURL.Remove(0,rootPath.Length);
            string speciesIndex = String.Join("",Regex.Split(speciesURL, @"[^0-9]"));
            StreamReader stream2 = new StreamReader($@"..\\ScientistPokemon\\DataFiles\\api\\v2\\pokemon-species\\{speciesIndex}\\index.json");
            string jsonString2 = stream2.ReadToEnd();

            species = JsonConvert.DeserializeObject<Entities.PokemonSpecies.MainPokemonSpecies>(jsonString2);
            } 
            
            catch{
                //return Entities.PokemonSpecies.MainPokemonSpecies.pokemonSpecies[0];
            }

        }
    }

    public class EvolvesTo
    {
        [JsonProperty("evolution_details")]
        public List<EvolutionDetail> EvolutionDetails { get; set; }

        [JsonProperty("evolves_to")]
        public List<EvolvesTo> evolvesTo { get; set; }

        [JsonProperty("is_baby")]
        public bool IsBaby { get; set; }

        [JsonProperty("species")]
        public Species Species { get; set; }
    }

    public class Chain
    {
        [JsonProperty("evolution_details")]
        public List<object> EvolutionDetails { get; set; }

        [JsonProperty("evolves_to")]
        public List<EvolvesTo> EvolvesTo { get; set; }

        [JsonProperty("is_baby")]
        public bool IsBaby { get; set; }

        [JsonProperty("species")]
        public Species Species { get; set; }
    }

    public class MainEvolutionChain
    {
        public static MainEvolutionChain[] evolutionChain;

        [JsonProperty("baby_trigger_item")]
        public object BabyTriggerItem { get; set; }

        [JsonProperty("chain")]
        public Chain Chain { get; set; }

        [JsonProperty("id")]
        public int Id { get; set; }

        //public Species species;

        public static void createObject(int items)
        {
            evolutionChain = new MainEvolutionChain[items];

        }

        public static void setAllItems(string content, int item, int count, string rootPath)
        {
            try
            {
                StreamReader stream = new StreamReader($@"..\\ScientistPokemon\\DataFiles\\api\\v2\\{content}\\{item}\\index.json");
                string jsonString = stream.ReadToEnd();
                evolutionChain[count] = JsonConvert.DeserializeObject<MainEvolutionChain>(jsonString);

                //Array.FindAll(evolutionChain[count].Chain.EvolvesTo[0]., p => p)

            }
            catch
            {
                
            }
        }


      /*  public static Entities.PokemonSpecies.MainPokemonSpecies catchSpecies()
        {

                string rootPath = "/api/v2/";
                string speciesURL = Species.Url;
                speciesURL = speciesURL.Remove(0,rootPath.Length);
                string speciesIndex = String.Join("",Regex.Split(speciesURL, @"[^0-9]"));
                StreamReader stream2 = new StreamReader($@"..\\ScientistPokemon\\DataFiles\\api\\v2\\pokemon-species\\{speciesIndex}\\index.json");
                string jsonString2 = stream2.ReadToEnd();
                return JsonConvert.DeserializeObject<Entities.PokemonSpecies.MainPokemonSpecies>(jsonString2);

        } */

        public static void linkAllContents(int count)
        {
            #region Species

            //evolutionChain[count].Chain.Species.species = Array.Find(Entities.PokemonSpecies.MainPokemonSpecies.pokemonSpecies, p => p.Name == Species.Name);
            //bool objectExisted;
            //List<EvolvesTo> evolvesTo;
        
            /*for (int i = 0; i < evolutionChain[count].Chain.EvolvesTo.Count; i++)
            {
                evolutionChain[count].Chain.EvolvesTo[i].Species.species = Array.Find(Entities.PokemonSpecies.MainPokemonSpecies.pokemonSpecies, p => p.Name ==  evolutionChain[count].Chain.EvolvesTo[i].Species.Name);

                for (int j = 0; j < evolutionChain[count].Chain.EvolvesTo[i].evolvesTo.Count; j++)
                {
                    evolutionChain[count].Chain.EvolvesTo[i].evolvesTo[j].= Array.Find(Entities.PokemonSpecies.MainPokemonSpecies.pokemonSpecies, p => p.Name ==  evolutionChain[count].Chain.EvolvesTo[i].Species.Name)
                }
            } */

            #endregion
        }
    }
}