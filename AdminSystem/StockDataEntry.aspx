<%@ Page Language="C#" AutoEventWireup="true" CodeFile="StockDataEntry.aspx.cs" Inherits="_1_DataEntry" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body style="width: 359px; height: 400px;">
    <form id="form1" runat="server">

        <asp:TextBox ID="txtProductId" runat="server" style="z-index: 1; left: 115px; top: 19px; position: absolute; height: 22px; width: 122px"></asp:TextBox>
        <asp:Label ID="lblName" runat="server" style="z-index: 1; left: 10px; top: 54px; position: absolute; width: 88px" Text="Name" height="23px"></asp:Label>
        <asp:TextBox ID="txtName" runat="server" style="z-index: 1; left: 115px; top: 56px; position: absolute" height="22px" width="122px"></asp:TextBox>
        <asp:Label ID="lblDescription" runat="server" style="z-index: 1; left: 10px; top: 95px; position: absolute; height: 23px" Text="Description" width="88px"></asp:Label>
        <asp:TextBox ID="txtDescription" runat="server" style="z-index: 1; left: 115px; top: 97px; position: absolute" height="22px" width="122px"></asp:TextBox>
        <asp:Label ID="lblPrice" runat="server" style="z-index: 1; left: 10px; top: 138px; position: absolute" Text="Price" height="23px" width="88px"></asp:Label>
        <asp:TextBox ID="txtPrice" runat="server" style="z-index: 1; left: 115px; top: 138px; position: absolute" height="22px" width="122px"></asp:TextBox>
        <asp:Label ID="lblStockQuantity" runat="server" style="z-index: 1; left: 10px; top: 179px; position: absolute; height: 23px; width: 88px;" Text="StockQuantity"></asp:Label>
        <asp:TextBox ID="txtStockQuantity" runat="server" style="z-index: 1; left: 115px; top: 176px; position: absolute" height="22px" width="122px"></asp:TextBox>
        <asp:Label ID="lblDateAdded" runat="server" style="z-index: 1; left: 10px; top: 220px; position: absolute" Text="DateAdded" height="23px" width="88px"></asp:Label>
        <asp:Label ID="lblProductId" runat="server" style="z-index: 1; left: 13px; top: 19px; position: absolute; height: 23px; width: 88px;" Text="ProductId"></asp:Label>
        <asp:TextBox ID="txtDateAdded" runat="server" style="z-index: 1; left: 115px; top: 220px; position: absolute" width="122px"></asp:TextBox>
        <asp:CheckBox ID="chkAvailable" runat="server" style="z-index: 1; left: 116px; top: 258px; position: absolute; width: 113px; margin-bottom: 0px" Text="Available" />
        <asp:Button ID="btnCancel" runat="server" OnClick="Button1_Click" style="z-index: 1; left: 104px; top: 346px; position: absolute" Text="Cancel" />
        <asp:Label ID="lblError" runat="server" style="z-index: 1; left: 10px; top: 302px; position: absolute"></asp:Label>
        <asp:Button ID="btnOK" runat="server" OnClick="btnOK_Click1" style="z-index: 1; left: 23px; top: 346px; position: absolute; right: 607px;" Text="OK" width="60px" />
        <asp:Button ID="btnFind" runat="server" OnClick="btnFind_Click" style="z-index: 1; left: 284px; top: 20px; position: absolute" Text="Find" />
    </form>
</body>
</html>