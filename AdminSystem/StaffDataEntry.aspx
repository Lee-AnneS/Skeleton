<%@ Page Language="C#" AutoEventWireup="true" CodeFile="StaffDataEntry.aspx.cs" Inherits="_1_DataEntry" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .auto-style1 {
            text-align: left;
        }
    </style>
</head>
<body>
    &nbsp;<form id="form1" runat="server">
        <div class="auto-style1">
        </div>
        <asp:Label ID="lblStaffFullName" runat="server" height="19px" style="z-index: 1; left: 15px; top: 73px; position: absolute; width: 107px" Text="Staff Full Name"></asp:Label>
        <asp:Label ID="lblStaffDoB" runat="server" height="19px" style="z-index: 1; left: 15px; top: 106px; position: absolute" Text="Staff DoB" width="95px"></asp:Label>
        <asp:Label ID="lblStaffEmail" runat="server" height="19px" style="z-index: 1; left: 15px; top: 135px; position: absolute" Text="Staff Email" width="95px"></asp:Label>
        <asp:Label ID="lblNINumber" runat="server" height="19px" style="z-index: 1; left: 15px; top: 166px; position: absolute" Text="NI Number" width="95px"></asp:Label>
        <asp:Label ID="lblSalary" runat="server" height="19px" style="z-index: 1; left: 15px; top: 194px; position: absolute" Text="Salary" width="95px"></asp:Label>
        <br />
        <br />
        <br />
        <br />
        <asp:TextBox ID="txtStaffDoB" runat="server" height="19px" style="z-index: 1; left: 138px; top: 99px; position: absolute" width="133px"></asp:TextBox>
        <br />
        <br />
        <asp:TextBox ID="txtStaffFullName" runat="server" height="19px" style="z-index: 1; left: 138px; top: 68px; position: absolute" width="133px"></asp:TextBox>
        <asp:TextBox ID="txtStaffEmail" runat="server" height="19px" style="z-index: 1; left: 138px; top: 129px; position: absolute" width="133px"></asp:TextBox>
        <br />
        <asp:TextBox ID="txtNINumber" runat="server" height="19px" style="z-index: 1; left: 138px; top: 164px; position: absolute" width="133px"></asp:TextBox>
        <br />
        <br />
        <asp:TextBox ID="txtSalary" runat="server" style="z-index: 1; left: 138px; top: 194px; position: absolute" width="133px"></asp:TextBox>
        <br />
        <asp:CheckBox ID="chkPresentInBuilding" runat="server" height="19px" style="z-index: 1; left: 126px; top: 227px; position: absolute" Text="Present In Building" />
        <p>
            <asp:Label ID="lblError" runat="server" height="19px" style="z-index: 1; left: 14px; top: 262px; position: absolute"></asp:Label>
        </p>
        <asp:Button ID="btnOK" runat="server" height="26px" OnClick="btnOK_Click" style="z-index: 1; left: 10px; top: 297px; position: absolute" Text="OK" width="60px" />
        <asp:Button ID="btnCancel" runat="server" style="z-index: 1; left: 112px; top: 297px; position: absolute" Text="Cancel" />
    </form>
</body>
</html>
