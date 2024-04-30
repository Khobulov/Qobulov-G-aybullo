using System;
using System.Collections.Generic;

namespace LogFormApplication
{
    public class User
    {
        public string FullName { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }

        public User(string fullName, string userName, string password)
        {
            FullName = fullName;
            UserName = userName;
            Password = password;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            List<User> users = new List<User>();

            User superAdmin = new User("Super Admin", "superadmin", "superadminpass");
            users.Add(superAdmin);

            User admin = new User("Admin", "admin", "adminpass");
            users.Add(admin);

            for (int i = 1; i <= 5; i++)
            {
                User user = new User($"User {i}", $"user{i}", $"user{i}pass");
                users.Add(user);
            }

           
        }
    }
}
