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
                }; 
            }
            else
            { 
                return new Pizza(); 
            }
        }
    }
}