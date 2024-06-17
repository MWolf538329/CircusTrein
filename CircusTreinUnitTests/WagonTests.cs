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

        #region Checks
        [TestMethod]
        public void DoesNotExceedMaxCapacity_Yes()
        {
            // Arrange
            Wagon wagon = new();
            wagon.TryToAddAnimalToWagon(new Animal(AnimalEnums.SizePoint.Big, AnimalEnums.FoodType.Herbivore));
            wagon.TryToAddAnimalToWagon(new Animal(AnimalEnums.SizePoint.Medium, AnimalEnums.FoodType.Herbivore));

            // Act & Assert
            Assert.AreEqual(true, wagon.DoesNotExceedMaxCapacity(new Animal(AnimalEnums.SizePoint.Small, AnimalEnums.FoodType.Herbivore)));
        }

        [TestMethod]
        public void DoesNotExceedMaxCapacity_No()
        {
            // Arrange
            Wagon wagon = new();
            wagon.TryToAddAnimalToWagon(new Animal(AnimalEnums.SizePoint.Big, AnimalEnums.FoodType.Herbivore));
            wagon.TryToAddAnimalToWagon(new Animal(AnimalEnums.SizePoint.Medium, AnimalEnums.FoodType.Herbivore));

            // Act & Assert
            Assert.AreEqual(false, wagon.DoesNotExceedMaxCapacity(new Animal(AnimalEnums.SizePoint.Medium, AnimalEnums.FoodType.Herbivore)));
        }

        [TestMethod]
        public void DoesWagonContainCarnivore_Yes()
        {
            // Arrange
            Wagon wagon = new();
            wagon.TryToAddAnimalToWagon(new Animal(AnimalEnums.SizePoint.Big, AnimalEnums.FoodType.Carnivore));

            // Act & Assert
            Assert.AreEqual(true, wagon.DoesWagonContainCarnivore());
        }

        [TestMethod]
        public void DoesWagonContainCarnivore_No()
        {
            // Arrange
            Wagon wagon = new();
            wagon.TryToAddAnimalToWagon(new Animal(AnimalEnums.SizePoint.Big, AnimalEnums.FoodType.Herbivore));

            // Act & Assert
            Assert.AreEqual(false, wagon.DoesWagonContainCarnivore());
        }

        [TestMethod]
        public void AreAllAnimalsBiggerThanCarnivore_Yes()
        {
            // Arrange
            Wagon wagonBigHerbivore = new();
            Wagon wagonMediumHerbivore = new();
            Wagon wagonSmallHerbivore = new();

            wagonBigHerbivore.TryToAddAnimalToWagon(new Animal(AnimalEnums.SizePoint.Big, AnimalEnums.FoodType.Herbivore));
            wagonMediumHerbivore.TryToAddAnimalToWagon(new Animal(AnimalEnums.SizePoint.Medium, AnimalEnums.FoodType.Herbivore));
            wagonSmallHerbivore.TryToAddAnimalToWagon(new Animal(AnimalEnums.SizePoint.Small, AnimalEnums.FoodType.Herbivore));

            // Act & Assert
            Assert.AreEqual(true, wagonBigHerbivore.AreAllAnimalsBiggerThanCarnivore(new Animal(AnimalEnums.SizePoint.Small, AnimalEnums.FoodType.Carnivore)));
            Assert.AreEqual(true, wagonMediumHerbivore.AreAllAnimalsBiggerThanCarnivore(new Animal(AnimalEnums.SizePoint.Small, AnimalEnums.FoodType.Carnivore)));
            Assert.AreEqual(false, wagonSmallHerbivore.AreAllAnimalsBiggerThanCarnivore(new Animal(AnimalEnums.SizePoint.Small, AnimalEnums.FoodType.Carnivore)));
        }

        [TestMethod]
        public void AreAllAnimalsBiggerThanCarnivore_No()
        {
            // Arrange
            Wagon wagonBigHerbivore = new();
            Wagon wagonMediumHerbivore = new();
            Wagon wagonSmallHerbivore = new();

            wagonBigHerbivore.TryToAddAnimalToWagon(new Animal(AnimalEnums.SizePoint.Big, AnimalEnums.FoodType.Herbivore));
            wagonMediumHerbivore.TryToAddAnimalToWagon(new Animal(AnimalEnums.SizePoint.Medium, AnimalEnums.FoodType.Herbivore));
            wagonSmallHerbivore.TryToAddAnimalToWagon(new Animal(AnimalEnums.SizePoint.Small, AnimalEnums.FoodType.Herbivore));

            // Act & Assert
            Assert.AreEqual(false, wagonBigHerbivore.AreAllAnimalsBiggerThanCarnivore(new Animal(AnimalEnums.SizePoint.Big, AnimalEnums.FoodType.Carnivore)));
            Assert.AreEqual(false, wagonMediumHerbivore.AreAllAnimalsBiggerThanCarnivore(new Animal(AnimalEnums.SizePoint.Big, AnimalEnums.FoodType.Carnivore)));
            Assert.AreEqual(false, wagonSmallHerbivore.AreAllAnimalsBiggerThanCarnivore(new Animal(AnimalEnums.SizePoint.Big, AnimalEnums.FoodType.Carnivore)));
        }

        [TestMethod]
        public void IsCurrentAnimalBiggerThanCarnivore_Yes()
        {
            // Arrange
            Wagon wagon = new();
            Animal currentAnimal = new(AnimalEnums.SizePoint.Big, AnimalEnums.FoodType.Carnivore);
            Animal carnivore = new(AnimalEnums.SizePoint.Small, AnimalEnums.FoodType.Carnivore);

            // Act & Assert
            Assert.AreEqual(true, wagon.IsCurrentAnimalBiggerThanCarnivore(currentAnimal, carnivore));
        }

        [TestMethod]
        public void IsCurrentAnimalBiggerThanCarnivore_No()
        {
            // Arrange
            Wagon wagon = new();
            Animal currentAnimal = new(AnimalEnums.SizePoint.Small, AnimalEnums.FoodType.Carnivore);
            Animal carnivore = new(AnimalEnums.SizePoint.Big, AnimalEnums.FoodType.Carnivore);

            // Act & Assert
            Assert.AreEqual(false, wagon.IsCurrentAnimalBiggerThanCarnivore(currentAnimal, carnivore));
        }

        [TestMethod]
        public void IsCurrentAnimalCarnivore_Yes()
        {
            // Arrange
            Wagon wagon = new();
            Animal animal = new(AnimalEnums.SizePoint.Big, AnimalEnums.FoodType.Carnivore);

            // Act & Assert
            Assert.AreEqual(true, wagon.IsCurrentAnimalCarnivore(animal));
        }

        [TestMethod]
        public void IsCurrentAnimalCarnivore_No()
        {
            // Arrange
            Wagon wagon = new();
            Animal animal = new(AnimalEnums.SizePoint.Big, AnimalEnums.FoodType.Herbivore);

            // Act & Assert
            Assert.AreEqual(false, wagon.IsCurrentAnimalCarnivore(animal));
        }
        #endregion

        #region Scenario Tests    
        [TestMethod]
        public void DivideAnimalsOverWagons_Scenario3()
        {
            // NOT WORKING YET!
            // Arrange
            List<Animal> animals = new List<Animal>()
            {
                new Animal(AnimalEnums.SizePoint.Big, AnimalEnums.FoodType.Carnivore),
                new Animal(AnimalEnums.SizePoint.Medium, AnimalEnums.FoodType.Carnivore),
                new Animal(AnimalEnums.SizePoint.Small, AnimalEnums.FoodType.Carnivore),
                new Animal(AnimalEnums.SizePoint.Big, AnimalEnums.FoodType.Herbivore),
                new Animal(AnimalEnums.SizePoint.Medium, AnimalEnums.FoodType.Herbivore),
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
            Assert.AreEqual(4, carnivoreDescendingTrain.Wagons.Count()); // CarnivoreDescendingAnimals
            Assert.AreEqual(4, carnivoreAscendingTrain.Wagons.Count()); // CarnivoreAscendingAnimals
            Assert.AreEqual(4, herbivoreDescendingTrain.Wagons.Count()); // HerbivoreDescendingAnimals
            Assert.AreEqual(4, herbivoreAscendingTrain.Wagons.Count()); // HerbivoreAscendingAnimals
        }

        [TestMethod]
        public void DivideAnimalsOverWagons_Scenario6()
        {
            // Arrange
            List<Animal> animals = new List<Animal>()
            {
                new Animal(AnimalEnums.SizePoint.Big, AnimalEnums.FoodType.Herbivore),
                new Animal(AnimalEnums.SizePoint.Big, AnimalEnums.FoodType.Herbivore),
                new Animal(AnimalEnums.SizePoint.Big, AnimalEnums.FoodType.Herbivore),
                new Animal(AnimalEnums.SizePoint.Medium, AnimalEnums.FoodType.Herbivore),
                new Animal(AnimalEnums.SizePoint.Medium, AnimalEnums.FoodType.Herbivore),
                new Animal(AnimalEnums.SizePoint.Small, AnimalEnums.FoodType.Carnivore),
                new Animal(AnimalEnums.SizePoint.Small, AnimalEnums.FoodType.Carnivore),
                new Animal(AnimalEnums.SizePoint.Small, AnimalEnums.FoodType.Carnivore)
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
            // CarnivoreDescendingAnimals == Most Efficient
            Assert.AreEqual(3, carnivoreDescendingTrain.Wagons.Count());

            // Wagon 1:
            Assert.AreEqual(AnimalEnums.SizePoint.Small, carnivoreDescendingTrain.Wagons[0].Animals[0].SizePoint);
            Assert.AreEqual(AnimalEnums.FoodType.Carnivore, carnivoreDescendingTrain.Wagons[0].Animals[0].FoodType);

            Assert.AreEqual(AnimalEnums.SizePoint.Big, carnivoreDescendingTrain.Wagons[0].Animals[1].SizePoint);
            Assert.AreEqual(AnimalEnums.FoodType.Herbivore, carnivoreDescendingTrain.Wagons[0].Animals[1].FoodType);

            Assert.AreEqual(AnimalEnums.SizePoint.Medium, carnivoreDescendingTrain.Wagons[0].Animals[2].SizePoint);
            Assert.AreEqual(AnimalEnums.FoodType.Herbivore, carnivoreDescendingTrain.Wagons[0].Animals[2].FoodType);

            // Wagon 2:
            Assert.AreEqual(AnimalEnums.SizePoint.Small, carnivoreDescendingTrain.Wagons[1].Animals[0].SizePoint);
            Assert.AreEqual(AnimalEnums.FoodType.Carnivore, carnivoreDescendingTrain.Wagons[1].Animals[0].FoodType);

            Assert.AreEqual(AnimalEnums.SizePoint.Big, carnivoreDescendingTrain.Wagons[1].Animals[1].SizePoint);
            Assert.AreEqual(AnimalEnums.FoodType.Herbivore, carnivoreDescendingTrain.Wagons[1].Animals[1].FoodType);

            Assert.AreEqual(AnimalEnums.SizePoint.Medium, carnivoreDescendingTrain.Wagons[1].Animals[2].SizePoint);
            Assert.AreEqual(AnimalEnums.FoodType.Herbivore, carnivoreDescendingTrain.Wagons[1].Animals[2].FoodType);

            // Wagon 3:
            Assert.AreEqual(AnimalEnums.SizePoint.Small, carnivoreDescendingTrain.Wagons[2].Animals[0].SizePoint);
            Assert.AreEqual(AnimalEnums.FoodType.Carnivore, carnivoreDescendingTrain.Wagons[2].Animals[0].FoodType);

            Assert.AreEqual(AnimalEnums.SizePoint.Big, carnivoreDescendingTrain.Wagons[2].Animals[1].SizePoint);
            Assert.AreEqual(AnimalEnums.FoodType.Herbivore, carnivoreDescendingTrain.Wagons[2].Animals[1].FoodType);

            // CarnivoreAscendingAnimals
            Assert.AreEqual(4, carnivoreAscendingTrain.Wagons.Count());

            // HerbivoreDescendingAnimals
            Assert.AreEqual(4, herbivoreDescendingTrain.Wagons.Count());

            // HerbivoreAscendingAnimals
            Assert.AreEqual(4, herbivoreAscendingTrain.Wagons.Count());
        }
        #endregion
    }
}