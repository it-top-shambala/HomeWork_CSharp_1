using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork_CSharp_1
{
    public static class task_2
    {
        public static double inputDouble() => Convert.ToDouble(Console.ReadLine());
        private static double calculate_time_to_profit(double procent) => Math.Ceiling(1001 / (100 * procent));

        public static void run() => Console.WriteLine($"" +
            $"Bank deposit will exceed 11000 in {calculate_time_to_profit(inputDouble())} mounths");
        
    }
}
