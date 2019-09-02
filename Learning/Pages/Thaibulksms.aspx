<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Thaibulksms.aspx.cs" Inherits="Learning.Pages.Thaibulksms" Async="true" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <asp:TextBox ID="txtUrl" runat="server" Text="Url"></asp:TextBox>
        <asp:TextBox ID="txtUsername" runat="server" Text="Username"></asp:TextBox>
        <asp:TextBox ID="txtPassword" runat="server" Text="Password"></asp:TextBox>
        <asp:TextBox ID="txtTel" runat="server" Text="Tel"></asp:TextBox>
        <asp:TextBox ID="txtMessage" runat="server" Text="Message"></asp:TextBox>
        <asp:Button ID="btnSend" runat="server" Text="Send" OnClick="btnSend_Click"/>
    </form>
</body>
</html>
