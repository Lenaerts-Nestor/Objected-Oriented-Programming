using System;

namespace H2_Program__main_
{
    class Program
    {
        static void Main(string[] args)
        {

            Pokemon pikachu = new Pokemon();
            pikachu.Naam = "Pickachu";
            pikachu.SpecialAttack_Base = 3;
            pikachu.Attack_Base = 5;
            pikachu.Defense_Base = 4;
            pikachu.HP_Base = 15;
            pikachu.SpDefense_Base = 7;




            //level-up tester

            for (int i = 0; i < 50; i++)
            {
                pikachu.ShowInfo();
                pikachu.VerhoogLevel();
                Console.WriteLine("\n");
            }



        }
    }
}
