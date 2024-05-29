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

        public override string ToString()
        {
            return $"{SizePoint} - {FoodType} - {(int)SizePoint}";
        }
    }
}
