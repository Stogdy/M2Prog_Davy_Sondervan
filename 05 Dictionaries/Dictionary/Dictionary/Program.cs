using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        Run();
    }

    static void Run()
    {
        Dictionary<int, string> personen = new Dictionary<int, string>();

        personen.Add(1, "Jan");
        personen.Add(2, "Piet");
        personen.Add(3, "Tim");

        
        Console.WriteLine("Sleutels:");
        foreach (var key in personen.Keys)
        {
            Console.WriteLine(key);
        }

       
        Console.WriteLine("\nWaarden:");
        foreach (var value in personen.Values)
        {
            Console.WriteLine(value);
        }
    }

}
        
    

