namespace consoleapp5;

public class Client : Human
{
    public Human FIO;
    public string adress { get; set; }
    public int phone { get; set; }
    public int numberOfOrders { get; set; }
    public int totalOfOrders { get; set; }

    public Client(string firstName, string secondName, string thirdName,
        string _adress, int _phone, int _numberOfOrders, int _totalOfOrders) : base(firstName, secondName, thirdName)
    {
        adress = _adress;
        phone = _phone;
        numberOfOrders = _numberOfOrders;
        totalOfOrders = _totalOfOrders;
    }

    public override void info()
    {
        base.info();
        Console.WriteLine($"Адрес: {adress}\nТелефон: {phone}\nКоличевство заказов: {numberOfOrders}\nОбщяя сумма заказов: {totalOfOrders}");
    }
}