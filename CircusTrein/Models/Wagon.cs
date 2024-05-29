namespace CircusTrein.Models
{
    public class Wagon
    {
        public const int _MAXCAPACITYSIZE = 10;

        public int CurrentCapacity { get; private set; } = 0;
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




            //if (Animals!.Count == 0) // wagon.animals is empty.
            //{
            //    return AddAnimalToWagon(currentAnimal); // Animal is added to a wagon.
            //}
            //else if ((CurrentCapacity + (int)currentAnimal.SizePoint) <= Wagon._MAXCAPACITYSIZE) // CurrentCapacity + Animal.Points does NOT exceed Wagon_MAXCAPACITYSIZE.
            //{
            //    wagonHasCarnivore = false;

            //    foreach (Animal animalInWagon in Animals.ToList())
            //    {
            //        if (!animalAddedToWagon)
            //        {
            //            if (animalInWagon.FoodType == AnimalEnums.FoodType.Carnivore)
            //            {
            //                wagonHasCarnivore = true;

            //                if ((int)currentAnimal.SizePoint > (int)animalInWagon.SizePoint)
            //                {
            //                    if (currentAnimal.FoodType != AnimalEnums.FoodType.Carnivore)
            //                    {
            //                        animalAddedToWagon = AddAnimalToWagon(currentAnimal);
            //                        return animalAddedToWagon;
            //                    }
            //                }
            //            }
            //            else
            //            {
            //                if (!wagonHasCarnivore)
            //                {
            //                    animalAddedToWagon = AddAnimalToWagon(currentAnimal);
            //                    return animalAddedToWagon;
            //                }
            //            }
            //        }
            //    }
            //}
            //return false;
        }

        private bool AddAnimalToWagon(Animal animal)
        {
            animals.Add(animal);
            CurrentCapacity += (int)animal.SizePoint;
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
                    return AddAnimalToWagon(currentAnimal);
                }
            }
            return false;
        }

        private bool DoesWagonContainCarnivore()
        {
            return animals.Where(a => a.FoodType == AnimalEnums.FoodType.Carnivore).Count() != 0;
        }

        private bool IsCurrentAnimalBiggerThanCarnivore(Animal currentAnimal, Animal carnivore)
        {
            return currentAnimal.SizePoint > carnivore.SizePoint;
        }

        private bool IsCurrentAnimalCarnivore(Animal currentAnimal)
        {
            return currentAnimal.FoodType == AnimalEnums.FoodType.Carnivore;
        }
        #endregion
    }
}
