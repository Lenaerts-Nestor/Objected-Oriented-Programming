namespace Week2
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            //Verjaardag
            Console.WriteLine("Wanneer is je verjaardag (d/m, bv 18/3)");
            DateTime verj = DateTime.Parse(Console.ReadLine());

            //als zijn verjaardag al voorbij is
            if(verj < DateTime.Today)
            {
                
                TimeSpan volgendeverjaardag = verj.AddYears(1) - DateTime.Today;
                Console.WriteLine($"mijn verjaardag is binnen: {volgendeverjaardag.Days} Dagen op een {verj.DayOfWeek}");
                
            }
            //verjaardag is nog niet voorbij
            else
            {
                TimeSpan verjaardag = verj - DateTime.Today ;                          //dag staat in engels
                Console.WriteLine($"Je bent over {verjaardag.Days} dagen jarig op een {verj.DayOfWeek} ");
            }

            Console.Clear();
            //rekening 2 geeft 300 euro aan rekening 1
            Rekening rekening1 = new Rekening();
            Rekening rekening2 = new Rekening();

            rekening1.NaamKlant = "pedro";
            rekening2.NaamKlant = "leo";

            rekening1.RekeningNummer = "BE4587481657";
            rekening2.RekeningNummer = "BE4587481657";

            rekening1.StortGeld(400);
            rekening2.StortGeld(500);

            //rekening 2 geeft 300 euro aan rekening 1
            rekening1.StortGeld(rekening2.HaalGeldAf(300));

            rekening1.ToonInfo();
            Console.WriteLine("\n");
            rekening2.ToonInfo();

            */

            //Persoon
            /*
            Persoon pedro = new Persoon();

            pedro.Achternaam = "luciano";
            pedro.Voornaam = "pedro";
            pedro.geboorteDatum = DateTime.Parse("21/8/2000");

            Console.WriteLine($"leeftijd: {pedro.BerekenLeeftijd()}");
            */


            Sample s = new Sample();
            Sample.fun1();
            s.fun2(123);


        }
    }
}
