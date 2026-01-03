using Electricity_Prj.Models;
using Electricity_Prj.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Electricity_Prj
{
    public partial class RetrieveBill : System.Web.UI.Page
    {

        private readonly ElectricityBoard board = new ElectricityBoard();

        protected void Page_Load(object sender, EventArgs e)
        {

            if (Session["user"] == null)
            {
                Response.Redirect("~/Login.aspx");
                return;
            }

        }

        protected void btnFetch_Click(object sender, EventArgs e)
        {

            lblStatus.Text = string.Empty;

            if (!int.TryParse(txtLastN.Text, out int n) || n <= 0)
            {
                lblStatus.Text = "Please enter a valid positive integer for N.";
                return;
            }

            List<ElectricityBill> list = board.Generate_N_BillDetails(n);
            gvBills.DataSource = list;
            gvBills.DataBind();

        }


        protected void btnRetrieveByCN_Click(object sender, EventArgs e)
        {
            lblStatus.Text = string.Empty;

            var cn = txtConsumerId.Text.Trim().ToUpperInvariant(); 
            if (string.IsNullOrEmpty(cn))
            {
                lblStatus.Text = "Please enter a Consumer Number.";
                gvBills.DataSource = null;
                gvBills.DataBind();
                return;
            }

            try
            {
                var list = board.GetBillsByConsumerNumber(cn);
                gvBills.DataSource = list;
                gvBills.DataBind();

                lblStatus.Text = (list == null || list.Count == 0)
                    ? $"No record found for Consumer Number '{cn}'."
                    : $"Found {list.Count} record(s) for '{cn}'.";
            }
            catch (Exception ex)
            {
                lblStatus.Text = "Unexpected error: " + ex.Message;
            }
        }

    }
}