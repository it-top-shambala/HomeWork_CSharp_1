namespace HomeWork6.app;

public enum ProdcutEnum
{
    Phone,
    NoteBook, 
    Clothes, 
    Food
}

public class RequestItem
{
    private ProdcutEnum _Product;
    private uint _AmountProduct;

    public RequestItem(ProdcutEnum product, uint amountProduct)
    {
        _Product= product;
        _AmountProduct = amountProduct;
    }

    public override string ToString() => $"Product: {_Product}  AmountProduct: {_AmountProduct}";
}