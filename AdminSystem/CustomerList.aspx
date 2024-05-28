<%@ Page Language="C#" AutoEventWireup="true" CodeFile="CustomerList.aspx.cs" Inherits="_1_List" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:Button ID="btnDelete" runat="server" height="26px" OnClick="btnDelete_Click" style="z-index: 1; left: 178px; top: 479px; position: absolute; width: 51px" Text="Delete" />
        </div>
        <asp:ListBox ID="lstCustomerList" runat="server" Height="427px" Width="377px"></asp:ListBox>
        <p>
            <asp:Button ID="btnAdd" runat="server" OnClick="btnAdd_Click" Text="Add" height="26px" width="51px" />
            <asp:Button ID="btnEdit" runat="server" height="26px" OnClick="btnEdit_Click" style="z-index: 1; left: 93px; top: 479px; position: absolute" Text="Edit" width="51px" />
        </p>
        <p>
            <asp:Label ID="lblError" runat="server" style="z-index: 1; left: 10px; top: 525px; position: absolute"></asp:Label>
        </p>
        <p>
            &nbsp;</p>
    </form>
</body>
</html>
