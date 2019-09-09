<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="LineBot.aspx.cs" Inherits="Learning.Pages.LineBot" Async="true" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            BoardCast
            <asp:TextBox ID="txtMessage" runat="server" Text="msg"></asp:TextBox>
            <asp:Button ID="btnSend" runat="server" Text="submit" OnClick="btnSend_Click"/>
        </div>
    </form>
</body>
</html>
