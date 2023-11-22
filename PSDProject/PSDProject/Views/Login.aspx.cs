using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using PSDProject.Controller;
namespace PSDProject.Views
{
    public partial class Login : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                if (Session["Role"] != null)
                {
                    Response.Redirect("~/Views/Home.aspx");
                }
                else if (Request.Cookies["UserCookie"] != null)
                {
                    EmailTxt.Text = Request.Cookies["UserCookie"]["Email"];
                    PasswordTxt.Attributes["value"] = Request.Cookies["UserCookie"]["Password"];
                }
            }
        }

        //cara login admin
        //email = admin1@email.com 
        //pass = admin123

        //cara login staff
        //email = staff1@email.com
        //pass = staff123
        protected void LoginBtn_Click(object sender, EventArgs e)
        {
            string email = EmailTxt.Text;
            string password = PasswordTxt.Text;
            bool rememberCheck = RememberCheckBox.Checked;

            string LoginResult = UserController.LoginUser(email, password, rememberCheck);
            if (LoginResult == null)
            {
                Response.Redirect("~/Views/Home.aspx");
            }
            else
            {
                ErrorLbl.Text = LoginResult;
                ErrorLbl.Visible = true;
            }
        }
    }
}