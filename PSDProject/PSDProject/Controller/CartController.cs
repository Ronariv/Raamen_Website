using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using PSDProject.Model;
using PSDProject.Handler;
namespace PSDProject.Controller
{
    public class CartController
    {
        public static dynamic getCart(int CustId)
        {
            return CartHandler.getCart(CustId);
        }
        public static List<Cart> getCartTransaction(int custId)
        {
            return CartHandler.getCartTransaction(custId);
        }
        public static void addCart(int CustomerId, int RamenId)
        {
            CartHandler.addCart(CustomerId, RamenId);
        }

        public static void ClearCart(int custid)
        {
            CartHandler.ClearCart(custid);
        }

        //public static dynamic addToCart(List<(int,int)> cart,int id)
        //{
        //    //List<Tuple<int, int>> tuples = new List<Tuple<int, int>>();
        //    var updateCart = new List<(int, int)>();
        //    bool newRamen = true;

        //    foreach(var c in cart)
        //    {
        //        if(c.Item1 == id)
        //        {
        //            //List<Tuple<int, int>> temp = new List<Tuple<int, int>>();
        //            int plusRamen = c.Item2 + 1;
        //            updateCart.Add((c.Item1, plusRamen));
        //            newRamen = false;
        //        }
        //        else
        //        {
        //            updateCart.Add((c.Item1,c.Item2));
        //        }       
        //    }
        //    if (newRamen)
        //    {
        //        updateCart.Add((id, 1));
        //    }
        //    return updateCart;
        //}
    }
}