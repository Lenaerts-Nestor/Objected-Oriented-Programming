using System;

namespace H3_MAIN
{
    internal class Program
    {
        private static void Main(string[] args)
        {


            
            DigitaleKlius eerste = new DigitaleKlius(5);

            for (int i = 0; i < 7; i++) //tot 7 om het klein en duidelijk te maken
            {

                eerste.TryCode(i); //het zal een keer geldige zijn en de rest zal geen geldige code zijn

            }

            eerste.TryCode(-666); // om te kijken als de error verschijn van CHEATER




            ;


        }
    }
}