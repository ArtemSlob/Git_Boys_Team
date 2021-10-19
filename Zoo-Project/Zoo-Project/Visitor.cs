using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zoo_Project
{
   public class Visitor
    {
            public int Age;
            public double Money;

            public Visitor(int age)
            {
                Age = age;

                Random randomMoney = new Random();
                Money = randomMoney.Next(1500, 2000);
            }
        }
    }


