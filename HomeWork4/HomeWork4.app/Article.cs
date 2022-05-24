namespace HomeWork4.app;

public enum ArticleType 
{
    Phone,
    NoteBook,
    Food, 
    Clothes, 
    Car
}

public class Article
{
    private uint _ProductCode;
    private ArticleType _NameProduct;
    private double _PriceProduct;
    public Article(uint productCode, ArticleType nameProduct, double priceProduct)
    {
        _ProductCode = productCode;
        _NameProduct = nameProduct;
        _PriceProduct = priceProduct;   
    }
    public override string ToString()
    {
        return $"Code : {_ProductCode} Name: {_NameProduct} Price: {_PriceProduct}";
    }
}