//Описать структуру Article, содержащую следующие поля: код товара; название товара; цену товара.


using System;

namespace HomeWork4.app 
{
    public class Program
    {
        static void Main(string[] args)
        {
            Article article = new (1234, ArticleType.Clothes, 100000);
            Console.WriteLine(article);
            
        }
    }
}