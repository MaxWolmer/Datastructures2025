using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Datastructures2025
{
    public class Pizza
    {
        public int Number { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }

        public double Price { get; set; }


        public Pizza(int number, string name, string description, double price)
        {
            Number = number;
            Name = name;
            Description = description;
            Price = price; 
        }

        public override string ToString()
        {
            return $"{Number} {Name} {Description} {Price} kr";
        }
    }
}
