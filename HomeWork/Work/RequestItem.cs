using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
//6.Описать структуру RequestItem содержащую поля:
//товар; количество единиц товара.
using System.Threading.Tasks;

namespace HomeWork
{
    class RequestItem
    {
        public string productName;
        public int productlot;

        public RequestItem(string pName, int plot )
        {
           productName = pName;
           productlot = plot;
        }

        public void PrintRegustItem()
        {
            Console.WriteLine($"Товар: { productName}");
            Console.WriteLine($"Количество единиц товара: {productlot}");
        }
    }
}
