using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using PSDProject.Controller;
namespace PSDProject.Views
{
    public partial class Register : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["Role"] != null)
            {
                Response.Redirect("~/View/Home.aspx");
            }
            if (!IsPostBack)
            {
            }
        }

        protected void registerBtn_Click(object sender, EventArgs e)
        {
            string email = EmailTxt.Text;
            string password = PasswordTxt.Text;
            string username = UsernameTxt.Text;
            string gender = GenderLists.Text;
            string confirmPassword = ConfirmPasswordTxt.Text;

            List<string> msgs = UserController.CreateMember(email, password, username, gender, confirmPassword);
            if (msgs != null)
            {
                if (msgs[0] != "")
                {
                    UsernameLbl.Visible = true;
                    UsernameLbl.Text = msgs[0];

                }
                if (msgs[1] != "")
                {
                    EmailLbl.Visible = true;
                    EmailLbl.Text = msgs[1];
                }
                if (msgs[2] != "")
                {

                    GenderLbl.Visible = true;
                    GenderLbl.Text = msgs[2];

                }
                if (msgs[3] != "")
                {

                    PasswordLbl.Visible = true;
                    PasswordLbl.Text = msgs[3];

                }

                if (msgs[4] != "")
                {
                    ConfirmPasswordLbl.Visible = true;
                    ConfirmPasswordLbl.Text = msgs[4];

                }
            }
            else
            {
                Response.Redirect("~/Views/Login.aspx");
            }
        }
    }
}