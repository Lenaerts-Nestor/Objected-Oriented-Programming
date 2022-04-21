using System;

namespace Arrays_en_Klassen
{
    internal class computeronderdeel
    {
        //autoproperties:
        public int Prijs { get; set; }
        public int ID { get; set; }
        public bool InDoos { get; set; }

        //default constructor
        public computeronderdeel()
        {
            Random rand = new Random();
            Prijs = rand.Next(1, 1001);
            ID = rand.Next(1, 1000);

            if (rand.Next(1, 10) > 5)
            {
                InDoos = true;
            }

        }
        //Methode

        public void ToonInfo()
        {
            Console.WriteLine($"\nPrijs:\t\t{Prijs}");
            Console.WriteLine($"ID:\t\t{ID}");
            Console.WriteLine($"InDoos:\t\t{InDoos}");
        }






    }
}
