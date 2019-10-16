using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace XEx08Reservation
{
    public partial class Confirm : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            lblYear.Text = DateTime.Today.Year.ToString();
            DisplayReservation();
        }

        private void DisplayReservation()
        {
            // Retrieve the Reservation object from session state, store it in a variable, and then
            // get the values from the reservation object and move them to the label controls on the form. 
            Reservation r = (Reservation)Session["Reservation"];
            lblFirstName.Text = r.FirstName;
            lblLastName.Text = r.LastName;
            lblEmail.Text = r.Email;
            lblPhone.Text = r.Phone;
            lblPreferredMethod.Text = r.PreferredMethod;
            lblArrivalDate.Text = r.ArrivalDate.ToShortDateString();
            lblDepartureDate.Text = r.DepartureDate.ToShortDateString();
            lblNoOfDays.Text = r.NoOfDays.ToString();
            lblNoOfPeople.Text = r.NoOfPeople.ToString();
            lblBedType.Text = r.BedType;
            lblSpecialRequests.Text = r.SpecialRequests;
        }

        protected void btnConfirm_Click(object sender, EventArgs e)
        {
            lblMessage.Text = "Thank you for your request. <br /> We will get back to you within 24 hours.";
        }
    }
}