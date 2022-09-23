using System;
using System.Collections.Generic;
using System.Text;

namespace Login.Register_Homework_23._09._2022.LoginRegisterHW
{
    public class User
    {
        public string Name { get; set; }
        public string Password { get; set; }

        public User(string name, string password)
        {
            Name = name;
            Password = password;
        }

        public void Add(User user)
        {
            Console.WriteLine("Add New User");
        }
    }
}
