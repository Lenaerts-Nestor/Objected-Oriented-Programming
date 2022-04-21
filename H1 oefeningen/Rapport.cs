using System;

namespace H1_oefeningen
{
    class Rapport
    {
        public int Percentage { get; set; }
        public void PrintGraad()
        {
            if (Percentage < 50)
            {
                Console.WriteLine("niet geslaagd");
            }
            else if (Percentage >= 50 && Percentage <= 68)
            {
                Console.WriteLine("Voldoende");
            }
            else if (Percentage > 68 && Percentage <= 75)
            {
                Console.WriteLine("Onderscheiding");
            }
            else if (Percentage > 75 && Percentage <= 85)
            {
                Console.WriteLine("Grote Onderscheiding");
            }
            else if (Percentage > 85)
            {
                Console.WriteLine("Grootste Onderscheiding");
            }
        }




    }
}
