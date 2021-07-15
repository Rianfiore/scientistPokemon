using System;
using ScientistPokemon.Entities.EncounterMethod;

namespace ScientistPokemon.Object.EncounterMethods
{
    public class EncounterMethodObject
    {
        public string locationName;
        public string[] typeEffectPrimary;
        public string[] typeEffectSecundary;

        public EncounterMethodObject(string locationName, string[] typeEffectPrimary, string[] typeEffectSecundary)
        {
            this.locationName = locationName;
            this.typeEffectPrimary = typeEffectPrimary;
            this.typeEffectSecundary = typeEffectSecundary;
        }
        
    }
}