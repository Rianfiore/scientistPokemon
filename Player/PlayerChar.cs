using ScientistPokemon.Entities;
using System;

namespace ScientistPokemon.Player
{
    internal class PlayerChar
    {
        public static void newChar()
        {
            MainPlayerChar playerChar = new MainPlayerChar();

            Console.WriteLine("Qual é o seu nome?");
            Console.WriteLine();
            //playerChar.name = Console.ReadLine();
            Console.Clear();

        }

        public void saveChar()
        {
            
        }

        public void loadChar()
        {

        }

        public void deleteChar()
        {

        }

        public void editChar()
        {

        }
    }
}