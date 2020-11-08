using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Circustrein.Logic
{
    public class Wagon
    {
        public int Capacity { get; private set; }
        private List<Animal> animals = new List<Animal>();

        public Wagon ()
        {
            Capacity = 10; 
        }

        public bool AddAnimal(Animal animal)
        {
            if(CheckFit(animal))
            {
                animals.Add(animal);
                return true; 
            }
            return false; 
        }

        private bool CheckFit(Animal animal)
        {
            if (CheckCapacity(animal) && CheckSafe(animal) && CheckWagonSafe(animal))
            {
                return true;
            }
            return false;            
        }

        private bool CheckCapacity(Animal animal)
        {
            return (int)animal.Size <= Capacity; 
        }

        private bool CheckSafe(Animal animal)
        {
            foreach (Animal an in animals)
            {
                if(an.Size >= animal.Size)
                {
                    if (an.Food == Food.carnivore)
                    {
                        return false;
                    }        
                }
            }
            return true; 
        }

        private bool CheckWagonSafe(Animal animal)
        {
            if (animal.Food == Food.carnivore)
            {
                foreach (Animal an in animals)
                {
                    if (an.Size <= animal.Size)
                    {
                        return false; 
                    }
                }
            }
            return true;  
        }
    }
}
