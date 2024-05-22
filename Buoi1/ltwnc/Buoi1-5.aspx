<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Buoi1-5.aspx.cs" Inherits="ltwnc.Buoi1_5" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <h3>Giải phương trình bậc 2: ax² + bx + c = 0</h3>
            Hệ số a: <asp:TextBox ID="txtCoefficientA" runat="server"></asp:TextBox><br /><br />
            Hệ số b: <asp:TextBox ID="txtCoefficientB" runat="server"></asp:TextBox><br /><br />
            Hệ số c: <asp:TextBox ID="txtCoefficientC" runat="server"></asp:TextBox><br /><br />
            <asp:Button ID="btnSolve" runat="server" Text="Giải phương trình" OnClick="btnSolve_Click" /><br /><br />
            Nghiệm: <asp:Label ID="lblResult" runat="server" Text=""></asp:Label>
        </div>
    </form>
</body>
</html>
