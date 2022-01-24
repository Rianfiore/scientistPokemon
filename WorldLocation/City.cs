using System.Collections.Generic;

namespace ScientistPokemon.WorldLocation
{
    public class City
    {
        public int id;
        public string name, region;

        public City(int id, string name, string region)
        {
            this.id = id;
            this.name = name;
            this.region = region;
        }

    }
}