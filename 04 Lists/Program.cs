namespace ForHerhaling
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double[] prijzen = new double[] { 0.99, 5.60, 10.11,};
            string[] artikelen = { "Snoepje, Luxe Broodje, Lunch Menu" };

            Formulier[] formulieren = new Formulier[2];

            formulieren[0] = new Formulier()
            {
                Feedback = "prijzig maar lekker",
                Sterren = 5
            };
            
            for (int i = 0; i< prijzen.Length; i++)
            {
                Console.WriteLine(prijzen[i]);
            }
        }

            internal class Formulier
        {
            internal int Sterren { get; set; }
            internal string Feedback { get; set; }
        }
    
    }
}
    

