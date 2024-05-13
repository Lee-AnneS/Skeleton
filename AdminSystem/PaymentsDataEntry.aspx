<%@ Page Language="C#" AutoEventWireup="true" CodeFile="PaymentsDataEntry.aspx.cs" Inherits="_1_DataEntry" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        #form1 {
            height: 244px;
        }
    </style>
</head>
<body style="height: 287px">
    <form id="form1" runat="server">
        <div>
            <asp:Label ID="lblPaymentId" runat="server" height="19px" style="z-index: 1; left: 25px; top: 46px; position: absolute" Text="Payments ID" width="104px"></asp:Label>
        </div>
         <asp:TextBox ID="txtPaymentsId" runat="server" style="z-index: 1; left: 149px; top: 42px; position: absolute; width: 131px"></asp:TextBox>
        <asp:TextBox ID="txtOrderId" runat="server" height="22px" style="z-index: 1; left: 149px; top: 71px; position: absolute" width="131px"></asp:TextBox>
        <asp:TextBox ID ="txtBillingAddress" runat="server" height="22px" style="z-index: 1; left: 149px; top: 106px; position: absolute" width="131px"></asp:TextBox>
        <asp:TextBox ID="txtPaymentsMethod" runat="server" height="22px" style="z-index: 1; left: 149px; top: 137px; position: absolute" width="131px"></asp:TextBox>
        <asp:TextBox ID="txtAmount" runat="server" height="22px" style="z-index: 1; left: 149px; top: 173px; position: absolute" width="131px"></asp:TextBox>
        <asp:TextBox ID="txtPaymentDate" runat="server" height="22px" style="z-index: 1; left: 149px; top: 208px; position: absolute" width="131px"></asp:TextBox>
        <p>
            <asp:Label ID="lblOrderId" runat="server" height="19px" style="z-index: 1; left: 25px; position: absolute; top: 77px" Text="Order ID" width="104px"></asp:Label>
        </p>
        <asp:Label ID="lblBillingAddress" runat="server" height="19px" style="z-index: 1; left: 25px; top: 110px; position: absolute" Text="Billing Address" width="104px"></asp:Label>
        <asp:Label ID="lblPaymentsMethod" runat="server" style="z-index: 1; left: 25px; top: 145px; position: absolute" Text="Payments Method"></asp:Label>
        <asp:Label ID="lblPaymentDate" runat="server" height="19px" style="z-index: 1; left: 25px; top: 216px; position: absolute" Text="Payment Date" width="104px"></asp:Label>
        <asp:Label ID="lblAmount" runat="server" height="19px" style="z-index: 1; left: 25px; top: 178px; position: absolute" Text="Amount" width="104px"></asp:Label>
        <p>
            &nbsp;</p>
        <p>
            <asp:CheckBox ID="chkPaymentsStatus" runat="server" style="z-index: 1; left: 140px; top: 273px; position: absolute" Text="Payment Status" />
        </p>
        <asp:Label ID="lblError" runat="server" style="z-index: 1; left: 48px; top: 308px; position: absolute; margin-top: 3px"></asp:Label>
        <asp:Button ID="btnCancel" runat="server" style="z-index: 1; left: 143px; top: 342px; position: absolute" Text="Cancel" />
       
        <p>
            <asp:Button ID="btnOK" runat="server" OnClick="btnOK_Click" style="z-index: 1; left: 41px; position: absolute; top: 342px; height: 26px; width: 65px" Text="OK" />
        </p>
    </form>
</body>
</html>
