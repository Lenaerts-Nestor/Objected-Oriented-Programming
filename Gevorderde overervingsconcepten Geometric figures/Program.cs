using System;

namespace Gevorderde_overervingsconcepten_Geometric_figures
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            //Testen Geometric oefening
            Rechthoek pedro = new Rechthoek();
            pedro.Hoogte = 10;
            pedro.Breedte = 3;

            Console.WriteLine(pedro.Oppervlakte);
        }
       
    }
}
