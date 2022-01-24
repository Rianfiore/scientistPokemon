using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using Objects;

namespace ScientistPokemon.World
{
    public class WorldAlgorithms
    {
        internal static void CalculateSpawnRate(List<Pokemon> PokemonEncounters, List<EncounterMethod> EncounterMethods, bool FirstTimeLoad)
        {
            DataTable encounterMethodValues = new DataTable();
            int totalPokemons = 0, totalSumPokemons = 0;
            List<Pokemon> pokemonsInEncounterMethods = new List<Pokemon>();
            

            encounterMethodValues.Columns.Add("Encounter Method", typeof(string));
            encounterMethodValues.Columns.Add("TotalPokemons", typeof(int));
            encounterMethodValues.Columns.Add("TotalSumPokemons", typeof(int));
            encounterMethodValues.Columns.Add("Pokemons", typeof(List<Pokemon>));
            
            
            Action<EncounterMethod> action = new Action<EncounterMethod>(eachEncounterMethod);

            EncounterMethods.ForEach(action);

            void eachEncounterMethod (EncounterMethod encounterMethod)
            {
               pokemonsInEncounterMethods = new List<Pokemon>();

               foreach (Pokemon pokemon in PokemonEncounters)
               {
                   foreach (Entities.Pokemon.Type type in pokemon.pokemonBase.Types)
                   {
                       if (encounterMethod.typeEffectPrimary.Find(p => p == type.type.Name) != null)
                       {
                           calculatePrimaryTypes(pokemon, encounterMethod);
                       }

                       if (encounterMethod.typeEffectSecundary.Find(p => p == type.type.Name) != null)
                       {
                           calculateSecundaryTypes(pokemon, encounterMethod);
                       }
                   }
               }

               if (FirstTimeLoad == true)
               {
                   encounterMethodValues.Rows.Add(new object[] {encounterMethod.locationName, totalPokemons, totalSumPokemons, pokemonsInEncounterMethods});
                   pokemonsInEncounterMethods.Clear();
               }
            }

            void calculatePrimaryTypes(Pokemon pokemon, EncounterMethod encounterMethod)
            {
                if (FirstTimeLoad == true)
                {
                    if (encounterMethod.locationName == "Avistamento Aéreo")
                    {
                        while (pokemon.pokemonBase.Moves.Find(p => p.move.Name == "fly")!= null)
                        {
                            totalPokemons++;
                            totalSumPokemons += pokemon.rarityValue;
                            pokemonsInEncounterMethods.Add(pokemon);
                        }
                    }

                }
            }

            void calculateSecundaryTypes(Pokemon pokemon, EncounterMethod encounterMethod)
            {
                if (FirstTimeLoad == true)
                {
                    if (encounterMethod.locationName == "Avistamento Aéreo")
                    {
                        while (pokemon.pokemonBase.Moves.Find(p => p.move.Name == "fly")!= null)
                        {
                            totalPokemons++;
                            totalSumPokemons += pokemon.rarityValue/2;
                            pokemonsInEncounterMethods.Add(pokemon);
                        }
                    }
                }
            }
        }
        
    }
}