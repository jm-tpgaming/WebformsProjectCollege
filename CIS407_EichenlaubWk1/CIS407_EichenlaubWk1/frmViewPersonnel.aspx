<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="frmViewPersonnel.aspx.cs" Inherits="CIS407_EichenlaubWk1.frmViewPersonnel" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        <asp:ImageButton ID="ImageButton1" runat="server" ImageUrl="~/images/CIS407A_iLab_ACITLogo.jpg" PostBackUrl="~/frmMain.aspx" />
        <br />
        <asp:GridView ID="grdViewPersonnel" runat="server">
        </asp:GridView>
    
    </div>
    </form>
</body>
</html>
