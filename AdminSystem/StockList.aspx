<%@ Page Language="C#" AutoEventWireup="true" CodeFile="StockList.aspx.cs" Inherits="_1_List" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<<body style="width: 500px; height: 600px;">
    <form id="form1" runat="server">

        <asp:ListBox ID="lstStockList" runat="server" Style="z-index: 1; left: 10px; top: 34px; position: absolute; height: 330px; width: 360px" OnSelectedIndex="lstStockList_SelectedIndex"></asp:ListBox>
        <asp:Button ID="btnAdd" runat="server" OnClick="btnAdd_Click" Style="z-index: 1; left: 23px; top: 396px; position: absolute; right: 607px;" Text="Add" Width="60px" />
    </form>
</body>
</html>
