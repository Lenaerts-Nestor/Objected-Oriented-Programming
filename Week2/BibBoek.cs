using System;

namespace Week2
{
    class BibBoek
    {
        //dit is correct maar de Uitgeleend moet full prop en geen autoprop
        public string Ontlener { get; set; } = "onbekend";
        public DateTime Uitgeleend { get; private set; } = DateTime.Now;

        public DateTime InleverDatum
        {
            get
            {
                return Uitgeleend.AddDays(14);
            }
        }

        public void VerlengTermijn(int extraDagen)
        {

            Uitgeleend = DateTime.Now.AddDays(extraDagen);
        }

    }
}
