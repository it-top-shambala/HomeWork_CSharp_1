using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Article
{
    class Request
    {
        int codeProduct;
        Client client;
        DateTime dateTime;
        Article article;
        double sum;

        PayType payType;
        public enum PayType
        {
            cash,
            nonCash
        }

        public double SumProduct(int quantity,double price)
        {
            return quantity * price;
        }

        public Request
            (
            int codeProduct, Client client, int quantity, Article article, PayType payType
            )
        {
            this.codeProduct = codeProduct;
            this.client = client;
            this.article = article;
            this.sum = SumProduct(quantity, article.price);
            this.dateTime = DateTime.Now;
            this.payType = payType;
        }
        public void PrintRequest()
        {
            Console.WriteLine
                (
                $"Код заказа: {codeProduct}\n" +
                $"Клиент {client.lastName} {client.firstName} {client.patronymic}\n" +
                $"Дата заказа {dateTime}\n" +
                $"Перечень заказанных товаров {article.product}\n" +
                $"Сумма заказа: {sum}\n" +
                $"Форма оплаты: {payType}\n"

                );
            Console.WriteLine();
        }
            

    }
}
