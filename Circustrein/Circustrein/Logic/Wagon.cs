using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Circustrein.Logic
{
    class Wagon
    {
        private int sizePoints = 10;
        public int SizePoints { get; private set; }

        public Wagon ()
        {
            List<Animal> animals = new List<Animal>(); 
        }

        public void AddAnimal(Animal animal)
        {
            animals.Add(animal); 
        }

        
    }
}
