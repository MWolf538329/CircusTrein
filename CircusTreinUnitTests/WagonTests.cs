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
        public void IsCurrentAnimalBiggerThanCarnivore_Yes()
        {
            // Arrange
            Wagon wagon = new();
            Animal currentAnimal = new(AnimalEnums.SizePoint.Big, AnimalEnums.FoodType.Carnivore);
            Animal carnivore = new(AnimalEnums.SizePoint.Small, AnimalEnums.FoodType.Carnivore);

            // Act
            bool isCurrentAnimalBiggerThanCarnivore = wagon.IsCurrentAnimalBiggerThanCarnivore(currentAnimal, carnivore);

            // Assert
            Assert.AreEqual(true, isCurrentAnimalBiggerThanCarnivore);
        }

        [TestMethod]
        public void IsCurrentAnimalBiggerThanCarnivore_No()
        {
            // Arrange
            Wagon wagon = new();
            Animal currentAnimal = new(AnimalEnums.SizePoint.Small, AnimalEnums.FoodType.Carnivore);
            Animal carnivore = new(AnimalEnums.SizePoint.Big, AnimalEnums.FoodType.Carnivore);

            // Act
            bool isCurrentAnimalBiggerThanCarnivore = wagon.IsCurrentAnimalBiggerThanCarnivore(currentAnimal, carnivore);

            // Assert
            Assert.AreEqual(false, isCurrentAnimalBiggerThanCarnivore);
        }

        [TestMethod]
        public void IsCurrentAnimalCarnivore_Yes()
        {
            // Arrange
            Wagon wagon = new();
            Animal animal = new(AnimalEnums.SizePoint.Big, AnimalEnums.FoodType.Carnivore);

            // Act
            bool isCarnivore = wagon.IsCurrentAnimalCarnivore(animal);

            // Assert
            Assert.AreEqual(true, isCarnivore);
        }

        [TestMethod]
        public void IsCurrentAnimalCarnivore_No()
        {
            // Arrange
            Wagon wagon = new();
            Animal animal = new(AnimalEnums.SizePoint.Big, AnimalEnums.FoodType.Herbivore);

            // Act
            bool isCarnivore = wagon.IsCurrentAnimalCarnivore(animal);

            // Assert
            Assert.AreEqual(false, isCarnivore);
        }

        #region Sorting Tests
        [TestMethod]
        public void SortingTests_CarnivoreDescending()
        {
            // Arrange
            List<Animal> animals = new List<Animal>()
            {
                new Animal(AnimalEnums.SizePoint.Big, AnimalEnums.FoodType.Herbivore),
                new Animal(AnimalEnums.SizePoint.Medium, AnimalEnums.FoodType.Herbivore),
                new Animal(AnimalEnums.SizePoint.Small, AnimalEnums.FoodType.Herbivore),
                new Animal(AnimalEnums.SizePoint.Big, AnimalEnums.FoodType.Carnivore),
                new Animal(AnimalEnums.SizePoint.Medium, AnimalEnums.FoodType.Carnivore),
                new Animal(AnimalEnums.SizePoint.Small, AnimalEnums.FoodType.Carnivore)
            };

            // Act
            List<Animal> carnivoreDescendingAnimals = animals.OrderBy(a => (int)a.FoodType).ThenBy(a => (int)a.SizePoint).Reverse().ToList();

            // Assert
            Assert.AreEqual(AnimalEnums.SizePoint.Big, carnivoreDescendingAnimals[0].SizePoint);
            Assert.AreEqual(AnimalEnums.FoodType.Carnivore, carnivoreDescendingAnimals[0].FoodType);

            Assert.AreEqual(AnimalEnums.SizePoint.Medium, carnivoreDescendingAnimals[1].SizePoint);
            Assert.AreEqual(AnimalEnums.FoodType.Carnivore, carnivoreDescendingAnimals[1].FoodType);

            Assert.AreEqual(AnimalEnums.SizePoint.Small, carnivoreDescendingAnimals[2].SizePoint);
            Assert.AreEqual(AnimalEnums.FoodType.Carnivore, carnivoreDescendingAnimals[2].FoodType);

            Assert.AreEqual(AnimalEnums.SizePoint.Big, carnivoreDescendingAnimals[3].SizePoint);
            Assert.AreEqual(AnimalEnums.FoodType.Herbivore, carnivoreDescendingAnimals[3].FoodType);

            Assert.AreEqual(AnimalEnums.SizePoint.Medium, carnivoreDescendingAnimals[4].SizePoint);
            Assert.AreEqual(AnimalEnums.FoodType.Herbivore, carnivoreDescendingAnimals[4].FoodType);

            Assert.AreEqual(AnimalEnums.SizePoint.Small, carnivoreDescendingAnimals[5].SizePoint);
            Assert.AreEqual(AnimalEnums.FoodType.Herbivore, carnivoreDescendingAnimals[5].FoodType);
        }

        [TestMethod]
        public void SortingTests_CarnivoreAscending()
        {
            // Arrange
            List<Animal> animals = new List<Animal>()
            {
                new Animal(AnimalEnums.SizePoint.Big, AnimalEnums.FoodType.Herbivore),
                new Animal(AnimalEnums.SizePoint.Medium, AnimalEnums.FoodType.Herbivore),
                new Animal(AnimalEnums.SizePoint.Small, AnimalEnums.FoodType.Herbivore),
                new Animal(AnimalEnums.SizePoint.Big, AnimalEnums.FoodType.Carnivore),
                new Animal(AnimalEnums.SizePoint.Medium, AnimalEnums.FoodType.Carnivore),
                new Animal(AnimalEnums.SizePoint.Small, AnimalEnums.FoodType.Carnivore)
            };

            // Act
            List<Animal> carnivoreAscendingAnimals = animals.OrderByDescending(a => (int)a.FoodType).ThenBy(a => (int)a.SizePoint).ToList();

            // Assert
            Assert.AreEqual(AnimalEnums.SizePoint.Small, carnivoreAscendingAnimals[0].SizePoint);
            Assert.AreEqual(AnimalEnums.FoodType.Carnivore, carnivoreAscendingAnimals[0].FoodType);

            Assert.AreEqual(AnimalEnums.SizePoint.Medium, carnivoreAscendingAnimals[1].SizePoint);
            Assert.AreEqual(AnimalEnums.FoodType.Carnivore, carnivoreAscendingAnimals[1].FoodType);

            Assert.AreEqual(AnimalEnums.SizePoint.Big, carnivoreAscendingAnimals[2].SizePoint);
            Assert.AreEqual(AnimalEnums.FoodType.Carnivore, carnivoreAscendingAnimals[2].FoodType);

            Assert.AreEqual(AnimalEnums.SizePoint.Small, carnivoreAscendingAnimals[3].SizePoint);
            Assert.AreEqual(AnimalEnums.FoodType.Herbivore, carnivoreAscendingAnimals[3].FoodType);

            Assert.AreEqual(AnimalEnums.SizePoint.Medium, carnivoreAscendingAnimals[4].SizePoint);
            Assert.AreEqual(AnimalEnums.FoodType.Herbivore, carnivoreAscendingAnimals[4].FoodType);

            Assert.AreEqual(AnimalEnums.SizePoint.Big, carnivoreAscendingAnimals[5].SizePoint);
            Assert.AreEqual(AnimalEnums.FoodType.Herbivore, carnivoreAscendingAnimals[5].FoodType);
        }

        [TestMethod]
        public void SortingTests_HerbivoreDescendingAnimals()
        {
            // Arrange
            List<Animal> animals = new List<Animal>()
            {
                new Animal(AnimalEnums.SizePoint.Big, AnimalEnums.FoodType.Herbivore),
                new Animal(AnimalEnums.SizePoint.Medium, AnimalEnums.FoodType.Herbivore),
                new Animal(AnimalEnums.SizePoint.Small, AnimalEnums.FoodType.Herbivore),
                new Animal(AnimalEnums.SizePoint.Big, AnimalEnums.FoodType.Carnivore),
                new Animal(AnimalEnums.SizePoint.Medium, AnimalEnums.FoodType.Carnivore),
                new Animal(AnimalEnums.SizePoint.Small, AnimalEnums.FoodType.Carnivore)
            };

            // Act
            List<Animal> herbivoreDescendingAnimals = animals.OrderByDescending(a => (int)a.FoodType).ThenBy(a => (int)a.SizePoint).Reverse().ToList();

            // Assert
            Assert.AreEqual(AnimalEnums.SizePoint.Big, herbivoreDescendingAnimals[0].SizePoint);
            Assert.AreEqual(AnimalEnums.FoodType.Herbivore, herbivoreDescendingAnimals[0].FoodType);

            Assert.AreEqual(AnimalEnums.SizePoint.Medium, herbivoreDescendingAnimals[1].SizePoint);
            Assert.AreEqual(AnimalEnums.FoodType.Herbivore, herbivoreDescendingAnimals[1].FoodType);

            Assert.AreEqual(AnimalEnums.SizePoint.Small, herbivoreDescendingAnimals[2].SizePoint);
            Assert.AreEqual(AnimalEnums.FoodType.Herbivore, herbivoreDescendingAnimals[2].FoodType);

            Assert.AreEqual(AnimalEnums.SizePoint.Big, herbivoreDescendingAnimals[3].SizePoint);
            Assert.AreEqual(AnimalEnums.FoodType.Carnivore, herbivoreDescendingAnimals[3].FoodType);

            Assert.AreEqual(AnimalEnums.SizePoint.Medium, herbivoreDescendingAnimals[4].SizePoint);
            Assert.AreEqual(AnimalEnums.FoodType.Carnivore, herbivoreDescendingAnimals[4].FoodType);

            Assert.AreEqual(AnimalEnums.SizePoint.Small, herbivoreDescendingAnimals[5].SizePoint);
            Assert.AreEqual(AnimalEnums.FoodType.Carnivore, herbivoreDescendingAnimals[5].FoodType);
        }

        [TestMethod]
        public void SortingTests_HerbivoreAscendingAnimals()
        {
            // Arrange
            List<Animal> animals = new List<Animal>()
            {
                new Animal(AnimalEnums.SizePoint.Big, AnimalEnums.FoodType.Herbivore),
                new Animal(AnimalEnums.SizePoint.Medium, AnimalEnums.FoodType.Herbivore),
                new Animal(AnimalEnums.SizePoint.Small, AnimalEnums.FoodType.Herbivore),
                new Animal(AnimalEnums.SizePoint.Big, AnimalEnums.FoodType.Carnivore),
                new Animal(AnimalEnums.SizePoint.Medium, AnimalEnums.FoodType.Carnivore),
                new Animal(AnimalEnums.SizePoint.Small, AnimalEnums.FoodType.Carnivore)
            };

            // Act
            List<Animal> herbivoreAscendingAnimals = animals.OrderBy(a => (int)a.FoodType).ThenBy(a => (int)a.SizePoint).ToList();

            // Assert
            Assert.AreEqual(AnimalEnums.SizePoint.Small, herbivoreAscendingAnimals[0].SizePoint);
            Assert.AreEqual(AnimalEnums.FoodType.Herbivore, herbivoreAscendingAnimals[0].FoodType);

            Assert.AreEqual(AnimalEnums.SizePoint.Medium, herbivoreAscendingAnimals[1].SizePoint);
            Assert.AreEqual(AnimalEnums.FoodType.Herbivore, herbivoreAscendingAnimals[1].FoodType);

            Assert.AreEqual(AnimalEnums.SizePoint.Big, herbivoreAscendingAnimals[2].SizePoint);
            Assert.AreEqual(AnimalEnums.FoodType.Herbivore, herbivoreAscendingAnimals[2].FoodType);

            Assert.AreEqual(AnimalEnums.SizePoint.Small, herbivoreAscendingAnimals[3].SizePoint);
            Assert.AreEqual(AnimalEnums.FoodType.Carnivore, herbivoreAscendingAnimals[3].FoodType);

            Assert.AreEqual(AnimalEnums.SizePoint.Medium, herbivoreAscendingAnimals[4].SizePoint);
            Assert.AreEqual(AnimalEnums.FoodType.Carnivore, herbivoreAscendingAnimals[4].FoodType);

            Assert.AreEqual(AnimalEnums.SizePoint.Big, herbivoreAscendingAnimals[5].SizePoint);
            Assert.AreEqual(AnimalEnums.FoodType.Carnivore, herbivoreAscendingAnimals[5].FoodType);
        }
        #endregion

        #region Scenario Tests
        //[TestMethod]
        //public void TryToAddAnimalToWagon_Scenario1()
        //{
        //    // Arrange
        //    List<Animal> animals = new List<Animal>()
        //    {
        //        new Animal(AnimalEnums.SizePoint.Small, AnimalEnums.FoodType.Carnivore),
        //        new Animal(AnimalEnums.SizePoint.Big, AnimalEnums.FoodType.Herbivore),
        //        new Animal(AnimalEnums.SizePoint.Medium, AnimalEnums.FoodType.Herbivore),
        //        new Animal(AnimalEnums.SizePoint.Medium, AnimalEnums.FoodType.Herbivore),
        //        new Animal(AnimalEnums.SizePoint.Small, AnimalEnums.FoodType.Herbivore),
        //        new Animal(AnimalEnums.SizePoint.Small, AnimalEnums.FoodType.Herbivore),
        //        new Animal(AnimalEnums.SizePoint.Small, AnimalEnums.FoodType.Herbivore),
        //        new Animal(AnimalEnums.SizePoint.Small, AnimalEnums.FoodType.Herbivore),
        //        new Animal(AnimalEnums.SizePoint.Small, AnimalEnums.FoodType.Herbivore)
        //    };

        //    Train carnivoreDescendingTrain = new();
        //    Train carnivoreAscendingTrain = new();
        //    Train herbivoreDescendingTrain = new();
        //    Train herbivoreAscendingTrain = new();

        //    List<Animal> carnivoreDescendingAnimals = animals.OrderBy(a => (int)a.FoodType).ThenBy(a => (int)a.SizePoint).Reverse().ToList();
        //    List<Animal> carnivoreAscendingAnimals = animals.OrderBy(a => (int)a.FoodType).ThenBy(a => (int)a.SizePoint).ToList();
        //    List<Animal> herbivoreDescendingAnimals = animals.OrderByDescending(a => (int)a.FoodType).ThenBy(a => (int)a.SizePoint).Reverse().ToList();
        //    List<Animal> herbivoreAscendingAnimals = animals.OrderBy(a => (int)a.FoodType).ThenBy(a => (int)a.SizePoint).ToList();

        //    // Act
        //    carnivoreDescendingTrain.DivideAnimalsOverWagons(carnivoreDescendingAnimals);
        //    carnivoreAscendingTrain.DivideAnimalsOverWagons(carnivoreAscendingAnimals);
        //    herbivoreDescendingTrain.DivideAnimalsOverWagons(herbivoreDescendingAnimals);
        //    herbivoreAscendingTrain.DivideAnimalsOverWagons(herbivoreAscendingAnimals);

        //    // Assert
        //    // CarnivoreDescendingAnimals
        //    Assert.AreEqual(1, carnivoreDescendingTrain.Wagons.Count());

        //    // CarnivoreAscendingAnimals
        //    Assert.AreEqual(1, carnivoreAscendingTrain.Wagons.Count());

        //    // HerbivoreDescendingAnimals
        //    Assert.AreEqual(1, herbivoreDescendingTrain.Wagons.Count());

        //    // HerbivoreAscendingAnimals
        //    Assert.AreEqual(1, herbivoreAscendingTrain.Wagons.Count());
        //}
        #endregion
    }
}