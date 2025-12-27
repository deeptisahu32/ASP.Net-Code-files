using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Electricity_Prj.Models;
using Electricity_Prj.Services;


namespace Electricity_Prj
{
    public partial class AddBill : System.Web.UI.Page
    {

        private ElectricityBoard board = new ElectricityBoard();
        private Billvalidator validator = new Billvalidator();

        protected void Page_Load(object sender, EventArgs e)
        {

            if (Session["Admin"] == null)
            {
                lblAuth.Text = "Please login as Admin.";
                Response.Redirect("~/Login.aspx");
                return;
            }

            if (!IsPostBack)
            {
                ViewState["TargetCount"] = 0;
                ViewState["AddedCount"] = 0;
            }

        }


        private bool TryParseCount(out int count)
        {
            count = 0;
            return int.TryParse(txtCount.Text, out count) && count > 0;
        }

        protected void btnAddOne_Click(object sender, EventArgs e)
        {

            if (!int.TryParse(txtUnits.Text, out int units))
            {
                lblUnitsError.Text = "Enter a valid integer for units.";
                return;
            }

            string unitsErr = validator.ValidateUnitsConsumed(units);
            if (unitsErr != null)
            {
                // Show error and do not proceed until user enters valid units
                lblUnitsError.Text = unitsErr; // "Given units is invalid"
                return;
            }

            lblUnitsError.Text = "";

            var eb = new ElectricityBill
            {
                ConsumerNumber = txtConsumerNumber.Text.Trim(),
                ConsumerName = txtConsumerName.Text.Trim(),
                UnitsConsumed = units
            };


            try
            {
                // Calculate & display per sample format
                board.CalculateBill(eb);

                // Log: EB#### Name Units Bill Amount : X
                litLog.Text += $"<div>{eb.ConsumerNumber} {eb.ConsumerName} {eb.UnitsConsumed} Bill Amount : {eb.BillAmount}</div>";

                // Store to DB
                board.AddBill(eb);
                lblOutput.Text = "Bill added.";


                if (TryParseCount(out int target))
                {

                    ViewState["TargetCount"] = target;
                    int added = (int)ViewState["AddedCount"] + 1;
                    ViewState["AddedCount"] = added;

                    if (added >= target)
                    {
                        lblOutput.Text = $"Added {added} bills (target {target}). You can now retrieve last N bills.";
                    }
                    else
                    {

                        lblOutput.Text = $"Added {added}/{target}. Continue adding...";

                    }

                }


            }
            catch(FormatException ex)
            {

                lblUnitsError.Text = ex.Message; // "Invalid Consumer Number"

            }
            catch(Exception ex)
            {

                lblUnitsError.Text = "Unexpected error: " + ex.Message;

            }

        }

        protected void btnFinish_Click(object sender, EventArgs e)
        {

            if (TryParseCount(out int target))
            {
                int added = (int)ViewState["AddedCount"];
                lblOutput.Text = $"Added {added}/{target}.";
            }
            else
            {
                lblOutput.Text = "Please set a valid target count.";
            }

        }

        protected void btnRetrieve_Click(object sender, EventArgs e)
        {

            if (!int.TryParse(txtLastN.Text, out int n) || n <= 0)
            {
                lblOutput.Text = "Enter a valid positive integer for last N.";
                return;
            }

            List<ElectricityBill> lastN = board.Generate_N_BillDetails(n);
            gvLastN.DataSource = lastN;
            gvLastN.DataBind();

        }
    }
}