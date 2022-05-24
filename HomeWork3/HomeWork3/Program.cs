using System;

namespace HomeWork3
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.Write("Enter width: ");
            int A = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter Height: ");
            int B = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine();
            try
            {
                Print(A,B);
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                throw;
            }
        }

        public static void Print(int A, int B)
        {
            if (A > B)
            {
                throw new Exception("A cant be small!!");
            }

            for (int i = A; i <= B; i++)
            {
                for (int j = 0; j < i; j++)
                {
                    Console.Write(i + " ");
                }

                Console.WriteLine();
            }
        }        
        
        public static void TestCase(int A,int B)
        {
            if (A > B)
            {
                throw new Exception("A cant be small!!");
            }
            int k;
            for (int i = 0; i < B; i++)
            {
                k = i + A;
                for (int j = 0; j < k; j++)
                {
                    Console.Write(k + " ");
                }
                Console.WriteLine();
            }
        }
        
    }
}