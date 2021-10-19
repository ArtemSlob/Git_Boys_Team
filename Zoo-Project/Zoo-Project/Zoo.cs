using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zoo_Project
{
   static class Zoo
    {
        static public List<Animal> Animals = new List<Animal>()
        {
            new Animal("Tiger", 150, true),
            new Animal("Wolf", 82, true),
            new Animal("Chicken", 305, false),
            new Animal("Phyton", 50, false),
            new Animal("Bear", 220, false),
            new Animal("Peacock", 180, false),
            new Animal("Penguin", 120, false)
        };

        static public int VisitorAmount;
        static public int AllVisitorAmount;
        static public double Earnings;
        static public double Treats = 100;
        static public int MaxVisitors = 5;

    }
}
