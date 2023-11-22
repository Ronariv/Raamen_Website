using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using PSDProject.Repository;
using PSDProject.Model;
namespace PSDProject.Handler
{
    public class CartHandler
    {
        public static void addCart(int CustomerId, int RamenId)
        {
            CartRepository.addCart(CustomerId, RamenId);
        }
        public static dynamic getCart(int custid)
        {
            return CartRepository.getCart(custid);
        }
        public static List<Cart> getCartTransaction(int custId)
        {
            return CartRepository.getCartTransaction(custId);
        }
        public static void ClearCart(int custid)
        {
            CartRepository.ClearCart(custid);
        }
    }
}