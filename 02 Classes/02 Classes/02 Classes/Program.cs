namespace _02_Classes
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Program program = new Program();
            program.run();

        }

        internal void run()




        {


            Auto auto1 = new Auto()
            {
                automaat = true,
                kenteken = "AA824H",
                kilometerStand = 20567,
                merk = "volkswagen"

            };

            Auto auto2 = new Auto()

            {
                automaat = false,
                kenteken = "KU786G",
                kilometerStand = 65739,
                merk = "volvo"
            };

            Rijleraar rijleraar = new Rijleraar()
            {
                leeftijd = 30,
                naam = "John",
                zzp = false
            };
            LesUur LesUur = new LesUur()
            {
                auto = auto1,
                rijleraar = new Rijleraar(),

                tijd = 1130

            };
            
            Student student = new Student();
            
            {
                lespakket = new LesPakket(),
                theorietest = new TheorieTest(),
                rijtest = new RijTest(),
            };
        }
    }
    

