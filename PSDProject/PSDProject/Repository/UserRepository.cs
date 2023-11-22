using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using PSDProject.Factory;
using PSDProject.Model;

namespace PSDProject.Repository
{
    public class UserRepository
    {
        private static Database1Entities1 db = new Database1Entities1();
        public static dynamic IsUniqueEmail(string email)
        {
            var users = db.Users.Where(x => x.Email == email).FirstOrDefault();

            return users;
        }

        public static dynamic IsValidCredential(string email, string password)
        {
            var members = db.Users.Where(x => x.Email == email && x.Password == password).FirstOrDefault();

            return members;
        }
        public static void Register(string email, string password, string name, string gender)
        {
            //role disini hanya diasumsi hanya bisa user yang register
            db.Users.Add(UserFactory.createUser(name,email, gender,password,3));
            db.SaveChanges();
        }
        public static string getRole(int roleid)
        {
            string role = (from roles in db.Roles where roleid == roles.Id select roles.Name).FirstOrDefault();

            return role;
        }

        public static dynamic getUser(int id)
        {
            var user = db.Users.Where(x => x.Id == id).FirstOrDefault();
            return user;
        }

        public static void UpdateMember(int id,string email,string password, string name, string gender)
        {
            var item = db.Users.Where(x => x.Id == id).FirstOrDefault();
            if (item == null) return;

            item.Username = name;
            item.Email = email;
            item.Gender = gender;
            item.Password = password;
            db.SaveChanges();
        }

        public static dynamic getUserListByRole(int roleid)
        {
            //password di hide
            return (from x in db.Users where x.Roleid.Equals(roleid) select x)
                .Join(db.Roles,
                user => user.Roleid,
                role => role.Id,
                (user,role) => new
                {
                    Id = user.Id,
                    Username = user.Username,
                    Email = user.Email,
                    Gender = user.Gender,
                    Role = role.Name,                
                }
                )
                .ToList();
        }
    }
}