using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Data;

namespace _04._Orders
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, Product> products = new Dictionary<string, Product>();

            while (true)
            {
                string[] command = Console.ReadLine().Split();
                string name = command[0];
                if (name == "buy")
                {
                    break;
                }
                double price = double.Parse(command[1]);
                int quantity = int.Parse(command[2]);
                
                Product curentProduct = new Product(name, price, quantity);

                if (products.ContainsKey(curentProduct.Name))
                {
                    products[curentProduct.Name].Quantity += quantity;
                    if (products[curentProduct.Name].Price != price)
                    {
                        products[curentProduct.Name].Price = price;
                    }
                }
                else
                {
                    products.Add(curentProduct.Name, curentProduct);
                }
            }

            foreach (var product in products)
            {
                Console.WriteLine($"{product.Key} -> {product.Value.Price * product.Value.Quantity:f2}");
            }

        }

        public class Product
        {
            public string Name { get; set; }
            public double Price { get; set; }
            public int Quantity { get; set; }


            public Product(string name, double price, int quantity)
            {
                this.Name = name;
                this.Price = price;
                this.Quantity = quantity;
            }
        }
    }
}
