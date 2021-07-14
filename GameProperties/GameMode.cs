using System;
using ScientistPokemon.World;

namespace ScientistPokemon.GameProperties
{
    internal class GameMode : WorldSettings
    {
        internal static void newHistory()
        {
            Console.WriteLine("Contando história do mundo...");
            timer(1000);
            //Criar uma intro aqui

            Console.Clear();

            Player.PlayerChar.newChar();

            Console.WriteLine("Te explicando a sua importância no mundo pokemon...");
            timer(1000);

            

            //Implementar as entities do mundo, tais como seus objs etc
            createNewWorld();

        }
    }
}