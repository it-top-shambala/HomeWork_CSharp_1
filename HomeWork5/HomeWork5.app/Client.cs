namespace HomeWork5.app;

public enum ClientType
{
    Doctor, 
    Police,
    Teacher,
    Programmer
}

public class Client
{
    private string _gUIClientId;  
    private string _Firstname;
    private string _Lastname;
    private string _adress;
    private uint _CountOrder;
    private double _TotalAmount;

    public Client(string id,string firstname, string lastname, string adress, uint countOrder, double totalAmount)
    {
        _gUIClientId = id;
        _Firstname = firstname;
        _Lastname = lastname;
        _adress = adress;
        _CountOrder = countOrder;
        _TotalAmount = totalAmount; 
    }

    public override string ToString() => $"Id: {_gUIClientId} Firstname: {_Firstname} Lastname: {_Lastname} Adress: {_adress} CountOrder: {_CountOrder} TotalAmount: {_TotalAmount}";
}