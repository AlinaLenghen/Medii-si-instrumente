using System;
using System.Collections.Generic;
using System.Linq;

public class Program
{
    static void Main()
    {
        List<Product> products = new List<Product>
        {
            new Product { ProductId = 1, Name = "Apple", UnitPrice = 5.5m, Category = Category.Food },
            new Product { ProductId = 2, Name = "Orange", UnitPrice = 8.0m, Category = Category.Food },
            new Product { ProductId = 3, Name = "Milk", UnitPrice = 12.0m, Category = Category.Drink },
            new Product { ProductId = 4, Name = "Shampoo", UnitPrice = 15.5m, Category = Category.Care },
            new Product { ProductId = 5, Name = "Soap", UnitPrice = 7.75m, Category = Category.Care }
        };

        List<Customer> customers = new List<Customer>
        {
            new Customer { CustomerId = 1, CustomerName = "John", Country = "UK", City = "London", Phone = "0723 456 789" },
            new Customer { CustomerId = 2, CustomerName = "Jane", Country = "USA", City = "New York", Phone = "0711 222 333" },
            new Customer { CustomerId = 3, CustomerName = "Mike", Country = "Romania", City = "Bucharest", Phone = "0744 123 456" }
        };

        List<Order> orders = new List<Order>
        {
            new Order { OrderId = 1, OrderDate = new DateTime(2021, 5, 10), CustomerId = 1 },
            new Order { OrderId = 2, OrderDate = new DateTime(2022, 3, 15), CustomerId = 2 },
            new Order { OrderId = 3, OrderDate = new DateTime(2021, 8, 20), CustomerId = 3 },
            new Order { OrderId = 4, OrderDate = new DateTime(2021, 6, 5), CustomerId = 1 },
            new Order { OrderId = 5, OrderDate = new DateTime(2022, 1, 30), CustomerId = 2 }
        };

        List<OrderDetails> orderDetails = new List<OrderDetails>
        {
            new OrderDetails { OrderId = 1, ProductId = 1, Quantity = 2 },
            new OrderDetails { OrderId = 1, ProductId = 3, Quantity = 1 },
            new OrderDetails { OrderId = 2, ProductId = 2, Quantity = 3 },
            new OrderDetails { OrderId = 3, ProductId = 4, Quantity = 2 },
            new OrderDetails { OrderId = 4, ProductId = 1, Quantity = 1 },
            new OrderDetails { OrderId = 5, ProductId = 3, Quantity = 4 }
        };

        var productsWithPriceOver10 = products.Where(p => p.UnitPrice >= 10);
        Console.WriteLine("Products with Unit Price >= 10:");
        foreach (var product in productsWithPriceOver10)
        {
            Console.WriteLine($"{product.Name} - ${product.UnitPrice} - {product.Category}");
        }

        var allProductNames = products.Select(p => p.Name);
        Console.WriteLine("\nAll product names:");
        foreach (var name in allProductNames)
        {
            Console.WriteLine(name);
        }

        var productNamesAndPricesOver10 = products
            .Where(p => p.UnitPrice >= 10)
            .Select(p => new { p.Name, p.UnitPrice });
        Console.WriteLine("\nProduct names and unit prices where Unit Price >= 10:");
        foreach (var item in productNamesAndPricesOver10)
        {
            Console.WriteLine($"{item.Name} - ${item.UnitPrice}");
        }

        var mostExpensiveProducts = products.OrderByDescending(p => p.UnitPrice).Take(2);
        Console.WriteLine("\nMost expensive products:");
        foreach (var product in mostExpensiveProducts)
        {
            Console.WriteLine($"{product.Name} - ${product.UnitPrice}");
        }

        var allButMostExpensiveProducts = products.OrderByDescending(p => p.UnitPrice).Skip(2);
        Console.WriteLine("\nAll but most expensive 2 products:");
        foreach (var product in allButMostExpensiveProducts)
        {
            Console.WriteLine($"{product.Name} - ${product.UnitPrice}");
        }

        var customersWithOrders = from customer in customers
                                  join order in orders on customer.CustomerId equals order.CustomerId
                                  select new { customer.CustomerName, order.OrderId };
        Console.WriteLine("\nCustomers with their orders:");
        foreach (var item in customersWithOrders)
        {
            Console.WriteLine($"{item.CustomerName} - OrderId: {item.OrderId}");
        }

        var productsOrderedByCategoryAndPrice = products.OrderByDescending(p => p.UnitPrice).ThenBy(p => p.Category);
        Console.WriteLine("\nProducts ordered by Category and descending Unit Price:");
        foreach (var product in productsOrderedByCategoryAndPrice)
        {
            Console.WriteLine($"{product.Name} - ${product.UnitPrice} - {product.Category}");
        }

        var productsGroupedByCategory = products.GroupBy(p => p.Category);
        Console.WriteLine("\nProducts grouped by Category:");
        foreach (var group in productsGroupedByCategory)
        {
            Console.WriteLine($"Category: {group.Key}");
            foreach (var product in group)
            {
                Console.WriteLine($"- {product.Name}");
            }
        }

      var customersWithOrdersIn2021 = from customer in customers
                                        join order in orders on customer.CustomerId equals order.CustomerId
                                        where order.OrderDate.Year == 2021
                                        select customer;
        Console.WriteLine("\nCustomers with orders in 2021:");
        foreach (var customer in customersWithOrdersIn2021)
        {
            Console.WriteLine($"{customer.CustomerName}");
        }

        var customerWithPhone = customers.FirstOrDefault(c => c.Phone == "0723 456 789");
        if (customerWithPhone != null)
        {
            Console.WriteLine($"\nFirst customer with phone number '0723 456 789': {customerWithPhone.CustomerName}");
        }
        else
        {
            Console.WriteLine("No customer with phone number '0723 456 789' found.");
        }

        var totalCustomersFromLondon = customers.Count(c => c.City == "London");
        Console.WriteLine($"\nTotal number of customers from London: {totalCustomersFromLondon}");

        var hasCustomerFromRomania = customers.Any(c => c.Country == "Romania");
        Console.WriteLine($"\nDoes any customer come from Romania? {hasCustomerFromRomania}");

        var totalSumOfOrdersIn2021 = (from order in orders
                                       where order.OrderDate.Year == 2021
                                       join orderDetail in orderDetails on order.OrderId equals orderDetail.OrderId
                                       join product in products on orderDetail.ProductId equals product.ProductId
                                       select product.UnitPrice * orderDetail.Quantity).Sum();
        Console.WriteLine($"\nTotal sum of orders from 2021: ${totalSumOfOrdersIn2021}");
    }
}