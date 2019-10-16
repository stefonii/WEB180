using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Coding0504
{
    public partial class Confirm : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            UnobtrusiveValidationMode = UnobtrusiveValidationMode.None;
            // If the sales price in session state is null, don't display the values on the page. 
            if (Session["SalesPrice"] != null)
                // Get the data from the session state and display it. 
                lblSalesPrice.Text = (string)(Session["SalesPrice"]);
                lblDiscountAmount.Text = (string)(Session["DiscountAmount"]);
                lblTotalPrice.Text = (string)(Session["TotalPrice"]);
        }

        protected void btnSendQuotation_Click(object sender, EventArgs e)
        {
            string name = txtName.Text.ToString();
            string email = txtEmail.Text.ToString();

            // If entries for this form are valid:
            if(IsValid)
            {
                // Display message using data entered by user.
                lblMessage.Text = "Quotation sent to " + name + " at " + email;

                // Set values in session state to null.
                Session["SalesPrice"] = null;
                Session["DiscountAmount"] = null;
                Session["TotalPrice"] = null;
            }
        }
    }
}