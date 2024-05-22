<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Bai5.aspx.cs" Inherits="Buoi2.Bai5" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">

.td {
    font-family: Arial, Helvetica, sans-serif;
    font-size: 15px;
    font-weight: 700;
    font-style: normal;
    color: #000000;
    background-color: #66FFFF;
    padding-top: 10px;
    padding-bottom: 10px;
    margin-top: 10px;
}
.button {
    font-family: Arial, Helvetica, sans-serif;
    font-size: 20px;
    font-weight: 600;
    color: #FFFFFF;
    background-color: #0000FF;
    margin: 20px;
    padding: 10px 30px 10px 30px;
}
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            Bài 1: Tìm UCLN của 2 số nguyên dương a và b<br />
            <br />
            a&nbsp;
            <asp:TextBox ID="txta" runat="server" CssClass="td"></asp:TextBox>
            <br />
            b&nbsp;
            <asp:TextBox ID="txtb" runat="server" CssClass="td"></asp:TextBox>
            <br />
            <asp:Button ID="btnTinh0" runat="server" CssClass="button" OnClick="btnTinh0_Click" Text="UCLN là" />
            <br />
            <asp:Label ID="Label3" runat="server" Text="Kết quả"></asp:Label>
&nbsp;
            <asp:TextBox ID="txtkq0" runat="server" CssClass="td"></asp:TextBox>
            <br />
        </div>
    </form>
</body>
</html>
