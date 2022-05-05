using System;

namespace Alles_samen_H1_H4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            Mens pablo = new Mens(ogen.Green, geslacht.Man, Convert.ToInt32(178));
            Mens lisa = new Mens(ogen.Blue, geslacht.Vrouw, Convert.ToInt32(158));
            Mens juan = new Mens(ogen.Red, geslacht.Man, Convert.ToInt32(190));


            //dit is zonder de list te gebruiken
            pablo.ToonMens();
            lisa.ToonMens();
            juan.ToonMens();
        }
    }
}
