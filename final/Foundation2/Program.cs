using System;

class Program
{
    static void Main(string[] args)
    {
        Address addressOne = new Address("30 Saltzburg Crescent", "Keswick", "ON", "Canada");
        Customer customerOne = new Customer("Ben Parada", addressOne);

        Product productOne = new Product("Shampoo", "005", 5.49, 2);
        Product productTwo = new Product("Soap", "004", 2.5, 1);
        Product productThree = new Product("Hairbrush", "010", 4.99, 1);

        Order orderOne = new Order(customerOne);

        orderOne.AddProduct(productOne);
        orderOne.AddProduct(productTwo);
        orderOne.AddProduct(productThree);

        string packingLabel = orderOne.GetPackingLabel();
        string shippingLabel = orderOne.GetShippingLabel();

        double totalPrice = orderOne.GetTotal();

        Console.WriteLine(packingLabel);
        Console.WriteLine(totalPrice);
        Console.WriteLine(shippingLabel);

    }
}