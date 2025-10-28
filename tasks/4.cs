using System;
using System.Collections.Generic;
using System.Linq;


interface IModel
{
    int Id { get; set; }
}


class Product : IModel
{
    public int Id { get; set; }
    public string Name { get; set; }
    public int Quantity { get; set; }
    public double Price { get; set; }

    public void DisplayDetails()
    {
        Console.WriteLine($"Product Id: {Id}");
        Console.WriteLine($"Name: {Name}");
        Console.WriteLine($"Quantity: {Quantity}");
        Console.WriteLine($"Price: {Price} AZN");
        Console.WriteLine("---------------------------");
    }
}


class Market : IModel
{
    public int Id { get; set; }
    public string Name { get; set; }
    private List<Product> Products = new List<Product>();

    
    public void AddProduct(Product product)
    {
        if (Products.Any(p => p.Id == product.Id))
        {
            Console.WriteLine($"Product with Id {product.Id} already exists!");
            return;
        }
        Products.Add(product);
        Console.WriteLine($"Product {product.Name} added successfully.");
    }

   
    public void RemoveProduct(int productId)
    {
        Product product = Products.FirstOrDefault(p => p.Id == productId);
        if (product == null)
        {
            Console.WriteLine($"Product with Id {productId} not found!");
            return;
        }
        Products.Remove(product);
        Console.WriteLine($"Product {product.Name} removed successfully.");
    }

    
    public void ViewAllProducts()
    {
        Console.WriteLine($"=== Products in Market {Name} ===");
        foreach (var p in Products)
        {
            Console.WriteLine($"Id: {p.Id}, Name: {p.Name}, Quantity: {p.Quantity}, Price: {p.Price} AZN");
        }
        Console.WriteLine("---------------------------");
    }

    
    public void ViewProductDetails(int productId)
    {
        Product product = Products.FirstOrDefault(p => p.Id == productId);
        if (product == null)
        {
            Console.WriteLine($"Product with Id {productId} not found!");
            return;
        }
        product.DisplayDetails();
    }
}


class Program1
{
    static void Main()
    {
        Market market = new Market { Id = 1, Name = "SuperMarket" };

        Product p1 = new Product { Id = 101, Name = "Apple", Quantity = 50, Price = 1.5 };
        Product p2 = new Product { Id = 102, Name = "Milk", Quantity = 20, Price = 2.0 };

        market.AddProduct(p1);
        market.AddProduct(p2);
        market.AddProduct(p1); 

        market.ViewAllProducts();

        market.RemoveProduct(103); 
        market.RemoveProduct(102); 

        market.ViewAllProducts();

        market.ViewProductDetails(101); 
        market.ViewProductDetails(105); 

        Console.ReadLine();
    }
}
