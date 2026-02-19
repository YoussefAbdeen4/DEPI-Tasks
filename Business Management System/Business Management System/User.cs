using System;
using System.Collections.Generic;
using System.Text;

namespace Business_Management_System
{
    internal class User
    {
        private int id;
        private string name;
        private string email;

        public User (int id, string name, string email)
        {
            this.Id = id;
            this.Name = name;
            this.Email = email;
        }

        public int Id { get => id; set => id = value; }
        public string Name { get => name; set => name = value; }
        public string Email { get => email; set => email = value; }
    }
}
