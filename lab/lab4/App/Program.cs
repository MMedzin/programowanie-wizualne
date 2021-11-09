using System;
using workerLib;
using System.Linq;

namespace App
{
    class Program
    {
        static void Main(string[] args)
        {
            // Projekt proj = new Projekt("projekt1");
            // proj.Add(new Pracownik(){
            //     Name="pracownik1", Salary=100
            //     });
            // proj.Add(new Pracownik(){
            //     Name="pracownik2", Salary=10000
            //     });
            // System.Console.WriteLine(proj.Budget);
            // foreach (var p in proj.Pracownicy)
            // {
            //     System.Console.WriteLine(p.Name);
            // }
            int[] arr = {0, 1, 2, 3, 4, 5, 6, 7, 7};
            foreach (var num in arr.Where(i => (i%2) == 1))
            {
                System.Console.WriteLine(num);
            }
        }
    }
}
