using System;

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
        Data.dataFiles.loadAllContents();
        Data.dataFiles.isLoadedContents = true;
        Data.dataFiles.loadAllContents();
        Console.WriteLine("Mundo criado!");
    }
    }
}