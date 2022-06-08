//Описать структуру Request содержащую поля: код заказа; клиент; дата заказа; перечень заказанных товаров; сумма заказа(реализовать вычисляемым свойством).

using System;

namespace HomeWork7.app
{
    public class Program
    {
        static void Main(string[] args)
        {
            Request request = new Request
            {
                OrderName = "Bring", Client = "Jhon",
                DateTime = new DateTime(2022, 06, 8),
                CodeRequest = 9088, PriceOrder = 1500,
                PayType = EnumPayType.NFC
            };
            Console.WriteLine(request);
        }
    }
}