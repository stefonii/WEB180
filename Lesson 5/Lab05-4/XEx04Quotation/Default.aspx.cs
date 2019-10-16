using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Coding0504    
{
    public partial class Default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            UnobtrusiveValidationMode = UnobtrusiveValidationMode.None;
        }

        protected void btnCalculate_Click(object sender, EventArgs e)
        {
            if (IsValid)
            {
                decimal salesPrice = Convert.ToDecimal(txtSalesPrice.Text);
                decimal discountPercent = Convert.ToDecimal(txtDiscountPercent.Text) / 100;

                decimal discountAmount = salesPrice * discountPercent;
                decimal totalPrice = salesPrice - discountAmount;

                lblDiscountAmount.Text = discountAmount.ToString("c");
                lblTotalPrice.Text = totalPrice.ToString("c");

                // Save the sales price, discount amount, and total price in session state.
                Session["SalesPrice"] = txtSalesPrice.Text;
                Session["DiscountAmount"] = lblDiscountAmount.Text;
                Session["TotalPrice"] = lblTotalPrice.Text;
            }
        }

        protected void btnConfirm_Click(object sender, EventArgs e)
        {
            // Test whether the value for the sales price in session state is null. 
            if (Session["SalesPrice"] != null)
            {
                // Redirect to the Confirmation page.
                Response.Redirect("Confirm.aspx");
            } else
                lblMessage.Text = "Click the Calculate button before you confirm.";     
        }
    }
}