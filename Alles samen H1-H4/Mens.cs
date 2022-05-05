using System;
namespace Alles_samen_H1_H4
{
    //Enums =>
    enum geslacht { Man, Vrouw }
    enum ogen { Blue, yellow, Green, Red } // Brown zit niet in het system.net dus ik ga yellow gebruiken
    internal class Mens
    {
        //Properties:
        public geslacht Geslacht { get; set; }
        public ogen Kleur_ogen { get; set; }

        private int maxlengte;

        public int Maxlengte
        {
            get { return maxlengte; }
            set
            {
                if (value > 30)
                {
                    maxlengte = value;
                }
                else
                {
                    //dit is ingeval dat het onder 30 {gewoon om deze gedeelte te controleren}
                    maxlengte = int.MinValue;
                }
            }
        }

        //Constructors:

        public Mens()
        {

            random kans = new random();
            int gekozenKans = kans.next(1, 21);
            int ogenKans = kans.next(1, 5);         //getalen tussen 1 en 4 (4 inclusief).
            int geslachtKans = kans.next(1, 3);     //getalen tussen 1 en 2;
            if (gekozenKans < 18)               //als het getal tussen 1 en 18 zit (90% van de tijd): *Bij maxlengte is deze waarde 90% van de tijd tussen 150 en 210*
            {
                maxlengte = kans.next(150, 210);    //tussen 150 en 210
                
                
                //deze manier heeft visual studio 2022 getoont, ik vind dit zelf schooner en duidelijker.

                //geslachtkans switch methoden
                Geslacht = geslachtKans switch
                {
                    1 => geslacht.Man,
                    2 => geslacht.Vrouw,
                    _ => throw new System.NotImplementedException(),
                };

                //ogen kans Switch methoden
                Kleur_ogen = ogenKans switch
                {
                    1 => ogen.Blue,
                    2 => ogen.yellow,
                    3 => ogen.Red,
                    4 => ogen.Green,
                    _ => throw new System.NotImplementedException(),
                };

                
            }
            else if (gekozenKans == 19)     //5% van de kans
            {
                maxlengte = kans.next(40, 151);       //tussen 40 en 150

                //geslachtkans switch methoden
                Geslacht = geslachtKans switch
                {
                    1 => geslacht.Man,
                    2 => geslacht.Vrouw,
                    _ => throw new System.NotImplementedException(),
                };

                //ogen kans Switch methoden
                Kleur_ogen = ogenKans switch
                {
                    1 => ogen.Blue,
                    2 => ogen.yellow,
                    3 => ogen.Red,
                    4 => ogen.Green,
                    _ => throw new System.NotImplementedException(),
                };
            }
            else if (gekozenKans == 20)     //5% kans
            {
                maxlengte = kans.next(210, 241);    //tussen 210 en 240

                //geslachtkans switch methoden
                Geslacht = geslachtKans switch
                {
                    1 => geslacht.Man,
                    2 => geslacht.Vrouw,
                    _ => throw new System.NotImplementedException(),
                };

                //ogen kans Switch methoden
                Kleur_ogen = ogenKans switch
                {
                    1 => ogen.Blue,
                    2 => ogen.yellow,
                    3 => ogen.Red,
                    4 => ogen.Green,
                    _ => throw new System.NotImplementedException(),
                };
            }

        }
        public Mens(ogen gekozenOgen, geslacht gekozenKans, int gekozenMaxlengte )
        {
            Kleur_ogen = gekozenOgen;
            Geslacht = gekozenKans;
            Maxlengte = gekozenMaxlengte;
        }

        //Methoden:

        //Toonmens =>

        public void ToonMens()    
        {
            //kleine gedeelte om de kleur te zetten in de background juist
            //ik ga het in forground zetten omdat het mooier is
            Console.ForegroundColor = Kleur_ogen switch
            {
                ogen.Blue => ConsoleColor.Blue,
                ogen.Green => ConsoleColor.Green,
                ogen.Red => ConsoleColor.Red,
                ogen.yellow => ConsoleColor.Yellow,
                _ => throw new NotImplementedException()

            };

            
            Console.WriteLine($"{maxlengte} Cm, {Geslacht}");       //geen zin omdat in Meter te zetten momenteel
            Console.ResetColor();
        }
        //Plantvoor:

        public Mens Plantvoort()
        {
            if (Geslacht == geslacht.Vrouw)
            {
               
                Mens nieuweMens = new Mens(ogen.Green, geslacht.Man, 130);
                //ik heb het zo gedaan want ik heb geen zin om die 50% kans van bla bla te doen.
            
                return nieuweMens;
            
            }
            else
            {
                return null;
            }



        }

    }
}
