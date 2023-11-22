using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using PSDProject.Model;
using PSDProject.Report;
using PSDProject.Controller;
namespace PSDProject.Views
{
    public partial class Report : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if(Session["Role"] == null || Session["Role"].ToString() == "User" || Session["Role"].ToString() == "Staff")
            {
                Response.Redirect("~/Views/Home.aspx");
            }
            CrystalReport1 report = new CrystalReport1();
            CrystalReportViewer1.ReportSource = report;

            int id = Convert.ToInt32(Session["Id"].ToString());
            DataSet1 data = loadData(TransactionController.getTransactionHeaderReport());
            report.SetDataSource(data);
        }

        public DataSet1 loadData(List<Header> transaction)
        {
            DataSet1 data = new DataSet1();
            var headerTbl = data.Header;
            var detailTbl = data.Detail;
            var grandTotalTbl = data.GrandTotal;

            int grandTotal = 0;
            foreach (Header head in transaction)
            {
                var newHeaderRow = headerTbl.NewRow();
                newHeaderRow["Id"] = head.Id;
                newHeaderRow["Customer"] = head.User.Username;

                User staff = UserController.getUser(head.StaffId);
                newHeaderRow["Staff"] = staff.Username;
                newHeaderRow["Date"] = head.Date;
                

                int subtotal = 0;
                
                foreach (Detail detail in head.Details)
                {
                    subtotal += detail.Quantity * detail.Raman.Price;
                    var newDetailRow = detailTbl.NewRow();
                    newDetailRow["HeaderId"] = detail.HeaderId;
                    newDetailRow["RamenId"] = detail.RamenID;
                    newDetailRow["Ramen"] = detail.Raman.Name;
                    newDetailRow["Meat"] = detail.Raman.Meat.Name;
                    newDetailRow["Broth"] = detail.Raman.Broth;
                    newDetailRow["Price"] = "$ " + (detail.Quantity * detail.Raman.Price).ToString();
                    newDetailRow["Quantity"] = detail.Quantity;
                    detailTbl.Rows.Add(newDetailRow);
                }
                newHeaderRow["Subtotal"] = "$ " + subtotal.ToString();
                grandTotal += subtotal;
                headerTbl.Rows.Add(newHeaderRow);
            }

            var newGrandTotalRow = grandTotalTbl.NewRow();
            newGrandTotalRow["GrandTotal"] = "$ " + grandTotal.ToString();
            grandTotalTbl.Rows.Add(newGrandTotalRow);

            return data;
        }
    }
}