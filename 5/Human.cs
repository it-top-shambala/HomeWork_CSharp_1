namespace consoleapp5;

public class Human
{
    public string firstName { get; set; }
    public string secondName { get; set; }
    public string thirdName { get; set; }

    public Human(string _firstName, string _secondName, string _thirdName)
    {
        firstName = _firstName;
        secondName = _secondName;
        thirdName = _thirdName;
    }

    public virtual void info()
    {
        Console.WriteLine($"Фамилия: {firstName}\nИмя: {secondName}\nОтчество: {thirdName}");
    }
}