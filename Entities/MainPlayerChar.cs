namespace ScientistPokemon.Entities
{
    public class MainPlayerChar
    {
        public string name;
        public string surname;
        public int dayOfBirthday;
        public int monthOfBirthday;
        public int yearOfBirthday;

        public MainPlayerChar(string name, string surname, int dayOfBirthday, int monthOfBirthday, int yearOfBirthday)
        {
            this.name = name;
            this.surname = surname;
            this.dayOfBirthday = dayOfBirthday;
            this.monthOfBirthday = monthOfBirthday;
            this.yearOfBirthday = yearOfBirthday;
        }
        public MainPlayerChar()
        {
        }

        public override string ToString()
        {
            return this.name + " " + this.surname + " " + this.dayOfBirthday + "/" + this.monthOfBirthday + "/" + this.yearOfBirthday;
        }
    }
}