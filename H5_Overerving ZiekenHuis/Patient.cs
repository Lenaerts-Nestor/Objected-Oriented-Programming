using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Overerving_ZiekenHuis
{
   
    class Patient
    {
        public string Naam { get; set; }

        public int AantalUrenInZiekenHuis { get; set; } = 0;

        public virtual double BerekenKost()
        {
            double totaalKost = 50 + (20 * AantalUrenInZiekenHuis);
            return totaalKost;
        }
        public void ToonInfo()
        {
            Console.WriteLine(Naam);
            Console.WriteLine($"Aantal uren in het ziekenHuis:{AantalUrenInZiekenHuis}, kost : {BerekenKost()}");
        }
    }

    class VerzekerdePatient : Patient
    {
        private double korting = 0.1;  //dit is 10%
        public override double BerekenKost()
        {
            double totaalbasisKost = base.BerekenKost();
            return totaalbasisKost - (totaalbasisKost * korting);
            
        }
    }

}
