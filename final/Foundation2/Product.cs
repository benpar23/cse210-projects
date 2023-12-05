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

    public string GetLabelInfo()
    {
        if (_quantity > 1)
        {
            string label = "";
            
            for (int i = 0; i < _quantity; i++)
            {
                label += $"{_name} - {_productID}\r\n";
            }

            return label;
        }
        else
        {
            return $"{_name} - {_productID}\r\n";
        }
    }
}