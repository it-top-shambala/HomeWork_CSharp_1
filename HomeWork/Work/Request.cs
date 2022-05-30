//7.Описать структуру Request содержащую поля:
//код заказа; клиент; дата заказа; перечень заказанных товаров;
//сумма заказа(реализовать вычисляемым свойством).

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork
{
    class Request
    {
        public int orderId;
        public string orderClient;
        public DateTime orderDate;
        public string[] orderItems;//Элементы заказа
        public double[] orderPrise;
        public double OrderSum { get => orderPrise.Sum(); }
        private double orderSum;
        private PayType payType;

        public Request(int id, string client, DateTime date,
            string[] items, double[] prise,PayType _payType)
        {
            orderId = id;
            orderClient = client;
            orderDate = date;
            orderItems = items;
            orderPrise = prise;
            payType = _payType;
        }

        public void PrintRequest()
        {
            Console.WriteLine($"Код заказа: {orderId}");
            Console.WriteLine($"Клиент: {orderClient}");
            Console.WriteLine($"Дата: {orderDate}");
            Console.Write("Перечень заказов: ");
            foreach (var item in orderItems)
            {
                Console.Write(item + " | ");
            }
            Console.Write("\n Цена товара: ");
            foreach (var item in orderPrise)
            {
                Console.Write(item + " | ");
            }
            Console.WriteLine($"\n Сумма: {OrderSum}");
            Console.WriteLine($"Оплата: {payType}\n");
            
        }
    }
}
