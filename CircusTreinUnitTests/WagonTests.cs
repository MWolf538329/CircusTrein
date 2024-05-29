using CircusTrein.Models;

namespace CircusTreinUnitTests
{
    [TestClass]
    public class WagonTests
    {
        [TestMethod]
        public void TryToAddAnimalToWagon_EmptyWagon()
        {
            // Arrange
            Train train = new();

            List<Animal> animals = new List<Animal>()
            {
                new Animal(AnimalEnums.SizePoint.Big, AnimalEnums.FoodType.Herbivore)
            };

            // Act
            train.DivideAnimalsOverWagons(animals);

            // Assert
            Assert.AreEqual(1, train.Wagons.Count());
        }

        [TestMethod]
        public void TryToAddAnimalToWagon_Scenario1()
        {
            // Arrange
            List<Animal> animals = new List<Animal>()
            {
                new Animal(AnimalEnums.SizePoint.Small, AnimalEnums.FoodType.Carnivore),
                new Animal(AnimalEnums.SizePoint.Big, AnimalEnums.FoodType.Herbivore),
                new Animal(AnimalEnums.SizePoint.Medium, AnimalEnums.FoodType.Herbivore),
                new Animal(AnimalEnums.SizePoint.Medium, AnimalEnums.FoodType.Herbivore),
                new Animal(AnimalEnums.SizePoint.Small, AnimalEnums.FoodType.Herbivore),
                new Animal(AnimalEnums.SizePoint.Small, AnimalEnums.FoodType.Herbivore),
                new Animal(AnimalEnums.SizePoint.Small, AnimalEnums.FoodType.Herbivore),
                new Animal(AnimalEnums.SizePoint.Small, AnimalEnums.FoodType.Herbivore),
                new Animal(AnimalEnums.SizePoint.Small, AnimalEnums.FoodType.Herbivore)
            };

            Train carnivoreDescendingTrain = new();
            Train carnivoreAscendingTrain = new();
            Train herbivoreDescendingTrain = new();
            Train herbivoreAscendingTrain = new();

            List<Animal> carnivoreDescendingAnimals = animals.OrderBy(a => (int)a.FoodType).ThenBy(a => (int)a.SizePoint).Reverse().ToList();
            List<Animal> carnivoreAscendingAnimals = animals.OrderBy(a => (int)a.FoodType).ThenBy(a => (int)a.SizePoint).ToList();
            List<Animal> herbivoreDescendingAnimals = animals.OrderByDescending(a => (int)a.FoodType).ThenBy(a => (int)a.SizePoint).Reverse().ToList();
            List<Animal> herbivoreAscendingAnimals = animals.OrderBy(a => (int)a.FoodType).ThenBy(a => (int)a.SizePoint).ToList();

            // Act
            carnivoreDescendingTrain.DivideAnimalsOverWagons(carnivoreDescendingAnimals);
            carnivoreAscendingTrain.DivideAnimalsOverWagons(carnivoreAscendingAnimals);
            herbivoreDescendingTrain.DivideAnimalsOverWagons(herbivoreDescendingAnimals);
            herbivoreAscendingTrain.DivideAnimalsOverWagons(herbivoreAscendingAnimals);

            // Assert
            // CarnivoreDescendingAnimals
            Assert.AreEqual(1, carnivoreDescendingTrain.Wagons.Count());

            // CarnivoreAscendingAnimals
            Assert.AreEqual(1, carnivoreAscendingTrain.Wagons.Count());

            // HerbivoreDescendingAnimals
            Assert.AreEqual(1, herbivoreDescendingTrain.Wagons.Count());

            // HerbivoreAscendingAnimals
            Assert.AreEqual(1, herbivoreAscendingTrain.Wagons.Count());
        }


    }
}