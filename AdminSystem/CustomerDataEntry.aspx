<%@ Page Language="C#" AutoEventWireup="true" CodeFile="CustomerDataEntry.aspx.cs" Inherits="_1_DataEntry" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
     
        <asp:Button ID="btnMainMenu" runat="server" OnClick="btnMainMenu_Click" style="z-index: 1; left: 335px; top: 363px; position: absolute" Text="Return to Main Menu" />
     
        <asp:Label ID="lblCustomerId" runat="server" style="z-index: 1; left: 10px; top: 34px; position: absolute" Text="CustomerId" height="19px" width="91px"></asp:Label>
        <asp:TextBox ID="txtCustomerId" runat="server" style="z-index: 1; left: 136px; top: 30px; position: absolute" height="22px" width="128px"></asp:TextBox>
        <asp:Label ID="lblCustomerName" runat="server" style="z-index: 1; left: 10px; top: 72px; position: absolute" Text="Name" height="19px" width="91px"></asp:Label>
        <asp:TextBox ID="txtCustomerDoB" runat="server" style="z-index: 1; left: 136px; top: 108px; position: absolute" height="22px" width="128px"></asp:TextBox>
        <asp:TextBox ID="txtCustomerEmail" runat="server" style="z-index: 1; left: 136px; top: 144px; position: absolute" height="22px" width="128px"></asp:TextBox>
        <asp:TextBox ID="txtCustomerName" runat="server" style="z-index: 1; left: 136px; top: 68px; position: absolute" height="22px" width="128px"></asp:TextBox>
        <asp:Label ID="lblCustomerDoB" runat="server" style="z-index: 1; left: 10px; top: 112px; position: absolute; margin-bottom: 118px;" Text="Date Of Birth" height="19px" width="91px"></asp:Label>
        <asp:Label ID="lblCustomerEmail" runat="server" style="z-index: 1; left: 10px; top: 148px; position: absolute" Text="Email" height="19px" width="91px"></asp:Label>
        <asp:Label ID="lblCustomerAddress" runat="server" style="z-index: 1; left: 10px; top: 184px; position: absolute" Text="Address" height="19px" width="91px"></asp:Label>
        <asp:TextBox ID="txtCustomerAddress" runat="server" style="z-index: 1; left: 136px; top: 180px; position: absolute; height: 22px;" width="128px"></asp:TextBox>
        <asp:Label ID="lblNumOrder" runat="server" style="z-index: 1; left: 10px; position: absolute; top: 224px; bottom: 399px;" Text="Num Of Order" height="19px" width="91px"></asp:Label>
        <asp:TextBox ID="txtNumOrder" runat="server" style="z-index: 1; left: 136px; top : 226px; position: absolute; bottom: 337px;" height="22px" width="128px"></asp:TextBox>
        <asp:CheckBox ID="chkActive" runat="server" style="z-index: 1; left: 137px; top: 269px; position: absolute; margin-top: 0px;" Text="Active" />
        <asp:Label ID="lblError" runat="server" BorderColor="Red" style="z-index: 1; left: 10px; top: 303px; position: absolute" ForeColor="#FF3300"></asp:Label>
        <asp:Button ID="btnCancel" runat="server" OnClick="btnCancel_Click" Style="z-index: 1; left: 104px; top: 363px; position: absolute" Text="Cancel" Height="26px" Width="60px"  />
        <asp:Button ID="btnOk" runat="server" OnClick="btnOk_Click" style="z-index: 1; left: 10px; top: 363px; position: absolute; right: 688px;" Text="Ok" height="26px" width="60px" />
        <asp:Button ID="btnFind" runat="server" height="26px" OnClick="btnFind_Click" style="z-index: 1; left: 338px; top: 31px; position: absolute; width: 103px;" Text="Find Customer" />
    </form>
</body>
</html>
