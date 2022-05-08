using System;

namespace Gevorderde_overervingsconcepten
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Boek perdro = new Boek();
            perdro.ISBN = 1546;
            perdro.Auteur = "Pedro";
            perdro.Prijs = 15;

            Boek leo = new Boek();
            leo.ISBN = 987;
            leo.Auteur = "Leo";
            leo.Prijs = 23;

            TextBoek kinderenOnderDeBuss = new TextBoek();
            kinderenOnderDeBuss.ISBN = 17;
            kinderenOnderDeBuss.Auteur = "Romaanse";
            kinderenOnderDeBuss.Prijs = 19;
            
            KoffietafelBoek koffie = new KoffietafelBoek();
            koffie.ISBN = 987789;
            koffie.Auteur = "Sofia";
            koffie.Prijs = 98;


            
            Console.WriteLine(Boek.TelOp(perdro, leo).ToString());

        }
    }
}
