//Описать структуру Article, содержащую следующие поля: код товара; название товара; цену товара.
//Описать структуру Client содержащую поля: код клиента; ФИО; адрес; телефон; количество заказов 
//    осуществленных клиентом; общая сумма заказов клиента.
//Описать структуру RequestItem содержащую поля: товар; количество единиц товара.
//Описать структуру Request содержащую поля: код заказа; клиент; дата заказа; перечень 
//    заказанных товаров; сумма заказа(реализовать вычисляемым свойством).
//Описать перечисление ArticleType определяющее типы товаров, и добавить соответствующее поле в структуру Article
//Описать перечисление ClientType определяющее важность клиента, и добавить соответствующее поле в структуру Client.
//Описать перечисление PayType определяющее форму оплаты клиентом заказа, и добавить соответствующее поле в структуру Request.
using System;


namespace Article
{
    class Program
    {
        static void Main(string[] args)
        {
            Article code=new Article (1,"Лопата",1000.0,Article.ArticleType.garden);
            code.PrintArticle();

            Client client = new Client
                (
                1, "Петров", "Петр", "Петрович", "Метро Бабушкинское",
                89557778861, 5, 100000
                );
            client.PrintClient();

            RequestItem requestItem = new RequestItem(code.product, 5);
            requestItem.PrintRequestItem();

            Request request = new Request(1, client, requestItem.quantity, code, Request.PayType.cash);
            request.PrintRequest();


                
        }
    }
}
