using System.Collections.Generic;

namespace ScientistPokemon.WorldLocation
{
    public class Region
    {
        public int id;

        public string name;

        public List<City> cities = new List<City>();
        public Region(int id, string name)
        {
            this.id = id;
            this.name = name;
            createAllCities(name);
        }

        void createAllCities(string regionName)
        {
            City pallettown = new City(1,"Cidade de Pallet", regionName);
            cities.Add(pallettown);
        }
    }
}