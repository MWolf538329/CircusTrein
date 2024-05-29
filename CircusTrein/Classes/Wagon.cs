using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CircusTrein.Classes
{
    public class Wagon
    {
        private List<Animal> animals { get; set; }
        public IReadOnlyList<Animal> Animals { get { return animals; } }
        public int CurrentCapacity { get; private set; }

        public const int _MAXCAPACITYSIZE = 10;
        private bool animalIsCompatible = false;
        private bool wagonHasCarnivore = false;

        public Wagon()
        {
            animals = new();
            CurrentCapacity = 0;
        }

        public bool TryToAddAnimalToWagon(Animal currentAnimal, bool animalAddedToWagon)
        {
            if (Animals!.Count == 0) // wagon.animals is empty.
            {
                return AddAnimalToWagon(currentAnimal); // Animal is added to a wagon.
            }
            else if ((CurrentCapacity + (int)currentAnimal.SizePoint) <= Wagon._MAXCAPACITYSIZE) // CurrentCapacity + Animal.Points does NOT exceed Wagon_MAXCAPACITYSIZE.
            {
                wagonHasCarnivore = false;

                foreach (Animal animalInWagon in Animals.ToList())
                {
                    if (!animalAddedToWagon)
                    {
                        if (animalInWagon.FoodType == CustomEnum.FoodType.Carnivore)
                        {
                            wagonHasCarnivore = true;

                            if ((int)currentAnimal.SizePoint > (int)animalInWagon.SizePoint)
                            {
                                if (currentAnimal.FoodType != CustomEnum.FoodType.Carnivore)
                                {
                                    animalAddedToWagon = AddAnimalToWagon(currentAnimal);
                                    return animalAddedToWagon;
                                }
                            }
                        }
                        else
                        {
                            if (!wagonHasCarnivore)
                            {
                                animalAddedToWagon = AddAnimalToWagon(currentAnimal);
                                return animalAddedToWagon;
                            }
                        }
                    }
                }
            }
            return false;
        }

        public bool AddAnimalToWagon(Animal animal)
        {
            animals!.Add(animal);
            CurrentCapacity += (int)animal.SizePoint;
            return true;
        }
    }
}
