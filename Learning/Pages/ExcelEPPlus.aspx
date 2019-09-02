<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="ExcelEPPlus.aspx.cs" Inherits="Learning.Pages.ExcelEPPlus" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <asp:ScriptManager ID="ScriptManager1" runat="server"></asp:ScriptManager>
        <asp:UpdatePanel runat="server">
            <ContentTemplate>
                <div>
                    <asp:FileUpload runat="server" ID="fuExcel"></asp:FileUpload>
                    <asp:CheckBox ID="cbFristRowIsColumnName" runat="server" Checked="true" Text="แถวแรกเป็นชื่อ Column"/>
                    <asp:Button ID="btnImport" runat="server" Text="ImportByEPPlus" OnClick="btnImport_Click" ToolTip="available for .xlsx"/>
                    <asp:Button ID="btnImportOledb" runat="server" Text="ImportByOledb" OnClick="btnImportOledb_Click" />
                    <br />
                    <asp:GridView ID="gvTree" runat="server"></asp:GridView>
                </div>
            </ContentTemplate>
            <Triggers>
                <asp:PostBackTrigger ControlID="btnImport" />
                <asp:PostBackTrigger ControlID="btnImportOledb" />
            </Triggers>
        </asp:UpdatePanel>
    </form>
    
</body>
</html>

