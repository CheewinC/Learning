<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="SignalRWithGridview.aspx.cs" Inherits="Learning.Pages.SignalRWithGridview" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        Id:<asp:TextBox ID="txtId" runat="server"></asp:TextBox>
        Name:<asp:TextBox ID="txtName" runat="server"></asp:TextBox>
        Parent<asp:TextBox ID="txtParentId" runat="server"></asp:TextBox>
        <%--<asp:Button ID="btnAdd" runat="server" Text="add" />--%>
        <input id="btnAdd" type="button" value="button" />
        <div>
            <asp:GridView ID="gvTree" runat="server"></asp:GridView>
        </div>
        <script src="../Scripts/jquery-3.4.1.min.js"></script>
        <script src="../Scripts/jquery.signalR-2.4.1.min.js"></script>
        <script src="<%= ResolveUrl("~/signalr/hubs") %>"></script>
        <script>

            $(function () {

                var tree = $.connection.treeHub;
                console.log("connect Hub");

                tree.client.addGridviewrow = function (id, name, parentId) {
                    $('#gvTree tbody tr:first').after('<tr><td>' + id + '</td><td>' + name + '</td><td>' + parentId + '</td></tr>');
                };

                tree.client.displayStatus = function (json) {
                    console.log("displayStatus");
                    console.log(json);
                    $('#gvTree > tbody:last').empty();
                    var obj = jQuery.parseJSON(json);
                    $.each(obj, function (key, val) {
                        var id = val["Id"];
                        var name = val["Name"];
                        var parentId = val["ParentId"];
                        var tr = "<tr>";
                        tr = tr + "<td>" + id + "</td>";
                        tr = tr + "<td>" + name + "</td>";
                        tr = tr + "<td>" + parentId + "</td>";
                        tr = tr + "</tr>";
                        $('#gvTree > tbody:last').append(tr);
                    });
                };

                $.connection.hub.start().done(function () {
                    $('#btnAdd').click(function () {
                        var id = document.getElementById('<%= txtId.ClientID%>').value;
                        var name = document.getElementById('<%= txtName.ClientID%>').value;
                        var parentId = document.getElementById('<%= txtParentId.ClientID%>').value;
                        tree.server.addTreeHub(id, name, parentId);
                    });
                    tree.server.getTreeData();
                    console.log("start Hub");
                });
            })
        </script>
    </form>
</body>
</html>
