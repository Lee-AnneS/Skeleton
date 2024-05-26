<%@ Page Language="C#" AutoEventWireup="true" CodeFile="StaffList.aspx.cs" Inherits="_1_List" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:ListBox ID="lstStaffList" runat="server" Height="240px" Width="266px"></asp:ListBox>
        </div>
        <p>
        <asp:Button ID="btnAdd" runat="server" OnClick="btnAdd_Click" Text="Add" height="26px" width="62px" />
        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; &nbsp;
            <asp:Button ID="btnEdit" runat="server" OnClick="btnEdit_Click" Text="Edit" Width="62px" height="26px" />
        </p>
        <p>
            <asp:Button ID="btnDelete" runat="server" OnClick="Button1_Click" style="z-index: 1; top: 275px; position: absolute; height: 26px; left: 227px" Text="Delete" width="62px" />
            <asp:Label ID="lblStaffFullNameFilter" runat="server" Text="Enter a Full Name"></asp:Label>
&nbsp;&nbsp;&nbsp;
            <asp:TextBox ID="txtFilterByStaffFullName" runat="server"></asp:TextBox>
        </p>
        <p>
            <asp:Button ID="btnApplyFilter" runat="server" height="26px" OnClick="btnApplyFilter_Click" Text="Apply Filter" width="95px" />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:Button ID="btnClearFilter" runat="server" OnClick="btnClearFilter_Click" Text="Clear Filter" />
        </p>
        <p>
            &nbsp;<asp:Label ID="lblError" runat="server"></asp:Label>
        </p>
    </form>
</body>
</html>
