using System;
using System.Collections.Generic;
namespace FactoryPattern2
{
	public class Product
	{
		public Product()
		{
		}
		public string Name { get; set; }
		public int Price { get; set; }
		public static List<Product> products = new List<Product>
		{
			new Product() {Name = "Iphone", Price = (int)1000.00},
			new Product() {Name= "Air Pods", Price = (int)199.00},

		};
	}
}

