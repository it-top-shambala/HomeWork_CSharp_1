using System;
using HomeWork5.app;

namespace HomeWork5.app
{
    public class Program
    {
        static void Main(string[] args)
        {
            Client client = new Client(Guid.NewGuid().ToString(),"Allaz", "Bairamov", "Russia", 13, 10.4);
            Console.WriteLine(client);
        }
    }
}