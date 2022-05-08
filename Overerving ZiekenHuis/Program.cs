using System;

namespace Overerving_ZiekenHuis
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Patient jose = new Patient() { AantalUrenInZiekenHuis = 10, Naam = "jose" };
            VerzekerdePatient leo = new VerzekerdePatient() { AantalUrenInZiekenHuis = 10, Naam = "leo" };


            jose.ToonInfo();
            leo.ToonInfo();
        }
    }
}
