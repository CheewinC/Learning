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
            Msg:<asp:TextBox ID="txtMessage" runat="server" Text="msg"></asp:TextBox><br />
            <asp:Button ID="btnSend" runat="server" Text="submit" OnClick="btnSend_Click"/>
            <hr />
            Send push message
            UserId:<asp:TextBox ID="txtUserId" runat="server" Text="msg"></asp:TextBox><br />
            Msg:<asp:TextBox ID="txtMsg" runat="server" Text="msg"></asp:TextBox><br />
            <asp:Button ID="btnSendTo" runat="server" Text="submit" OnClick="btnSendTo_Click"/>
        </div>
    </form>
</body>
</html>
