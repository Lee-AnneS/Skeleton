<%@ Page Language="C#" AutoEventWireup="true" CodeFile="CustomerLogin.aspx.cs" Inherits="CustomerLogin" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
        </div>
        <asp:Label ID="lblText" runat="server" style="z-index: 1; left: 63px; top: 64px; position: absolute" Text="Customer Login Page"></asp:Label>
        <asp:Label ID="lblError" runat="server" ForeColor="#FF3300" style="z-index: 1; left: 445px; top: 196px; position: absolute"></asp:Label>
        <asp:Label ID="lblUserName" runat="server" style="z-index: 1; left: 105px; top: 141px; position: absolute; bottom: 501px; " Text="Username: "></asp:Label>
        <asp:TextBox ID="txtUserName" runat="server"  style="z-index: 1; position: absolute; left: 210px; top: 139px;  bottom: 495px; height: 24px; width: 166px"></asp:TextBox>
        <asp:Label ID="lblPassword" runat="server" style="z-index: 1; left: 105px; top: 196px; position: absolute; right: 590px" Text="Password:"></asp:Label>
        <asp:Button ID="btnLogin" runat="server" OnClick="btnLogin_Click" style="z-index: 1; left: 231px; top: 275px; position: absolute; height: 26px" Text="Login" width="60px" />
        <asp:Button ID="btnCancel" runat="server" height="26" style="z-index: 1; top: 275px; position: absolute; left: 319px" Text="Cancel" OnClick="btnCancel_Click" />
        <asp:TextBox ID="txtPassword" runat="server" style="z-index: 1; left: 210px; top: 189px; position: absolute; height: 24px; width: 166px" TextMode="Password"></asp:TextBox>
        
    </form>
</body>
</html>
