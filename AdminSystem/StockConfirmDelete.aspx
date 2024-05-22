<%@ Page Language="C#" AutoEventWireup="true" CodeFile="StockConfirmDelete.aspx.cs" Inherits="_1_ConfirmDelete" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
        </div>
       
        <asp:Label ID="lblDelete" runat="server" style="z-index: 1; left: 10px; top: 34px; position: absolute" Text="Are you sure you want to delete this record?"></asp:Label>
        <asp:Button ID="btnYes" runat="server" style="z-index: 1; left: 56px; top: 91px; position: absolute; width: 56px" Text="Yes" OnClick="btnYes_Click" />
        <asp:Button ID="btnNo" runat="server" style="z-index: 1; left: 155px; top: 91px; position: absolute; width: 56px" Text="No" OnClick="btnNo_Click" />
        
    </form>
</body>
</html>
