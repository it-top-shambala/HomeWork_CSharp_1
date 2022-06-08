//Описать структуру RequestItem содержащую поля: товар; количество единиц товара.

using System;

namespace HomeWork6.app
{
    internal class Program
    {
        static void Main(string[] args)
        {
            RequestItem requestItem = new RequestItem(ProdcutEnum.Food, 15);
            Console.WriteLine(requestItem);
        }
    }
}