<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Buoi1-1.aspx.cs" Inherits="ltwnc.Bai1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <link href ="CSS/Styles.css" rel ="stylesheet" type ="text/css"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <h3>Tính trung bình cộng 3 số</h3>
            <label for="txtNumber1">a:</label>
            <asp:TextBox ID="txtNumber1" runat="server"></asp:TextBox>
            <br /><br />
            <label for="txtNumber2">b:</label>
            <asp:TextBox ID="txtNumber2" runat="server"></asp:TextBox>
            <br /><br />
            <label for="txtNumber3">c:</label>
            <asp:TextBox ID="txtNumber3" runat="server"></asp:TextBox>
            <br /><br />
            <asp:Button ID="btnCalculate" runat="server" Text="Tính Trung Bình" OnClick="btnCalculate_Click" />
            <br /><br />
            <asp:Label ID="lblResult" runat="server" Text=""></asp:Label>
        </div>
    </form>
</body>
</html>
