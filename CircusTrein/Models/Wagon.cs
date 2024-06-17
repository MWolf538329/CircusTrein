
namespace CircusTrein.Models
{
    public class Wagon
    {
        private const int _MAXCAPACITYSIZE = 10;

        public int CurrentCapacity { get { return animals.Sum(a => (int)a.SizePoint); } }
        public IReadOnlyList<Animal> Animals { get { return animals; } }
        private List<Animal> animals { get; set; } = new();

        public bool TryToAddAnimalToWagon(Animal currentAnimal)
        {
            if (IsAnimalCompatible(currentAnimal)) return AddAnimalToWagon(currentAnimal);

            return false;
        }

        public bool DoesNotExceedMaxCapacity(Animal currentAnimal)
        {
            return (CurrentCapacity + (int)currentAnimal.SizePoint) <= Wagon._MAXCAPACITYSIZE;

        }

        private bool IsAnimalCompatible(Animal currentAnimal)
        {
            return DoesNotExceedMaxCapacity(currentAnimal) && CheckIfAnimalsCanCoexist(currentAnimal);
        }

        private bool CheckIfAnimalsCanCoexist(Animal currentAnimal)
        {
            bool coexist = true;

            foreach (Animal animal in animals)
            {
                if (coexist) coexist = animal.CanCoexist(currentAnimal);
            }

            return coexist;
        }

        private bool AddAnimalToWagon(Animal animal)
        {
            animals.Add(animal);
            return true;
        }
    }
}
