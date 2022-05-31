//5.Описать структуру Client содержащую поля:
//код клиента; ФИО; адрес;телефон;
//количество заказов осуществленных клиентом;
//общая сумма заказов клиента.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork
{
    class Client
    {

        private int clientId;
        private string clientName;
        private string clientAddress;
        private string clientPhone;
        private int clientOrders;
        private double clientOrdersSum;
        private ClientType clientType;

        public Client(int id, string name, string address, string phone,
            int orders, double ordersum,ClientType _clientType)
        {
            clientId = id;
            clientName = name;
            clientAddress = address;
            clientPhone = phone;
            clientOrders = orders;
            clientOrdersSum = ordersum;
            clientType = _clientType;
        }
        public void PrintClient()
        {
            Console.WriteLine($"Код: {clientId}");
            Console.WriteLine($"ФИО: {clientName}");
            Console.WriteLine($"Адрес: {clientAddress}");
            Console.WriteLine($"Телефон: {clientPhone}");
            Console.WriteLine($"Количество заказов: {clientOrders}");
            Console.WriteLine($"Общая сумма заказов: {clientOrdersSum}");
            Console.WriteLine($"ClientType :{ clientType}");
        }


    }
}
