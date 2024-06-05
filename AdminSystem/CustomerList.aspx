<%@ Page Language="C#" AutoEventWireup="true" CodeFile="CustomerList.aspx.cs" Inherits="_1_List" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:Button ID="btnDelete" runat="server" height="26px" OnClick="btnDelete_Click" style="z-index: 1; left: 41px; top: 527px; position: absolute; width: 112px" Text="Delete Customer" />
        </div>
        <asp:ListBox ID="lstCustomerList" runat="server" Height="427px" Width="377px"></asp:ListBox>
        <asp:Button ID="btnAdd" runat="server" height="26px" OnClick="btnAdd_Click" style="z-index: 1; left: 41px; top: 482px; position: absolute; width: 112px;" Text="Add Customer" />
        <p>
            <asp:Button ID="btnEdit" runat="server" height="26px" OnClick="btnEdit_Click" style="z-index: 1; left: 190px; top: 482px; position: absolute" Text="Edit Customer" width="112px" />
        </p>
        <p>
            <asp:Label ID="lblFilter" runat="server" style="z-index: 1; left: 43px; top: 573px; position: absolute" Text="Enter a Customer Name"></asp:Label>
            <asp:TextBox ID="txtFilter" runat="server" style="z-index: 1; left: 226px; top: 572px; position: absolute"></asp:TextBox>
        <asp:Button ID="btnMainMenu" runat="server" OnClick="btnMainMenu_Click" style="z-index: 1; left: 416px; top: 616px; position: absolute" Text="Return to Main Menu" />
        </p>
        <p>
            &nbsp;</p>
        <p>
            <asp:Button ID="btnApply" runat="server" OnClick="btnApply_Click" style="z-index: 1; left: 75px; top: 616px; position: absolute" Text="Apply Filter" height="26px" width="100px" />
        </p>
        <asp:Button ID="btnClear" runat="server" height="26px" OnClick="btnClear_Click" style="z-index: 1; top: 616px; position: absolute; left: 207px" Text="Clear Filter" width="100px" />
        <p>
            <asp:Label ID="lblError" runat="server" style="z-index: 1; left: 14px; top: 655px; position: absolute" ForeColor="#FF3300"></asp:Label>
            </p>
    </form>
</body>
</html>
