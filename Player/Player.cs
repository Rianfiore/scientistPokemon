using System;
using ScientistPokemon.WorldLocation;

namespace ScientistPokemon.Player
{
    public class PlayerChar
    {
        public string name;
        public string surname;
        public int dayOfBirthday;
        public int monthOfBirthday;
        public int yearOfBirthday;

        public LocationArea localPosition;

        public PlayerPokedex pokedex;

        public PlayerChar(string name, string surname, int dayOfBirthday, int monthOfBirthday, int yearOfBirthday)
        {
            this.name = name;
            this.surname = surname;
            this.dayOfBirthday = dayOfBirthday;
            this.monthOfBirthday = monthOfBirthday;
            this.yearOfBirthday = yearOfBirthday;
        }

        public override string ToString()
        {
            return this.name + " " + this.surname + " " + this.dayOfBirthday + "/" + this.monthOfBirthday + "/" + this.yearOfBirthday;
        }
    }

    public class configProprieties
    {
        public static PlayerChar player1;
        public static void newChar()
        {

            Console.WriteLine("Qual é o seu nome?");
            Console.WriteLine();
            string name = Console.ReadLine();
            Console.Clear();

            Console.WriteLine("Qual é o seu sobrenome?");
            Console.WriteLine();
            string surname = Console.ReadLine();
            Console.Clear();

            Console.WriteLine("Que dia você nasceu?");
            Console.WriteLine();
            int day = Int32.Parse(Console.ReadLine());
            Console.Clear();

            Console.WriteLine("Que mês você nasceu?");
            Console.WriteLine();
            int month = Int32.Parse(Console.ReadLine());
            Console.Clear();

            player1 = new PlayerChar(name, surname, day, month, 1999);

        }

        public void saveChar()
        {
            
        }

        public PlayerChar loadChar()
        {
            return player1;
        }

        public void deleteChar()
        {

        }

        public void editChar()
        {

        }        
    }
    
    public class PlayerPosition
    {
      public static void setInitialPlayerPosition(LocationArea locationArea)
        {
            configProprieties.player1.localPosition = locationArea;
        }

        LocationArea currentPlayerPosition (PlayerChar player)
        {
            return player.localPosition;
        }
    }
}