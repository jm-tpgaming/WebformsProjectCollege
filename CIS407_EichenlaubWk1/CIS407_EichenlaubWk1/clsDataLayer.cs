// Week 3 namespace refrences Added to the project.
using System.Data.OleDb;
using System.Net;
using System.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CIS407_EichenlaubWk1
{
    public class clsDataLayer
    {

        //Start of Week 6 additions

        // This function verifies a user in the tblUser table
        public static dsUser VerifyUser(string Database, string UserName, string UserPassword)
        {
            // Here we set the variables for our user dataset
            dsUser DS;
            OleDbConnection sqlConn;
            OleDbDataAdapter sqlDA;
            // Starting a new connection to the dataset
            sqlConn = new OleDbConnection("PROVIDER=Microsoft.ACE.OLEDB.12.0;" +
            "Data Source=" + Database);
            // Find out the user's security level
            sqlDA = new OleDbDataAdapter("Select SecurityLevel from tblUserLogin " +
            "where UserName like '" + UserName + "' " +
            "and UserPassword like '" + UserPassword + "'", sqlConn);
            // Start a new instance of the user in the dataset
            DS = new dsUser();
            // Adds the user's info to the db table
            sqlDA.Fill(DS.tblUserLogin);
            // returns the dsUser dataset info
            return DS;
        }

        public static void SaveUser(string Database, string UserName, string Password, string SecurityLevel)
        {
            // Here we make a new connection to the database
            OleDbConnection conn = new OleDbConnection("PROVIDER=Microsoft.ACE.OLEDB.12.0;" +
            "Data Source=" + Database);
            conn.Open();
            OleDbCommand command = conn.CreateCommand();
            string strSQL;
            strSQL = "Insert into tblUserLogin (Username, UserPassword, SecurityLevel) values ('" +
            UserName + "', '" + Password + "', '" + SecurityLevel + "')";
            command.CommandType = CommandType.Text;
            command.CommandText = strSQL;
            command.ExecuteNonQuery();
            conn.Close();
        }

        // End of Week 6 additions

        public static dsPersonnel GetPersonnel(string Database, string strSearch )
        {
            // These are the variables set for the database
            dsPersonnel DS;
            OleDbConnection sqlConn;
            OleDbDataAdapter sqlDA;
            // Here we start a new connection to the database
            sqlConn = new OleDbConnection("PROVIDER=Microsoft.ACE.OLEDB.12.0;" + "Data Source=" + Database);
            // Starting a new instance for the BD adapter
            if (strSearch == null || strSearch.Trim() == "")
            {
                sqlDA = new OleDbDataAdapter("select * from tblPersonnel", sqlConn);
            }
            else
            {
                sqlDA = new OleDbDataAdapter("select * from tblPersonnel where LastName = '" + strSearch + "'", sqlConn);
            }
            // A new instance to track user activity 
            DS = new dsPersonnel();
            // Add your comments here
            sqlDA.Fill(DS.tblPersonnel);
            // Add your comments here
            return DS;
        }

        // Here is the added functions from Week 4's iLab
        // This function saves the personnel data
        public static bool SavePersonnel(string Database, string FirstName, string LastName,
        string PayRate, string StartDate, string EndDate)
        {
            bool recordSaved;
            // week 5 addition. This assigns our DB a variable set to NULL by default. 
            OleDbTransaction myTransaction = null;
            //

            try
            {
                // Here we're connecting to the database
                OleDbConnection conn = new OleDbConnection("PROVIDER=Microsoft.ACE.OLEDB.12.0;" +
                "Data Source=" + Database);
                conn.Open();
                OleDbCommand command = conn.CreateCommand();
                string strSQL;

                // week 5 addition. Here we set the connection for the DB. 
                myTransaction = conn.BeginTransaction();
                command.Transaction = myTransaction;
                //

                // The input data gets listed here
                strSQL = "Insert into tblPersonnel " +
        "(FirstName, LastName) values ('" +
        FirstName + "', '" + LastName + "')";
                // Add your comments here
                command.CommandType = CommandType.Text;
                command.CommandText = strSQL;
                // Add your comments here
                command.ExecuteNonQuery();
                // Add your comments here
                strSQL = "Update tblPersonnel " +
                "Set PayRate=" + PayRate + ", " +
                "StartDate='" + StartDate + "', " +
                "EndDate='" + EndDate + "' " +
                "Where ID=(Select Max(ID) From tblPersonnel)";
                // Add your comments here
                command.CommandType = CommandType.Text;
                command.CommandText = strSQL;
                // Add your comments here
                command.ExecuteNonQuery();

                // week 5 addition. This commits the DB transaction.
                myTransaction.Commit();
                //

                // Add your comments here
                conn.Close();
                recordSaved = true;
            }
            catch (Exception ex)
            {
                // week 5 addition. This will rollback to previous if the data doesn't save correctly. 
                myTransaction.Rollback();
                //

                recordSaved = false;
            }
            return recordSaved;
        }

        // This function gets the user activity from the tblUserActivity
        public static dsUserActivity GetUserActivity(string Database)
        {
            // These are the variables set for the database
            dsUserActivity DS;
            OleDbConnection sqlConn;
            OleDbDataAdapter sqlDA;
            // Here we start a new connection to the database
            sqlConn = new OleDbConnection("PROVIDER=Microsoft.ACE.OLEDB.12.0;" + "Data Source=" + Database);
            // Starting a new instance for the BD adapter
            sqlDA = new OleDbDataAdapter("select * from tblUserActivity", sqlConn);
            // A new instance to track user activity 
            DS = new dsUserActivity();
            // Add your comments here
            sqlDA.Fill(DS.tblUserActivity);
            // Add your comments here
            return DS;
        }

        // This function saves the user activity
        public static void SaveUserActivity(string Database, string FormAccessed)
        {
            // Here we make a new connection to the database
            OleDbConnection conn = new OleDbConnection("PROVIDER=Microsoft.ACE.OLEDB.12.0;" +
            "Data Source=" + Database);
            conn.Open();
            OleDbCommand command = conn.CreateCommand();
            string strSQL;
            strSQL = "Insert into tblUserActivity (UserIP, FormAccessed) values ('" +
            GetIP4Address() + "', '" + FormAccessed + "')";
            command.CommandType = CommandType.Text;
            command.CommandText = strSQL;
            command.ExecuteNonQuery();
            conn.Close();
        }

        // This function gets the IP Address
        public static string GetIP4Address()
        {
            string IP4Address = string.Empty;
            foreach (IPAddress IPA in
            Dns.GetHostAddresses(HttpContext.Current.Request.UserHostAddress))
            {
                if (IPA.AddressFamily.ToString() == "InterNetwork")
                {
                    IP4Address = IPA.ToString();
                    break;
                }
            }
            if (IP4Address != string.Empty)
            {
                return IP4Address;
            }
            foreach (IPAddress IPA in Dns.GetHostAddresses(Dns.GetHostName()))
            {
                if (IPA.AddressFamily.ToString() == "InterNetwork")
                {
                    IP4Address = IPA.ToString();
                    break;
                }
            }
            return IP4Address;
        } //End of week 3 iLab

        public clsDataLayer()
        {
            //
            // Add the constructor logic in here
            //
        }
      
    }
}