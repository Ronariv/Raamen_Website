using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using PSDProject.Controller;
namespace PSDProject.Views
{
    public partial class Profile : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["Role"] == null)
            {
                Response.Redirect("~/Views/Home.aspx");
            }
            if (!IsPostBack)
            {
                EmailTxt.Text = Session["Email"].ToString();
                UsernameTxt.Text = Session["Username"].ToString();
                GenderLists.Text = Session["Gender"].ToString();
            }
            
        }

        protected void UpdateButton_Click(object sender, EventArgs e)
        {
            if(Session["Role"].ToString() != "User")
            {
                Response.Redirect("~/Views/Home.aspx");
            }
            string email = EmailTxt.Text;
            string emailLama = Session["Email"].ToString();
            string password = Session["Password"].ToString();
            string username = UsernameTxt.Text;
            string gender = GenderLists.Text;
            string updatePass = PasswordTxt.Text;

            int id = Convert.ToInt32(Session["ID"]);
            List<string> msgs = UserController.UpdateMember(id,email, password, username, gender,updatePass,emailLama);
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
            }
            else
            {
                Response.Redirect("~/Views/Home.aspx");
            }
        }
    }
}