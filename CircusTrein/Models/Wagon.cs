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

            if (DoesNotExceedMaxCapacity(currentAnimal))
            {
                if (!DoesWagonContainCarnivore())
                {
                    return AddAnimalToWagon(currentAnimal);
                }
                else
                {
                    if (IsAnimalCompatible(currentAnimal))
                    {
                        return AddAnimalToWagon(currentAnimal);
                    }
                }
            }
            return false;
        }

        private bool AddAnimalToWagon(Animal animal)
        {
            animals.Add(animal);
            return true;
        }

        #region Checks
        private bool DoesNotExceedMaxCapacity(Animal currentAnimal)
        {
            return (CurrentCapacity + (int)currentAnimal.SizePoint) <= Wagon._MAXCAPACITYSIZE;
        }

        private bool IsAnimalCompatible(Animal currentAnimal)
        {
            if (IsCurrentAnimalBiggerThanCarnivore(currentAnimal,
                animals.Where(a => a.FoodType == AnimalEnums.FoodType.Carnivore).FirstOrDefault()!))
            {
                if (!IsCurrentAnimalCarnivore(currentAnimal))
                {
                    return true;
                }
            }
            return false;
        }

        private bool DoesWagonContainCarnivore()
        {
            return animals.Where(a => a.FoodType == AnimalEnums.FoodType.Carnivore).Count() != 0;
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
