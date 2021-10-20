using System;
using System.Linq;
using System.Text;
using System.Globalization;
using System.Collections.Generic;

// Задание номер 6


namespace Operators1
{
    class Program
    {

        static void Main(string[] args)
        {
            Console.InputEncoding = Encoding.Unicode;
            Console.OutputEncoding = Encoding.Unicode;

            Zadacha6();

            Console.ReadLine();
        }

        static void Zadacha6()
        {

            Console.WriteLine("Введите число элементов массива");
            string nInput = Console.ReadLine();
            bool isInt32Size = Int32.TryParse(nInput, out int size);

            // если ввели не число
            while (!isInt32Size || size < 0)
            {
                Console.WriteLine("Некорректно задано число элементов массива. Введите снова:");
                nInput = Console.ReadLine();
                isInt32Size = Int32.TryParse(nInput, out size);
            }

            Random rnd = new Random();

            int[] genArray = new int[size];
            List<int> FoundArray = new List<int>();

            for (int i = 0; i < size; i++)
            {
                genArray[i] = rnd.Next(-15, 50);
                Console.Write(genArray[i] + "\t");
            }

            Console.WriteLine("Список повторяющихся элементов:");
            Console.WriteLine();

            for (int k = 0; k < genArray.Length; k++)
            {
                for (int i = 0; i < genArray.Length; i++)
                {
                    if (genArray[i] == genArray[k] && i != k && !FoundArray.Contains(genArray[k]))
                    {
                        Console.Write($"{genArray[i]} ");
                        FoundArray.Add(genArray[i]);
                    }
                }
            }


        }
    }
}

