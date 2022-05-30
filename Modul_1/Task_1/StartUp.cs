//=====================================================
/*      Task-1:
 * Даны целые положительные числа A, B, C. 
 * Значение этих чисел программа должна запрашивать 
 * у пользователя. На прямоугольнике размера A*B 
 * размещено максимально возможное количество 
 * квадратов со стороной C. Квадраты не накладываются 
 * друг на друга. Найти количество квадратов, 
 * размещенных на прямоугольнике, а также площадь 
 * незанятой части прямоугольника. Необходимо 
 * предусмотреть служебные сообщения в случае, 
 * если в прямоугольнике нельзя разместить ни одного 
 * квадрата со стороной С (например, если 
 * значение С превышает размер сторон прямоугольника).*/
//=======================================================
using System;
namespace Task_1
{
    public partial class StartUp
    {
        public static void Main(string[]args)
        {
            uint a, b, c, square_AB, square_C, numberOfSquares_C, square;
            Console.Write("Enter value A : ");
            a = uint.Parse(Console.ReadLine());
            Console.Write("Enter value B : ");
            b = uint.Parse(Console.ReadLine());
            Console.Write("Enter value C : ");
            c = uint.Parse(Console.ReadLine());
            if (c > a || c > b)
            {
                Console.WriteLine($"C = {c} > A = {a} or B = {b}");
            }else
            {
                square_AB = a * b;
                numberOfSquares_C = (a / c) * (b / c);
                square_C = c * c * numberOfSquares_C;
                square = square_AB - square_C;
                Console.WriteLine($"The number of squares C placed on the rectangle AB = {numberOfSquares_C}, " +
                    $"the area of the unoccupied part of the rectangle = {square}");
            }

        }
    }
}