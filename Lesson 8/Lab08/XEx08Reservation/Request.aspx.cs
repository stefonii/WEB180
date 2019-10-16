using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace XEx08Reservation
{
    public partial class Request : System.Web.UI.Page
    {
        private string currentDate = DateTime.Today.ToShortDateString();
        private string currentYear = DateTime.Today.Year.ToString();
        

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                // set copyright year no matter what
                lblYear.Text = currentYear;

                // display saved reservation data if there is any
                if (Session["Reservation"] != null)
                {
                    DisplayReservation();
                }
                else  {
                    // otherwise, set default values
                    txtArrivalDate.Text = currentDate;
                    rdoKing.Checked = true;
                }   
            }
        }

        private void DisplayReservation()
        {
            Reservation reservation = (Reservation)Session["Reservation"];

            txtArrivalDate.Text = reservation.ArrivalDate.ToShortDateString();
            txtDepartureDate.Text = reservation.DepartureDate.ToShortDateString();
            ddlNoOfPeople.SelectedValue = reservation.NoOfPeople.ToString();

            if (reservation.BedType == "King")
                rdoKing.Checked = true;
            else if (reservation.BedType == "Two Queens")
                rdoDouble.Checked = true;
            else
                rdoSingle.Checked = true;

            txtSpecialRequests.Text = reservation.SpecialRequests;
            txtFirstName.Text = reservation.FirstName;
            txtLastName.Text = reservation.LastName;
            txtEmail.Text = reservation.Email;
            txtPhone.Text = reservation.Phone;
            ddlPreferredMethod.SelectedValue = reservation.PreferredMethod;
        }

        protected void btnClear_Click(object sender, EventArgs e)
        {
            txtArrivalDate.Text = currentDate;
            txtDepartureDate.Text = "";
            ddlNoOfPeople.SelectedIndex = -1;
            rdoKing.Checked = true;
            rdoDouble.Checked = false;
            rdoSingle.Checked = false;
            txtSpecialRequests.Text = "";
            txtFirstName.Text = "";
            txtLastName.Text = "";
            txtEmail.Text = "";
            txtPhone.Text = "";
            ddlPreferredMethod.SelectedIndex = 0;
            lblMessage.Text = "";
        }

        protected void btnSubmit_Click(object sender, EventArgs e)
        {
            // Initialize a new Reservation object and set it's properties based on the values the user entered on the form. 
            Reservation r = new Reservation();
            r.ArrivalDate = Convert.ToDateTime(txtArrivalDate.Text);
            r.DepartureDate = Convert.ToDateTime(txtDepartureDate.Text);
            r.NoOfDays = (r.DepartureDate - r.ArrivalDate).Days;
            r.NoOfPeople = Convert.ToInt32(ddlNoOfPeople.Text);
            if (rdoKing.Checked) r.BedType = "King";
            if (rdoDouble.Checked) r.BedType = "Two Queens";
            if (rdoSingle.Checked) r.BedType = "One Queen";
            r.SpecialRequests = txtSpecialRequests.Text;
            r.FirstName = txtFirstName.Text;
            r.LastName = txtLastName.Text;
            r.Email = txtEmail.Text;
            r.Phone = txtPhone.Text;
            r.PreferredMethod = ddlPreferredMethod.SelectedItem.Text;

            // Save the Reservation object in session state.
            Session["Reservation"] = r;

            // Redirect to the Confirmation page. 
            Response.Redirect("Confirm.aspx");
        }
    }
}