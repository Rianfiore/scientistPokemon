using System;
using System.Globalization;
using ScientistPokemon.GameProperties;
using ScientistPokemon.Player;

namespace ScientistPokemon.World
{
    internal class WorldSettings
    {
        public static void timer (int time)
        {
            System.Threading.Thread.Sleep(1000);
        }
        private protected static void createNewWorld()
        {
            Console.WriteLine("Aguarde! Estamos criando o mundo...");
            Data.dataFiles.loadAllContents();
            Data.dataFiles.isLoadedContents = true;
            Data.dataFiles.loadAllContents();
            WorldTime.newWorldTime();
            World.WorldLocation world = new World.WorldLocation();
            Console.WriteLine("Mundo criado!");
            InGame.enterNewGame(world, WorldTime.dateWorld, configProprieties.player1);
        }
    }

    internal class WorldTime
    {
        public static CultureInfo ptbr;
        public static DateTime dateWorld;
        public static DateTime newWorldTime()
        {
            ptbr = new CultureInfo("pt-BR");
            dateWorld = new DateTime(2021, 1, 5, 12, 45, 0, new GregorianCalendar());
            return dateWorld;
        }

        public static void showCalendar(DateTime date)
        {
            Console.WriteLine(date.ToString("f", ptbr));
        }
    }
}