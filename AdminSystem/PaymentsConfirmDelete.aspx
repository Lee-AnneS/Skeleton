<%@ Page Language="C#" AutoEventWireup="true" CodeFile="PaymentsConfirmDelete.aspx.cs" Inherits="_1_ConfirmDelete" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div style="height: 346px">
            <asp:Label ID="Label1" runat="server" style="z-index: 1; left: 169px; top: 146px; position: absolute; width: 293px" Text="Are you sure you want to delete this record?"></asp:Label>
            <asp:Button ID="btnYes" runat="server" OnClick="btnYes_Click" style="z-index: 1; left: 209px; top: 185px; position: absolute; width: 62px" Text="Yes" BorderColor="#CC3300" BorderStyle="Double" ForeColor="Red" />
            <asp:Button ID="btnNo" runat="server" height="26px" style="z-index: 1; left: 303px; top: 185px; position: absolute; width: 50px" Text="No" OnClick="btnNo_Click" />
        </div>
    </form>
</body>
</html>
