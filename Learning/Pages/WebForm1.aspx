<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="Learning.Pages.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        /*Now the CSS*/
        * {
            margin: 0;
            padding: 0;
        }

        .tree ul {
            padding-top: 20px;
            position: relative;
            transition: all 0.5s;
            -webkit-transition: all 0.5s;
            -moz-transition: all 0.5s;
        }

        .tree td {
            float: left;
            text-align: center;
            list-style-type: none;
            position: relative;
            padding: 20px 5px 0 5px;
            transition: all 0.5s;
            -webkit-transition: all 0.5s;
            -moz-transition: all 0.5s;
        }

            /*We will use ::before and ::after to draw the connectors*/

            .tree td::before, .tree td::after {
                content: '';
                position: absolute;
                top: 0;
                right: 50%;
                border-top: 1px solid #ccc;
                width: 50%;
                height: 20px;
            }

            .tree td::after {
                right: auto;
                left: 50%;
                border-left: 1px solid #ccc;
            }

            /*We need to remove left-right connectors from elements without 
any sibtdngs*/
            .tree td:only-child::after, .tree td:only-child::before {
                display: none;
            }

            /*Remove space from the top of single children*/
            .tree td:only-child {
                padding-top: 0;
            }

            /*Remove left connector from first child and 
right connector from last child*/
            .tree td:first-child::before, .tree td:last-child::after {
                border: 0 none;
            }
            /*Adding back the vertical connector to the last nodes*/
            .tree td:last-child::before {
                border-right: 1px solid #ccc;
                border-radius: 0 5px 0 0;
                -webkit-border-radius: 0 5px 0 0;
                -moz-border-radius: 0 5px 0 0;
            }

            .tree td:first-child::after {
                border-radius: 5px 0 0 0;
                -webkit-border-radius: 5px 0 0 0;
                -moz-border-radius: 5px 0 0 0;
            }

        /*Time to add downward connectors from parents*/
        .tree tr tr::before {
            content: '';
            position: absolute;
            top: 0;
            left: 50%;
            border-left: 1px solid #ccc;
            width: 0;
            height: 20px;
        }

        .tree td a {
            border: 1px solid #ccc;
            padding: 5px 10px;
            text-decoration: none;
            color: #666;
            font-family: arial, verdana, tahoma;
            font-size: 11px;
            display: inline-block;
            border-radius: 5px;
            -webkit-border-radius: 5px;
            -moz-border-radius: 5px;
            transition: all 0.5s;
            -webkit-transition: all 0.5s;
            -moz-transition: all 0.5s;
        }

            /*Time for some hover effects*/
            /*We will apply the hover effect the the lineage of the element also*/
            .tree td a:hover, .tree td a:hover + tr td a {
                background: #c8e4f8;
                color: #000;
                border: 1px solid #94a0b4;
            }
                /*Connector styles on hover*/
                .tree td a:hover + tr td::after,
                .tree td a:hover + tr td::before,
                .tree td a:hover + tr::before,
                .tree td a:hover + tr tr::before {
                    border-color: #94a0b4;
                }

        /*Thats all. I hope you enjoyed it.
Thanks :)*/
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:Literal ID="ltrTree" runat="server"></asp:Literal>
            <button onclick="tt()" id="a">aa</button>
            <asp:Button ID="Button1" runat="server" Text="Button" OnClick="Button1_Click" />
        </div>
        <hr />
        <div>
            <asp:TreeView ID="tvTree" runat="server" CssClass="tree"  OnSelectedNodeChanged="tvTree_SelectedNodeChanged">
            </asp:TreeView>
            <asp:TextBox ID="txtSelectedNode" runat="server"></asp:TextBox>
        </div>
        <script src="../Scripts/jquery-3.0.0.slim.min.js"></script>
        <script src="../Scripts/popper.min.js"></script>
        <script>
            function tt() {
                $("#Button1").click();
            }
        </script>
    </form>
</body>
</html>
