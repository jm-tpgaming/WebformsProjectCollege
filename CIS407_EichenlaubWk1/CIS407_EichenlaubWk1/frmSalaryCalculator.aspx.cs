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
    public partial class frmSalaryCalculator : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnCalculateSalary_Click(object sender, EventArgs e)
        {
            // Here I set the variables for the on click event

            double annualHours = 0;
            double payRate = 0;
            double income = 0;


            // Now we collect the data so we can output the results
            annualHours = Double.Parse(txtAnnualHours.Text);
            payRate = Double.Parse(txtPayRate.Text);
            income = annualHours * payRate;


            //And here's the output
            lblAnnualSalary.Text = "Annual Salary: " + income.ToString("C");   
        }
    }
}