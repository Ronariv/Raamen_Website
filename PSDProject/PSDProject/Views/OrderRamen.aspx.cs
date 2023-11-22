using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using PSDProject.Controller;
using PSDProject.Model;
namespace PSDProject.Views
{
    public partial class OrderRamen : System.Web.UI.Page
    {
        //List<(int, int)> cart = new List<(int, int)>();
        
        protected void Page_Load(object sender, EventArgs e)
        {
            
            if (Session["Role"] == null)
            {
                Response.Redirect("~/Views/Home.aspx");
            }
            
            
            if (!IsPostBack)
            {
                int CustId = Convert.ToInt32(Session["Id"].ToString());
                var cart = CartController.getCart(CustId);
                HttpContext.Current.Session["Cart"] = cart;
                GridViewCart.DataSource = CartController.getCart(CustId);
                GridViewCart.DataBind();
                RepeaterRamen.DataSource = RamenController.getRamenList();
                RepeaterRamen.DataBind();
            }
            
        }


        protected void detailBtn_Click(object sender, EventArgs e)
        {
            if (Session["Role"].ToString() == "User")
            {
                LinkButton linkbtn = (LinkButton)sender;
                int ramenid = Convert.ToInt32(linkbtn.CommandArgument);
                int customerid = Convert.ToInt32(Session["Id"].ToString());
                CartController.addCart(customerid,ramenid);

                GridViewCart.DataSource = CartController.getCart(customerid);
                GridViewCart.DataBind();
            }
            else
            {
                
            }
        }
        protected void BuyBtn_Click(object sender, EventArgs e)
        {
            int CustomerId = Convert.ToInt32(Session["Id"].ToString());
            DateTime date = DateTime.Now;
            //staff id sama seperti customer id berarti unhandled
            int headerId = TransactionController.CreateTransactionHeader(CustomerId,CustomerId,date);

            dynamic cart = CartController.getCartTransaction(CustomerId);
            foreach (dynamic c in cart)
            {
                TransactionController.CreateTransactionDetail(headerId, c.RamenId, c.Quantity);
            }
            cart.Clear();
            
            CartController.ClearCart(CustomerId);
            GridViewCart.DataSource = CartController.getCart(CustomerId);
            GridViewCart.DataBind();
        }

        protected void ClearBtn_Click(object sender, EventArgs e)
        {
            int CustomerId = Convert.ToInt32(Session["Id"].ToString());
            CartController.ClearCart(CustomerId);
            GridViewCart.DataSource = CartController.getCart(CustomerId);
            GridViewCart.DataBind();
        }
    }
}