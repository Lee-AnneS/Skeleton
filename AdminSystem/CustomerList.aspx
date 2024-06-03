<%@ Page Language="C#" AutoEventWireup="true" CodeFile="CustomerList.aspx.cs" Inherits="_1_List" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:Button ID="btnDelete" runat="server" height="26px" OnClick="btnDelete_Click" style="z-index: 1; left: 193px; top: 479px; position: absolute; width: 51px" Text="Delete" />
        </div>
        <asp:ListBox ID="lstCustomerList" runat="server" Height="427px" Width="377px"></asp:ListBox>
        <asp:Button ID="btnAdd" runat="server" height="26px" OnClick="btnAdd_Click" style="z-index: 1; left: 25px; top: 479px; position: absolute" Text="Add" width="51px" />
        <asp:Button ID="btnMainMenu" runat="server" OnClick="btnMainMenu_Click" style="z-index: 1; left: 454px; top: 582px; position: absolute" Text="Return to Main Menu" />
        <p>
            <asp:Button ID="btnEdit" runat="server" height="26px" OnClick="btnEdit_Click" style="z-index: 1; left: 110px; top: 479px; position: absolute" Text="Edit" width="51px" />
        </p>
        <p>
            <asp:Label ID="lblError" runat="server" style="z-index: 1; left: 13px; top: 633px; position: absolute" ForeColor="#FF3300"></asp:Label>
            <asp:Label ID="lblFilter" runat="server" style="z-index: 1; left: 43px; top: 537px; position: absolute" Text="Enter a Customer Name"></asp:Label>
            <asp:TextBox ID="txtFilter" runat="server" style="z-index: 1; left: 228px; top: 536px; position: absolute"></asp:TextBox>
        </p>
        <p>
            &nbsp;</p>
        <p>
            <asp:Button ID="btnApply" runat="server" OnClick="btnApply_Click" style="z-index: 1; left: 73px; top: 582px; position: absolute" Text="Apply Filter" />
        </p>
        <asp:Button ID="btnClear" runat="server" height="26px" OnClick="btnClear_Click" style="z-index: 1; top: 582px; position: absolute; left: 207px" Text="Clear Filter" width="100px" />
    </form>
</body>
</html>
