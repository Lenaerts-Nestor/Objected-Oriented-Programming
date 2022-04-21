namespace H2_Program__main_
{
    class Meetlat
    {
        //instantie Variable
        private double lengte;

        //write only property
        public double BeginLengte
        {
            set
            {
                if (value > 0.0)
                {
                    lengte = value;
                }
            }
        }

        //read only properties
        public double LengteInM
        {
            get { return (lengte * 1); }
        }

        public double LengteInCM
        {
            get { return (lengte * 100); }
        }
        public double LengteInKM
        {
            get { return (lengte / 1000); }
        }

        public double LengteInVoet
        {
            get { return (lengte * 3.2808399); }
        }


    }
}
