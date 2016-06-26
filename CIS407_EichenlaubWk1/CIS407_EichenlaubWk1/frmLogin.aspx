<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="frmLogin.aspx.cs" Inherits="CIS407_EichenlaubWk1.frmLogin" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .auto-style1 {
            text-align: center;
        }
        #login
        {
            width: 460px;
            margin: 0 auto;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
    <div class="auto-style1"">
    
        <div>
&nbsp;<asp:Image ID="Image1" runat="server" ImageUrl="~/images/CIS407A_iLab_ACITLogo.jpg" />
            <br />
            <br />
            <div id="login">
            <asp:Login ID="Login1" runat="server" TitleText="Please enter your UserName and Password in order to log in to the system." OnAuthenticate="Login1_Authenticate" DestinationPageUrl="~/frmMain.aspx" >
            </asp:Login>
            </div>
            <br />
        
    </div>
    </div>
    </form>
</body>
</html>
