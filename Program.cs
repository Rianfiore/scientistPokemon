using System;
using ScientistPokemon.GameProperties;
using ScientistPokemon.WorldLocation;


namespace ScientistPokemon
{
    public class Program
    {
        static void Main(string[] args)
        {
            //InitMenu();
            Console.Clear();
            StartGame();
           
        }
        
        internal static void InitMenu()
        {
           initGameOptions initGame = new initGameOptions();
           string userOption = initGame.GetUserOption();

                switch (userOption)
                {
                    case "1":
                    initGame.newGameFile();
                    break;

                    case "2":
                    initGame.loadGameFile();
                    InitMenu();
                    break;

                    case "X":
                    initGame.exitGame();
                    System.Environment.Exit(0);
                    break;

                    default:
                    ScientistPokemon.World.WorldSettings.timer(500);
                    Console.WriteLine("Opção inexistente!");
                    ScientistPokemon.World.WorldSettings.timer(1000);
                    InitMenu();
                    break;
                }
        }
 
        //Implementar Save, Delete e Create File Game
        internal static void StartGame()
        {
            //Implementar uma verificação de continue game ou new game, mas por enquanto sempre será new game

            GameMode.newHistory();

        }
    }

}
