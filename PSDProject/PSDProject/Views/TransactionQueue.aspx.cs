using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using PSDProject.Controller;
namespace PSDProject.Views
{
    public partial class TransactionQueue : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if(Session["Role"] == null || Session["Role"].ToString() == "User")
            {
                Response.Redirect("~/Views/Home.aspx");
            }
            if (!IsPostBack)
            {
                GridViewUnhandled.DataSource = TransactionController.getUnhandled();
                GridViewUnhandled.DataBind();
            }
        }

        protected void HandleBtn_Click(object sender, EventArgs e)
        {
            int staffId = Convert.ToInt32(Session["Id"].ToString());
            TransactionController.HandleAll(staffId);
            refresh();
        }

        protected void GridViewUnhandled_RowEditing(object sender, GridViewEditEventArgs e)
        {
            GridViewRow row = GridViewUnhandled.Rows[e.NewEditIndex];
            int id = Convert.ToInt32(row.Cells[1].Text.ToString());
            int staffId = Convert.ToInt32(Session["Id"].ToString());
            TransactionController.handle(id, staffId);
            refresh();
        }

        protected void refresh()
        {
            GridViewUnhandled.DataSource = TransactionController.getUnhandled();
            GridViewUnhandled.DataBind();
        }
    }
}