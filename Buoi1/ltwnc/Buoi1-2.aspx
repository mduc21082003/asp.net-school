<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Buoi1-2.aspx.cs" Inherits="ltwnc.Buoi1_2" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <h3>Tính chu vi tam giác</h3>
            <label for="txtSideA">Cạnh a:</label>
            <asp:TextBox ID="txtSideA" runat="server"></asp:TextBox>
            <br /><br />
            <label for="txtSideB">Cạnh b:</label>
            <asp:TextBox ID="txtSideB" runat="server"></asp:TextBox>
            <br /><br />
            <label for="txtSideC">Cạnh c:</label>
            <asp:TextBox ID="txtSideC" runat="server"></asp:TextBox>
            <br /><br />
            <asp:Button ID="btnCalculateTriangle" runat="server" Text="Tính chu vi tam giác" OnClick="btnCalculateTriangle_Click" />
            <br /><br />
            <asp:Label ID="lblTriangleResult" runat="server" Text=""></asp:Label>
            
            <h3>Tính chu vi hình chữ nhật</h3>
            <label for="txtLength">Chiều dài:</label>
            <asp:TextBox ID="txtLength" runat="server"></asp:TextBox>
            <br /><br />
            <label for="txtWidth">Chiều rộng:</label>
            <asp:TextBox ID="txtWidth" runat="server"></asp:TextBox>
            <br /><br />
            <asp:Button ID="btnCalculateRectangle" runat="server" Text="Tính chu vi hình chữ nhật" OnClick="btnCalculateRectangle_Click" />
            <br /><br />
            <asp:Label ID="lblRectangleResult" runat="server" Text=""></asp:Label>
            
            <h3>Tính chu vi hình vuông</h3>
            <label for="txtSideSquare">Cạnh:</label>
            <asp:TextBox ID="txtSideSquare" runat="server"></asp:TextBox>
            <br /><br />
            <asp:Button ID="btnCalculateSquare" runat="server" Text="Tính chu vi hình vuông" OnClick="btnCalculateSquare_Click" />
            <br /><br />
            <asp:Label ID="lblSquareResult" runat="server" Text=""></asp:Label>
        </div>
    </form>
</body>
</html>
