using System.Collections.Generic;

namespace Objects
{
    public class PokemonSpawnValues
    {
        int spawnValue;
        Pokemon pokemon;

        PokemonSpawnValues (Pokemon pokemon, int spawnValue)
        {
            this.pokemon = pokemon;
            this.spawnValue = spawnValue;
        }
    }
    public class EncounterMethod
    {
        public string locationName;
        public List<string> typeEffectPrimary, typeEffectSecundary;

        public List<PokemonSpawnValues> pokemonSpawnValues;

        public EncounterMethod(List<Pokemon> pokemonEncounters, string locationName, List<string> typeEffectPrimary, List<string> typeEffectSecundary)
        {
            this.locationName = locationName;
            this.typeEffectPrimary = typeEffectPrimary;
            this.typeEffectSecundary = typeEffectSecundary;
        }
        
    }
}