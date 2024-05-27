<%@ Page Language="C#" AutoEventWireup="true" CodeFile="StockLogin.aspx.cs" Inherits="StockLogin" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body style="width: 500px; height: 600px;">
    <form id="form1" runat="server">
        <asp:Label ID="lblUserName" runat="server" Style="z-index: 1; left: 53px; top: 90px; position: absolute; right: 883px;" Text="UserName: " Width="85px" />
        <asp:Label ID="lblPassword" runat="server" Style="z-index: 1; left: 53px; top: 140px; position: absolute; right: 883px;" Text="Password: " Width="85px" />
        <asp:TextBox ID="txtUserName" runat="server" Style="z-index: 1; left: 145px; top: 85px; position: absolute" Height="20px" Width="130px"></asp:TextBox>
        <asp:TextBox ID="txtPassword" runat="server" TextMode="Password" Style="z-index: 1; left: 145px; top: 140px; position: absolute" Height="20px" Width="130px"></asp:TextBox>
        <asp:Button ID="btnLogin" runat="server" OnClick="btnLogin_Click" Style="z-index: 1; left: 145px; top: 200px; position: absolute; right: 883px;" Text="Login" Width="60px" />
        <asp:Button ID="btnCancel" runat="server" OnClick="btnCancel_Click" Style="z-index: 1; left: 215px; top: 200px; position: absolute; right: 883px;" Text="Cancel" Width="60px" />
        <asp:Label ID="lblError" runat="server" Style="z-index: 1; left: 348px; top: 140px; position: absolute; right: 883px;" Width="85px" ForeColor="#FF3300" />

    </form>
</body>
</html>
