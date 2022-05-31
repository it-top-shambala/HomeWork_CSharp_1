using _2;

Console.WriteLine("Введите размер вклада [ P ]");
int p = Convert.ToInt32(Console.ReadLine());
Bank bank = new Bank(p);
Console.WriteLine($"Через {bank.Count()} месяцев размер вклада превысит 11000 рублей и будет состовлять {bank.Deposit} рублей");