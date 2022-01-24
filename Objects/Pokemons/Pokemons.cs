using System;
using ScientistPokemon.Entities.Pokemon;

namespace Objects
{
    public class Pokemon
    {
        public MainPokemon pokemonBase;
        public int rarityValue, rarityRelativeValue;

        public Pokemon(string name, int rarityValue)
        {
            pokemonBase = Array.Find(MainPokemon.pokemon, p => p.Name == name);
            this.rarityValue = rarityValue;
        }
        
    }
}