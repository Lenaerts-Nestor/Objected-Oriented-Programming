using System;

namespace H2_Program__main_
{
    class Program
    {
        static void Main(string[] args)
        {
            

            //om te testen de eerste deel, de nummers verander randomly.
            Bankmanager_2 eersteRekening = new Bankmanager_2();
            Bankmanager_2 tweedeRekening = new Bankmanager_2();
            eersteRekening.NaamKlant = "Pedro";
            tweedeRekening.NaamKlant = "Leo";
            eersteRekening.SimuleerOverdtacht(eersteRekening, tweedeRekening);

            //het deel van de Tiener
            Bankmanager_2 TienerAccounts = new Bankmanager_2();
            Bankmanager_2 Luciana = TienerAccounts.CreerTienerRekening("luciana");
            Luciana.ToonInfo();
            

        }
    }
}
