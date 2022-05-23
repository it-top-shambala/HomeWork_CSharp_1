namespace HomeWork5.app;

public class Client
{
    private string _Firstname;
    private string _Lastname;
    private string _Adress;
    private uint _CountOrder;
    private double _TotalAmount;

    public Client(string firstname, string lastname, string adress, uint countOrder, double totalAmount)
    {
        _Firstname = firstname;
        _Lastname = lastname;
        _Adress = adress;
        _CountOrder = countOrder;
        _TotalAmount = totalAmount; 
    }

    public override string ToString()
    {
        return $"Firstname: " +
               $"{_Firstname} Lastname: {_Lastname}" +
               $" Adress: {_Adress} CountOrder: {_CountOrder} TotalAmount: {_TotalAmount}";
    }
}