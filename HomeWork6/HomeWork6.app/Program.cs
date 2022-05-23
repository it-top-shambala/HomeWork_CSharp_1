using System;

namespace HomeWork6.app
{
    internal class Program
    {
        static void Main(string[] args)
        {
            RequestItem requestItem = new RequestItem(ProdcutEnum.Phone, 10);
            Console.WriteLine(requestItem);
        }
    }
}