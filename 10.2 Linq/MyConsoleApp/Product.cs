using System;
using System.Collections.Generic;
using System.Linq;

public class Product
{
    public int ProductId { get; set; }
    public string Name { get; set; }
    public decimal UnitPrice { get; set; }
    public Category Category { get; set; }
}