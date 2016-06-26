using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
// week 7 adds the ability to send SMTP
using System.Net.Mail;

namespace CIS407_EichenlaubWk1
{
    public class clsBusinessLayer
    {
        //This is the week 7 addition.

        

//**** Add the following code inside the body of public class clsBusinessLayer ****
public static bool SendEmail(string Sender, string Recipient, string bcc, string cc,
string Subject, string Body)
    {
        try
        {
            // Here we create a new MailMessage instance
            MailMessage MyMailMessage = new MailMessage();
            // Set the sender info
            MyMailMessage.From = new MailAddress(Sender);
            // Who the message is being sent to 
            MyMailMessage.To.Add(new MailAddress(Recipient));
            // Blind carbon copy, only the sender sees
            if (bcc != null && bcc != string.Empty)
            {
                // Adds the BCC email
                MyMailMessage.Bcc.Add(new MailAddress(bcc));
            }
            // Carbon Copy, sender & recipient can see
            if (cc != null && cc != string.Empty)
            {
                // Adds CC address
                MyMailMessage.CC.Add(new MailAddress(cc));
            }
            // Subject Line
            MyMailMessage.Subject = Subject;
            // Message Body
            MyMailMessage.Body = Body;
            // Marks message as an html element
            MyMailMessage.IsBodyHtml = true;
            // Sets the mailing priority to normal
            MyMailMessage.Priority = MailPriority.Normal;
            // uses your local machine as the mailer client
            SmtpClient MySmtpClient = new SmtpClient("localhost");
            //SMTP Port = 25;
            //Generic IP host = "127.0.0.1";
            // Sends the message 
            MySmtpClient.Send(MyMailMessage);
            // Message sent successfully
            return true;
        }
        catch (Exception ex)
        {
            // Unseccessful message
            return false;
        }
    }


    // End of the week 7 code.
}
}