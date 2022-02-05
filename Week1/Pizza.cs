using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week1
{
    class Pizza
    {
        //Toppings
        private string topping;

        public string Toppings
        {
            get { return topping; }
            set
            {
                if (value != null)
                {
                    topping = value;
                }
                
            }
        }

        //Diameter
        private int diameter;

        public int Diameter
        {
            get { return diameter; }
            set
            {
                if (value > 0)
                {
                    diameter = value;
                }

            }
        }

        //Price
        private double price;

        public double Price
        {
            get { return price; }
            set
            {
                if (value > 0)
                {
                    price = value;
                }
            }
        }

        public void text()
        {
            Console.WriteLine($"prijs: {price}");
            Console.WriteLine($"diameter: {diameter}");
            Console.WriteLine($"topping: {topping}");
            Console.WriteLine("einde");
        }



    }
}
