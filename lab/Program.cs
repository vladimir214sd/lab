using System;
using System.Diagnostics.CodeAnalysis;

namespace lab
{
    internal class Program
    {
        static void Main(string[] args)
        {

            /*// Создание объекта с использованием конструктора без параметров
             Pokemon pokemon1 = new Pokemon();
             Console.WriteLine($"Покемон 1: {pokemon1.ToString()}");

             Console.WriteLine((int)pokemon1);
             Console.WriteLine(pokemon1);

             pokemon1= pokemon1>>23;
             Console.WriteLine($"Покемон 1: {pokemon1.ToString()}");

             // Создание объекта с использованием конструктора с параметрами
             Pokemon pokemon2 = new Pokemon(10000, 150, 200);
             Console.WriteLine($"Покемон 2: {pokemon2.ToString()}");

             pokemon2--;
             Console.WriteLine($"Покемон 2 отредактированный: {pokemon2.ToString()}");


             // Создание объекта с использованием конструктора копирования
             Pokemon pokemon3 = new Pokemon(pokemon2);
             Console.WriteLine($"Покемон 3 (копия 2-го): {pokemon3.ToString()}");

             // Демонстрация работы метода увеличения характеристик
             Pokemon pokemon4 = pokemon1.IncreaseStats(50000, 1000, 10000);
             Console.WriteLine($"Покемон 4: {pokemon4.ToString()}");

             // Подсчет всех созданных объектов
             Console.WriteLine($"Всего создано {Pokemon.count} объектов");


            
         pokemon4.ToString();
         
           */
            Arena a1 = new Arena(5, true);
            a1[0] = new Pokemon(24, 52, 496);
            a1[1] = new Pokemon(2224, 52, 496);
            a1[2] = new Pokemon(24, 52, 496);
            a1[3] = new Pokemon(24, 52, 232);
            a1[4] = new Pokemon(24, 52, 44);
            a1.Show();
            /*
            a1[55] = new Pokemon(24, 52, 23);
            a1[55].Show();

            Arena.Moda(a1);

            Arena a2 = new Arena();

            a2.Show();

            Arena a3 = new Arena(a2);

            a3.Show();

            a2[0].IncreaseStats(1,1,1);
            a2.Show();
            a3.Show();

            Console.WriteLine($"Всего создано {Pokemon.count} объектов");
            Console.WriteLine($"Всего создано {Arena.count} коллекций");
            */
            Pokemon p22 = new Pokemon(55, 55, 44);
            p22.Show();
            p22 = ~p22;
            Console.WriteLine($"CombatPower: {p22.CombatPower}");
            p22.Show();
            Arena a4 = new Arena(4);
            try
            {
                a4[60] = new Pokemon(52, 58, 64);
                Console.WriteLine(a4.ToString());
            }
            catch (Exception e)
            {
                Console.WriteLine (e.Message);
            }


        }
    }
}