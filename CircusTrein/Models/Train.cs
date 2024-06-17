namespace CircusTrein.Models
{
    public class Train
    {
        public IReadOnlyList<Wagon> Wagons { get { return wagons; } }
        private List<Wagon> wagons { get; set; } = new();

        public void DivideAnimalsOverWagons(List<Animal> animals)
        {
            if (wagons.Count == 0)
            {
                AddWagonToTrain();
            }

            foreach (Animal currentAnimal in animals)
            {
                bool animalAddedToWagon = false;

                foreach (Wagon currentWagon in wagons)
                {
                    if (!animalAddedToWagon)
                    {
                        animalAddedToWagon = currentWagon.TryToAddAnimalToWagon(currentAnimal);
                    }
                }

                if (!animalAddedToWagon)
                {
                    AddWagonToTrain();
                    wagons.Last().TryToAddAnimalToWagon(currentAnimal);
                }
            }
        }

        public void AddWagonToTrain()
        {
            wagons.Add(new Wagon());
        }
    }
}
