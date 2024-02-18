using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace lab
{
    public class Arena
    {
        public static int count = 0;

        static Random rnd = new Random();

        Pokemon[] arena;

        public int Length
        {
            get => arena.Length;
        }

        public Arena(int length)
        {
            arena = new Pokemon[length];
            for (int i = 0; i < length; i++)
            {
                arena[i] = new Pokemon();
            }
            count++;
        }

        public Arena(int length, bool generateRandomValues)
        {
            arena = new Pokemon[length];

            if (generateRandomValues)
            {
                for (int i = 0; i < length; i++)
                {
                    arena[i] = new Pokemon(rnd.Next(17, 414), rnd.Next(32, 396), rnd.Next(1, 496));
                }
            }
            else
            {
                for (int i = 0; i < length; i++)
                {
                    arena[i] = new Pokemon();
                }
            }
            count++;
        }
        public Arena()
        {
            int length = InputValidNumber("length");
            arena = new Pokemon[length];

            for (int i = 0; i < length; i++)
            {
                Console.WriteLine($"Покемон №{i+1}");
                arena[i] = new Pokemon(InputValidNumber("attack"), InputValidNumber("defense"), InputValidNumber("stamina"));
            }
            count++;
        }

        public Arena(Arena other)
        {
            arena = new Pokemon[other.Length];
            for (int i = 0; i < other.Length; i++)
                this.arena[i] = new Pokemon(other.arena[i]);
            count++;
        }

        public void Show()
        {
            for (int i = 0; i < arena.Length; i++)
            {
                Console.WriteLine(arena[i].ToString());
            }
        }

        public Pokemon this[int index]
        {
            get
            {
                if (index >= 0 && index < arena.Length)
                    return arena[index];
                else
                    throw new Exception("Индекс выходит за пределы коллекции");
            }
            set
            {
                if (index >= 0 && index < arena.Length)
                    arena[index] = value;
                else
                    Console.WriteLine("Индекс выходит за пределы коллекции");
            }
        }

        public static int Moda(Arena a)
        {
            int[] rateArray = new int[497];
            for (int i = 0; i < a.Length; i++)
            {
                rateArray[a[i].Stamina]++;
            }
            return Array.IndexOf(rateArray, rateArray.Max());
        }
        public static int InputValidNumber(string type)  // проверка на целое число
        {
            int element;
            bool isConvert;
            if (type == "attack")
            {
                do
                {
                    Console.Write("Введите значение атаки: ");
                    isConvert = int.TryParse(Console.ReadLine(), out element) && element >= 17 && element <= 414;

                    if (!isConvert)
                        Console.Write("Ошибка при вводе атаки! Введите значение от 17 до 414: ");
                } while (!isConvert);
                return element;
            }
            if (type == "defense")
            {
                do
                {
                    Console.Write("Введите значение защиты: ");
                    isConvert = int.TryParse(Console.ReadLine(), out element) && element >= 32 && element <= 396;

                    if (!isConvert)
                        Console.Write("Ошибка при вводе защиты! Введите значение от 32 до 396: ");
                } while (!isConvert);
                return element;
            }
            if (type == "stamina")
            {
                do
                {
                    Console.Write("Введите значение выносливости: ");
                    isConvert = int.TryParse(Console.ReadLine(), out element) && element >= 1 && element <= 496;

                    if (!isConvert)
                        Console.Write("Ошибка при вводе выносливости! Введите значение от 1 до 496: ");
                } while (!isConvert);
                return element;
            }
            if (type == "length")
            {
                do
                {
                    Console.Write("Введите длину коллекции: ");
                    isConvert = int.TryParse(Console.ReadLine(), out element) && element >= 1 && element <= 1000;

                    if (!isConvert)
                        Console.Write("Ошибка при вводе длины! Введите положительное число: ");
                } while (!isConvert);
                return element;
            }
            else
                return 0;
        }


    }
}




