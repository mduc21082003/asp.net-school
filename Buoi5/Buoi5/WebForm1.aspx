<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="Buoi5.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:Label ID="Label1" runat="server" style="z-index: 1; left: 10px; top: 14px; position: absolute" Text="Mã hàng"></asp:Label>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:DropDownList ID="ddlMaHang" runat="server" style="z-index: 1; left: 120px; top: 14px; position: absolute" OnSelectedIndexChanged="ddlMaHang_SelectedIndexChanged" AutoPostBack="True">
            </asp:DropDownList>
            <asp:TextBox ID="txtMaHang" runat="server" style="z-index: 1; left: 250px; top: 14px; position: absolute; width: 100px"></asp:TextBox>
            <br />
            <br />
            <asp:Label ID="Label2" runat="server" style="z-index: 1; left: 10px; top: 59px; position: absolute" Text="Tên hàng"></asp:Label>
            <asp:TextBox ID="txtTenHang" runat="server" style="z-index: 1; left: 120px; top: 57px; position: absolute; right: 607px; width: 160px;"></asp:TextBox>
            <br />
            <br />
            <asp:Label ID="Label3" runat="server" style="z-index: 1; left: 10px; top: 103px; position: absolute; right: 781px" Text="Đơn giá"></asp:Label>
            <asp:TextBox ID="txtDonGia" runat="server" style="z-index: 1; left: 120px; top: 102px; position: absolute; width: 160px;"></asp:TextBox>
            <br />
            <asp:TextBox ID="txtTimKiem" runat="server" style="z-index: 1; left: 662px; top: 191px; position: absolute"></asp:TextBox>
            <br />
            <asp:Label ID="Label4" runat="server" style="z-index: 1; left: 10px; top: 147px; position: absolute" Text="Đơn vị tính"></asp:Label>
            <asp:TextBox ID="txtDonViTinh" runat="server" style="z-index: 1; left: 120px; top: 145px; position: absolute"></asp:TextBox>
            <br />
            <br />
            <asp:Button ID="btnThem" runat="server" style="z-index: 1; left: 10px; top: 191px; position: absolute; width: 75px" Text="Thêm" OnClick="btnThem_Click" />
            <asp:Button ID="btnSua" runat="server" style="z-index: 1; left: 150px; top: 191px; position: absolute; right: 706px; width: 75px" Text="Sửa" OnClick="btnSua_Click" />
            <asp:Button ID="btnXoa" runat="server" style="z-index: 1; left: 290px; top: 191px; position: absolute; width: 75px" Text="Xóa" OnClick="btnXoa_Click" />
            <asp:Button ID="btnHienThi" runat="server" style="z-index: 1; left: 430px; top: 191px; position: absolute; width: 75px" Text="Hiển thị" OnClick="btnHienThi_Click" />
            <asp:Button ID="btnTimKiem" runat="server" style="z-index: 1; left: 570px; top: 191px; position: absolute; right: 254px; width: 75px" Text="Tìm kiếm" OnClick="btnTimKiem_Click" />
            <br />
            <br />
            <br />
            <br />
            <asp:GridView ID="gvTatCa" runat="server" style="z-index: 1; left: 10px; top: 313px; position: absolute; height: 152px; width: 817px" BackColor="White" BorderColor="#999999" BorderStyle="None" BorderWidth="1px" CellPadding="3" GridLines="Vertical">
                <AlternatingRowStyle BackColor="#DCDCDC" />
                <FooterStyle BackColor="#CCCCCC" ForeColor="Black" />
                <HeaderStyle BackColor="#000084" Font-Bold="True" ForeColor="White" />
                <PagerStyle BackColor="#999999" ForeColor="Black" HorizontalAlign="Center" />
                <RowStyle BackColor="#EEEEEE" ForeColor="Black" />
                <SelectedRowStyle BackColor="#008A8C" Font-Bold="True" ForeColor="White" />
                <SortedAscendingCellStyle BackColor="#F1F1F1" />
                <SortedAscendingHeaderStyle BackColor="#0000A9" />
                <SortedDescendingCellStyle BackColor="#CAC9C9" />
                <SortedDescendingHeaderStyle BackColor="#000065" />
            </asp:GridView>
            <br />
            <br />
            <br />
            <br />
            <br />
            <br />
            <br />
            <br />
            <br />
            <br />
            <br />
            <br />
            <br />
            <br />
        </div>
    </form>
</body>
</html>
