<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="frmMain.aspx.cs" Inherits="CIS407_EichenlaubWk1.frmMain" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        <asp:Image ID="Image1" runat="server" ImageUrl="~/images/CIS407A_iLab_ACITLogo.jpg" />
        <br />
        <asp:Panel ID="Panel1" runat="server" Height="840px" Width="660px">
            <asp:ImageButton ID="imgbtnCalculator" runat="server" Height="150px" ImageUrl="~/images/calculator-01.jpg" PostBackUrl="~/frmSalaryCalculator.aspx" Width="150px" />
            <asp:LinkButton ID="linkbtnCalculator" runat="server" PostBackUrl="~/frmSalaryCalculator.aspx">Annual Salary Calculator</asp:LinkButton>
            &nbsp;&nbsp;&nbsp;&nbsp;
            <asp:ImageButton ID="imgbtnNewEmployee" runat="server" Height="150px" ImageUrl="~/images/staff.jpg" PostBackUrl="~/frmPersonnel.aspx" Width="150px" />
&nbsp;
            <asp:LinkButton ID="linkbtnNewEmployee" runat="server" PostBackUrl="~/frmPersonnel.aspx">Add New Employee</asp:LinkButton>
            <br />
            <br />
            <br />
            &nbsp;&nbsp; &nbsp;<br />&nbsp;<br /><asp:ImageButton ID="imgbtnViewPersonnel" runat="server" Height="150px" ImageUrl="~/images/customer-support.jpg" PostBackUrl="~/frmViewPersonnel.aspx" Width="150px" />
            &nbsp;<asp:HyperLink ID="linkbtnViewPersonnel" runat="server" NavigateUrl="~/frmViewPersonnel.aspx">View Personnel</asp:HyperLink>
            &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; <asp:ImageButton ID="imgbtnViewUserActivity" runat="server" Height="150px" ImageUrl="~/images/Valley-Community-Association-Forms-and-documents.jpg" PostBackUrl="~/frmUserActivity.aspx" Width="150px" />
            &nbsp;
            <asp:HyperLink ID="linkbtnViewUserActivity" runat="server" NavigateUrl="~/frmUserActivity.aspx">User Activity</asp:HyperLink>
            <br />
            <br />
            &nbsp;&nbsp;<br />&nbsp;<br /><br /><asp:ImageButton ID="imgbtnSearch" runat="server" Height="150px" ImageUrl="~/images/magnifying-glass-clipart-transparent-background-9i4LRa6iE.jpeg" PostBackUrl="~/frmSearchPersonnel.aspx" Width="150px" />
            &nbsp;<asp:HyperLink ID="linkbtnSearch" runat="server" NavigateUrl="~/frmSearchPersonnel.aspx">Search Personnel</asp:HyperLink>
            &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:ImageButton ID="imgbtnEditEmployees" runat="server" Height="150px" ImageUrl="~/images/PersAndSvcs_330pxWide.jpg" PostBackUrl="~/frmEditPersonnel.aspx" Width="150px" />
            &nbsp;
            <asp:HyperLink ID="linkbtnEditEmployees" runat="server" NavigateUrl="~/frmEditPersonnel.aspx">Edit Employees</asp:HyperLink>
            <br />
            <br />
            <br />
            <asp:ImageButton ID="imgbtnEditUsers" runat="server" Height="150px" ImageUrl="~/images/users_edit.png" PostBackUrl="~/frmManageUsers.aspx" Width="150px" />
            <asp:HyperLink ID="linkbtnEditUsers" runat="server" NavigateUrl="~/frmManageUsers.aspx">Manage Users</asp:HyperLink>
        </asp:Panel>
    
    </div>
    </form>
</body>
</html>
