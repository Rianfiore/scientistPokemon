using System;
using System.Collections.Generic;
using ScientistPokemon.Entities.Pokemon;

namespace ScientistPokemon.Object.Pokemons
{
    public class PokemonObject
    {
        public MainPokemon pokemonBase;
        public int rarityValue;

        public PokemonObject(string name, int rarityValue)
        {
            pokemonBase = Array.Find(MainPokemon.pokemon, p => p.Name == name);
            this.rarityValue = rarityValue;
        }
        
    }
}