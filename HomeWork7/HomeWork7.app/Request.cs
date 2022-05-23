namespace HomeWork7.app;

public class Request
{
    public int CodeRequest { get; set; }
    public string Client { get; set; }
    private DateTime _dateRequest;
    public string OrderName { get; set; }
    public uint PriceOrder { get; set; }
    public DateTime DateTime
    {
        get => _dateRequest;
        set
        {
            if (value > DateTime.Now)
            {
                throw new TimeoutException();
            }
            _dateRequest = value;
        }
    }
    public override string ToString()
    {
        return
            $"Coderequest: {CodeRequest} Client: {Client}" +
            $"" +
            $" OrderName: {OrderName} PricerOrder: {PriceOrder}" +
            $" Date: {DateTime}"; 
    }
}