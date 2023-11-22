using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using PSDProject.Controller;
namespace PSDProject.Views
{
    public partial class History : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["Role"] == null || Session["Role"].ToString() == "Staff")
            {
                Response.Redirect("~/Views/Home.aspx");
            }
            if (!IsPostBack)
            {
                if(Session["Role"].ToString() == "User")
                {
                    int CustomerId = Convert.ToInt32(Session["Id"].ToString());
                    GridViewHistory.DataSource = TransactionController.getTransactionHeader(CustomerId);
                    GridViewHistory.DataBind();
                }else if (Session["Role"].ToString() == "Admin")
                {
                    GridViewHistory.DataSource = TransactionController.getAllTransactionHeader();
                    GridViewHistory.DataBind();
                }
            }
        }

        protected void GridViewHistory_RowEditing(object sender, GridViewEditEventArgs e)
        {
            GridViewRow row = GridViewHistory.Rows[e.NewEditIndex];
            String id = row.Cells[1].Text.ToString();
            Response.Redirect("~/Views/TransactionDetail.aspx?id=" + id);
        }
    }
}