using System;

namespace WorkersLib
{
    public class Manager : Worker
    {
        protected String role;
        public Manager(string name, String surname, System.DateTime birthDate) : base(name, surname, birthDate)
        {
            // System.Console.WriteLine("Constructing manager");
            role = "Manager";
        }

        public sealed override String ToString()
        {
            return $"Role: {role}\n" + base.ToString();
        }
    }
}