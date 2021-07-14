using System;

namespace ScientistPokemon.GameProperties
{
    internal class GameFile
    {
        protected static void newGameFile()
        {
            Console.WriteLine("Escreva o nome do arquivo: ");
            Console.WriteLine();
            string fileName = Console.ReadLine();
        }
    }
}