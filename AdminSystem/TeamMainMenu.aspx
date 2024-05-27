<%@ Page Language="C#" AutoEventWireup="true" CodeFile="TeamMainMenu.aspx.cs" Inherits="TeamMainMenu" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .auto-style1 {
            text-align: justify;
        }
        .auto-style2 {
            font-size: large;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div class="auto-style1">
        <div>
            <span class="TextRun SCXW258358509 BCX8" data-contrast="auto" lang="EN-GB" style="-webkit-user-drag: none; -webkit-tap-highlight-color: transparent; margin: 0px; padding: 0px; user-select: text; font-variant-ligatures: none !important; color: rgb(0, 0, 0); font-style: normal; font-variant-caps: normal; letter-spacing: normal; orphans: 2; text-align: center; text-indent: 0px; text-transform: none; widows: 2; word-spacing: 0px; -webkit-text-stroke-width: 0px; white-space: pre-wrap; background-color: rgb(255, 255, 255); text-decoration-thickness: initial; text-decoration-style: initial; text-decoration-color: initial; font-size: 36pt; line-height: 67.85px; font-family: Calibri, Calibri_EmbeddedFont, Calibri_MSFontService, sans-serif; font-weight: bold;" xml:lang="EN-GB"><span class="NormalTextRun SCXW258358509 BCX8" style="-webkit-user-drag: none; -webkit-tap-highlight-color: transparent; margin: 0px; padding: 0px; user-select: text;">Boba Bliss Main Menu<br />
            </span></span>
        </div>
 HEAD
            <asp:Label ID="lblMainMenu" runat="server" Font-Bold="False" Font-Names="MV Boli" style="z-index: 1; left: 333px; top: 78px; position: absolute; font-size: xx-large" Text="Boba Bliss Main Menu"></asp:Label>
            <asp:Image ID="Image1" runat="server" ImageUrl="~/img/bubble-tea-drink.jpg" style="z-index: 1; left: 402px; top: 117px; position: absolute; height: 142px; width: 147px" />
            <asp:Label ID="lblEst" runat="server" Font-Names="Akzidenz-Grotesk Pro Cnd" style="z-index: 1; left: 459px; top: 260px; position: absolute" Text="Est.2024"></asp:Label>
            <asp:Button ID="btnCustomer" runat="server" CssClass="auto-style2" Font-Names="Californian FB" height="26px" OnClick="btnCustomer_Click" style="z-index: 1; left: 378px; top: 303px; position: absolute" Text="Customer" width="84px" />
            <asp:Button ID="btnStock" runat="server" CssClass="auto-style2" Font-Names="Californian FB" height="26px" OnClick="btnStock_Click" style="z-index: 1; left: 525px; top: 339px; position: absolute; right: 556px; width: 84px" Text="Stock" />
            <asp:Button ID="btnOrder" runat="server" CssClass="auto-style2" Font-Names="Californian FB" height="26px" OnClick="btnOrder_Click" style="z-index: 1; left: 426px; top: 339px; position: absolute; width: 84px" Text="Order" />
        </div>
        <asp:Button ID="btnPayments" runat="server" CssClass="auto-style2" Font-Names="Californian FB" height="26px" OnClick="btnPayments_Click" style="z-index: 1; left: 329px; top: 339px; position: absolute" Text="Payments" width="84px" />
        <p>
            &nbsp;</p>
        <asp:Button ID="btnStaff" runat="server" CssClass="auto-style2" Font-Names="Californian FB" height="26px" OnClick="btnStaff_Click" style="z-index: 1; left: 491px; top: 303px; position: absolute; width: 84px" Text="Staff" />
        <br />
        <p>
            <asp:Button ID="btnStaffManagement" runat="server" OnClick="btnStaffManagement_Click" Text="Staff Management" />
        </p>
        <asp:Button ID="Button1" runat="server" Text="Button" />
        <p>
            <asp:Button ID="Button2" runat="server" Text="Button" />
        </p>
        <asp:Button ID="Button3" runat="server" Text="Button" />
        <br />
        <br />
    </form>
</body>
</html>
