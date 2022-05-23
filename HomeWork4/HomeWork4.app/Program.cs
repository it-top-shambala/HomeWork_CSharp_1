using System;

namespace HomeWork4.app 
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Article article = new Article(1234, ProductEnum.Clothes, 100000);
            Console.WriteLine(article);
        }
    }
}