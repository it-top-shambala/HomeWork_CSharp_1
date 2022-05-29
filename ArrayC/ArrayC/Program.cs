//Даны целые положительные числа A и B (A < B) .
//    Вывести все целые числа от A до B включительно; 
//каждое число должно выводиться на новой строке;
//при этом каждое число должно выводиться количество раз, 
//    равное его значению (например, число 3 выводится
//3 раза) . Например: если А = 3, а В = 7, то программа должна сформировать в консоли следующий вывод:
//3 3 3
//4 4 4 4
//5 5 5 5 5
//6 6 6 6 6 6
//7 7 7 7 7 7 7

using System;

namespace Arrays.App
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var array = new int[5][];

            for (int i = 0; i < 5; i++)
            {
                array[i] = new int[i + 1];
            }

            for (int i = 0; i < 5; i++)
            {
                for (int j = 0; j < array[i].Length; j++)
                {
                    array[i][j] = i + 1;
                }
            }

            for (int i = 0; i < 5; i++)
            {
                for (int j = 0; j < array[i].Length; j++)
                {
                    Console.Write($"{array[i][j]}\t");
                }
                Console.WriteLine();
            }
        }
    }
}
