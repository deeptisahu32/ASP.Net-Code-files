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
                ViewState["AddedCount"] = 0;
            }

        }



        private bool TryParseCount(out int target)
        {
            target = 0;
            if (int.TryParse(txtCount.Text, out int t) && t > 0)
            {
                target = t;
                return true;
            }
            return false;
        }



        protected void btnAddOne_Click(object sender, EventArgs e)
        {
            // 1) Units parse
            if (!int.TryParse(txtUnits.Text, out int units))
            {
                lblUnitsError.Text = "Enter a valid integer for units.";
                return;
            }

            // 2) Units validation (empty string means NO error)
            string unitsErr = validator.ValidateUnitsConsumed(units);
            if (!string.IsNullOrEmpty(unitsErr))
            {
                lblUnitsError.Text = unitsErr; // "Given units is invalid"
                return;
            }

            lblUnitsError.Text = string.Empty;

            // 3) Prepare model (normalize CN)
            var eb = new ElectricityBill
            {
                ConsumerNumber = txtConsumerNumber.Text.Trim().ToUpperInvariant(), // normalize
                ConsumerName = txtConsumerName.Text.Trim(),
                UnitsConsumed = units
            };

            try
            {
                // Calculate bill
                board.CalculateBill(eb);

                // Store (AddBill includes duplicate pre-check + SQL unique catch)
                board.AddBill(eb);

                

                litLog.Text += $"<div>{eb.ConsumerNumber} {eb.ConsumerName} {eb.UnitsConsumed} " +
                                               $"Bill Amount : {eb.BillAmount:0.##} | Date : {DateTime.Now:dd-MMM-yyyy HH:mm}</div>";

                lblOutput.Text = "Bill added.";

                // 7) Counter logic (safe ViewState reads)
                int target = 0;
                if (TryParseCount(out target))
                {
                    ViewState["TargetCount"] = target;
                    int added = (ViewState["AddedCount"] is int v) ? v : 0;
                    added++;
                    ViewState["AddedCount"] = added;

                    if (added >= target)
                        lblOutput.Text = $"Added {added} bills (target {target}). You can now retrieve last N bills.";
                    else
                        lblOutput.Text = $"Added {added}/{target}. Continue adding...";
                }
            }
            catch (FormatException ex)
            {
                // Invalid Consumer Number (from model property or CalculateBill)
                lblUnitsError.Text = ex.Message; // "Invalid Consumer Number"
            }
            catch (InvalidOperationException ex)
            {
                lblUnitsError.Text = ex.Message;
            }
            catch (Exception ex)
            {
                lblUnitsError.Text = "Unexpected error: " + ex.Message;
            }
        }

        protected void btnFinish_Click(object sender, EventArgs e)
        {


            txtConsumerNumber.Text = "";
            txtConsumerName.Text = "";
            txtUnits.Text = "";
            lblOutput.Text = "Finished adding. Use header links to navigate.";


        }

       
    }
}