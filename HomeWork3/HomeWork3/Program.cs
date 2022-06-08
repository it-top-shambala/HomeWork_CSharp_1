//Даны целые положительные числа A и B (A < B). 
//Вывести все целые числа от A до B включительно; 
//каждое число должно выводиться на новой строке; 
//при этом каждое число должно выводиться количество раз, равное его значению (например, число 3 выводится 3 раза).
//Например: если А = 3, а В = 7, то программа должна сформировать в консоли следующий вывод: 
//    3 3 3
//    4 4 4 4
//    5 5 5 5 5
//    6 6 6 6 6 6
//    7 7 7 7 7 7 7

using System;

namespace HomeWork3
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.Write("Enter width: ");
            int A = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter Height: ");
            int B = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine();
            try
            {
                Print(A,B);
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                throw;
            }
        }

        public static void Print(int A, int B)
        {
            if (A > B)
            {
                throw new Exception("A cant be small!!");
            }

            for (int i = A; i <= B; i++)
            {
                for (int j = 0; j < i; j++)
                {
                    Console.Write(i + " ");
                }

                Console.WriteLine();
            }
        }         
    }
}