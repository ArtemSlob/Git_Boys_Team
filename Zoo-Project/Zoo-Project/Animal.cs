using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2021_09_28_Zoo
{
    class Animal
    {
        public string AnimalName;
        public double AnimalCost;
        public bool IsAnamalScary;

        public Animal(string animalName, double animalCost, bool isAnamalScary)
        {
            AnimalName = animalName;
            AnimalCost = animalCost;
            IsAnamalScary = isAnamalScary;
        }
    }
}
