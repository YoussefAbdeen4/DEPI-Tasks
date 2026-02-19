using System;
using System.Collections.Generic;
using System.Text;

namespace Business_Management_System
{
    internal class CashPayment : Payment
    {
        public override void processPayment(double ammount)
        {
            Console.WriteLine($"{ammount}$ Processing cash payment…");
        }
    }
}
