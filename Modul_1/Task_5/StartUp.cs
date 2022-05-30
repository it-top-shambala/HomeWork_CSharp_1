/*          Task_5
 * Описать структуру Client содержащую поля: код клиента; ФИО; адрес; телефон; 
 * количество заказов осуществленных клиентом; общая сумма заказов клиента.*/
using System;
using Task_5;


namespace Task_5
{
    public partial class StartUp
    {
        public static void Main(string[] args)
        {
            Client client = new Client();
            client.Id = 10;
            client.LastName = "Oleg";
            client.FirstName = "Schegolev";
            client.Patronym = "Leonidovich";
            client.City = "Ekaterinburg";
            client.Street = "Uralskaya";
            client.House = "8B";
            client.Apartment = 10;
            client.TelefonNumber = "+790891020852";
            client.AmountOfMoney = 102500.05;
            client.NumberOfOrders = 100;
            client.Print();
        }

    }
}
