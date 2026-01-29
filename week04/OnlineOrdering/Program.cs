using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("=== E-COMMERCE ORDER PROCESSING SYSTEM ===\n");

        // Create addresses
        Address address1 = new Address("123 Main St", "New York", "NY", "USA");
        Address address2 = new Address("456 Oak Ave", "Toronto", "ON", "Canada");

        // Create customers
        Customer customer1 = new Customer("John Smith", address1);
        Customer customer2 = new Customer("Emily Johnson", address2);

        // Create products
        Product product1 = new Product("Laptop", "P001", 999.99, 1);
        Product product2 = new Product("Mouse", "P002", 25.50, 2);
        Product product3 = new Product("Keyboard", "P003", 75.00, 1);
        Product product4 = new Product("Monitor", "P004", 299.99, 1);
        Product product5 = new Product("USB Cable", "P005", 12.99, 3);

        // Create first order (USA customer)
        Order order1 = new Order(customer1);
        order1.AddProduct(product1);
        order1.AddProduct(product2);
        order1.AddProduct(product3);

        // Create second order (International customer)
        Order order2 = new Order(customer2);
        order2.AddProduct(product4);
        order2.AddProduct(product5);
        order2.AddProduct(product2); // Adding mouse again for second customer

        // Store orders in a list
        Order[] orders = { order1, order2 };

        // Process and display each order
        for (int i = 0; i < orders.Length; i++)
        {
            Console.WriteLine($"\n{new string('=', 50)}");
            Console.WriteLine($"ORDER {i + 1} DETAILS");
            Console.WriteLine($"{new string('=', 40)}");

            // Display shipping label
            Console.WriteLine("\n" + orders[i].GetShippingLabel());

            // Display packing label
            Console.WriteLine("\n" + orders[i].GetPackingLabel());

            // Calculate and display total cost
            double totalCost = orders[i].CalculateTotalCost();
            Console.WriteLine($"\nORDER TOTAL: ${totalCost:F2}");
            Console.WriteLine($"Shipping Cost: ${(orders[i].GetCustomer().IsInUSA() ? "5.00" : "35.00")}");

            Console.WriteLine($"\n{new string('=', 50)}\n");
        }

        // Display summary
        Console.WriteLine("\nORDER SUMMARY");
        Console.WriteLine($"{new string('=', 30)}");
        Console.WriteLine($"Total Orders Processed: {orders.Length}");
        Console.WriteLine($"Order 1 Total: ${order1.CalculateTotalCost():F2}");
        Console.WriteLine($"Order 2 Total: ${order2.CalculateTotalCost():F2}");
        Console.WriteLine($"\nPress any key to exit...");
        Console.ReadKey();
    }
}