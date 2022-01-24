using System.Collections.Generic;
using ScientistPokemon.WorldLocation;

namespace ScientistPokemon.World
{
    public class WorldLocation
    {
        public List<Region> regions = new List<Region>();
        public List<City> cities = new List<City>();
        public List<LocationArea> locationAreas = new List<LocationArea>();

        public WorldLocation ()
        {
            createAll();
        }

        void createAll()
        {
            createAllRegions();
            createAllCities();
            createAllLocationAreas();
        }
        void createAllRegions()
        {
            Region kanto = new Region(1,"Kanto");
            regions.Add(kanto);

        }

        void createAllCities()
        {
            City palletTown = new City(1, "Cidade de Pallet", "Kanto");
            cities.Add(palletTown);
        }

        void createAllLocationAreas()
        {
            LocationArea palletTownArea  = new LocationArea(1, "Área da Cidade de Pallet");
            locationAreas.Add(palletTownArea);
        }
    }
}