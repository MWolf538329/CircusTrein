namespace CircusTrein.Models
{
    public class Animal
    {
        public AnimalEnums.SizePoint SizePoint { get; private set; }
        public AnimalEnums.FoodType FoodType { get; private set; }

        public Animal(AnimalEnums.SizePoint size, AnimalEnums.FoodType foodType)
        {
            SizePoint = size;
            FoodType = foodType;
        }

        public bool CanCoexist(Animal animal)
        {
            bool coexist = true;

            if (FoodType == AnimalEnums.FoodType.Carnivore && animal.FoodType == AnimalEnums.FoodType.Carnivore) 
                coexist = false;

            if (FoodType == AnimalEnums.FoodType.Herbivore && animal.FoodType == AnimalEnums.FoodType.Carnivore)
                if ((int)SizePoint <= (int)animal.SizePoint)
                    coexist = false;

            if (FoodType == AnimalEnums.FoodType.Carnivore && animal.FoodType == AnimalEnums.FoodType.Herbivore)
                if ((int)SizePoint >= (int)animal.SizePoint)
                    coexist = false;

            return coexist;
        }

        public override string ToString()
        {
            return $"{SizePoint} - {FoodType} - {(int)SizePoint}";
        }
    }
}
