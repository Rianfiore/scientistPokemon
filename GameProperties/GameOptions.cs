using System;
using System.Threading;
using ScientistPokemon.World;

namespace ScientistPokemon.GameProperties
{
    internal class initGameOptions : WorldSettings
    {
        public string GetUserOption()
        {
            Console.WriteLine();
            Console.WriteLine("Escolha sua opção:");
            timer(1000);

            Console.WriteLine("1- Novo jogo");
            Console.WriteLine("2- Carregar jogo");
            Console.WriteLine("X- Sair do Jogo");
            Console.WriteLine();

            string userOption = Console.ReadLine().ToUpper();
            Console.WriteLine();
            return userOption;
        }
        public void newGameFile()
        {
            timer(500);
            Console.WriteLine("Criando novo jogo!");
            timer(1000);
            
        }

        public void loadGameFile()
        {
            //Implementar load game
            timer(500);
            Console.WriteLine("Não há jogo salvo!");
            timer(1000);
            
        }

        public void exitGame()
        {
            Console.WriteLine("Saindo...");
            timer(500);
        }
    }
}