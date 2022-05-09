using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gevorderde_overervingsconcepten_Money
{
    public enum RekeningStaat { Geldig, Geblokeerd };
    public abstract class Rekening
    {
        //Informatie over deze klasse ==>
        ///ik ben BankManager aan het hergruibken van H1
       
        


        /// Het saldo van de rekening wordt in een private variabele bijgehouden
        /// Het saldo noemt balans in deze class, en ze beginnen met 2k om te testen enzo.
        /// \(*.*)/

        private  int balans = 2000;
        public  int Balans
        {
            get
            {
                return balans;
            }
        }

        public string NaamKlant { get; set; }
        public string RekeningNummer { get; set; }

        //enum methode
        public RekeningStaat Staat { get; private set; } = RekeningStaat.Geldig;
        //methoden
        public int HaalGeldAf(int bedrag)
        {
            if (Staat == RekeningStaat.Geldig)
            {
                if (bedrag > balans)
                {
                    int ovegebleefBalans = balans;
                    balans = 0;
                    Console.WriteLine("Rekening leeg nu");
                    VeranderStaat();
                    return ovegebleefBalans;
                }
                else
                {
                    balans -= bedrag;
                    return bedrag;
                }
            }
            else
            {
                Console.WriteLine("gaat niet, rekening geblokeerd");
                return 0;
            }

        }

        public void StortGeld(int bedrag) //dit is VoegGeldToe
        {

            if (Staat == RekeningStaat.Geldig)
            {
                balans += bedrag;
            }
            else
            {
                Console.WriteLine("Gaat niet. Rekening geblokkeerd.");
            }
        }

        public RekeningStaat VeranderStaat()
        {
            if (Staat == RekeningStaat.Geldig)
            {
                Staat = RekeningStaat.Geblokeerd;
                return Staat;
            }
            else
            {
                Staat = RekeningStaat.Geldig;
                return Staat;
            }
        }
        public void ToonInfo()
        {
            Console.WriteLine($"Naam:\t {NaamKlant}");
            Console.WriteLine($"RekeningsNr:\t {RekeningNummer}");
            Console.WriteLine($"Balans:\t {balans}");

        }

        //abstracte methode BerekenRente 


        public abstract double BerekenRente();
    }

    public class BankRekening : Rekening
    {
        public override double BerekenRente()
        {
            double PercentageRente = 0.05; //5%
            if (base.Balans > 100)
            {
                return Balans + (Balans * PercentageRente); 
            }
            else
            {
                return 0;                   //0%    
            }
        }
    }

    public class SpaarRekening : Rekening
    {
        double PercentageRente = 0.02;      //2%
        public override double BerekenRente()
        {
            /// in deze geval geven we het voledige bedrag terug + de korting , herrinner balans is 2k in het begin
            /// dus er word 40(2% van 2k) euro derbij toegevoegd want het is rente.
            return Balans + (Balans*PercentageRente);
            

        }
    }

   public class ProRekening : SpaarRekening
    {
        public override double BerekenRente()
        {
            int XDuizende = (int)Balans / 1000; //dit gaat tellen hoeveel duizende er is;
            return base.BerekenRente() + XDuizende * 10; //de base is want je refereert naar de spaarRekening berekenRente
        }
    }

}
