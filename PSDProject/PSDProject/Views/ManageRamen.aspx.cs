using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using PSDProject.Controller;
namespace PSDProject.Views
{
    public partial class ManageRamen : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if(Session["Role"] == null || Session["Role"].ToString() == "User")
            {
                Response.Redirect("~/Views/Home.aspx");
            }
            if (!IsPostBack)
            {
                GridViewRamen.DataSource = RamenController.getRamenList();
                GridViewRamen.DataBind();
            }
        }

        protected void GridViewRamen_RowDeleting(object sender, GridViewDeleteEventArgs e)
        {
            GridViewRow row = GridViewRamen.Rows[e.RowIndex];
            String id = row.Cells[1].Text.ToString();

            RamenController.DeleteRamen(id);
            Response.Redirect("~/Views/ManageRamen.aspx");
            
        }

        protected void GridViewRamen_RowEditing(object sender, GridViewEditEventArgs e)
        {
            GridViewRow row = GridViewRamen.Rows[e.NewEditIndex];
            String id = row.Cells[1].Text.ToString();
            Response.Redirect("~/Views/UpdateRamen.aspx?id=" + id);
        }
    }
}