using System;
using ScientistPokemon.World;
using ScientistPokemon.Player;
using ScientistPokemon.Menu;


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
            Player.configProprieties.newChar();

            Console.WriteLine("Te explicando a sua importância no mundo pokemon...");
            timer(1000);

            

            //Implementar as entities do mundo, tais como seus objs etc
            createNewWorld();

        }
    }

    public class InGame : World.WorldLocation
    {
        public static void enterNewGame(World.WorldLocation world, DateTime dateTime, PlayerChar player)
        {
            PlayerPosition.setInitialPlayerPosition(world.locationAreas[0]);

            LocationAreaMenu.showMenu(player);


        } 
    }
}