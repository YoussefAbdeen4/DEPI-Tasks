namespace HR_Management_System
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Employee employee = new Employee();
            Employee employee2 = new Employee(2,"Omer",12000);
            Employee employee1 = new Employee(employee);
            employee1.Id = 3;
            employee1.Name = "Mahmoud";
            employee1.Salary = 10000;

            Manager manager = new Manager();
            Manager manager1 = new Manager(4,"Youssef",24000,4000,8);
            Manager manager2 = new Manager(manager);
            manager2.Id = 5;
            manager2.Name = "Ahmed";
            manager2.Salary = 20000;
            manager2.Bonus = 3600;
            manager1.TeamSize = 6;

            Employee[] emp = [employee, employee1, employee2, manager, manager1, manager2];

            foreach (Employee e in emp) {
                e.displayInfo();
            }
        }
    }
}