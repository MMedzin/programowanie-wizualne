using System;
using Printables;

namespace WorkersLib
{
    public abstract class Worker: IPrintable, IPublicPrintable
    {
        public String Name;
        public String Surname;
        public System.Guid ID { get; set; } = System.Guid.NewGuid();
        public System.DateTime BirthDate;

        public Worker(String name, String surname, System.DateTime birthDate)
        {
            this.Name = name;
            this.Surname = surname;
            this.BirthDate = birthDate;

        }

        public override String ToString()
        {
            return $"Name: {Name}\n Surname: {Surname}\n ID: {ID}\n Date of birth: {BirthDate}";
        }

        public void GenerateNewID()
        {
            ID = System.Guid.NewGuid();
        }

        void IPrintable.Print()
        {
                System.Console.WriteLine($"{ID}");
        }

        void IPublicPrintable.Print()
        {
            System.Console.WriteLine(":))");
        }
    }
}
