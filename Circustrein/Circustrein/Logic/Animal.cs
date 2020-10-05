using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Circustrein
{
    class Animal
    {
        public string Food { get; set; }
        public string Size { get;  set; }

        public Animal(string food, string size)
        {
            this.Food = food;
            this.Size = size; 
        }
    }
}
