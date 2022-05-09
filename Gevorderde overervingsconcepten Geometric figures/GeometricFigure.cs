using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gevorderde_overervingsconcepten_Geometric_figures
{
    public abstract class GeometricFigure
    {
        public int Hoogte { get; set; }
        public int Breedte { get; set; }

        public int Oppervlakte
        {
            get { return BerekenOppervlakte(); }
        }
        public abstract int BerekenOppervlakte();

    }


    public class Rechthoek : GeometricFigure
    {
        public override int BerekenOppervlakte()
        {
            return Breedte * Hoogte;
        }
    }
    public class Vierkant : Rechthoek
    {
        public Vierkant(int hoogte, int breedte)
        {
            if (hoogte != breedte) //indien ze niet gelijk zijn, zet je deze tijdens de constructie gelijk
            {
                //in deze geval ga ik zeggen zet de breedte gelijk aan de lengte van de hoogte
                breedte = hoogte;   //ik moet dit niet persee zo zetten, ik kan het gewoon de properties de lengte van hoogte direct zetten, maar ik ga het voor duidelijkheid zo zetten.

                //dan zet ik ze in de properties correct
                Hoogte = hoogte;
                Breedte = breedte;
            }
            else
            {
                Hoogte = hoogte;
                Breedte = breedte;
            }
        }
        public Vierkant(int lengte)
        {
            Hoogte = lengte;
            Breedte = lengte;

           
        }
        //bij meneer zijn oefening zie je het volgende niet bij klasse vierkant, want je erft direct de Rechhoek BerekenOppervlakte(), en ze returne hetzelfde *Return H*B; 
        /*
        public override int BerekenOppervlakte()
        {
            return base.BerekenOppervlakte();
        }
        */
    }
    public class Driehoek : GeometricFigure
    {
        public override int BerekenOppervlakte()
        {
            return Breedte * Hoogte / 2;
        }
    }


}
