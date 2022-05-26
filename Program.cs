
Console.WriteLine("Введите А и Б через пробел");
string line = Console.ReadLine();
string[] splitLine = line.Split(' ');
int a = int.Parse(splitLine[0]);
int b = int.Parse(splitLine[1]);

for(int i = a; i <= b; i++)
{
    for(int j = 0; j < i; j++)
    {
        Console.Write($"{i} ");
    }
    Console.WriteLine();
}