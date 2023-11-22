using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using PSDProject.Repository;
using PSDProject.Model;

namespace PSDProject.Handler
{
    public class UserHandler
    {
        public static dynamic IsUniqueEmail(string email)
        {
            return UserRepository.IsUniqueEmail(email);
        }

        public static dynamic IsValidCredential(string email, string password)
        {
            return UserRepository.IsValidCredential(email, password);
        }
        public static void Register(string email, string password, string name, string gender)
        {
            UserRepository.Register(email, password, name,gender);
        }
        public static string getRole(int roleid)
        {
            return UserRepository.getRole(roleid);
        }

        public static dynamic getUser(int id)
        {
            return UserRepository.getUser(id);
        }

        public static void UpdateMember(int id,string email,string password, string name, string gender)
        {
            UserRepository.UpdateMember(id,email, password, name, gender);
        }

        public static dynamic getUserListByRole(int roleid)
        {
            return UserRepository.getUserListByRole(roleid);
        }
    }
}