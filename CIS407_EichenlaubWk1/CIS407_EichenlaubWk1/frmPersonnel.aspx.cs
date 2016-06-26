using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace CIS407_EichenlaubWk1
{
    public partial class frmPersonnel : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            // This checks to see if the session is an admin session
            if (Session["SecurityLevel"] == "A")
            {
                btnSubmit.Visible = true;
                // If it is an admin session then the submit button will be visable
            }
            else
            {
                btnSubmit.Visible = false;
            }
        }

        protected void btnSubmit_Click(object sender, EventArgs e)
        {
            bool isValid = true;

            lblError.Text = "";

            txtFirstName.BackColor = System.Drawing.Color.White;
            txtLastName.BackColor = System.Drawing.Color.White;
            txtPayRate.BackColor = System.Drawing.Color.White;
            txtStartDate.BackColor = System.Drawing.Color.White;
            txtEndDate.BackColor = System.Drawing.Color.White;

            if (txtFirstName.Text.Trim() == "")
            {
                isValid = false;
                txtFirstName.BackColor = System.Drawing.Color.Yellow;
                lblError.Text = lblError.Text + "First Name is required. ";
            }

            if (txtLastName.Text.Trim() == "")
            {
                isValid = false;
                txtLastName.BackColor = System.Drawing.Color.Yellow;
                lblError.Text = lblError.Text + "Last Name is required. ";
            }

            if (txtPayRate.Text.Trim() == "")
            {
                isValid = false;
                txtPayRate.BackColor = System.Drawing.Color.Yellow;
                lblError.Text = lblError.Text + "Please enter a valid pay rate. ";
            }

            if (txtStartDate.Text.Trim() == "")
            {
                isValid = false;
                txtStartDate.BackColor = System.Drawing.Color.Yellow;
                lblError.Text = lblError.Text + "Please enter a valid start date. ";
            }

            if (txtEndDate.Text.Trim() == "")
            {
                isValid = false;
                txtEndDate.BackColor = System.Drawing.Color.Yellow;
                lblError.Text = lblError.Text + "Please enter a valid end date. ";
            }

            DateTime dtStart = DateTime.Parse(txtStartDate.Text);
            DateTime dtEnd = DateTime.Parse(txtEndDate.Text);

            int result = DateTime.Compare(dtStart, dtEnd);

            if(result >= 0 )
            {
                isValid = false;
                txtStartDate.BackColor = System.Drawing.Color.Yellow;
                txtEndDate.BackColor = System.Drawing.Color.Yellow;
                lblError.Text = lblError.Text + "Start Date must be less than End Date. ";
            }

            if (isValid)
            {
                Session["txtFirstName"] = txtFirstName.Text;
                Session["txtLastName"] = txtLastName.Text;
                Session["txtPayRate"] = txtPayRate.Text;
                Session["txtStartDate"] = txtStartDate.Text;
                Session["txtEndDate"] = txtEndDate.Text;

                // This will redirect the session 
                Response.Redirect("frmPersonnelVerified.aspx");
            }
        }
    }
}