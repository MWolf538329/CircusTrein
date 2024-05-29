using CircusTrein.Classes;

namespace CircusTrein
{
    public partial class CircusTrein : Form
    {
        private Train train;
        private List<Animal> animals;

        public CircusTrein()
        {
            InitializeComponent();
        }

        private void CircusTrein_Load(object sender, EventArgs e)
        {
            train = new();
            animals = new();

            FillUIElements();
        }

        private void btn_AddAnimal_Click(object sender, EventArgs e)
        {
            if (!String.IsNullOrWhiteSpace(cb_Size.SelectedItem.ToString()) && !String.IsNullOrWhiteSpace(cb_FoodType.SelectedItem.ToString()))
            {
                Animal newAnimal = new Animal((CustomEnum.SizePoint)cb_Size.SelectedItem, (CustomEnum.FoodType)cb_FoodType.SelectedItem);

                animals.Add(newAnimal);
                lb_AnimalList.Items.Add(newAnimal.ToString());
            }
            else
            {
                MessageBox.Show("Not all comboboxes are filled!");
            }
        }

        private void btn_ClearAnimalList_Click(object sender, EventArgs e)
        {
            animals.Clear();
            lb_AnimalList.Items.Clear();
            train = new();
            txt_Output.Text = string.Empty;
        }

        private void btn_Calculate_Click(object sender, EventArgs e)
        {
            /// Find the most efficient way to sort the animals over the wagons...
            /// Link: https://en.wikipedia.org/wiki/Bin_packing_problem

            // Does NOT work with Scenario 3.
            /// Carnivore first -> Descending
            //animals = animals.OrderBy(a => (int)a.FoodType).ThenBy(a => (int)a.SizePoint).Reverse().ToList();

            // Works with Scenario 3 but not with 1.
            /// Carnivore first -> Ascending
            //animals = animals.OrderBy(a => (int)a.FoodType).ThenBy(a => (int)a.SizePoint).ToList();

            Train carnivoreDescendingTrain = new();
            Train carnivoreAscendingTrain = new();
            Train herbivoreDescendingTrain = new();
            Train herbivoreAscendingTrain = new();

            List<Animal> carnivoreDescendingAnimals = animals.OrderBy(a => (int)a.FoodType).ThenBy(a => (int)a.SizePoint).Reverse().ToList();
            List<Animal> carnivoreAscendingAnimals = animals.OrderBy(a => (int)a.SizePoint).ThenBy(a => (int)a.FoodType).ToList();
            List<Animal> herbivoreDescendingAnimals = animals.OrderByDescending(a => (int)a.FoodType).ThenBy(a => (int)a.SizePoint).Reverse().ToList();
            List<Animal> herbivoreAscendingAnimals = animals.OrderBy(a => (int)a.FoodType).ThenBy(a => (int)a.SizePoint).ToList();

            carnivoreDescendingTrain.DevideAnimalsOverWagons(carnivoreDescendingAnimals);
            carnivoreAscendingTrain.DevideAnimalsOverWagons(carnivoreAscendingAnimals);
            herbivoreDescendingTrain.DevideAnimalsOverWagons(herbivoreDescendingAnimals);
            herbivoreAscendingTrain.DevideAnimalsOverWagons(herbivoreAscendingAnimals);

            //train.DevideAnimalsOverWagons(animals);

            //OutputResult(carnivoreDescendingTrain);

            txt_Output.Text += $"CarnivoreDescendingTrain: {carnivoreDescendingTrain.Wagons.Count}" + Environment.NewLine;
            txt_Output.Text += $"CarnivoreAscendingTrain: {carnivoreAscendingTrain.Wagons.Count}" + Environment.NewLine;
            txt_Output.Text += $"HerbivoreDescendingTrain: {herbivoreDescendingTrain.Wagons.Count}" + Environment.NewLine;
            txt_Output.Text += $"HerbivoreAscendingTrain: {herbivoreAscendingTrain.Wagons.Count}" + Environment.NewLine;
        }

        #region UI
        private void FillUIElements()
        {
            FillSizeComboBox();
            FillFoodTypeComboBox();
        }

        private void FillSizeComboBox()
        {
            CustomEnum.SizePoint[] sizePointItems = (CustomEnum.SizePoint[])Enum.GetValues(typeof(CustomEnum.SizePoint));

            for (int i = 0; i < sizePointItems.Length; i++)
            {
                cb_Size.Items.Add(sizePointItems[i]);
            }
        }

        private void FillFoodTypeComboBox()
        {
            CustomEnum.FoodType[] foodTypeItems = (CustomEnum.FoodType[])Enum.GetValues(typeof(CustomEnum.FoodType));

            for (int i = 0; i < foodTypeItems.Length; i++)
            {
                cb_FoodType.Items.Add(foodTypeItems[i]);
            }
        }

        private void OutputResult(Train train)
        {
            string result = string.Empty;

            result += "Begin van de trein:" + Environment.NewLine;

            for (int i = 0; i < train.Wagons.Count; i++)
            {
                result += $"Wagen {i + 1} - Capaciteit: {train.Wagons[i].CurrentCapacity}: " + Environment.NewLine;

                foreach (Animal animal in train.Wagons[i].Animals)
                {
                    result += animal.ToString() + Environment.NewLine;
                }

                result += Environment.NewLine;
            }

            result += "Einde van de trein!";

            txt_Output.Text = result;
        }
        #endregion

        #region Scenario's
        private void btn_LoadScenario1_Click(object sender, EventArgs e)
        {
            animals.AddRange(new List<Animal>() {
                new Animal(CustomEnum.SizePoint.Small ,CustomEnum.FoodType.Carnivore),
                new Animal(CustomEnum.SizePoint.Big ,CustomEnum.FoodType.Herbivore),
                new Animal(CustomEnum.SizePoint.Big ,CustomEnum.FoodType.Herbivore),
                new Animal(CustomEnum.SizePoint.Medium ,CustomEnum.FoodType.Herbivore),
                new Animal(CustomEnum.SizePoint.Medium ,CustomEnum.FoodType.Herbivore),
                new Animal(CustomEnum.SizePoint.Medium ,CustomEnum.FoodType.Herbivore)
            });

            foreach (Animal animal in animals)
            {
                lb_AnimalList.Items.Add(animal.ToString());
            }
        }

        private void btn_LoadScenario2_Click(object sender, EventArgs e)
        {
            animals.AddRange(new List<Animal>() {
                new Animal(CustomEnum.SizePoint.Small, CustomEnum.FoodType.Carnivore),
                new Animal(CustomEnum.SizePoint.Big, CustomEnum.FoodType.Herbivore),
                new Animal(CustomEnum.SizePoint.Medium, CustomEnum.FoodType.Herbivore),
                new Animal(CustomEnum.SizePoint.Medium, CustomEnum.FoodType.Herbivore),
                new Animal(CustomEnum.SizePoint.Small, CustomEnum.FoodType.Herbivore),
                new Animal(CustomEnum.SizePoint.Small, CustomEnum.FoodType.Herbivore),
                new Animal(CustomEnum.SizePoint.Small, CustomEnum.FoodType.Herbivore),
                new Animal(CustomEnum.SizePoint.Small, CustomEnum.FoodType.Herbivore),
                new Animal(CustomEnum.SizePoint.Small, CustomEnum.FoodType.Herbivore)
            });

            foreach (Animal animal in animals)
            {
                lb_AnimalList.Items.Add(animal.ToString());
            }
        }

        private void btn_LoadScenario3_Click(object sender, EventArgs e)
        {
            animals.AddRange(new List<Animal>() {
                new Animal(CustomEnum.SizePoint.Big, CustomEnum.FoodType.Carnivore),
                new Animal(CustomEnum.SizePoint.Medium, CustomEnum.FoodType.Carnivore),
                new Animal(CustomEnum.SizePoint.Small, CustomEnum.FoodType.Carnivore),
                new Animal(CustomEnum.SizePoint.Big, CustomEnum.FoodType.Herbivore),
                new Animal(CustomEnum.SizePoint.Medium, CustomEnum.FoodType.Herbivore),
                new Animal(CustomEnum.SizePoint.Small, CustomEnum.FoodType.Herbivore)
            });

            foreach (Animal animal in animals)
            {
                lb_AnimalList.Items.Add(animal.ToString());
            }
        }

        private void btn_LoadScenario4_Click(object sender, EventArgs e)
        {
            animals.AddRange(new List<Animal>()
            {
                new Animal(CustomEnum.SizePoint.Big, CustomEnum.FoodType.Carnivore),
                new Animal(CustomEnum.SizePoint.Big, CustomEnum.FoodType.Carnivore),
                new Animal(CustomEnum.SizePoint.Medium, CustomEnum.FoodType.Carnivore),
                new Animal(CustomEnum.SizePoint.Small, CustomEnum.FoodType.Carnivore),
                new Animal(CustomEnum.SizePoint.Big, CustomEnum.FoodType.Herbivore),
                new Animal(CustomEnum.SizePoint.Medium, CustomEnum.FoodType.Herbivore),
                new Animal(CustomEnum.SizePoint.Medium, CustomEnum.FoodType.Herbivore),
                new Animal(CustomEnum.SizePoint.Medium, CustomEnum.FoodType.Herbivore),
                new Animal(CustomEnum.SizePoint.Medium, CustomEnum.FoodType.Herbivore),
                new Animal(CustomEnum.SizePoint.Medium, CustomEnum.FoodType.Herbivore),
                new Animal(CustomEnum.SizePoint.Small, CustomEnum.FoodType.Herbivore)
            });

            foreach (Animal animal in animals)
            {
                lb_AnimalList.Items.Add(animal.ToString());
            }
        }

        private void btn_LoadScenario5_Click(object sender, EventArgs e)
        {
            animals.AddRange(new List<Animal>()
            {
                new Animal(CustomEnum.SizePoint.Small, CustomEnum.FoodType.Carnivore),
                new Animal(CustomEnum.SizePoint.Big, CustomEnum.FoodType.Herbivore),
                new Animal(CustomEnum.SizePoint.Big, CustomEnum.FoodType.Herbivore),
                new Animal(CustomEnum.SizePoint.Medium, CustomEnum.FoodType.Herbivore),
                new Animal(CustomEnum.SizePoint.Small, CustomEnum.FoodType.Herbivore)
            });

            foreach (Animal animal in animals)
            {
                lb_AnimalList.Items.Add(animal.ToString());
            }
        }

        private void btn_LoadScenario6_Click(object sender, EventArgs e)
        {
            animals.AddRange(new List<Animal>()
            {
                new Animal(CustomEnum.SizePoint.Small, CustomEnum.FoodType.Carnivore),
                new Animal(CustomEnum.SizePoint.Small, CustomEnum.FoodType.Carnivore),
                new Animal(CustomEnum.SizePoint.Small, CustomEnum.FoodType.Carnivore),
                new Animal(CustomEnum.SizePoint.Big, CustomEnum.FoodType.Herbivore),
                new Animal(CustomEnum.SizePoint.Big, CustomEnum.FoodType.Herbivore),
                new Animal(CustomEnum.SizePoint.Big, CustomEnum.FoodType.Herbivore),
                new Animal(CustomEnum.SizePoint.Medium, CustomEnum.FoodType.Herbivore),
                new Animal(CustomEnum.SizePoint.Medium, CustomEnum.FoodType.Herbivore)
            });

            foreach (Animal animal in animals)
            {
                lb_AnimalList.Items.Add(animal.ToString());
            }
        }

        private void btn_LoadScenario7_Click(object sender, EventArgs e)
        {
            animals.AddRange(new List<Animal>()
            {
                new Animal(CustomEnum.SizePoint.Big, CustomEnum.FoodType.Carnivore),
                new Animal(CustomEnum.SizePoint.Big, CustomEnum.FoodType.Carnivore),
                new Animal(CustomEnum.SizePoint.Big, CustomEnum.FoodType.Carnivore),
                new Animal(CustomEnum.SizePoint.Medium, CustomEnum.FoodType.Carnivore),
                new Animal(CustomEnum.SizePoint.Medium, CustomEnum.FoodType.Carnivore),
                new Animal(CustomEnum.SizePoint.Medium, CustomEnum.FoodType.Carnivore),
                new Animal(CustomEnum.SizePoint.Small, CustomEnum.FoodType.Carnivore),
                new Animal(CustomEnum.SizePoint.Small, CustomEnum.FoodType.Carnivore),
                new Animal(CustomEnum.SizePoint.Small, CustomEnum.FoodType.Carnivore),
                new Animal(CustomEnum.SizePoint.Small, CustomEnum.FoodType.Carnivore),
                new Animal(CustomEnum.SizePoint.Small, CustomEnum.FoodType.Carnivore),
                new Animal(CustomEnum.SizePoint.Small, CustomEnum.FoodType.Carnivore),
                new Animal(CustomEnum.SizePoint.Small, CustomEnum.FoodType.Carnivore),
                new Animal(CustomEnum.SizePoint.Big, CustomEnum.FoodType.Herbivore),
                new Animal(CustomEnum.SizePoint.Big, CustomEnum.FoodType.Herbivore),
                new Animal(CustomEnum.SizePoint.Big, CustomEnum.FoodType.Herbivore),
                new Animal(CustomEnum.SizePoint.Big, CustomEnum.FoodType.Herbivore),
                new Animal(CustomEnum.SizePoint.Big, CustomEnum.FoodType.Herbivore),
                new Animal(CustomEnum.SizePoint.Big, CustomEnum.FoodType.Herbivore),
                new Animal(CustomEnum.SizePoint.Medium, CustomEnum.FoodType.Herbivore),
                new Animal(CustomEnum.SizePoint.Medium, CustomEnum.FoodType.Herbivore),
                new Animal(CustomEnum.SizePoint.Medium, CustomEnum.FoodType.Herbivore),
                new Animal(CustomEnum.SizePoint.Medium, CustomEnum.FoodType.Herbivore),
                new Animal(CustomEnum.SizePoint.Medium, CustomEnum.FoodType.Herbivore)
            });

            foreach (Animal animal in animals)
            {
                lb_AnimalList.Items.Add(animal.ToString());
            }
        }
        #endregion
    }
}