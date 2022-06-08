//Описать структуру Client содержащую поля: код клиента; ФИО; адрес; телефон; количество заказов осуществленных клиентом;
//общая сумма заказов клиента.

using System;
using HomeWork5.app;

namespace HomeWork5.app
{
    public class Program
    {
        static void Main(string[] args)
        {
            Client client = new ("1842","John", "Doo", "Russia", 20, 30.5);
            Console.WriteLine(client);
        }
    }
}   