using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Article
{
    public class Article
    {

        int code;
        public string product;
        public double price;
        ArticleType articleType;
        public enum ArticleType
        {
            garden,
            food,
            shoes
        }

        public Article(int code, string product, double price, ArticleType articleType)
        {
            this.code = code;
            this.product = product;
            this.price = price;
            this.articleType = articleType;

        }
        public void PrintArticle()
        {
            Console.WriteLine($"Код товара: {code}");
            Console.WriteLine($"Название товара: {product}");
            Console.WriteLine($"Цена товара: {price}");
            Console.WriteLine($"Тип товара: {articleType}\n");
        }

        
    }
}
