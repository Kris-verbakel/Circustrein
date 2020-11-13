using Microsoft.VisualStudio.TestTools.UnitTesting;
using Circustrein;
using Circustrein.Logic;


namespace CircustreinUnitTest
{
    [TestClass]
    public class TrainTest
    {
        [TestMethod]
        public void AddNewAnimal_AnimalFit_ReturnsTrue()
        {
            //Arrange
            Animal animal = new Animal(Food.herbivore, Size.medium, "Koe");
            Train train = new Train();
            train.wagons.Add(new Wagon()); 

            //Act
            bool result = train.AddNewAnimal(animal);

            //Assert
            Assert.IsTrue(result); 
        }

        [TestMethod]
        public void AddNewAnimal_AnimalNotFit_ReturnsFalse()
        {
            //Arrange
            Animal animal1 = new Animal(Food.herbivore, Size.medium, "Koe");
            Animal animal2 = new Animal(Food.herbivore, Size.big, "Olifant");
            Animal animal3 = new Animal(Food.herbivore, Size.medium, "Paard");

            Train train = new Train();

            train.AddNewAnimal(animal1);
            train.AddNewAnimal(animal2);

            //Act
            bool result = train.AddNewAnimal(animal3);

            //Assert
            Assert.IsFalse(result);
        }
    }
}
