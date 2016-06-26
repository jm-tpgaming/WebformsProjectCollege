using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace CIS407_EichenlaubWk1
{
    public partial class frmLogin : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Login1_Authenticate(object sender, AuthenticateEventArgs e)
        {
            // This variable is for the user login 
            dsUser dsUserLogin;
            // variable for setting the security level
            string SecurityLevel;
            // Reach out to the DB to verify user login info
            dsUserLogin = clsDataLayer.VerifyUser(Server.MapPath("PayrollSystem_DB.accdb"),
            Login1.UserName, Login1.Password);
            // Checks to see if the user logged in
            if (dsUserLogin.tblUserLogin.Count < 1)
            {
                e.Authenticated = false;

                // Week 7 addition for SMTP Functionality
                // Add your comments here
                // Add your comments here
                if (clsBusinessLayer.SendEmail("admin@acit.com",
                "justin.eichenlaub@gmail.com", "", "", "Login Incorrect",
                "The login failed for UserName: " + Login1.UserName +
                " Password: " + Login1.Password))
                {
                    Login1.FailureText = Login1.FailureText +
                    " Your incorrect login information was sent to receiver@receiverdomain.com";
                }
                //End of week 7 code.
                return;
            }
            // This checks the user's security level against the db
            SecurityLevel = dsUserLogin.tblUserLogin[0].SecurityLevel.ToString();
            // Add your comments here
            switch (SecurityLevel)
            {
                case "A":
                    // this would be an admin-level user
                    e.Authenticated = true;
                    FormsAuthentication.RedirectFromLoginPage(Login1.UserName, false);
                    Session["SecurityLevel"] = "A";
                    break;
                case "U":
                    // this is a user-level user, with less privs
                    e.Authenticated = true;
                    FormsAuthentication.RedirectFromLoginPage(Login1.UserName, false);
                    Session["SecurityLevel"] = "U";
                    break;
                default:
                    e.Authenticated = false;
                    break;
            }
        }
    }
}