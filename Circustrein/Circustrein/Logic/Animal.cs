using Circustrein.Logic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Circustrein
{
    public class Animal
    {
        public string Name { get; }
        public Size Size { get; }
        public Food Food { get; }

        public Animal(Food food, Size size, string name)
        {
            this.Food = food;
            this.Size = size;
            this.Name = name; 
        }
    }
}
