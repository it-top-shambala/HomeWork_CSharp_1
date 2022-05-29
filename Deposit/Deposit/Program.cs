//Начальный вклад в банке равен 10000 руб . Через каждый месяц размер
//    вклада увеличивается на P процентов от имеющейся суммы (P — вещественное число, 0 < P < 25) 
// Значение Р программа должна получать у пользователя . По данному P определить через сколько
//    месяцев размер вклада превысит 11000 руб ., и вывести найденное количество месяцев K 
//    (целое число) и итоговый размер вклада S (вещественное число) .


using System;

namespace Deposit
{
    class Program
    {
        static void Main(string[] args)
        {
            double deposit = 10000.0;
            int percent;
            int month=0;

            Console.WriteLine($"Введите процент вклада в диапазоне от 1 до 25:  ");
            int.TryParse(Console.ReadLine(), out percent);

            if(percent<=0 || percent>=25)
            {
                Console.WriteLine("Вы ввели неправильный процент!");
                return;
            }

            while(deposit<=11000)
            {
                month++;
                deposit += deposit /100*percent ;
            }

            Console.WriteLine($"Количество месяцев по вкладу сотавляет {month}" +
                $" ваш депозит равен: {deposit}");
           
        }
    }
}
