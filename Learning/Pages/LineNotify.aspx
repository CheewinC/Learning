<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="LineNotify.aspx.cs" Inherits="Learning.Pages.LineNotify" Async="true"%>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:TextBox ID="txtMessage" runat="server" Text="Message"></asp:TextBox>
            <asp:Button ID="btnSend" runat="server" Text="Send Message" OnClick="btnSend_Click"/>
        </div>
    </form>
</body>
</html>
