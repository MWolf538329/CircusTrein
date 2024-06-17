
namespace CircusTrein.Models
{
    public class Wagon
    {
        public const int _MAXCAPACITYSIZE = 10;

        public int CurrentCapacity { get { return animals.Sum(a => (int)a.SizePoint); } }
        public IReadOnlyList<Animal> Animals { get { return animals; } }
        private List<Animal> animals { get; set; } = new();

        public bool TryToAddAnimalToWagon(Animal currentAnimal)
        {
            if (animals.Count() == 0) return AddAnimalToWagon(currentAnimal);

            if (IsAnimalCompatible(currentAnimal)) return AddAnimalToWagon(currentAnimal);

            return false;
        }

        private bool AddAnimalToWagon(Animal animal)
        {
            animals.Add(animal);
            return true;
        }

        private bool IsAnimalCompatible(Animal currentAnimal)
        {
            if (DoesNotExceedMaxCapacity(currentAnimal) && !WillThereBeAFight(currentAnimal))
            {
                //AddAnimalToWagon(currentAnimal);
                return true;
            }
            else
                return false;




            //if (DoesNotExceedMaxCapacity(currentAnimal))
            //{
            //    if (!DoesWagonContainCarnivore())
            //    {
            //        if (IsCurrentAnimalCarnivore(currentAnimal))
            //            if (!AreAllAnimalsBiggerThanCarnivore(currentAnimal)) isCompatible = false;
            //    }
            //    else
            //    {
            //        if (!IsCurrentAnimalCarnivore(currentAnimal))
            //        {
            //            if (!IsCurrentAnimalBiggerThanCarnivore(currentAnimal,
            //            animals.Where(a => a.FoodType == AnimalEnums.FoodType.Carnivore).FirstOrDefault()!)) isCompatible = false;
            //        }
            //        else isCompatible = false;
            //    }
            //}
            //else isCompatible = false;

            //return isCompatible;
        }

        private bool WillThereBeAFight(Animal currentAnimal)
        {
            bool fight = false;

            foreach (Animal animal in animals)
            {
                if (!fight) fight = animal.WillThereBeAFight(currentAnimal);
            }

            return fight;

            //foreach (Animal animal in animals)
            //{
            //    if (currentAnimal.GaDeGijVechte(animal))
            //{ }
            //        if ((int)animal.SizePoint <= (int)carnivore.SizePoint) isCompatible = false;
            //}
        }

        #region Checks
        public bool DoesNotExceedMaxCapacity(Animal currentAnimal)
        {
            return (CurrentCapacity + (int)currentAnimal.SizePoint) <= Wagon._MAXCAPACITYSIZE;
        }

        public bool DoesWagonContainCarnivore()
        {
            return animals.Where(a => a.FoodType == AnimalEnums.FoodType.Carnivore).Any();
        }

        public bool AreAllAnimalsBiggerThanCarnivore(Animal carnivore)
        {
            bool isCompatible = true;

            foreach (Animal animal in animals)
            {
                if (isCompatible)
                    if ((int)animal.SizePoint <= (int)carnivore.SizePoint) isCompatible = false;
            }

            return isCompatible;
        }

        public bool IsCurrentAnimalBiggerThanCarnivore(Animal currentAnimal, Animal carnivore)
        {
            return currentAnimal.SizePoint > carnivore.SizePoint;
        }

        public bool IsCurrentAnimalCarnivore(Animal currentAnimal)
        {
            return currentAnimal.FoodType == AnimalEnums.FoodType.Carnivore;
        }
        #endregion
    }
}
