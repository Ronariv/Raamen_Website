using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using PSDProject.Handler;
using PSDProject.Model;
using System.Text.RegularExpressions;
namespace PSDProject.Controller
{
    public class RamenController
    {
        public static List<String> InsertRamen(string name, int meat, string broth, int price)
        {
            List<string> messages = new List<string>();
            messages.Add("");
            messages.Add("");
            messages.Add("");
            messages.Add("");

            if (!name.Contains("Ramen"))
            {
                messages[0] = "Name must contain Ramen";
            }

            if (meat < 0)
            {
                messages[1] = "Meat must be chosen";
            }

            if (string.IsNullOrEmpty(broth))
            {
                messages[2] = "Broth cannot be empty";
            }

            if((price) < 3000)
            {
                messages[3] = "Price must be at leat 3000";
            }

            if (messages[0] == "" && messages[1] == "" && messages[2] == "" && messages[3] == "")
            {
                RamenHandler.CreateRamen(name, meat, broth, price);
                return null;
            }
            return messages;
        }

        public static List<String> UpdateRamen(string id, string name, int meat, string broth, int price)
        {
            List<string> messages = new List<string>();
            messages.Add("");
            messages.Add("");
            messages.Add("");
            messages.Add("");

            if (!name.Contains("Ramen"))
            {
                messages[0] = "Name must contain Ramen";
            }

            if (meat < 0)
            {
                messages[1] = "Meat must be chosen";
            }

            if (string.IsNullOrEmpty(broth))
            {
                messages[2] = "Broth cannot be empty";
            }

            if ((price) < 3000)
            {
                messages[3] = "Price must be at leat 3000";
            }

            if (messages[0] == "" && messages[1] == "" && messages[2] == "" && messages[3] == "")
            {
                RamenHandler.UpdateRamen(id,name, meat, broth, price);
                return null;
            }
            return messages;
        }

        public static void DeleteRamen(string id)
        {
            RamenHandler.DeleteRamen(id);
        }
        public static Ramen getRamen(int id)
        {
            return RamenHandler.getRamen(id);
        }
        public static dynamic getRamenList()
        {
            return RamenHandler.getRamenList();
        }

        public static List<Meat> getMeatList()
        {
            return RamenHandler.getMeatList();
        }


    }
}