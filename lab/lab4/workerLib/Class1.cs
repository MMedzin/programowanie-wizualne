using System;
using System.Collections.Generic;

namespace workerLib
{
    public class Pracownik
    {
        public string Name{get; set;}
        public int Salary{get; set;}
    }

    public class Projekt
    {
        public string Name{get; set;}
        public int Budget{get; set;}
        public List<Pracownik> Pracownicy{get; set;}
        
        public event BudgetExceededHandler budgetExceededHandlers;

        public Projekt(string name)
        {
            Name = name;
            Budget = 0;
            Pracownicy = new List<Pracownik>{};
            budgetExceededHandlers += BudgetExceeded;
        }
        
        public void Add(Pracownik p)
        {
            Budget = budgetExceededHandlers(Budget + p.Salary);
            Pracownicy.Add(p);
        }

        private int BudgetExceeded(int amount)
        {
            if (amount > 1000) 
            {
                return 1000;
            }
            return amount;
        }
    }

    public delegate int BudgetExceededHandler(int amount);

}
