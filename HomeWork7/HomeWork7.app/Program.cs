using System;

namespace HomeWork7.app
{
    public class Program
    {
        static void Main(string[] args)
        {
            Request request = new Request
            {
                OrderName = "Bring", Client = "Allaz",
                DateTime = new DateTime(2022, 02, 1),
                CodeRequest = 1244, PriceOrder = 500,
                PayType = EnumPayType.Cash
            };
            Console.WriteLine(request);
        }
    }
}