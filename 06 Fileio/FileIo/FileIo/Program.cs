



static void Run()
{
    // Pad naar quiz.txt (naast de .exe)
    string quizFilePath = "quiz.txt";

    // Check of het bestand quiz.txt bestaat
    if (File.Exists(quizFilePath))
    {
        string[] quizLines = File.ReadAllLines(quizFilePath);
        Console.WriteLine("Inhoud van quiz.txt:");
        for (int i = 0; i < quizLines.Length; i++)
        {
            Console.WriteLine($"Regel {i + 1}: {quizLines[i]}");
        }
    }
    else
    {
        Console.WriteLine("Het bestand 'quiz.txt' is niet gevonden.");
    }

    // Pad naar news.txt (naast de .exe)
    string newsFilePath = "news.txt";

    // Check of het bestand news.txt bestaat
    if (File.Exists(newsFilePath))
    {
        string[] newsLines = File.ReadAllLines(newsFilePath);
        Console.WriteLine("\nInhoud van news.txt:");
        for (int i = 0; i < newsLines.Length; i++)
        {
            Console.WriteLine($"Regel {i + 1}: {newsLines[i]}");
        }
    }
    else
    {
        Console.WriteLine("Het bestand 'news.txt' is niet gevonden.");
    }
}
