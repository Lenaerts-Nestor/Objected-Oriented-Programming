using System;

namespace Week1
{
    class Program
    {
        static void Main(string[] args)
        {
            //Raport oefening
            /*
            Console.WriteLine("Hello World!");
            Rapport mijnpunten = new Rapport();
            mijnpunten.Percentage = 50;
            mijnpunten.PrintGraad();
            */

            //Nummers oefening
            /*
            Nummers paar1 = new Nummers();
            paar1.Getal1 = 12;
            paar1.Getal2 = 34;

            Console.WriteLine("Paar:" + paar1.Getal1 + ", " + paar1.Getal2);
            Console.WriteLine("Som = " + paar1.Som());
            Console.WriteLine("Verschil = " + paar1.Verschil());
            Console.WriteLine("Product = " + paar1.Product());
            Console.WriteLine("Quotient = " + paar1.Quotient());
            */



            //Studentklasse oefening
            /*
            Student student1 = new Student();
            student1.Klas = Klassen.TI1;
            student1.Leeftijd = 21;
            student1.Naam = "Joske Vermeulen";
            student1.PuntenCommunicatie = 12;
            student1.PuntenProgrammingPrinciples = 15;
            student1.PuntenWebTech = 13;

            student1.GeefOverzicht();
            */

            //PizzaTime oefening 
            /*
            Pizza peperonie = new Pizza();
            peperonie.Diameter = 35;
            peperonie.Price = 10.07;
            peperonie.Toppings = "Peperonie";
            peperonie.text();
            */


            //Figuren: Rechthoek

            Rechthoek eerste = new Rechthoek();
            eerste.Lengte = 4;
            eerste.Breedte = 5;
            eerste.ToonOppervlakte();
            Console.WriteLine("\n");
            Driehoek tweede = new Driehoek();

            tweede.Basis = 5;
            tweede.Hoogte = 7;
            tweede.ToonOppervlakte();



        }
    }
}
