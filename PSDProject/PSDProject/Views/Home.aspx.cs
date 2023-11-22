using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using PSDProject.Controller;
namespace PSDProject.Views
{
    public partial class Home : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            
            if (!IsPostBack)
            {
                if(Session["Role"] != null)
                {
                    string role = Session["Role"].ToString();
                    if (role.Equals("Staff"))
                    {
                        UserTable.Text = "List User";
                        GridViewHome.DataSource = UserController.getUserListByRole(3);
                        GridViewHome.DataBind();
                    }
                    else if (role.Equals("Admin"))
                    {
                        UserTable.Text = "List Staff";
                        GridViewHome.DataSource = UserController.getUserListByRole(2);
                        GridViewHome.DataBind();
                    }
                }
            }
            if(Session["Role"] == null)
            {
                
            }
            else
            {
                CurrentUser.Text = Session["Username"].ToString();
                CurrentRole.Text = (Session["Role"].ToString());
                
            }
        }

        protected void GridViewHome_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}