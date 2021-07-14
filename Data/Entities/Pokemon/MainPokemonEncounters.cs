using System;
using System.Collections.Generic;
using System.IO;
using Newtonsoft.Json;

namespace ScientistPokemon.Entities.Pokemon.Encounters
{// Root myDeserializedClass = JsonConvert.DeserializeObject<Root>(myJsonResponse); 
    public class LocationArea
    {
        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("url")]
        public string Url { get; set; }
        
        public Entities.LocationArea.MainLocationArea locationArea;
    }

    public class ConditionValue
    {
        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("url")]
        public string Url { get; set; }
    }

    public class Method
    {
        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("url")]
        public string Url { get; set; }
        public Entities.EncounterMethod.MainEncounterMethod EncounterMethod;
    }

    public class EncounterDetail
    {
        [JsonProperty("chance")]
        public int Chance { get; set; }

        [JsonProperty("condition_values")]
        public List<ConditionValue> ConditionValues { get; set; }

        public EncounterConditionValue.MainEncounterConditionValue ConditionValue;

        [JsonProperty("max_level")]
        public int MaxLevel { get; set; }

        [JsonProperty("method")]
        public Method Method { get; set; }
        
        public EncounterMethod.MainEncounterMethod EncounterMethod;

        [JsonProperty("min_level")]
        public int MinLevel { get; set; }
    }

    public class Version
    {
        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("url")]
        public string Url { get; set; }
    }

    public class VersionDetail
    {
        [JsonProperty("encounter_details")]
        public List<EncounterDetail> EncounterDetails { get; set; }

        [JsonProperty("max_chance")]
        public int MaxChance { get; set; }

        [JsonProperty("version")]
        public Version Version { get; set; }
    }

    public class MainPokemonEncounters
    {
        public static List<MainPokemonEncounters[]> PokemonEncounters;
        [JsonProperty("location_area")]
        public LocationArea LocationArea { get; set; }

        [JsonProperty("version_details")]
        public List<VersionDetail> VersionDetails { get; set; }

        public static void createObject(int items)
        {

            PokemonEncounters = new List<MainPokemonEncounters[]>();
            
        }

        public static void setAllItems(int length, StreamReader stream, string jsonString, string content, int item, int count)
        {
            try
            {
                stream = new StreamReader($@"..\\ScientistPokemon\\DataFiles\\api\\v2\\{content}\\{item}\\encounters\\index.json");
                jsonString = stream.ReadToEnd();
                PokemonEncounters.Add(JsonConvert.DeserializeObject<MainPokemonEncounters[]>(jsonString));
            }
            catch
            {

            }
        }

        public static void linkAllContents (int count, bool loadEncounters)
        {
            if (loadEncounters == true)
            {
                #region Encounters

                    for (int i = 0; i < PokemonEncounters[count].Length;i++)
                    {
                        PokemonEncounters[count][i].LocationArea.locationArea = Array.Find(Entities.LocationArea.MainLocationArea.locationArea, p => p.Name == PokemonEncounters[count][i].LocationArea.Name);
                    }

                    loadEncounters = false;

                #endregion

                #region EncounterDetails && ConditionValue

                for (int i = 0; i < PokemonEncounters[count].Length;i++)
                {
                    for(int j = 0; j < PokemonEncounters[count][i].VersionDetails.Count; j++)
                    {
                        #region EncounterDetails

                        for (int k = 0; k < PokemonEncounters[count][i].VersionDetails[j].EncounterDetails.Count;k++)
                        {
                            PokemonEncounters[count][i].VersionDetails[j].EncounterDetails[k].EncounterMethod = Array.Find(Entities.EncounterMethod.MainEncounterMethod.encounterMethod, p => p.Name == PokemonEncounters[count][i].VersionDetails[j].EncounterDetails[k].Method.Name);
                        }

                        #endregion

                        #region  ConditionValue

                        for (int k = 0; k < PokemonEncounters[count][i].VersionDetails[j].EncounterDetails.Count;k++)
                        {

                            for (int l = 0; l < PokemonEncounters[count][i].VersionDetails[j].EncounterDetails[k].ConditionValues.Count;l++)
                            {
                                PokemonEncounters[count][i].VersionDetails[j].EncounterDetails[k].ConditionValue = Array.Find(Entities.EncounterConditionValue.MainEncounterConditionValue.encounterConditionValue, p => p.Name == PokemonEncounters[count][i].VersionDetails[j].EncounterDetails[k].ConditionValues[l].Name);
                            }
                        }

                        #endregion
                    }
                }

                #endregion
            }
        }
    }
}