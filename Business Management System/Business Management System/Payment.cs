using System;
using System.Collections.Generic;
using System.Text;

namespace Business_Management_System
{
    internal abstract class Payment
    {
        public abstract void processPayment(double ammount);
    }
}
