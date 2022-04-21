namespace Alles_samen_H1_H4
{
    enum geslacht { Man, Vrouw }
    enum ogen { blauw, bruin, groen, rood }
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
            int ogenKans = kans.next(1, 5);         //getalen tussen 1 en 4 (4 inclusief).
            int geslachtKans = kans.next(1, 3);     //getalen tussen 1 en 2;
            if (kans.next(1,21) < 18)               //als het getal tussen 1 en 18 zit (90% van de tijd): *Bij maxlengte is deze waarde 90% van de tijd tussen 150 en 210*
            {
                maxlengte = kans.next(150, 210);
                
                
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
                    1 => ogen.blauw,
                    2 => ogen.bruin,
                    3 => ogen.rood,
                    4 => ogen.groen,
                    _ => throw new System.NotImplementedException(),
                };
            }


        }

    }
}
