using System;
using System.Collections.Generic;
using System.Text;

namespace Business_Management_System
{
    internal class Order
    {
        private Customer Customer;

        private List<Product> products = new List<Product>();

        public Order(Customer customer)
        {
            this.Customer = customer;
        }

        public void AddProduct(Product product)
        {
            products.Add(product);
        }

        public double CalculateTotal()
        {
            double total = 0;

            foreach (Product product in products)
            {
                total += product.Price;
            }

            return total;
        }

        public void PrintOrder()
        {
            Console.WriteLine($"Customer : {Customer.Name}");
            Console.WriteLine("Products :- ");

            foreach (var product in products)
            {
                Console.WriteLine($"{product.Name} - {product.Price:C}");
            }

            Console.WriteLine($"Total: {this.CalculateTotal()}");
        }
    }
}
