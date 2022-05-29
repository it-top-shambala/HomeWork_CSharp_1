using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Article
{
    class RequestItem
    {
        string product;
        public int quantity;

        public RequestItem
            (
            string product, int quantity
            )
        {
            this.product = product;
            this.quantity = quantity;
        }

        public void PrintRequestItem()
        {
            Console.WriteLine($"Товар: {product}");
            Console.WriteLine($"Количество единиц товара: {quantity}");
        }
    }
}
