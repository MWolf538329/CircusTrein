using CircusTrein.Models;

namespace CircusTreinUnitTests
{
    [TestClass]
    public class AnimalTests
    {
        [TestMethod]
        public void CanCoexist_Yes()
        {
            // Arrange
            Animal smallHerbivore = new(AnimalEnums.SizePoint.Small, AnimalEnums.FoodType.Herbivore);
            Animal mediumHerbivore = new(AnimalEnums.SizePoint.Medium, AnimalEnums.FoodType.Herbivore);
            Animal bigHerbivore = new(AnimalEnums.SizePoint.Big, AnimalEnums.FoodType.Herbivore);

            Animal smallCarnivore = new(AnimalEnums.SizePoint.Small, AnimalEnums.FoodType.Carnivore);
            Animal mediumCarnivore = new(AnimalEnums.SizePoint.Medium, AnimalEnums.FoodType.Carnivore);

            // Act & Assert
            // Herbivore Tests
            Assert.AreEqual(true, smallHerbivore.CanCoexist(smallHerbivore));
            Assert.AreEqual(true, smallHerbivore.CanCoexist(mediumHerbivore));
            Assert.AreEqual(true, smallHerbivore.CanCoexist(bigHerbivore));

            Assert.AreEqual(true, mediumHerbivore.CanCoexist(smallHerbivore));
            Assert.AreEqual(true, mediumHerbivore.CanCoexist(mediumHerbivore));
            Assert.AreEqual(true, mediumHerbivore.CanCoexist(bigHerbivore));

            Assert.AreEqual(true, bigHerbivore.CanCoexist(smallHerbivore));
            Assert.AreEqual(true, bigHerbivore.CanCoexist(mediumHerbivore));
            Assert.AreEqual(true, bigHerbivore.CanCoexist(bigHerbivore));

            // Carnivore tests
            Assert.AreEqual(true, mediumHerbivore.CanCoexist(smallCarnivore));
            Assert.AreEqual(true, bigHerbivore.CanCoexist(mediumCarnivore));
        }

        [TestMethod]
        public void CanCoexist_No()
        {
            // Arrange
            Animal smallHerbivore = new(AnimalEnums.SizePoint.Small, AnimalEnums.FoodType.Herbivore);
            Animal mediumHerbivore = new(AnimalEnums.SizePoint.Medium, AnimalEnums.FoodType.Herbivore);
            Animal bigHerbivore = new(AnimalEnums.SizePoint.Big, AnimalEnums.FoodType.Herbivore);

            Animal smallCarnivore = new(AnimalEnums.SizePoint.Small, AnimalEnums.FoodType.Carnivore);
            Animal mediumCarnivore = new(AnimalEnums.SizePoint.Medium, AnimalEnums.FoodType.Carnivore);
            Animal bigCarnivore = new(AnimalEnums.SizePoint.Big, AnimalEnums.FoodType.Carnivore);

            // Act & Assert
            Assert.AreEqual(false, smallHerbivore.CanCoexist(smallCarnivore));
            Assert.AreEqual(false, smallHerbivore.CanCoexist(mediumCarnivore));
            Assert.AreEqual(false, smallHerbivore.CanCoexist(bigCarnivore));

            Assert.AreEqual(false, mediumHerbivore.CanCoexist(mediumCarnivore));
            Assert.AreEqual(false, mediumHerbivore.CanCoexist(bigCarnivore));

            Assert.AreEqual(false, bigHerbivore.CanCoexist(bigCarnivore));
        }
    }
}
