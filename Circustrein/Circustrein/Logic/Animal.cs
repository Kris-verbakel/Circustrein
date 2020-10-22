using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Circustrein
{
    class Animal
    {
        private Size size;

        public string Food { get; set; }
        public int SizeP { get; set; }

        public Animal(string food, Size size)
        {
            this.Food = food;
            this.Size = size; 
        }
    }
}
