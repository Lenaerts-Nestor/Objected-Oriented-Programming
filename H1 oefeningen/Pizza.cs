namespace H1_oefeningen
{
    internal class Pizza
    {
        //instantieVariabelen = aantal properties;
        private string toppings;

        public string Toppings
        {
            get { return toppings; }
            set { if (toppings != " ") { toppings = value; } }
        }


        private int diameter;

        public int Diameter
        {
            get { return diameter; }
            set
            {
                if (diameter > 0)
                {
                    diameter = value;
                }
            }
        }

        private double price;

        public double Price
        {
            get { return price; }
            set { if (price > 0) { price = value; } }
        }
    }
}