using System;



class Program
{
    static void Main()
    {
        Run();
    }

    static void Run()
    {
        static void RunPlayer()
        {
            string filePath = "Player.json"; 

            
            string text = File.ReadAllText(filePath);

            
            Player[] players = JsonConvert.DeserializeObject<Player[]>(text);

            
            Console.WriteLine("Players:");
            foreach (var player in players)
            {
                Console.WriteLine($"Name: {player.Name}");
                Console.WriteLine($"Level: {player.Level}");
                Console.WriteLine($"Max HP: {player.MaxHp}");
                Console.WriteLine($"HP: {player.Hp}");
                Console.WriteLine();
            }
        }

    }
}

