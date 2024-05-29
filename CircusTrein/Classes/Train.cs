using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CircusTrein.Classes
{
    public class Train
    {
        private List<Wagon> wagons { get; set; }
        public IReadOnlyList<Wagon> Wagons { get { return wagons; } }

        public Train()
        {
            wagons = new();
        }

        public void DevideAnimalsOverWagons(List<Animal> animals)
        {
            if (wagons.Count == 0)
            {
                AddWagonToTrain();
            }

            foreach (Animal currentAnimal in animals)
            {
                bool animalAddedToWagon = false;

                foreach (Wagon currentWagon in Wagons.ToList())
                {
                    if (!animalAddedToWagon)
                    {
                        animalAddedToWagon = currentWagon.TryToAddAnimalToWagon(currentAnimal, animalAddedToWagon);
                    }
                }

                if (!animalAddedToWagon)
                {
                    AddWagonToTrain();
                    Wagons.Last().TryToAddAnimalToWagon(currentAnimal, animalAddedToWagon);
                }
            }
        }

        public void AddWagonToTrain()
        {
            wagons.Add(new Wagon());
        }
    }
}
