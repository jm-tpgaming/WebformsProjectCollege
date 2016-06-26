/* CIS-407A
 * Week 2 Assignment
 * Justin Eichenlaub
 * DeVry University
 * This is the week one assignment that will be built off of
 * for the course final project. */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace CIS407_EichenlaubWk1
{
    public partial class frmPersonnelVerified : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e) //This section of code takes the input data and outputs it to the text box
        {
            txtVerifiedInfo.Text = Session["txtFirstName"] +
                "\n" + Session["txtLastName"] +
                "\n" + Session["txtPayRate"] +
                "\n" + Session["txtStartDate"] +
                "\n" + Session["txtendDate"];
            // End of Week 3 iLab

            // Week 4 iLab addition. This code adds session saving and alerts if the data is saved or not. 
            if (clsDataLayer.SavePersonnel(Server.MapPath("PayrollSystem_DB.accdb"),
            Session["txtFirstName"].ToString(),
            Session["txtLastName"].ToString(),
            Session["txtPayRate"].ToString(),
            Session["txtStartDate"].ToString(),
            Session["txtEndDate"].ToString()))
            {
                txtVerifiedInfo.Text = txtVerifiedInfo.Text +
                "\nThe information was successfully saved!";
            }
            else
            {
                txtVerifiedInfo.Text = txtVerifiedInfo.Text +
                "\nThe information was NOT saved.";
            }
        }
    }
}