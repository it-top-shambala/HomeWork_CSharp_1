/*          Task_3
 * Даны целые положительные числа A и B (A < B). Вывести все целые числа от A до B 
 * включительно; каждое число должно выводиться на новой строке; при этом каждое 
 * число должно выводиться количество раз, равное его значению (например, число 3 
 * выводится 3 раза). Например: если А = 3, а В = 7, то программа должна сформировать
 * в консоли следующий вывод: 
 * 3 3 3 
 * 4 4 4 4 
 * 5 5 5 5 5 
 * 6 6 6 6 6 6 
 * 7 7 7 7 7 7 7*/
using System;
namespace Task_3
{
    public class StartUp
    {
        public static void Main(string[] args)
        {
            uint a, b;
            Console.Write("Enter value A :");
            a = uint.Parse(Console.ReadLine());
            Console.Write("Enter value B :");
            b = uint.Parse(Console.ReadLine());
            if (b < a)
            {
                b = a + b;
                a = b - a;
                b = b - a;
            }
            for (uint i = a; i <= b; i++)
            {
                for (uint j = 0; j < i; j++)
                {
                    Console.Write(i);
                }
                Console.WriteLine();
            }
        }
    }
}


