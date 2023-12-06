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

       if (quantity > 1)
       {
        return $"{_name} -\t {_productID,8} x {quantity}\r\n";
       }
       else
       {
        return $"{_name} -\t {_productID,8}\r\n";
       }
    }
}