<%@ Page Language="C#" AutoEventWireup="true" CodeFile="PaymentsList.aspx.cs" Inherits="_1_List" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
        </div>
        <asp:ListBox ID="lstPaymentsList" runat="server" style="z-index: 1; left: 10px; top: 30px; position: absolute; height: 384px; width: 530px"></asp:ListBox>
        <asp:Button ID="btnAdd" runat="server" OnClick="btnAdd_Click" style="z-index: 1; left: 17px; top: 424px; position: absolute" Text="Add" />
        <asp:Button ID="btnEdit" runat="server" OnClick="btnEdit_Click" style="z-index: 1; left: 80px; top: 424px; position: absolute" Text="Edit" />
        <asp:Button ID="lblError" runat="server" style="z-index: 1; left: 43px; top: 466px; position: absolute" />
        <asp:Button ID="btnDelete" runat="server" OnClick="btnDelete_Click" style="z-index: 1; left: 139px; top: 424px; position: absolute" Text="Delete" />
    </form>
</body>
</html>
