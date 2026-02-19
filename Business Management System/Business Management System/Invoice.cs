using System;
using System.Collections.Generic;
using System.Text;

namespace Business_Management_System
{
    internal class Invoice
    {
        private static int invoiceCounter;
        private int invoiceNumber;
        private LinkedList <string> products = new LinkedList <string> (); 

        static Invoice()
        {
            invoiceCounter = 1000;
        }

        public Invoice() {
            invoiceCounter++;
            this.invoiceNumber = invoiceCounter;
        }

        public void addProduct(Product product) {
            products.AddLast($"{product.Name} - {product.Price}");
        }

        public void addProduct(Product product, int quantity)
        {
            products.AddLast($"{product.Name} - {product.Price*quantity}");
        }

        public void desplayInvoice()
        {
            foreach (string product in products) { 
                Console.WriteLine(product);  
            }
            Console.WriteLine("invoice Number : " + this.invoiceNumber);
        }

        public static int invoiceCount()
        {
            return invoiceCounter - 1000;
        }
    }
}
