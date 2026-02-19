using System;
using System.Collections.Generic;
using System.Text;

namespace HR_Management_System
{
    internal class Employee
    {
        private int id;
        private string name;
        private double salary;
        public Employee() { 
            this.id = 1;
            this.name = "NewEmployee";
            this.Salary = 3000;
        }

        public Employee(int id, string name, double salary)
        {
            this.id = id;
            this.name = name;
            this.salary = salary;
        }

        public Employee(Employee employee)
        {
            this.id= employee.id;
            this.name = employee.name;
            this.salary = employee.salary;
        }

        public int Id { get => id; set
            {
                if (value <= 0) {
                    Console.WriteLine("Invalid id...!");
                    return;
                }
                id = value;
            }
        }
        public string Name { get => name; set {
                if (value == null || value.Equals("")) {
                    Console.WriteLine("Invalid Name...!");
                    return;
                }
                name = value;
            } 
        }
        public double Salary { get => salary; set  {
                if (value < 0 ) {
                    Console.WriteLine("Invalid Salary...!");
                    return;
                }
                salary = value;
            } 
        }

        public void displayInfo()
        {
            Console.WriteLine($"Employee [ id = '{this.Id}', name = '{this.Name}', salary = '{this.Salary}' ]");
        }
    }
}
