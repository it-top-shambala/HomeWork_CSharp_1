//Описать структуру Article, содержащую следующие
//поля: код товара; название товара; цену товара.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork
{
    class Article
    {
        public int productKey;
        public string productName;
        public double productPrice;
        public ArticleType articleType;

        public Article(int pKey, string pName, double pPrice, ArticleType artType)
        {
            productKey = pKey;
            productName = pName;
            productPrice = pPrice;
            articleType = artType;
        }

        public void PrintArticle()
        {
            Console.WriteLine($"Код: {productKey}");
            Console.WriteLine($"Название товара: {productName}");
            Console.WriteLine($"Цена: {productPrice } рублей");
            Console.WriteLine($"ArticleType: {articleType}");
        }
    }

}
