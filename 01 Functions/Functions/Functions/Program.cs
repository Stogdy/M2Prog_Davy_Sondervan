using System.Net.Sockets;

namespace Functions
{
    internal class Program
    {
        static void Main(string[] args)//Return
        {
            Program program = new Program();//New program
            program.Run(); //Run


        }
        internal void Run()
        {
            Console.WriteLine("Dit is nu de start van mijn programma");


        }


        internal void Vraag1()
        {

            Console.WriteLine("How long do you think you'd survive in a zombie apocalypse?");

            string antwoord = Console.ReadLine();

            Console.WriteLine(antwoord);
        }

            internal void Vraag2()
            { 
                
                Console.WriteLine("What secret conspiracy would you like to actually start letting other people know?");

                string antwoord = Console.ReadLine();

                Console.WriteLine(antwoord);
            }
       internal void Vraag3()
        {

            Console.WriteLine("Why do round pizzas come in square boxes?");

            string antwoord = Console.ReadLine();

            Console.WriteLine(antwoord);


        }
        internal void Vraag4()
        {

            Console.WriteLine("Has someone caught you dancing in front of the mirror?");

            string antwoord = Console.ReadLine();

            Console.WriteLine(antwoord);
        }

            
            internal void Vraag5()
            {

                Console.WriteLine("What would you call a male ladybug?");

                string antwoord = Console.ReadLine();

                Console.WriteLine(antwoord);
            }

        }

        }
    

    

