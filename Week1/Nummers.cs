using System;

namespace Week1
{
    class Nummers
    {
        public int Getal1 { get; set; }
        public int Getal2 { get; set; }

        //4 methodens die telkens een int teruggeven, behalve Quotient dat een double teruggeeft

        public int Som()
        {
            return Getal1 + Getal2;
        }
        public int Verschil()
        {
            return Getal1 - Getal2;
        }
        public int Product()
        {
            return Getal1 * Getal2;
        }
        public double Quotient()
        {
            if (Getal1 == 0)
            {
                Console.WriteLine("Kan niet delen door 0");
                return 0.0;
            }
            return Convert.ToDouble(Getal1) / Convert.ToDouble(Getal2);
        }

    }
}
