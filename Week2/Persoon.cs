using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week2
{
    class Persoon
    {
        public string Voornaam { get; set; }
        public string Achternaam { get; set; }

        private DateTime GetDate;

        public DateTime geboorteDatum
        {   
            get { return GetDate; }
            set
            {
                if (value > new DateTime(1/1/1990) && value < DateTime.Today)
                {
                    GetDate = value;
                }
                else
                {
                    GetDate = DateTime.Today;

                }
            }
        }

        public int BerekenLeeftijd()
        {

            int leeftijd = DateTime.Now.Year - geboorteDatum.Year;

            if (DateTime.Now.Month < geboorteDatum.Month || (DateTime.Now.Month == DateTime.Now.Month && DateTime.Now.Day < geboorteDatum.Day))
                leeftijd--;

            return leeftijd;
        }

        private int myVar;

        public int MyProperty
        {
            get { return myVar; }
            set { myVar = value; }
        }

        
    }
}
