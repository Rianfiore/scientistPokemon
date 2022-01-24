using System;
using ScientistPokemon.WorldLocation;
using ScientistPokemon.Player;

namespace ScientistPokemon.Menu
{
    public class LocationAreaMenu
    {

        public static string userInput = Console.ReadLine();
        public static void showMenu(PlayerChar player)
        {
            LocationAreaMenuOptions.MainMenu();
            
            switch(userInput)
            {
                case "1":
                    LocationAreaMenuOptions.EncounterMethodOptions();
                    EncounterMethodMenu.showMenu();
                    break;
                
                case "2":
                    player.pokedex.openPokedex();
                    break;

                case "3":
                    //Criar menu de jogo
                    break;
            }
        }
    }

    public class EncounterMethodMenu
    {
        public static void showMenu()
        {

        }
    }
}