using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using PSDProject.Model;

namespace PSDProject.Factory
{
    public class RamenFactory
    {
        public static Ramen CreateRamen(string name, int meatid, string broth, int price)
        {
            return new Ramen
            {
                Name = name,
                Meatid = meatid,
                Broth = broth,
                Price = price
            };
            
        }

        public static Meat CreateMeat(string meat)
        {
            return new Meat
            {
                Name = meat
            };
        }
    }
}