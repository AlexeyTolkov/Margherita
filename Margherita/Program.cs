using System;
using System.Collections.Generic;

namespace Margherita
{
    class Program
    {
        void Main()
        {
        }
        public class Pizza
        {
            public string Name { get; set; }
            public List<string> Ingredients { get; set; }
            public int Size { get; set; }
            public decimal Price { get; set; }
        }
        public Pizza CreateByName(string name) { throw new NotImplementedException(); }
    }
}
