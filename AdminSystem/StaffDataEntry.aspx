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
    <form id="form1" runat="server">
    &nbsp;<p>
            <asp:Label ID="lblStaffId" runat="server" Text="Staff Id" style="top: 60px; left: 15px; position: absolute; height: 19px; width: 68px"></asp:Label>
            &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:TextBox ID="txtStaffId" runat="server" OnTextChanged="txtStaffId_TextChanged" style="top: 57px; left: 134px; position: absolute; height: 22px; width: 128px"></asp:TextBox>
        <asp:Button ID="btnFind" runat="server" OnClick="btnFind_Click" Text="Find Staff Member" style="top: 59px; left: 307px; position: absolute; height: 24px; width: 151px;" />
        </p>
        <div class="auto-style1">
        </div>
        <asp:Label ID="lblStaffFullName" runat="server" height="19px" style="z-index: 1; left: 11px; top: 122px; position: absolute; width: 107px" Text="Staff Full Name"></asp:Label>
        <asp:Label ID="lblStaffDoB" runat="server" height="19px" style="z-index: 1; left: 16px; top: 170px; position: absolute" Text="Staff DoB" width="95px"></asp:Label>
        <asp:Label ID="lblStaffEmail" runat="server" height="19px" style="z-index: 1; left: 15px; top: 217px; position: absolute" Text="Staff Email" width="95px"></asp:Label>
        <asp:Label ID="lblNINumber" runat="server" height="19px" style="z-index: 1; left: 16px; top: 263px; position: absolute" Text="NI Number" width="95px"></asp:Label>
        <asp:Label ID="lblSalary" runat="server" height="19px" style="z-index: 1; left: 15px; top: 309px; position: absolute" Text="Salary" width="95px"></asp:Label>
        <br />
        <br />
        <br />
        <br />
        <asp:TextBox ID="txtStaffDoB" runat="server" height="22px" style="z-index: 1; left: 135px; top: 164px; position: absolute" width="128px"></asp:TextBox>
        <br />
        <br />
        <asp:TextBox ID="txtStaffFullName" runat="server" height="22px" style="z-index: 1; left: 135px; top: 116px; position: absolute" width="128px"></asp:TextBox>
        <asp:TextBox ID="txtStaffEmail" runat="server" height="22px" style="z-index: 1; left: 135px; top: 211px; position: absolute" width="128px"></asp:TextBox>
        <asp:TextBox ID="txtSalary" runat="server" style="z-index: 1; left: 135px; top: 305px; position: absolute" width="128px" height="22px"></asp:TextBox>
        <br />
        <br />
        <asp:Label ID="lblError" runat="server" style="z-index: 1; left: 14px; top: 400px; position: absolute"></asp:Label>
        <br />
        <asp:TextBox ID="txtNINumber" runat="server" height="22px" style="z-index: 1; left: 135px; top: 259px; position: absolute" width="128px"></asp:TextBox>
        <br />
        <br />
        <br />
        <br />
        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<br />
        <br />
        &nbsp;&nbsp;
        <br />
        <br />
        <asp:CheckBox ID="chkPresentInBuilding" runat="server" height="19px" style="z-index: 1; left: 138px; top: 358px; position: absolute" Text="Present In Building" />
        <asp:Button ID="btnOK" runat="server" height="22px" OnClick="btnOK_Click" style="z-index: 1; left: 15px; top: 469px; position: absolute" Text="Confirm" width="60px" />
    &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:Button ID="btnRtnToMenu" runat="server" OnClick="btnRtnToMenu_Click" Text="Return to Main Menu" style="z-index: 1; left: 14px; top: 515px; position: absolute" />
        <asp:Button ID="btnCancel" runat="server" style="z-index: 1; left: 142px; top: 468px; position: absolute; width: 60px;" Text="Cancel" OnClick="btnCancel_Click" height="22px" />
        <p>
            &nbsp;</p>
    </form>
</body>
</html>
