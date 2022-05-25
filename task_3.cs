using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork_CSharp_1
{
    static public class task_3
    {
        private static void print_funny_numbers(int from, int to)
        {
            for (int i = from; i <= to; i++)
            {
                for(int j = i; j > 0; --j)
                {
                    Console.WriteLine(i.ToString() + '\n');
                }
            }
        }

        public static void run() => print_funny_numbers(task_1.inputInt(), task_1.inputInt());
    }
}
