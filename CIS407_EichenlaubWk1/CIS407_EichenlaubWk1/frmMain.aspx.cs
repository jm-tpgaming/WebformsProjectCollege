using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace CIS407_EichenlaubWk1
{
    public partial class frmMain : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            // Add your comments here
            clsDataLayer.SaveUserActivity(Server.MapPath("PayrollSystem_DB.accdb"), "frmPersonnel");


            // Week 6 Code addition

            // Here we set the initial values for the links and images
            // We'll "activate" some of the links based on the user's security
            // level which we'll obtain after they have logged in.

            linkbtnCalculator.Visible = true;
            imgbtnCalculator.Visible = true;
            linkbtnNewEmployee.Visible = false;
            imgbtnNewEmployee.Visible = false;
            linkbtnViewUserActivity.Visible = false;
            imgbtnViewUserActivity.Visible = false;
            linkbtnViewPersonnel.Visible = true;
            imgbtnViewPersonnel.Visible = true;
            linkbtnSearch.Visible = true;
            imgbtnSearch.Visible = true;
            linkbtnEditEmployees.Visible = false;
            imgbtnEditEmployees.Visible = false;
            linkbtnEditUsers.Visible = false;
            imgbtnEditUsers.Visible = false;


            // If the session is an Admin session then  
            // they will gain access to these additional links 
            if (Session["SecurityLevel"] == "A")
            {
                linkbtnNewEmployee.Visible = true;
                imgbtnNewEmployee.Visible = true;
                linkbtnViewUserActivity.Visible = true;
                imgbtnViewUserActivity.Visible = true;
                linkbtnEditEmployees.Visible = true;
                imgbtnEditEmployees.Visible = true;
                linkbtnEditUsers.Visible = true;
                imgbtnEditUsers.Visible = true;
            }
            //End of Week 6 addition
        }
    }
}