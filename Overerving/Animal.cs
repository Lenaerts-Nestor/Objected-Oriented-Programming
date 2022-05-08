using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Overerving
{
    class Animal        //DIT is het Parent section
    {
        public bool Alive { get; set; }
        public virtual void ToonInfo()
        {
            Console.WriteLine("\n");
            Console.WriteLine($"This is a Animal right?  {Alive}");
        }
    }


    //Mammal Section
    class Mammal : Animal       //Parent Animal
    {
        public string TypeOfBlood { get; set; } = "red";
        public override void ToonInfo()
        {
            base.ToonInfo();
            Console.WriteLine($"This is kind of Animal has a {TypeOfBlood} type of blood");
        }
    }

    class Rabbit : Mammal
    {
        public string size { get; set; } = "smal";
        public override void ToonInfo()
        {
            base.ToonInfo();
            Console.WriteLine($"this is a Rabit and its size is {size}");
        }
    }
    class Cow : Mammal
    {
        public string Naam { get; set; } = "Pedro";
        public override void ToonInfo()
        {
            base.ToonInfo();
            Console.WriteLine($"this is a Cow and its name is {Naam}");
        }
    }
    class Dog : Mammal
    {
        public string Naam { get; set; }
        
        public override void ToonInfo()
        {
            
            base.ToonInfo();
            Console.Write($"deze honds naam is: ");
            Console.ForegroundColor = ConsoleColor.Green;
            Console.Write(Naam);
            Console.ResetColor();

        }
    }


    

    //Reptile Section (zelfde doen zoals die van Mamals...)
    class Reptile : Animal      
    {

    }

}
