public class Product
{
    private string _prodName;
    private string _prodId;
    private decimal _price;
    private int _quantity;

    public Product(string prodName, string prodId, decimal price,  int quantity)
    {
        _prodName = prodName;
        _prodId = prodId;
        _price = price;
        _quantity = quantity;
    }

    public decimal GetTotalCost()
    {
        return _price * _quantity;
    }

    public string GetPackLabel()
    {
        return $"{_prodName} (ID: {_prodId})";
    }
}