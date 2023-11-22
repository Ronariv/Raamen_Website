using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using PSDProject.Handler;

namespace PSDProject
{
    public partial class Site1 : System.Web.UI.MasterPage
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if(Session["Role"] == null)
            {
                
            }else if (Session["Role"].ToString() == "User")
            {
                loginBtn.Visible = false;
                registerBtn.Visible = false;

                logoutBtn.Visible = true;
                historyBtn.Visible = true;
                profileBtn.Visible = true;

                orderRamenBtn.Visible = true;
            }
            else if (string.Compare(Session["Role"].ToString(), "Staff") == 0)
            {
                loginBtn.Visible = false;
                registerBtn.Visible = false;

                logoutBtn.Visible = true;
                historyBtn.Visible = false;
                profileBtn.Visible = true;

                manageRamenBtn.Visible = true;
                orderQueueBtn.Visible = true;
            }
            else if (string.Compare(Session["Role"].ToString(), "Admin") == 0)
            {
                loginBtn.Visible = false;
                registerBtn.Visible = false;

                logoutBtn.Visible = true;
                historyBtn.Visible = true;
                profileBtn.Visible = true;

                manageRamenBtn.Visible = true;
                orderQueueBtn.Visible = true;

                reportBtn.Visible = true;
            }

        }
        protected void logoutBtn_Click(object sender, EventArgs e)
        {
            if (Request.Cookies["UserCookie"] != null)
            {
                HttpCookie userCookie = new HttpCookie("UserCookie");
                Request.Cookies["UserCookie"].Expires = DateTime.Now.AddDays(-1);
                Response.Cookies.Add(userCookie);
            }
            Session.Abandon();
            Response.Redirect("~/Views/Login.aspx");
        }

        protected void loginBtn_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/Views/Login.aspx");
        }

        protected void registerBtn_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/Views/Register.aspx");
        }

        protected void logoutBtn_Click1(object sender, EventArgs e)
        {
            if (Request.Cookies["UserCookie"] != null)
            {
                HttpCookie userCookie = new HttpCookie("UserCookie");
                Request.Cookies["UserCookie"].Expires = DateTime.Now.AddDays(-1);
                Response.Cookies.Add(userCookie);
            }
            Session.Abandon();
            Response.Redirect("~/Views/Login.aspx");
        }
    }
}