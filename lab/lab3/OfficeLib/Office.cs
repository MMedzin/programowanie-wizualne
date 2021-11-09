using System;
using Printables;
using WorkersLib;
using System.Collections;

namespace OfficeLib
{
    public class Office: IEnumerable
    {
        IPublicPrintable[] tab;

        public Office()
        {
            tab = new IPublicPrintable[]
            {
                new Manager("Manager", "Nr_1", System.DateTime.Now),
                new Manager("Manager", "Nr_2", System.DateTime.Now),
                new Manager("Manager", "Nr_3", System.DateTime.Now),
                new Supervisor("Supervisor", "Nr_1", System.DateTime.Now),
                new Supervisor("Supervisor", "Nr_2", System.DateTime.Now),
                new Supervisor("Supervisor", "Nr_3", System.DateTime.Now),
            };
        }

        public IEnumerator GetEnumerator()
        {
            return tab.GetEnumerator();
        }

        public IEnumerator GetCounterAlphabetical()
        {
            for (int i = tab.Length; i >= 0; i--)
            {
                yield return tab[i];
            }
        }
    }
}
