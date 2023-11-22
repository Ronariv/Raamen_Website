using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using PSDProject.Controller;
namespace PSDProject.Views
{
    public partial class TransactionDetail : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["Role"] == null || Session["Role"].ToString() == "Staff")
            {
                Response.Redirect("~/Views/Home.aspx");
            }
            if (!IsPostBack)
            {
                int id = Convert.ToInt32(Request.QueryString["Id"]);
                RepeaterDetail.DataSource = TransactionController.getTrDetail(id);
                RepeaterDetail.DataBind();
            }
        }
    }
}