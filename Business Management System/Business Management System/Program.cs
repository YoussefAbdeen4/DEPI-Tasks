namespace Business_Management_System
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Product p1 = new Product();
            Product p2 = new Product(1, "Laptop", 30000, 8);
            Product p3 = new Product(p1);
            p3.Name = "TV";
            p3.Id = 2;
            p3.Price = 10000;
            p3.StockQuantity = 6;

            Console.WriteLine("Products Created : ");
            Console.WriteLine(p1);
            Console.WriteLine(p2);
            Console.WriteLine(p3);

            Console.WriteLine("----------------------------------");

            Customer customer = new Customer(1, "Youssef","youssef@gmail.com","BNS","01203226858");
            Employee employee = new Employee(101, "Omer", "omer@gmail.com","manager",20000);

            Order order = new Order(customer);
            order.AddProduct(p2);
            order.AddProduct(p3);
            order.PrintOrder();

            Console.WriteLine("----------------------------------");


            Invoice invoice = new Invoice();
            invoice.addProduct(p2,2);
            invoice.addProduct(p3);
            invoice.desplayInvoice();
            Console.WriteLine($"Number of invoices = {Invoice.invoiceCount()}");

            Console.WriteLine("----------------------------------");

            List<Product> products = new List<Product> { p2, p3 };
            Product.applyDiscount(products, 10);

            Console.WriteLine("After 10% Discount:");
            foreach (Product p in products)
            {
                Console.WriteLine(p);
            }

            Console.WriteLine("----------------------------------");

            Payment payment ;

            payment = new CreditCardPayment();
            payment.processPayment(order.CalculateTotal());

            payment = new CashPayment();
            payment.processPayment(order.CalculateTotal());

        }
    }
}
