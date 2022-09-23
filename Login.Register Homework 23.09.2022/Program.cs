using Login.Register_Homework_23._09._2022.LoginRegisterHW;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Login.Register_Homework_23._09._2022
{
    public class Program
    {
        static void Main(string[] args)
        {
            
        }
        private static  Your_Account account = new Your_Account();
        public static void user(string[] args)
        {
            //menyu
            bool stoop = true;
            while (stoop)
            {
                Console.WriteLine("1: Register");
                Console.WriteLine("2: Forget password");
                Console.WriteLine("3: Check login and password");
                int menu = int.Parse(Console.ReadLine());
                try
                {
                    switch (menu)
                    {

                        case 1:
                            Register();
                            stoop = false;
                            break;
                        case 2:
                            ForgetPassword(account.user);
                            stoop = false;
                            break;
                        case 3:
                            CheckloginAndPassword(account.user);
                            stoop = false;
                            break;
                        default:
                            break;
                    }
                }
                catch (FormatException)
                {
                    Console.WriteLine("Wrong Menu");
                }
            }

        }

        public static void Register()
        {
            try
            {
                Console.Write("Enter The Login: ");
                string name = Console.ReadLine();
                string username = name;
                Console.Write("Enter The Password: ");
                string password = Console.ReadLine();
                int userpassword = int.Parse(password);
                if (name == username && int.Parse(password) == userpassword)
                {
                    Console.WriteLine("Welcome");
                    Console.WriteLine(" ");
                }
                User use1 = new User(name, password);
                account.Register(use1);

            }
            catch (Exception)
            {
                Console.WriteLine("Your password wrong");
            }
        }
        public static void ForgetPassword( List<User> user)
        {
            Console.Write("Enter The  Login: ");
            string ad = Console.ReadLine();
            Console.Write("Enter The Password: ");
            string pass = Console.ReadLine();
            try
            {
                User user1 = user.Where(u => u.Name == ad).FirstOrDefault();
                user1.Password = pass;
                Console.WriteLine("You Changed Your Password");
                Console.WriteLine(" ");
            }
            catch (FormatException)
            {
                Console.WriteLine("Wrong Login Or Password");
            }
        }
        public static void CheckloginAndPassword(List<User>user)
        {
            while (true)
            {
                Console.Write("Enter the login: ");
                string login = Console.ReadLine();
                Console.Write("Enter the password: ");
                string kod = Console.ReadLine();
                User user1 = user.Where(u => u.Name == login).FirstOrDefault();
                if (user1 != null)
                {
                    if (user1.Password == kod)
                    {
                        Console.WriteLine("Welcome ");
                    }
                    else
                    {
                        Console.WriteLine("Wrong Password");
                    }
                }
                else
                {
                    Console.WriteLine("User Not Found");
                }
            }
        }

    }
}
    
    

