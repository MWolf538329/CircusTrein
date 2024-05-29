using Accessibility;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace CircusTrein.Classes
{
    public class Animal
    {
        public CustomEnum.SizePoint SizePoint { get; private set; }
        public CustomEnum.FoodType FoodType { get; private set; }

        public Animal(CustomEnum.SizePoint size, CustomEnum.FoodType foodType)
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
