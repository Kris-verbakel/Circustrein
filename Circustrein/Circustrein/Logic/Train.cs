using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Circustrein.Logic
{
    public class Train
    {
        public List<Wagon> wagons = new List<Wagon>();

        public Train()
        {
            wagons.Add(new Wagon()); 
        }

        public bool AddNewAnimal(Animal animal)
        {
            foreach(Wagon w in wagons)
            {
                if (w.AddAnimal(animal))
                {
                    return true; 
                }
            }
            return false; 
        }
            

    }
}

    
