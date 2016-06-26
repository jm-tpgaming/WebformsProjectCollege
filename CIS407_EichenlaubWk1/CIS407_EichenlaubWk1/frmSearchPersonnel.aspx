<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="frmSearchPersonnel.aspx.cs" Inherits="CIS407_EichenlaubWk1.frmSearchPersonnel" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        <asp:ImageButton ID="ImgBtnMain" runat="server" ImageUrl="~/images/CIS407A_iLab_ACITLogo.jpg" PostBackUrl="~/frmMain.aspx" />
        <br />
        <br />
        <asp:Label ID="LblSearch1" runat="server" Text="Search for employee by last name:"></asp:Label>
&nbsp;<asp:TextBox ID="txtSearch" runat="server"></asp:TextBox>
&nbsp;<asp:Button ID="btnSearch" runat="server" PostBackUrl="~/frmViewPersonnel.aspx" Text="Search" />
    
    </div>
    </form>
</body>
</html>
