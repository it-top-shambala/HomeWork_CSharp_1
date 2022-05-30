/*          Task-2
 * Начальный вклад в банке равен 10000 руб. Через каждый месяц размер 
 * вклада увеличивается на P процентов от имеющейся суммы 
 * (P — вещественное число, 0 < P < 25). Значение Р программа должна 
 * получать у пользователя. По данному P определить через сколько 
 * месяцев размер вклада превысит 11000 руб., и вывести найденное 
 * количество месяцев K (целое число) и итоговый размер вклада S 
 * (вещественное число).*/
using System;
namespace Task_2
{
    public partial class StartUp
    {
        public static void Main(string[] args)
        {

            float interesDeposit = 0;// Количество месяцев
            float depositAmount = 10000;//сумма вклада
            uint numberMonths = 0;//Количество месяцев
            do
            {
                Console.Write("Enter the deposit percentage for the month (0 - 25 %) : ");
                interesDeposit = float.Parse(Console.ReadLine());
                if (interesDeposit > 25 || interesDeposit < 0)
                {
                    Console.WriteLine("The deposit interest was entered for the month incorrectly!!!");
                }
            } while (interesDeposit > 25 || interesDeposit < 0);
            while (depositAmount < 11000)
            {
                depositAmount += depositAmount * (interesDeposit / 100);
                numberMonths++;
            }
            Console.WriteLine($"Deposit amount in {numberMonths} months = " + string.Format("{0:F2}", depositAmount) + " rub.");
        }
    }
}