using System;

class Program
{
    static void Main(string[] args)
    {
        Customer customerOne = new Customer("Ben Parada");
        customerOne.SetAddress("30 Saltzburg Crescent", "Keswick", "ON", "Canada");

        Product productOne = new Product("Shampoo", "005", 5.49, 2);
        Product productTwo = new Product("Soap", "004", 2.5, 1);
        Product productThree = new Product("Hairbrush", "010", 4.99, 1);

        Order orderOne = new Order(customerOne);

        orderOne.AddProduct(productOne);
        orderOne.AddProduct(productTwo);
        orderOne.AddProduct(productThree);

        string packingLabelOne = orderOne.GetPackingLabel();
        string shippingLabelOne = orderOne.GetShippingLabel();

        double totalPriceOne = orderOne.GetTotal();

        Console.WriteLine("\r\nORDER 1");
        Console.WriteLine("------------------------\r\n\r\n");
        Console.WriteLine(packingLabelOne);
        Console.WriteLine();
        Console.WriteLine(shippingLabelOne);
        Console.WriteLine();
        Console.WriteLine($"Total Price: {totalPriceOne:c}");
        Console.WriteLine("------------------------\r\n\r\n");

        Customer customerTwo = new Customer("Ken Jeong");
        customerTwo.SetAddress("123 Main Street","New York City","NY","USA");

        Product productFour = new Product("Mascara", "024", 10, 1);
        Product productFive = new Product("Loofa", "034", 3.5, 1);
        Product productSix = new Product("Hair Scissors", "017", 6.99, 1);

        Order orderTwo = new Order(customerTwo);

        orderTwo.AddProduct(productFour);
        orderTwo.AddProduct(productFive);
        orderTwo.AddProduct(productSix);

        string packingLabelTwo = orderTwo.GetPackingLabel();
        string shippingLabelTwo = orderTwo.GetShippingLabel();

        double totalPriceTwo = orderTwo.GetTotal();

        Console.WriteLine("\r\nORDER 2");
        Console.WriteLine("------------------------\r\n\r\n");
        Console.WriteLine(packingLabelTwo);
        Console.WriteLine();
        Console.WriteLine(shippingLabelTwo);
        Console.WriteLine();
        Console.WriteLine($"Total Price: {totalPriceTwo:c}");
        Console.WriteLine("------------------------\r\n\r\n");
    }
}