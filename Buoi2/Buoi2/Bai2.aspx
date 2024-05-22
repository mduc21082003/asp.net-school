<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Bai2.aspx.cs" Inherits="Buoi2.WebForm2" %>

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
            Bài 2: Tính tích các số chẵn từ 2 đến N<br />
            <br />
            <asp:Label ID="Label5" runat="server" Text="N"></asp:Label>
&nbsp;
            <asp:TextBox ID="txtN0" runat="server" CssClass="td"></asp:TextBox>
            <br />
            <asp:Button ID="btnTinh1" runat="server" CssClass="button" OnClick="btnTinh0_Click" Text="Tính" />
            <br />
            <asp:Label ID="Label6" runat="server" Text="Kết quả"></asp:Label>
&nbsp;
            <asp:TextBox ID="txtkq1" runat="server" CssClass="td"></asp:TextBox>
        </div>
    </form>
</body>
</html>
