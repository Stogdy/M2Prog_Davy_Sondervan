using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Constructors
{
    internal class QuizVraag

    {
        class QuizVraag
        {
            internal string vraag;
            internal string antwoord;

            internal QuizVraag(string vraag, string antwoord)
            {
                this.vraag = vraag;
                this.antwoord = antwoord;
            }
            private void Run();
            QuizVraag quizvraag = new QuizVraag("What 1997 N64 video game, features James Bond and is named after the 1995 film ?", "Answer: GoldenEye");
        }
    }
}