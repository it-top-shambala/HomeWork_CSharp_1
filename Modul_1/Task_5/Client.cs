using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_5
{
    public struct Client
    {
        private string _lastName;
        private string _firstName;
        private string _patronym;
        private uint _id;
        private string _city;
        private string _street;
        private string _house;
        private uint _apartment;
        private string _telefonNumber;
        private uint _numberOfOrders;
        private double _amountOfMoney;

        public string LastName { get => _lastName; set => _lastName = value; }
        public string FirstName { get => _firstName; set => _firstName = value; }
        public string Patronym { get => _patronym; set => _patronym = value; }
        public uint Id { get => _id; set => _id = value; }
        public string City { get => _city; set => _city = value; }
        public string Street { get => _street; set => _street = value; }
        public string House { get => _house; set => _house = value; }
        public uint Apartment { get => _apartment; set => _apartment = value; }
        public string TelefonNumber { get => _telefonNumber; set => _telefonNumber = value; }
        public uint NumberOfOrders { get => _numberOfOrders; set => _numberOfOrders = value; }
        public double AmountOfMoney { get => _amountOfMoney; set => _amountOfMoney = value; }

        public void Print()
        {
            Console.WriteLine(
                $"Client id \t\t{_id}\n" +
                $"Client's name :\t\t{_firstName} {_lastName} {_patronym}\n" +
                $"Telefon number :\t{_telefonNumber}\n" +
                $"Address :\t\t{_city} {_street} {_house} {_apartment}\n" +
                $"Number Of Orders :\t{_numberOfOrders}\n" +
                $"Amount Of Money :\t{string.Format("{0:F2}", _amountOfMoney)} rub.");
        }
    }
}
