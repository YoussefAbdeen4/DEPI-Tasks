using System;
using System.Collections.Generic;
using System.Text;

namespace Business_Management_System
{
    internal class CreditCardPayment : Payment
    {
        public override void processPayment(double ammount)
        {
            Console.WriteLine($"{ammount}$ Processing credit card payment…");
        }
    }
}
