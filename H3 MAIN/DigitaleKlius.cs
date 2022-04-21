using System;

namespace H3_MAIN
{
    class DigitaleKlius
    {


        private int code;

        public DigitaleKlius(int startcode)
        {
            Code = startcode;
        }

        public int Code
        {
            get
            {
                if (CanShowCode == true)
                {
                    return code;
                }
                else
                {
                    return -666;
                }
            }
            private set { code = value; }
        }


        public bool CanShowCode { get; set; }


        public int CodeLevel
        {
            get { return Code / 1000; }

        }

        //Een private variabele aantalPogingen om bij te houden hoe vaak de gebruiker geprobeerd heeft de code te vinden.

        private int aantalPogingen;


        public bool TryCode(int testcode)
        {
            if (aantalPogingen < 10)
            {
                aantalPogingen++;
                if (testcode == -666)
                {
                    Console.WriteLine("CHEATER");
                    return false;
                }
                else if (testcode == code)
                {
                    Console.WriteLine($"Deze code is geldig. Aantalpogingen = {aantalPogingen}");
                    return true;
                }
                Console.WriteLine("Dat is geen geldige code");

            }
            else
                Console.WriteLine("Je hebt je 10 pogingen opgebruikt.Sorry.");
            return false;
        }

    }
}
