namespace _6;

public class RequestItem
{
    public string item { get; set; }
    public int numberOfItem { get; set; }

    public RequestItem(string _item, int _numberOfItem)
    {
        item = _item;
        numberOfItem = _numberOfItem;
    }

    public void Info()
    {
        Console.WriteLine($"Товар: {item}\nKоличество едениц товара: {numberOfItem}");
    }
}