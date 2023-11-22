using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using PSDProject.Model;
using PSDProject.Factory;
namespace PSDProject.Repository
{
    public class CartRepository
    {
        private static Database1Entities1 db = new Database1Entities1();
        public static dynamic getCart(int custid)
        {
            //cart hanya menunukan nama ramen dan quantity
            return (from x in db.Carts where x.CustomerId.Equals(custid) 
                    select x).Join(
                    db.Ramen1,
                    cart => cart.RamenId,
                    ramen => ramen.Id,
                    (cart,ramen) => new
                    {
                        Name = ramen.Name,
                        Quantity = cart.Quantity
                    }
                    )
                    .ToList();
        }
        public static List<Cart> getCartTransaction(int custId)
        {
            return db.Carts.Where(x => x.CustomerId == custId).ToList();
        }
        public static void addCart(int CustomerId, int RamenId)
        {
            var ramen = (from cart in db.Carts where cart.RamenId == RamenId select cart).FirstOrDefault();
            if(ramen == null)
            {
                db.Carts.Add(CartFactory.CreateCart(CustomerId, RamenId, 1));
                db.SaveChanges();
                return;
            }
            else
            {
                ramen.Quantity = (ramen.Quantity + 1);
                db.SaveChanges();
            }
            
        }

        public static void ClearCart(int custid)
        {
            db.Carts.RemoveRange(db.Carts.Where(x => x.CustomerId == custid));
            db.SaveChanges();
        }
    }
}