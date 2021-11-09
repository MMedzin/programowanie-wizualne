using System;

namespace WorkersLib
{
    public sealed class OfficeWorker : Worker 
    {
        public OfficeWorker(String name, String surname, System.DateTime birthDate): base(name, surname, birthDate)
        { }

    }
    
}