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
        public Size Size { get; }
        public Food Food { get; }

        public Animal(Food food, Size size)
        {
            this.Food = food;
            this.Size = size; 
        }
    }
}
