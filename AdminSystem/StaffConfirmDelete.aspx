<%@ Page Language="C#" AutoEventWireup="true" CodeFile="StaffConfirmDelete.aspx.cs" Inherits="_1_ConfirmDelete" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <br />
            <br />
            <br />
            Are you sure you want to delete this record?<br />
            <br />
            <br />
            <asp:Button ID="btnNo" runat="server" style="z-index: 1; left: 187px; top: 134px; position: absolute; height: 26px" Text="No" width="37px" OnClick="btnNo_Click" />
            <asp:Button ID="btnYes" runat="server" OnClick="ButtonYes_Click" style="z-index: 1; left: 65px; top: 134px; position: absolute" Text="Yes" />
            <br />
        </div>
    </form>
</body>
</html>
