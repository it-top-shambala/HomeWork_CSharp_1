using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Article
{
    public class Client
    {
        int code;
        public string firstName;
        public string patronymic;
        public string lastName;
        string address;
        long phone;
        int quantity;
        double sum;
        ClientType clientType;

        public enum ClientType
        {
            VIP,
            normal,
            poor
        }
        public Client
            (
            int code, string lastName, string firstName, string patronymic,
             string address, long phone,
            int quantity, double sum
            )
        {
            this.code = code;
            this.lastName = lastName;
            this.firstName = firstName;
            this.patronymic = patronymic;
            
            this.address = address;
            this.phone = phone;
            this.quantity = quantity;
            this.sum = sum;

            if (sum>=100000)
            {
                this.clientType = ClientType.VIP;
            }
            else if(sum>=50000 && sum<100000)
            {
                this.clientType = ClientType.normal;
            }
            else
            {
                this.clientType = ClientType.poor;
            }
        }
        public Client() { }

        public void PrintClient()
        {
            Console.WriteLine
                (
                @$"Код клиента: {code}
Фамилия : {lastName}
Имя :{firstName}
Отчество :{patronymic}
Адрес:{address}
Телефон:{phone}
Количество заказов:{quantity}
Сумма заказов: {sum}
Важность клиента: {clientType}"

                );
            Console.WriteLine();

           
        }
    }
}
