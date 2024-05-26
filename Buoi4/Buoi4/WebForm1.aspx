<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="Buoi4.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .newStyle1 {
            color: #00FFFF;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div style="margin-left: 40px">
            <br />
            <br />
            <asp:Label ID="Label2" runat="server" style="z-index: 1; left: 10px; top: 59px; position: absolute" Text="Mã môn"></asp:Label>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:DropDownList ID="DropDownList1" runat="server" OnSelectedIndexChanged="DropDownList1_SelectedIndexChanged" style="z-index: 1; left: 221px; top: 55px; position: absolute" AutoPostBack="True">
            </asp:DropDownList>
            <br />
            <asp:TextBox ID="TextBox4" runat="server" style="z-index: 1; left: 137px; top: 55px; position: absolute; width: 57px; right: 838px;"></asp:TextBox>
            <br />
            <asp:Label ID="Label3" runat="server" style="z-index: 1; left: 10px; top: 103px; position: absolute" Text="Tên môn"></asp:Label>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:TextBox ID="TextBox2" runat="server" style="z-index: 1; left: 135px; top: 103px; position: absolute"></asp:TextBox>
            <br />
            <br />
            <asp:Label ID="Label4" runat="server" style="z-index: 1; left: 10px; top: 147px; position: absolute" Text="Số ĐVHT"></asp:Label>
            <asp:TextBox ID="TextBox3" runat="server" style="z-index: 1; left: 135px; top: 147px; position: absolute"></asp:TextBox>
            &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <br />
            <br />
            <asp:Button ID="Button1" runat="server" style="z-index: 1; left: 10px; top: 190px; position: absolute; width: 130px" Text="Thêm môn học" OnClick="Button1_Click" />
            <asp:Button ID="Button2" runat="server" style="z-index: 1; left: 152px; top: 190px; position: absolute; width: 130px" Text="Sửa môn học" OnClick="Button2_Click" />
            <asp:Button ID="Button3" runat="server" style="z-index: 1; left: 295px; top: 189px; position: absolute; width: 130px" Text="Xóa môn học" OnClick="Button3_Click" />
            <br />
            <br />
            <asp:GridView ID="GridView1" runat="server" style="z-index: 1; left: 10px; top: 257px; position: absolute; height: 152px; width: 232px" BackColor="White" BorderColor="#CCCCCC" BorderStyle="None" BorderWidth="1px" CellPadding="3">
                <FooterStyle BackColor="White" ForeColor="#000066" />
                <HeaderStyle BackColor="#006699" Font-Bold="True" ForeColor="White" />
                <PagerStyle BackColor="White" ForeColor="#000066" HorizontalAlign="Left" />
                <RowStyle ForeColor="#000066" />
                <SelectedRowStyle BackColor="#669999" Font-Bold="True" ForeColor="White" />
                <SortedAscendingCellStyle BackColor="#F1F1F1" />
                <SortedAscendingHeaderStyle BackColor="#007DBB" />
                <SortedDescendingCellStyle BackColor="#CAC9C9" />
                <SortedDescendingHeaderStyle BackColor="#00547E" />
            </asp:GridView>
            <br />
            <br />
            <br />
        </div>
    </form>
</body>
</html>
