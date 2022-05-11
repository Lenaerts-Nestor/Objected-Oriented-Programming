using System;
using System.Collections.Generic;

namespace H5_HetDierenRijk
{
    internal class Program
    {
        static void Main(string[] args)
        {

            List<Animal> zoo = new List<Animal>(); //gebruik Add
            {
                zoo.Add(new Animal());
                zoo.Add(new Cow());
                zoo.Add(new Dog() { Naam = "lumi", Alive = true, TypeOfBlood = "koud" });
                zoo.Add(new Rabbit());

            }

            foreach (var animal in zoo)
            {
                animal.ToonInfo();
            }

        }
    }
}
