using System;

namespace WorkersLib
{
    public class Supervisor : Manager
    {
        public Supervisor(string name, String surname, System.DateTime birthDate) : base(name, surname, birthDate)
        {
            System.Console.WriteLine("Constructing supervisor");
            role = "Supervisor";
        }

    }
}