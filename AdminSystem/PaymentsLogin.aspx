<%@ Page Language="C#" AutoEventWireup="true" CodeFile="PaymentsLogin.aspx.cs" Inherits="PaymentsLogin" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
        </div>
        <asp:Button ID="btnCancel" runat="server" style="z-index: 1; left: 340px; top: 291px; position: absolute" Text="Cancel" OnClick="btnCancel_Click" />
        <asp:Label ID="lblPaymentsLogin" runat="server" style="z-index: 1; left: 108px; top: 86px; position: absolute" Text="Payments Login Page"></asp:Label>
        <asp:Label ID="lblUsername" runat="server" style="z-index: 1; left: 228px; top: 182px; position: absolute" Text="Username"></asp:Label>
        <asp:Label ID="lblPassword" runat="server" style="z-index: 1; left: 230px; top: 226px; position: absolute" Text="Password"></asp:Label>
        <asp:TextBox ID="txtUserName" runat="server" style="z-index: 1; left: 334px; top: 181px; position: absolute"></asp:TextBox>
        <asp:TextBox ID="txtPassword" runat="server" style="z-index: 1; left: 333px; top: 225px; position: absolute" TextMode="Password"></asp:TextBox>
        <asp:Button ID="btnLogin" runat="server" OnClick="btnLogin_Click" style="z-index: 1; left: 255px; top: 291px; position: absolute" Text="Login" />
        <asp:Label ID="lblError" runat="server" ForeColor="Red" style="z-index: 1; left: 602px; top: 206px; position: absolute"></asp:Label>
    </form>
</body>
</html>
