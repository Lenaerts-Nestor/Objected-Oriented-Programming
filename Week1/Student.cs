using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week1
{
    enum Klassen { TI1, TI2, TI3, TI4 }
    class Student
    {
        //6 autopropperties
        public string Naam { get; set; }
        public int Leeftijd { get; set; }

        public Klassen Klas { get; set; } 
        public int PuntenCommunicatie { get; set; }
        public int PuntenProgrammingPrinciples { get; set; }
        public int PuntenWebTech { get; set; }

        //methode 
        
        public double BerekenTotaalCijfer()
        {
            double bedrag = Convert.ToDouble(PuntenCommunicatie + PuntenProgrammingPrinciples + PuntenWebTech) / 3;
            return Math.Round(bedrag, 1);

        }

        public void GeefOverzicht()
        {
            Console.WriteLine("Rapport");
            Console.WriteLine("*******");

            Console.WriteLine($"Naam: {Naam} ");
            Console.Write($"Leeftijd: {Leeftijd}");
            Console.WriteLine($"Klas: {Klas}\n");
            Console.WriteLine($"Punten: ");
            Console.WriteLine($"Communicatie:               {PuntenCommunicatie}");
            Console.WriteLine($"Programming Principles:     {PuntenProgrammingPrinciples}");
            Console.WriteLine($"WebTech:                    {PuntenWebTech}\n");
            Console.WriteLine($"Gemiddelde: {BerekenTotaalCijfer()}");
        }

    }
}
