using System;
using System.Collections.Generic;
using System.Text;

namespace Business_Management_System
{
    internal class Customer : User
    {
        private string address, phone;

        public Customer(int id, string name, string email, string address, string phone)
           : base(id, name, email)
        {
            this.Address = address;
            this.Phone = phone;
        }

        public string Address { get => address; set => address = value; }
        public string Phone { get => phone; set => phone = value; }
    }
}
