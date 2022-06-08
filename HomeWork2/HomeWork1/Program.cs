//Начальный вклад в банке равен 10000 руб. Через каждый месяц размер вклада увеличивается на 
//    P процентов от имеющейся суммы (P — вещественное число, 0 < P < 25). Значение Р программа 
//    должна получать у пользователя. По данному P определить через сколько месяцев размер вклада 
//    превысит 11000 руб., и вывести найденное количество месяцев K (целое число) и итоговый размер
//    вклада S (вещественное число).


using System;
namespace HomeWork2
{
    public  class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите данные по процентам");
            int P = Convert.ToInt32(Console.ReadLine());
            int NMonths = MCounter(P);
            Console.WriteLine(NMonths);
            int NewSum = SumCounter(P);
            Console.WriteLine(NewSum);            
        }        

        public static int MCounter(int P)
        {
            int S = 10000;
            int Target = 11000;
            int k = 0;

            while (S <= Target)
            {
                S += (int)(S * P / 100.0);
                ++k;
            }
            return k; 
        }
        public static int SumCounter(int P)
        {
            int S = 10000;
            int Target = 11000;         

            while (S <= Target)
            {
                S += (int)(S * P / 100.0);                
            }
            return S;
        }

    }
}