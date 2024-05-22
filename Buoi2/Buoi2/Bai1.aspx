<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Bai1.aspx.cs" Inherits="Buoi2.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <link href="Buoi2.css" rel="stylesheet" type="text/css" />
    <link href="Buoi2.css" rel="stylesheet" type="text/css" />
    <link href="Buoi2.css" rel="stylesheet" type="text/css" />
    <link href="Buoi2.css" rel="stylesheet" type="text/css" />
    <link href="Buoi2.css" rel="stylesheet" type="text/css" />
</head>
<body>
    <form id="form1" runat="server">
        <div style="width: 1163px; height: 291px">
            Bài 1: Tính tổng các số từ 1 đến N<br />
            <br />
            <asp:Label ID="Label2" runat="server" Text="N"></asp:Label>
&nbsp;
            <asp:TextBox ID="txtN" runat="server" CssClass="td"></asp:TextBox>
            <br />
            <asp:Button ID="btnTinh0" runat="server" CssClass="button" OnClick="btnTinh0_Click" Text="Tính" />
            <br />
            <asp:Label ID="Label3" runat="server" Text="Kết quả"></asp:Label>
&nbsp;
            <asp:TextBox ID="txtkq0" runat="server" CssClass="td"></asp:TextBox>
            <br />
            <p style="width: 1163px">
                &nbsp;</p>
        </div>
    </form>
</body>
</html>
