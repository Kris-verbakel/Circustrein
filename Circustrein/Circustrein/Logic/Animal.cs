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
        public int SizeP { get; set; }

        public Animal(string food, string size)
        {
            this.Food = food;
            this.Size = size; 

            switch(size)
            {
                case "small":
                    SizeP = 1;
                    break;

                case "medium":
                    SizeP = 3;
                    break;

                case "big":
                    SizeP = 5;
                    break;
            }
        }
        
        public Animal()
        {
            this.Food = "plant";
            this.Size = "small";
            SizeP = 1; 
        }
    }
}
