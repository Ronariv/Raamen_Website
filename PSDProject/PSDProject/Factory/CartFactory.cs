using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using PSDProject.Model;
namespace PSDProject.Factory
{
    public class CartFactory
    {
        public static Cart CreateCart(int CustomerId, int RamenId, int Qty)
        {
            return new Cart
            {
                CustomerId = CustomerId,
                RamenId = RamenId,
                Quantity = Qty
            };

        }
    }
}