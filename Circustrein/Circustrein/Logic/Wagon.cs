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
        List<Animal> animals = new List<Animal>(); 
        
        public Wagon()
        {

        }

        public bool AddAnimal(Animal animal)
        {
            string animalSize = animal.Size; 
            switch(animalSize)
            {
                case "big":
                    if (sizePoints >= 5)
                    {
                        animals.Add(animal);
                        sizePoints-=5;
                        return true; 
                    }
                    else { return false; };
                    

                case "medium":
                    if (sizePoints >= 3)
                    {
                        animals.Add(animal);
                        sizePoints -= 3;
                        return true; 
                    }
                    else { return false; };

                case "smal":
                    if (sizePoints >= 1)
                    {
                        animals.Add(animal);
                        sizePoints -= 1;
                        return true; 
                    }
                    else { return false; };
            }
            return false;  
        }

        
    }
}
