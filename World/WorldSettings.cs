using System;
using System.Globalization;
using System.Threading;

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
            Console.WriteLine("Aguarde! Estamos criando um novo mundo...");
            //Data.dataFiles.loadAllContents();
            //Data.dataFiles.isLoadedContents = true;
            //Data.dataFiles.loadAllContents();
            WorldTime.newWorldTime();
            Console.WriteLine("Mundo criado!");
        }
    }

    internal class WorldTime
    {
        public static CultureInfo ptbr;
        public static DateTime dateWorld;
        public static void newWorldTime()
        {
            ptbr = new CultureInfo("pt-BR");
            dateWorld = new DateTime(2021, 1, 5, 12, 45, 0, new GregorianCalendar());
        }

        public static void showCalendar()
        {
            Console.WriteLine(dateWorld.ToString("f", ptbr));
            //Console.WriteLine( $"{dateWorld.DayOfWeek} - Dia {dateWorld.Day} de {dateWorld.Month} de {dateWorld.Year} - {dateWorld.Hour}:{dateWorld.Minute}");
        }
    }
}