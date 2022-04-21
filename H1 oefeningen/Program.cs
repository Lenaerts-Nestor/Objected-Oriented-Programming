using System;
using System.Collections.Generic;
namespace H1_oefeningen
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            List<Student> studentenVanAP = new List<Student>()
            {
                new Student() {Naam = "nestor", Klas = Klassen.TI1, Leeftijd = 14 , PuntenCommunicatie = 16, PuntenProgrammingPrinciples = 7, PuntenWebTech = 18 },
                new Student() { Naam = "lora", Klas = Klassen.TI2, Leeftijd = 17, PuntenCommunicatie = 17, PuntenProgrammingPrinciples = 4, PuntenWebTech = 13 },
                new Student() { Naam = "nana", Klas = Klassen.TI3, Leeftijd = 19, PuntenCommunicatie = 4, PuntenProgrammingPrinciples = 15, PuntenWebTech = 11 }
            };

            foreach (var item in studentenVanAP)
            {
                item.GeefOverzicht();
                Console.WriteLine("\n\n");
            }
            int[] array1 = new int[];


            array1[0] = 12768;
            array1[2] = 6;
            array1[1] = 165;

        }
    }
}