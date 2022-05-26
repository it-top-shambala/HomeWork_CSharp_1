using System;

namespace zadanie_4
{
    public class Article
    {
        public string productCode { get; set; }
        public string productName { get; set; }
        public double price { get; set; }

        public Article(string _code, string _name, double _price)
        {
            productCode = _code;
            productName = _name;
            price = _price;
        }

        public void info()
        {
            string priceLine = Convert.ToString(price);
            string[] splitPriceline = priceLine.Split(','); 
            
            Console.WriteLine($"Код товара: {productCode}\n" +
                              $"Название товара: {productName}\n" +
                              $"Цена товара: {splitPriceline[0]} рублей {splitPriceline[1]} копеек");
        }

    }
}