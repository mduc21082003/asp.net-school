<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Buoi1-4.aspx.cs" Inherits="ltwnc.Buoi1_4" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <h3>Giải phương trình bậc 1: ax + b = 0</h3>
            <label for="txtA">a:</label>
            <asp:TextBox ID="txtA" runat="server"></asp:TextBox>
            <br /><br />
            <label for="txtB">b:</label>
            <asp:TextBox ID="txtB" runat="server"></asp:TextBox>
            <br /><br />
            <asp:Button ID="btnSolveLinear" runat="server" Text="Giải phương trình" OnClick="btnSolveLinear_Click" />
            <br /><br />
            <asp:Label ID="lblLinearResult" runat="server" Text=""></asp:Label>
        </div>
    </form>
</body>
</html>
