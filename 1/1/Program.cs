using Square;

Console.WriteLine("Введите A, B прямоугольника через пробел");
string line = Console.ReadLine();
string[] splitLine = line.Split(' ');
int a = int.Parse(splitLine[0]);
int b = int.Parse(splitLine[1]);

Console.WriteLine("Введите размер квадрата");
int c = Convert.ToInt32(Console.ReadLine());

Console.WriteLine(SquareCount.Search(a, b, c));

