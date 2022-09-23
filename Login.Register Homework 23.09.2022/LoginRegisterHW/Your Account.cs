using System;
using System.Collections.Generic;
using System.Text;

namespace Login.Register_Homework_23._09._2022.LoginRegisterHW
{
    public class Your_Account
    {
        public List<User> user = new List<User>();
        public void Register(User user) => user.Add(user);
    }
}
