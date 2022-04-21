using System;

namespace H2_Program__main_
{
    class Pokemon
    {
        //Base-Stats: ful properties: Ints
        private int hp_Base;
        private int attack_Base;
        private int defense_Base;
        private int specialAttack_Base;
        private int specialDefense_Base;
        private int speed_Base;

        public int HP_Base
        {
            get { return hp_Base; }
            set { hp_Base = value; }
        }
        public int Attack_Base
        {
            get { return attack_Base; }
            set { attack_Base = value; }
        }
        public int Defense_Base
        {
            get { return defense_Base; }
            set { defense_Base = value; }
        }
        public int SpecialAttack_Base
        {
            get { return specialAttack_Base; }
            set { specialAttack_Base = value; }
        }
        public int SpDefense_Base
        {
            get { return specialDefense_Base; }
            set { specialDefense_Base = value; }
        }
        public int Speed_Base
        {
            get { return speed_Base; }
            set { speed_Base = value; }
        }


        //extra stats: auto properties
        public string Naam { get; set; }
        public string Type { get; set; }


        //Level
        private int level = 1;
        public int Level
        {
            get { return level; }
            private set { level = value; }
        }

        //Verhoog Level
        public void VerhoogLevel()
        {
            Level++;
        }

        //statistieken
        public int Average
        {
            get { return (HP_Base + Attack_Base + Defense_Base + SpecialAttack_Base + SpDefense_Base + Speed_Base) / 6; }
        }
        public int Totaal
        {
            get { return (HP_Base + Attack_Base + Defense_Base + SpecialAttack_Base + SpDefense_Base + Speed_Base); }
        }

        //Level-gebaseerd stats

        public int HP_Full
        {

            get { return ((hp_Base + 50) * Level / 50) + 10; }

        }

        public int Attack_ull
        {

            get { return ((Attack_Base * Level) / 50) + 5; }

        }

        public int Defense_Full
        {

            get { return ((Defense_Base * Level) / 50) + 5; }

        }

        public int SpAttack_Full
        {

            get { return ((SpecialAttack_Base * Level) / 50) + 5; }

        }

        public int SpDefense_Full
        {

            get { return ((SpDefense_Base * Level) / 50) + 5; }

        }
        public int Speed_Full
        {

            get { return ((Speed_Base * Level) / 50) + 5; }

        }


        public void ShowInfo()
        {                                                                                                                           //2 groepje
            Console.WriteLine($"{Naam} (level {level})\nBase stats:\n \t* Health = {HP_Base}\n\t* DPS = {attack_Base}\n \t* DF = {defense_Base}\n\t* Speed = {speed_Base}\n\t* SPDF = {specialDefense_Base}\n\t* SPAT = {specialAttack_Base}\n");
            Console.WriteLine($"Full stats:\n\t* Health = {HP_Full}\n\t* DPS = {Attack_ull}\n \t* DF = {Defense_Full}\n\t* Speed = {Speed_Full}\n\t* SPDF = {SpDefense_Full}\n\t* SPAT = {SpAttack_Full}\n");
        }



    }
}
