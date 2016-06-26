<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="frmManageUsers.aspx.cs" Inherits="CIS407_EichenlaubWk1.frmManageUsers" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .auto-style1 {
            text-align: left;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
    <div class="auto-style1">
    
        <asp:ImageButton ID="ImageButton1" runat="server" ImageUrl="~/images/CIS407A_iLab_ACITLogo.jpg" PostBackUrl="~/frmMain.aspx" />
        

        <br />
        <asp:Label ID="Label1" runat="server" Text="User Name:"></asp:Label>
        <asp:TextBox ID="tbUserName" runat="server" style="margin-left: 25px"></asp:TextBox>
        <br />
        <asp:Label ID="Label2" runat="server" Text="Password:"></asp:Label>
        <asp:TextBox ID="tbPassword" runat="server" style="margin-left: 37px"></asp:TextBox>
        <br />
        <asp:Label ID="Label3" runat="server" Text="Security Level:"></asp:Label>
        <asp:DropDownList ID="ddlSecLvl" runat="server" style="margin-left: 12px">
            <asp:ListItem>A</asp:ListItem>
            <asp:ListItem>U</asp:ListItem>
        </asp:DropDownList>
        <br />
        <asp:Button ID="btnAddUser" runat="server" OnClick="btnAddUser_Click" Text="Add User" />
        

    </div>
    </form>
</body>
</html>
