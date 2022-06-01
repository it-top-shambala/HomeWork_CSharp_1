using System;

namespace HomeTask3
{
    class Program
    {
        static void Main(string[] args)
        {
            int A, B;
            Console.WriteLine("Введите A:");
            A = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите B:");
            B = Convert.ToInt32(Console.ReadLine());
            if (A > B)
            {
                A = A ^ B;
                B = A ^ B;
                A = A ^ B;
            }

            for (; A <= B; ++A)
            {
                for (int i = 0; i < A; ++i)
                {
                    Console.Write($"{A} ");
                }

            }


        }
    }
}
