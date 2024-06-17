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

        public bool WillThereBeAFight(Animal animal)
        {
            return FoodType == AnimalEnums.FoodType.Carnivore && (int)SizePoint <= (int)animal.SizePoint;
        }

        public override string ToString()
        {
            return $"{SizePoint} - {FoodType} - {(int)SizePoint}";
        }
    }
}
