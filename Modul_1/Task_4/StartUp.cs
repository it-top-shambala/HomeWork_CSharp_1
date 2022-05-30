/*          Task_4
 * Описать структуру Article, содержащую следующие поля: код товара; название товара; цену товара.*/
using System;
namespace Task_4
{
    public struct Article
    {
        private uint _productCode;
        private string _productName;
        private float _productPrice;

        
        public uint ProductCode { get => _productCode; set => _productCode = value; }
        public string ProductName { get => _productName; set => _productName = value; }
        public float ProductPrice { get => _productPrice; set => _productPrice = value; }
    }


    public class StartUp
    {
        public static void Main(string[]args)
        {
            Article article1= new Article();
            article1.ProductPrice = 12.12F;
            article1.ProductName = "Snikers";
            article1.ProductCode = 123215;

        }

    }
}