using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
using System.Web;
using System.Web.UI.WebControls;
using PSDProject.Handler;
using PSDProject.Model;
namespace PSDProject.Controller
{
    public class UserController
    {
        public static List<string> CreateMember(string email, string password, string username, string gender, string confirmPassword)
        {
            List<string> messages = new List<string>();
            messages.Add("");
            messages.Add("");
            messages.Add("");
            messages.Add("");
            messages.Add("");

            if (username.Length < 5 || username.Length > 15)
            {
                messages[0] = "Username must be between 5 and 15 characters.";
            }
            else if (!Regex.IsMatch(username, @"^[a-zA-Z\s]+$"))
            {
                messages[0] = "Username must only contain alphabet characters and spaces.";
            }
            if (IsUniqueEmail(email) != null || !email.Contains("@") || !email.Contains(".com"))
            {
                messages[1] = "Email must be unique and using a correct email format";
            }
            //gender
            if (string.IsNullOrEmpty(gender))
            {
                messages[2] = "Please select a gender.";
            }
            if (password.Length < 5 || password.Length > 15)
            {
                messages[3] = "Password length must be between 5 and 15 characters.";
            }

            

            // Validasi password dan confirm password
            // string confirmpassword = passwordtxt.text.trim();
            if (password != confirmPassword)
            {
                messages[4] = "Password and Confirm Password must match.";
            }

            if (messages[0] == "" && messages[1] == "" && messages[2] == "" && messages[3] == "" && messages[4] == "")
            {
                UserHandler.Register(email, password, username, gender);
                return null;
            }


            return messages;
        }

        public static List<string> UpdateMember(int id,string email, string password, string username, string gender, string updatePassword, string emailLama)
        {
            List<string> messages = new List<string>();
            messages.Add("");
            messages.Add("");
            messages.Add("");
            messages.Add("");

            // Validasi username
            if (username.Length < 5 || username.Length > 15)
            {
                messages[0] = "Username must be between 5 and 15 characters.";
            }
            else if (!Regex.IsMatch(username, @"^[a-zA-Z\s]+$"))
            {
                messages[0] = "Username must only contain alphabet characters and spaces.";
            }

            // email
            if (string.Compare(email, emailLama) == 0)
            {
                
            }
            else if (IsUniqueEmail(email) != null || !email.Contains("@") || !email.Contains(".com"))
            {
                messages[1] = "Email must be unique and using a correct email format";
            }


            //gender
            if (string.IsNullOrEmpty(gender))
            {
                messages[2] = "Please select a gender.";
            }
            // Validasi password
            if (string.Compare(password,updatePassword) != 0)
            {
                messages[3] = "Password be the same as current password";
            }

            if (messages[0] == "" && messages[1] == "" && messages[2] == "" && messages[3] == "")
            {
                UserHandler.UpdateMember(id, email, password, username, gender);
                updateSession(id);

                return null;
            }


            return messages;
        }

        public static void updateSession(int id)
        {
            var user = UserHandler.getUser(id);
            HttpContext.Current.Session["User"] = user;
            HttpContext.Current.Session["Username"] = user.Username;
            HttpContext.Current.Session["ID"] = id;
            HttpContext.Current.Session["Email"] = user.Email;
            HttpContext.Current.Session["Gender"] = user.Gender;
            HttpContext.Current.Session["Password"] = user.Password;
        }

        public static bool IsAlphabet(string s)
        {
            s = s.ToLower();
            for (int i = 0; i < s.Length; i++)
            {
                if ((s[i] < 'a' || s[i] > 'z') && s[i] != ' ') return false;
            }
            return true;
        }

        public static string LoginUser(string email, string password, bool remember)
        {
            if (!email.Contains(".com") || !email.Contains("@"))
            {
                return "Email must using a correct email format";
            }

            var user = IsValidCredential(email, password);
            if (user == null)
            {
                return "Credential is not valid";
            } 

            string role = UserHandler.getRole(user.Roleid);
            HttpContext.Current.Session["Role"] = role;
            HttpContext.Current.Session["User"] = user;
            HttpContext.Current.Session["Username"] = user.Username;
            HttpContext.Current.Session["ID"] = user.Id;
            HttpContext.Current.Session["Email"] = email;
            HttpContext.Current.Session["Gender"] = user.Gender;
            HttpContext.Current.Session["Password"] = password;
            
            
            if (remember)
            {
                HttpCookie userCookie = new HttpCookie("UserCookie");
                userCookie.Values.Add("Email", email);
                userCookie.Values.Add("Password", password);
                userCookie.Expires = DateTime.Now.AddHours(24);
                HttpContext.Current.Response.Cookies.Add(userCookie);
            }

            return null;
        }

        public static dynamic getUserListByRole(int roleid)
        {
            return UserHandler.getUserListByRole(roleid);
        }
        public static dynamic IsUniqueEmail(string email)
        {
            return UserHandler.IsUniqueEmail(email);
        }
        public static dynamic IsValidCredential(string email, string password)
        {
            return UserHandler.IsValidCredential(email, password);
        }
        public static dynamic getUser(int id)
        {
            return UserHandler.getUser(id);
        }
    }
}