<%@ Page Language="C#" AutoEventWireup="true" CodeFile="CustomerConfirmDelete.aspx.cs" Inherits="_1_ConfirmDelete" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
        </div>
        <p>
            <asp:Label ID="lblText" runat="server" style="z-index: 1; left: 15px; top: 54px; position: absolute; height: 31px; width: 310px; margin-top: 14px" Text="Are you sure you want to delete this record?"></asp:Label>
        </p>
        <p>
            <asp:Button ID="btnNo" runat="server" OnClick="btnNo_Click" style="z-index: 1; top: 119px; position: absolute; left: 155px; width: 85px; height: 29px" Text="No" />
        </p>
        <p>
            <asp:Button ID="btnYes" runat="server" OnClick="btnYes_Click" style="z-index: 1; left: 33px; top: 119px; position: absolute; right: 467px; height: 29px" Text="Yes" width="85px" />
        </p>
    </form>
</body>
</html>
