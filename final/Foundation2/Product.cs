public class Product
{
    private string _name;
    private string _productID;
    private double _price;
    private double _quantity;

    public Product(string name, string productID, double price, double quantity)
    {
        _name = name;
        _productID = productID;
        _price = price;
        _quantity = quantity;
    }

    public double GetSubtotal()
    {   
        return _price * _quantity;
    }

    public int GetQuantity()
    {
        int quantity = (int)_quantity;

        return quantity;
    }

    public string GetLabelInfo()
    {
        int quantity = GetQuantity();

        return $"{_name,-10}\t{_productID,-5}\t{quantity,-5}\r\n";
    }
}