<%@ Page Language="C#" AutoEventWireup="true" CodeFile="StaffList.aspx.cs" Inherits="_1_List" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:ListBox ID="lstStaffList" runat="server" Height="358px" Width="280px" style="margin-top: 25px"></asp:ListBox>
        </div>
        <p>
        <asp:Button ID="btnAdd" runat="server" OnClick="btnAdd_Click" Text="Add New Staff Member" height="26px" style="top: 79px; left: 322px; position: absolute; width: 148px" />
        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; &nbsp;
            </p>
        <p>
            <asp:Button ID="btnDelete" runat="server" OnClick="Button1_Click" style="z-index: 1; top: 308px; position: absolute; height: 26px; left: 325px; width: 143px;" Text="Delete Staff Member" />
            <asp:Label ID="lblStaffFullNameFilter" runat="server" Text="Enter a Full Name" style="top: 440px; left: 10px; position: absolute; height: 19px; width: 125px"></asp:Label>
&nbsp;&nbsp;&nbsp;
            <asp:Button ID="btnClearFilter" runat="server" OnClick="btnClearFilter_Click" Text="Clear Filter" style="top: 480px; left: 272px; position: absolute; height: 26px; width: 95px" />
            <asp:TextBox ID="txtFilterByStaffFullName" runat="server" style="top: 434px; left: 161px; position: absolute; height: 22px; width: 128px"></asp:TextBox>
        </p>
        <p>
            <asp:Button ID="btnApplyFilter" runat="server" height="26px" OnClick="btnApplyFilter_Click" Text="Apply Filter" width="95px" style="top: 480px; left: 148px; position: absolute; right: 439px" />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:Button ID="btnEdit" runat="server" OnClick="btnEdit_Click" Text="Edit Staff Member" height="26px" style="top: 197px; left: 322px; position: absolute; width: 145px" />
            </p>
        <p>
            &nbsp;</p>
        <p>
        <asp:Button ID="btnRtnToMenu" runat="server" OnClick="btnRtnToMenu_Click" Text="Return to Main Menu" style="top: 576px; left: 58px; position: absolute; height: 26px; width: 183px" />
            <asp:Label ID="lblError" runat="server" style="top: 519px; left: 21px; position: absolute; height: 19px; width: 56px"></asp:Label>
        </p>
    </form>
</body>
</html>
