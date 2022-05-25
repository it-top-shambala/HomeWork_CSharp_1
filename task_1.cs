
namespace HomeWork_CSharp_1
{
    public static class task_1
    {
        public static int inputInt() => Convert.ToInt32(Console.ReadLine());
        private static int square(int weith, int height) => height * weith;
        private static void solution(int A, int B, int C)
        {
            if (C >= A || C >= B)
                throw new Exception("The inscribed square is larger than the main figure");
            Console.WriteLine($"Total squares: {square(A, B) / square(C, C)}");
            Console.WriteLine($"Free area: {square(A, B) % square(C, C)}");
        }

        public static void run() => solution(inputInt(), inputInt(), inputInt());
    }
}

