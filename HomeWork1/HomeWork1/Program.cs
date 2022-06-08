/*Даны целые положительные числа A, B, C. Значение этих чисел программа должна запрашивать у пользователя.
    На прямоугольнике размера A*B размещено максимально возможное количество квадратов со стороной C. 
    Квадраты не накладываются друг на друга. Найти количество квадратов, размещенных на прямоугольнике,
    а также площадь незанятой части прямоугольника. Необходимо предусмотреть служебные сообщения в случае, 
    если в прямоугольнике нельзя разместить ни одного квадрата со стороной С (например, если значение С превышает 
    размер сторон прямоугольника).*/


using System;
namespace HomeWork1
{
    public  class Program
    {
        static void Main(string[] args)
        
        {           
                Console.WriteLine("Enter A, mm: ");
                int A = Convert.ToInt32(Console.ReadLine());              
                Console.WriteLine("Enter B, mm: ");
                int B = Convert.ToInt32(Console.ReadLine()); 
                Console.WriteLine("Enter C, mm: ");
                int C = Convert.ToInt32(Console.ReadLine());
                int result = Rect(A,B,C);
                Console.WriteLine($"Result: {result} rectangls");
                int FreePlace = A * B - (result * (C * C));
                Console.WriteLine($"Free plase: {FreePlace} mm^2");
        }
        // public static int Rect(int A,int B,int C)
        //{
        //    if (C > A || C > B)
        //    {
        //        throw new Exception("C can't be greater!");
        //    }
        //    int k = 0, n = 0;

        //    while (A >= C) 
        //    {
        //        A -= C;
        //        k++;
        //    }
        //    while (B >= C)
        //    {
        //        B -= C;
        //        n++;
        //    }

        //    int result = 0;

        //    for (int i = 0; i < k; i++)
        //    {
        //        result += n;
        //    }
        //    return result;
        //}

        public static int Rect(int A, int B, int C) => (C > A || C > B)? throw new Exception("C can't be greater!"): (A / C) * (B / C);
    }
}