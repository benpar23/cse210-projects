public class Order
{
    private List<Product> _products = new List<Product>();
    private Customer _customer;

    public Order(Customer customer)
    {
        _customer = customer;
    }

    public double GetTotal()
    {
        double total = 0;
        
        foreach (Product product in _products)
        {
            total += product.GetSubtotal();
        }

        if (_customer.GetAddress().IsUSA())
        {
            total += 5;
        }
        else
        {
            total += 35;
        }

        return total;
    }

    public string GetPackingLabel()
    {
        string label = "";

        int i = 0;

        string nameTitle = "PRODUCT NAME";
        string idTitle = "ID";
        string quantityTitle = "QUANTITY";

        string title = $"{nameTitle,-10}\t{idTitle,-5}\t{quantityTitle,-5}\r\n\r\n";
        
        foreach (Product product in _products)
        {
            i++;
            string labelInfo = product.GetLabelInfo();

            label += $"{labelInfo}";
        }
        
        return $"PACKING LIST\r\n\r\n{title}{label}";
    }

    public string GetShippingLabel()
    {
       string customerName = _customer.GetName();
       Address address = _customer.GetAddress();

       string addressString = address.GetAddress();
       
       return $"SHIP TO\r\n{customerName}\r\n{addressString}";
    }

    public void AddProduct(Product product)
    {
        _products.Add(product);
    }
}