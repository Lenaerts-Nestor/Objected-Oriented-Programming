using System;

namespace H1_oefeningen
{
    enum Klassen { TI1, TI2, TI3 }
    class Student
    {
        public string Naam { get; set; }
        public int Leeftijd { get; set; }
        public Klassen Klas { get; set; }

        public int PuntenCommunicatie { get; set; }
        public int PuntenProgrammingPrinciples { get; set; }
        public int PuntenWebTech { get; set; }


        public double BerekenTotaalCijfer()
        {
            return Convert.ToDouble((PuntenCommunicatie + PuntenProgrammingPrinciples + PuntenWebTech) / 3);
        }

        public void GeefOverzicht()
        {
            Console.WriteLine($"Naam: \t {Naam}");
            Console.WriteLine($"leeftijd: \t {Leeftijd}");
            Console.WriteLine($"klass: \t \t {Klas}");

            Console.WriteLine("\nCijferrapport: ");
            Console.WriteLine("***************\n");


            Console.WriteLine($"PP \t\t {PuntenProgrammingPrinciples}");
            Console.WriteLine($"Communicatie: \t {PuntenCommunicatie}");
            Console.WriteLine($"WebTech: \t {PuntenWebTech}");

            Console.WriteLine($"Gemiddelde: \t {BerekenTotaalCijfer()}");


        }

    }
}
