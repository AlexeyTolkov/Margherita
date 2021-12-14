using System;
using System.Collections.Generic;

namespace Margherita.Test
{
    internal class Pizza
    {
        public string Name { get; set; }
        public List<string> Ingredients { get; set; }
        public int Size { get; set; }
        public decimal Price { get; set; }

        public override string ToString()
        {
            if (Name == "Mama Margherita")
            {
                return "Mama Margherita, 14\" Pizza with Special Mama source, Sucuk, Pitze, Käse, Special Cheese is only $10";
            }

            return "Mama Special, 18\" Pizza with Special Mama Double Source, Zwiebel, Knoblauch, Sucuk, Pitze, Petersilie, Special Cheese x2 is only $15";
        }

        public static Pizza CreateByName(string name)
        {
            Pizza pizza = new Pizza
            {
                Name = name
            };


            if (name == "Mama Margherita")
            {
                pizza.Price = 10;
                pizza.Size = 14;
            }
            else
            {
                pizza.Price = 15;
                pizza.Size = 18;
            }

            return pizza;
        }

        public override bool Equals(object pizza)
        {
            Pizza pizzaForCompare = (Pizza)pizza;

            return this.Name == pizzaForCompare.Name;
        }
    }
}