//#define MyRegion
#undef MyRegion

using System;
namespace HomeWork
{
    class Program
    {

        static void Main(string[] args)
        {

#if MyRegion

            //1`.Даны целые положительные числа A, B, C.
            //Значение этих чисел программа должна запрашивать у пользователя.
            //На прямоугольнике размера A*B размещено максимально возможное количество квадратов со стороной C.
            //Квадраты не накладываются друг на друга. Найти количество квадратов, размещенных на прямоугольнике,
            // а также площадь незанятой части прямоугольника. Необходимо предусмотреть служебные сообщения в случае,
            //если в прямоугольнике нельзя разместить ни одного квадрата со стороной С
            //(например, если значение С превышает размер сторон прямоугольника).

            Console.WriteLine("Введите число А:");
            int a = int.Parse(Console.ReadLine());

            Console.WriteLine("Введите число В:");
            int b = int.Parse(Console.ReadLine());

            Console.WriteLine("Введите число С:");
            int c = int.Parse(Console.ReadLine());

            if (c > a || c > b || a == b)
            {
                Console.WriteLine("Error");
                return;
            }
            var count = (a / c) * (b / c);
            Console.WriteLine($"Количество квадратов = {count}");
            var square = a * b - count * c * c;
            Console.WriteLine($"Незанятая площадь = {square}");

            //2.Начальный вклад в банке равен 10000 руб.
            // Через каждый месяц размер вклада увеличивается на P процентов от имеющейся суммы
            // (P — вещественное число, 0 < P < 25).
            // Значение Р программа должна получать у пользователя.
            // По данному P определить через сколько месяцев размер вклада превысит 11000 руб.,
            // и вывести найденное количество месяцев K(целое число) и итоговый размер вклада S(вещественное число).

            Console.WriteLine("-------------------------------");
            Console.WriteLine("Введите процент по вкладу(0 < Percent < 25):");
            double percent = double.Parse(Console.ReadLine());
            if (percent > 25)
            {
                Console.WriteLine("Завышенный процент");
                return;
            }
            double deposit = 1000;
            int count1 = 0;
            while (deposit <= 1100)
            {
                deposit += deposit * percent / 100;
                count1++;
            }
            Console.WriteLine($"До превышения лимита вклада на сумму 1100 руб. понадобится:" +
                $" \n количество месяцев:{count1} \n сумма вклада составит:{deposit}руб.");

            //3.Даны целые положительные числа A и B(A<B).
            // Вывести все целые числа от A до B включительно;
            // каждое число должно выводиться на новой строке;
            //при этом каждое число должно выводиться количество раз, равное его значению
            //(например, число 3 выводится 3 раза).
            // Например: если А = 3, а В = 7, то программа должна сформировать в консоли следующий вывод:
            //  3 3 3
            //  4 4 4 4
            //  5 5 5 5 5
            //  6 6 6 6 6 6
            //  7 7 7 7 7 7 7  

            Console.WriteLine("-------------------------------");
            //Console.WriteLine("Введите число А:");
            //int n = int.Parse(Console.ReadLine());
            //Console.WriteLine("Введите число B:");
            //int m = int.Parse(Console.ReadLine());
            //Console.WriteLine();
            int num1 = 3;
            int num2 = 7;
            //if (num1 > num2)
            //{
            //    Console.WriteLine("Error !!!");
            //    return;
            //}
            while (num1 <= num2)
            {
                for (int i = 1; i <= num1; i++)
                    Console.Write("{0}", num1);
                num1++;
                Console.WriteLine();
            }

            #endif
            //4./---------------------------------------/
            Console.WriteLine("4.-------------------------------/");
            Article cloths = new Article(111, "Костюм", 15000,  ArticleType.Clothes  );           
            cloths.PrintArticle();
            //5./-----------------------------------------/
            Console.WriteLine("5.-------------------------------/");
            Client client1 = new Client(222, "Ирина Петровна Дорохова", "Москва",
           "+79273651919",  20 , 20000,ClientType.Boss);           
            client1.PrintClient();
            Console.WriteLine();
            Client client2 = new Client(333, "Генадий  Иванович Левченко", "Kазань",
            "+79373741515", 30, 30000, ClientType.Meneger);          
            client2.PrintClient();
            //6./--------------------------------------/
            Console.WriteLine("6.-------------------------------/");
            RequestItem request = new RequestItem("Холодильник" + "", 5);
            request.PrintRegustItem();           
            //7./---------------------------------------/
            Console.WriteLine("7.-------------------------------/");
            string[] items1 = { "Компьютер", " клавиатура", "мышь" };
            double[] prise1 = { 50000, 2000, 1000 };
            string[] items2 = { "Принтер", "Монитор", "камера" };
            double[] prise2 = { 10000, 5000, 1000 };
            string[] items3 = { "Стол", "Стул", "Лампа" };
            double[] prise3 = { 10000, 7000, 3000 };
           
            Request order1 = new Request(1, "Иван Иванов",
            DateTime.Now, items1, prise1, PayType.Cach);
            Request order2 = new Request(2, "Сергей Сидоров",
            DateTime.Now, items2, prise2,PayType.PayCard);
            Request order3 = new Request(3, "Aлексей Петров",
            DateTime.Now, items2, prise3,PayType.PayCard);
            order1.PrintRequest();
            order2.PrintRequest();
            order3.PrintRequest();

        
           
        }
    }
    
    
}
