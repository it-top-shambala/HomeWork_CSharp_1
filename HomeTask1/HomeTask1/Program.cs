using System;

namespace HomeTask1
{
    class Program
    {
        private static int rectangle(int A, int B)
        {
            return A * B;
        }
        static void Main(string[] args)
        {
            int A, B, C;
            Console.Write("Введите А: ");
            A = Convert.ToInt32(Console.ReadLine());
            Console.Write("\nВведите B: ");
            B = Convert.ToInt32(Console.ReadLine());
            Console.Write("\nВведите C: ");
            C = Convert.ToInt32(Console.ReadLine());

            if (C >= A || C >= B)
                Console.WriteLine("\'С\' не может быть меньше любой из сторон.");
            else
            {
                Console.WriteLine($"Количество квадратов: {rectangle(A, B) / rectangle(C, C)}");
                Console.WriteLine($"Не занятая часть прямоугольника: {rectangle(A, B) % rectangle(C, C)}");
            }
        }
    }
}
