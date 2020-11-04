using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Circustrein.Logic
{
    class Train
    {
        public List<Wagon> wagons = new List<Wagon>();
        int count = 0; 
        public Train()
        {
            wagons.Add(new Wagon()); 
        }
        private void newAnimal(Animal animal)
        {
            if (wagons[count].CheckFit(animal))
            {
                wagons[count].AddAnimal(animal);
            }

            else
            {
                wagons.Add(new Wagon());
                count++;
                wagons[count].AddAnimal(animal);
            }
        }

    }
}

    
