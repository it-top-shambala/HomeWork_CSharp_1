/*Даны целые положительные числа A, B, C . Значение этих чисел программа должна запрашивать
 * у пользователя . На прямоугольнике размера A*B размещено максимально возможное количество 
 * квадратов со стороной C . Квадраты не накладываются друг на друга . Найти количество квадратов,
 * размещенных на прямоугольнике, а также площадь незанятой части прямоугольника .
Необходимо предусмотреть служебные сообщения в случае, если в прямоугольнике нельзя 
разместить ни одного квадрата со стороной С (например, если значение С превышает размер сторон прямоугольника) .*/
using System;

namespace Square
{
    class Program
    {
        static void Main(string[] args)
        {
            int length;
            int width;
            int side;

            Console.WriteLine("Введите длину:");
            string str = Console.ReadLine();
            // length = Convert.ToInt32(str);
            int.TryParse(str, out length);
            if (length <= 0)
            {
                Console.WriteLine("Значение должно быть больше 0!");
                return;
            }

            Console.WriteLine("Введите ширину:");
            str = Console.ReadLine();
            // width = Convert.ToInt32(str);
            int.TryParse(str, out width);
            if(width<=0)
            {
                Console.WriteLine("Значение должно быть больше 0!");
                return;
            }

            Console.WriteLine("Введите сторону квадрата:");
            str = Console.ReadLine();
            // side = Convert.ToInt32(str);
            int.TryParse(str, out side);
            if (side <= 0)
            {
                Console.WriteLine("Значение должно быть больше 0!");
                return;
            }

            if(length<side || width<side)
            {
                Console.WriteLine("Не входит ни один квадрат");
                return;
            }

            int quantity = (length / side) * (width / side);
            Console.WriteLine($"Количество квадратов в прямоугольнике равно {quantity}");

            int amptyArea = (length * width) - (quantity * (side * side));
            Console.WriteLine($"Незанятая площадь равна: {amptyArea}");

        }
    }
}
