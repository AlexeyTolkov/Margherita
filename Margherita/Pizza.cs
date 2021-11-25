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
            return "Mama Margherita, 14\" Pizza with Special Mama source, Sucuk, Pitze, Käse, Special Cheese is only $10";
        }

        public static Pizza CreateByName(string v)
        {
            if (v == "Mama Margherita")
            {
                return new Pizza()
                { 
                    Name = v
                }; // "Mama Margherita, 14\" Pizza with Special Mama source, Sucuk, Pitze, Käse, Special Cheese is only $10";
            }
            else
            { 
                return new Pizza(); //"Mama Special, 18\" Pizza with Special Mama Double Source, Zwiebel, Knoblauch, Sucuk, Pitze, Petersilie, Special Cheese x2 is only $15";
            }
        }
    }
}