<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="LineBot.aspx.cs" Inherits="Learning.Pages.LineBot" Async="true" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False">
            <Columns>
                <asp:BoundField DataField="Id" HeaderText="Id" SortExpression="Id" />
                <asp:BoundField DataField="ReplyToken" HeaderText="ReplyToken" SortExpression="ReplyToken" />
                <asp:BoundField DataField="Timestamp" HeaderText="Timestamp" SortExpression="Timestamp" />
                <asp:BoundField DataField="UserId" HeaderText="UserId" SortExpression="UserId" />
                <asp:BoundField DataField="Text" HeaderText="Text" SortExpression="Text" />
                <asp:BoundField DataField="DisplayName" HeaderText="DisplayName" SortExpression="DisplayName" />
                <%--<asp:BoundField DataField="ProfilePicture" HeaderText="ProfilePicture" SortExpression="ProfilePicture" />--%>
                <asp:ImageField DataImageUrlField="ProfilePicture" HeaderText="ProfilePicture" SortExpression="ProfilePicture" ControlStyle-Height="100" ControlStyle-Width="100"/>
                <asp:BoundField DataField="StatusMessage" HeaderText="StatusMessage" SortExpression="StatusMessage" />
                <asp:BoundField DataField="MobileNo" HeaderText="MobileNo" SortExpression="MobileNo" />
                <asp:BoundField DataField="CreateDate" HeaderText="CreateDate" SortExpression="CreateDate" />
                <asp:BoundField DataField="ModifyDate" HeaderText="ModifyDate" SortExpression="ModifyDate" />
            </Columns>
        </asp:GridView>
            Reply Message<br />
            Reply Token:<asp:TextBox ID="txtReplyToken" runat="server" Text="txtReplyToken"></asp:TextBox><br />
            Msg:<asp:TextBox ID="txtMessageReply" runat="server" Text="msg"></asp:TextBox><br />
            <asp:Button ID="btnReply" runat="server" Text="Reply" OnClick="btnReply_Click"/>
        <hr />
        <div>
            BoardCast<br />
            Msg:<asp:TextBox ID="txtMessageBoardCast" runat="server" Text="msg"></asp:TextBox><br />
            <asp:Button ID="btnSend" runat="server" Text="submit" OnClick="btnSend_Click"/>
            <hr />
            Send push message<br />
            UserId:<asp:TextBox ID="txtUserId" runat="server" Text="msg"></asp:TextBox><br />
            Msg:<asp:TextBox ID="txtMessagePush" runat="server" Text="msg"></asp:TextBox><br />
            <asp:Button ID="btnSendTo" runat="server" Text="submit" OnClick="btnSendTo_Click"/>
        </div>
    </form>
</body>
</html>
