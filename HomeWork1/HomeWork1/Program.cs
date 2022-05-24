using System;
//included homework 1 and 2 
namespace HomeWork1
{
    public  class Program
    {
        static void Main(string[] args)
        {
            #region FIRST_HOMEWORK
                /*Console.WriteLine("Enter A: ");
                int A = Convert.ToInt32(Console.ReadLine()); 
                Console.WriteLine("Enter B: ");
                int B = Convert.ToInt32(Console.ReadLine()); 
                Console.WriteLine("Enter C: ");
                int C = Convert.ToInt32(Console.ReadLine());
                int result = DoMath(A,B,C);
                Console.WriteLine($"Result: {result}");*/
            #endregion

            #region SECOND_HOMEWORK

            int result = DoMath2(2);
            Console.WriteLine(result);
            #endregion
        }
        public static int DoMath(int A,int B,int C)
        {
            if (C > A || C > B)
            {
                throw new Exception("C cant be greater!");
            }
            int k = 0, n = 0;

            while (A >= C) 
            {
                A -= C;
                k++;
            }
            while (B >= C)
            {
                B -= C;
                n++;
            }

            int result = 0;

            for (int i = 0; i < k; i++)
            {
                result += n;
            }
            return result;
        }

        public static int DoMath2(double P,double S = 10000)
        {
            int Target = 11000;
            int k = 0;

            while (S <= Target)
            {
                S += S * P / 100.0;
                ++k;
            }
            return k; 
        }
        
    }
}