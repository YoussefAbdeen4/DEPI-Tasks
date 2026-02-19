using System;
using System.Collections.Generic;
using System.Text;

namespace Business_Management_System
{
    internal class Employee : User
    {
        private string position;
        private double salary;

        public Employee(int id, string name, string email, string position, double salary) 
            : base(id, name, email) 
        {
            this.Position = position;
            this.Salary = salary;
        }

        public string Position { get => position; set => position = value; }
        public double Salary { get => salary; set => salary = value; }
    }
}
