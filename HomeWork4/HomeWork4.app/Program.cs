using System;

namespace HomeWork4.app 
{
    public class Program
    {
        static void Main(string[] args)
        {
            Article article = new Article(1234, ArticleType.Clothes, 100000);
            Console.WriteLine(article);
        }
    }
}