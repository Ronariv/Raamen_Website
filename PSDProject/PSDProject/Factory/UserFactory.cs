using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using PSDProject.Model;

namespace PSDProject.Factory
{
    public class UserFactory
    {
        public static User createUser(string username, string email, string gender, string pass, int role)
        {
            return new User
            {
                Username = username,
                Email = email,
                Gender = gender,
                Password = pass,
                Roleid = role
            };
        }
    }
}