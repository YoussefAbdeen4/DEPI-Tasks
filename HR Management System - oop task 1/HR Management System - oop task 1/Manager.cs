using System;
using System.Collections.Generic;
using System.Text;

namespace HR_Management_System
{
    internal class Manager : Employee
    {
        private double bonus;
        private int teamSize;

        public Manager() : base() {  
            this.Bonus = 3000;
            this.TeamSize = 5;
        }

        public Manager(int id, string name, double salary, double bonus, int teamSize) : base(id, name, salary)
        {
            this.Bonus = bonus;
            this.TeamSize = teamSize;
        }

        public Manager(Manager manager) : base(manager) { 
            this.Bonus = manager.Bonus;
            this.TeamSize = manager.TeamSize;
        }
        public double Bonus { get => bonus; set  {
                if (value < 0) {
                    Console.WriteLine("Invalid bonus...!");
                    return;
                }
                bonus = value;
            } 
        }
        public int TeamSize { get => teamSize; set  {
                if (value <= 0) {
                    Console.WriteLine("Invalid team Size..!");
                    return;
                }
                teamSize = value; 
            } 
        }

    }
}
