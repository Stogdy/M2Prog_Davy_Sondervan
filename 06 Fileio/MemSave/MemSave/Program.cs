using System;
using System.IO;

class Program
{
    static void Main()
    {
        Run();
    }

    static void Run()
    {
        {
            string welkomstTekst = "Hello world";
            string saveFile = "welkomState.txt";

           
            if (File.Exists(saveFile))
            {
                
                welkomstTekst = File.ReadAllText(saveFile);
            }

            
            Console.WriteLine(welkomstTekst);

           
            while (true)
            {
                
                Console.WriteLine(welkomstTekst);

                
                Console.WriteLine("TEST!");

                
                welkomstTekst = Console.ReadLine();

                
                File.WriteAllText(saveFile, welkomstTekst);
            }
        }

    }
}

