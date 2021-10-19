using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zoo_Project
{
    class Menu
    {
        static public void Start()
        {
            while (true)
            {
                MainMenu();
                ChooseMenuPoint();
            }
        }

        static public void MainMenu()
        {
            Console.WriteLine("Main Menu\n");
            Console.WriteLine($"Visitors Amount - {Zoo.VisitorAmount}");
            Console.WriteLine("1 - Sell Ticket");
            Console.WriteLine("2 - Kick out Visitors");
            Console.WriteLine("3 - Close Zoo");
            Console.WriteLine("4 - Show Statistic");
            Console.WriteLine("5 - Exit");
        }

        static public void ChooseMenuPoint()
        {
            int menuPoint;
            bool isNum = int.TryParse(Console.ReadLine(), out menuPoint);
            while (!isNum || menuPoint < 1 || menuPoint > 5)
            {
                Console.WriteLine("Wrong input! Try againe");
                isNum = int.TryParse(Console.ReadLine(), out menuPoint);
            }
            switch (menuPoint)
            {
                case 1:
                    SellTicket();
                    break;
                case 2:
                    KickOut();
                    break;
                case 3:
                    CloseZoo();
                    break;
                case 4:
                    Statistc();
                    break;
                case 5:
                    Environment.Exit(0);
                    break;
            }
        }

        static public void KickOut()
        {
            if (Zoo.VisitorAmount > 0)
            {
                Zoo.VisitorAmount--;
            }
            else
            {
                Console.WriteLine($"Amount of visitors in Zoo: {Zoo.VisitorAmount}");
            }
        }

        static public void CloseZoo()
        {
            Zoo.VisitorAmount = 0;
            Statistc();
        }

        static public void Statistc()
        {
            Console.WriteLine($"Earnings of Zoo: {Zoo.Earnings}$");
            Console.WriteLine($"Visitors amount of Zoo: {Zoo.AllVisitorAmount}");
        }
<<<<<<< HEAD

        static public void SellTicket()
        {
            Console.WriteLine("Sell Ticket Menu");
            if (Zoo.VisitorAmount == Zoo.MaxVisitors)
            {
                Console.WriteLine("Sorry! Zoo is full!");
                return;
            }
            else
            {
                Visitor visitor = new Visitor(AgeChoose());
                List<Animal> availebleAnimals = Zoo.Animals;
                if (visitor.VisitorAge < 14)
                {
                    for (int i = 0; i < availebleAnimals.Count; i++)
                    {
                        if (availebleAnimals[i].IsAnamalScary)
                        {
                            availebleAnimals.RemoveAt(i);
                            i--;
                        }
                    }
                }
                DisplayAnimals(availebleAnimals);
                Console.WriteLine("Chose Animals:");
                List<int> chosenAnimals = AskNumOfAnimals(availebleAnimals.Count);
                Console.WriteLine("Treats yes/no:");
                double treat = AskTreat() ? Zoo.Treats : 0;
                double ticketPrice = CountSum(chosenAnimals, treat);
                Console.WriteLine($"Total ticket price: {ticketPrice}$");
                if (!IsMoneyEnough(visitor.VisitorMoney, ticketPrice))
                {
                    Console.WriteLine($"Sorry, you have only {visitor.VisitorMoney}$ - its not enough!\n");
                }
                else
                {
                    Console.WriteLine("Welcome! Have fun in Zoo");
                    Zoo.VisitorAmount++;
                    Zoo.AllVisitorAmount++;
                    Zoo.Earnings += ticketPrice;
                    Console.WriteLine();
                }
            }
        }

        static public int AgeChoose()
        {
            Console.WriteLine("Enter visitor age: ");
            int visitorAge;
            bool isNum = int.TryParse(Console.ReadLine(), out visitorAge);
            while (!isNum || visitorAge < 7 || visitorAge > 125)
            {
                Console.WriteLine("Wrong input! Try againe");
                isNum = int.TryParse(Console.ReadLine(), out visitorAge);
            }
            return visitorAge;
        }

        private static bool IsMoneyEnough(double visitorMoney, double ticketPrice)
        {
            return visitorMoney >= ticketPrice;
        }

        static public void DisplayAnimals(List<Animal> animals)
        {
            int number = 1;
            foreach (Animal animal in animals)
            {
                Console.WriteLine($"{number++}. {animal.AnimalName} - {animal.AnimalCost}$");
            }
        }

        static public int AnimalChoose()
        {
            Console.WriteLine("Enter Animal number: ");
            int animalChoose;
            bool isNum = int.TryParse(Console.ReadLine(), out animalChoose);
            while (!isNum || animalChoose < 1 || animalChoose > 125)
            {
                Console.WriteLine("Wrong input! Try againe");
                isNum = int.TryParse(Console.ReadLine(), out animalChoose);
            }
            return animalChoose;
        }
=======
>>>>>>> main
    }
}
