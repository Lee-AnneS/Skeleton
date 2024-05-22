<%@ Page Language="C#" AutoEventWireup="true" CodeFile="StockList.aspx.cs" Inherits="_1_List" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<<body style="width: 500px; height: 600px;">
    <form id="form1" runat="server">

        <asp:ListBox ID="lstStockList" runat="server" Style="z-index: 1; left: 10px; top: 34px; position: absolute; height: 330px; width: 360px" OnSelectedIndex="lstStockList_SelectedIndex"></asp:ListBox>
        <asp:Button ID="btnAdd" runat="server" OnClick="btnAdd_Click" Style="z-index: 1; left: 23px; top: 396px; position: absolute; right: 883px;" Text="Add" Width="45px" />
        <asp:Button ID="btnEdit" runat="server" OnClick="btnEdit_Click" Style="z-index: 1; left: 93px; top: 396px; position: absolute; right: 607px;" Text="Edit" Width="45px" />
        <asp:Button ID="btnDelete" runat="server" OnClick="btnDelete_Click" Style="z-index: 1; left: 163px; top: 396px; position: absolute; right: 607px;" Text="Delete" Width="55px" />
        <asp:Label ID="lblError" runat="server" Style="z-index: 1; left: 23px; top: 436px; position: absolute; right: 607px;" Text="" Width="345px"  />
    </form>
</body>
</html>
