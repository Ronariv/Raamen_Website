using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using PSDProject.Controller;
namespace PSDProject.Views
{
    public partial class InsertRamen : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if(Session["Role"] == null || Session["Role"].ToString() == "User")
            {
                Response.Redirect("~/Views/Home.aspx");

            }
            if (!IsPostBack)
            {
                MeatList.DataSource = RamenController.getMeatList();
                MeatList.DataBind();
                MeatList.DataTextField = "Name";
                MeatList.DataValueField = "Id";
                MeatList.DataBind();
            }
        }

        protected void InsertBtn_Click(object sender, EventArgs e)
        {
            string name = NameBox.Text;
            int meat = Convert.ToInt32(MeatList.SelectedValue);
            string broth = BrothBox.Text;
            int price = Convert.ToInt32(PriceBox.Text);

            List<string> msgs = RamenController.InsertRamen(name, meat, broth, price);
            if (msgs != null)
            {
                if (msgs[0] != "")
                {
                    NameLbl.Visible = true;
                    NameLbl.Text = msgs[0];

                }
                if (msgs[1] != "")
                {
                    MeatLbl.Visible = true;
                    MeatLbl.Text = msgs[1];
                }
                if (msgs[2] != "")
                {

                    BrothLbl.Visible = true;
                    BrothLbl.Text = msgs[2];

                }
                if (msgs[3] != "")
                {

                    PriceLbl.Visible = true;
                    PriceLbl.Text = msgs[3];

                }
            }
            else
            {
                Response.Redirect("~/Views/ManageRamen.aspx");
            }
        }
    }
    
}