using System;
using System.Collections.Generic;
using System.Text;

namespace Business_Management_System
{
    internal class Product
    {
        private int id;
        private string name;
        private double price;
        private int stockQuantity;

        public Product()
        {
            this.Id = 0;
            this.Name = "Unknown";
            this.Price = 0;
            this.StockQuantity = 0;
        }
        public Product(int id, string name, double price, int stockQuantity)
        {
            this.Id = id;
            this.Name = name;
            this.Price = price;
            this.StockQuantity = stockQuantity;
        }

        public Product (Product product)
        {
            this.Id = product.Id;
            this.Name = product.Name;
            this.Price = product.Price;
            this.StockQuantity = product.StockQuantity;
        }

        public int Id { get => id; set => id = value; }
        public string Name { get => name; set => name = value; }
        public double Price { get => price; set {
                if (value < 0)
                {
                    Console.WriteLine("Invalid price...!");
                    return;
                }
                price = value; 
            }
        }
        public int StockQuantity { get => stockQuantity; set {
                if (value < 0)
                {
                    Console.WriteLine("Invalid stock Quantity..!");
                    return;
                }
                stockQuantity = value;
            } 
        }

        public static void applyDiscount(List<Product> products, double percentage)
        {
            if (percentage < 0 || percentage > 100)
            {
                Console.WriteLine("Invalid discount percentage!");
                return;
            }

            foreach (Product product in products)
            {
                product.Price -= product.Price * (percentage / 100);
            }
        }

        public override string ToString()
        {
            return $"Product [ ID: {Id}, Name: {Name}, Price: {Price}, Stock: {StockQuantity} ]"; ;
        }
    }
}
