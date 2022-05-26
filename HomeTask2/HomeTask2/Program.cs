using System;

namespace HomeTask2
{
    class Program
    {
        static void Main(string[] args)
        {
            double cont = 10000;
            double P, S;
            int K;
            Console.WriteLine("Введите процент:");
            P = Convert.ToInt32(Console.ReadLine());
            if (P < 0 || P > 25)
            {
                Console.WriteLine("Введен неверный процент.");
            }
            else
            {
                K = (int)(1000 / (100 * P));
                if ((cont + 100 * P * K) < 11000)
                    K++;
                S = cont + 100 * P * K;
                Console.WriteLine($"Размер вклада увеличится до 11000 через {K} месяцев.");
                Console.WriteLine($"Итоговый размер вклада {S}.");
            }


        }
    }
}
