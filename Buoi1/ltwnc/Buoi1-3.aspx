<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Buoi1-3.aspx.cs" Inherits="ltwnc.Buoi1_3" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <h3>Tính diện tích hình chữ nhật</h3>
            <label for="txtLengthRectangle">Chiều dài:</label>
            <asp:TextBox ID="txtLengthRectangle" runat="server"></asp:TextBox>
            <br /><br />
            <label for="txtWidthRectangle">Chiều rộng:</label>
            <asp:TextBox ID="txtWidthRectangle" runat="server"></asp:TextBox>
            <br /><br />
            <asp:Button ID="btnCalculateRectangleArea" runat="server" Text="Tính diện tích hình chữ nhật" OnClick="btnCalculateRectangleArea_Click" />
            <br /><br />
            <asp:Label ID="lblRectangleAreaResult" runat="server" Text=""></asp:Label>
            
            <h3>Tính diện tích hình vuông</h3>
            <label for="txtSideSquare">Cạnh:</label>
            <asp:TextBox ID="txtSideSquare" runat="server"></asp:TextBox>
            <br /><br />
            <asp:Button ID="btnCalculateSquareArea" runat="server" Text="Tính diện tích hình vuông" OnClick="btnCalculateSquareArea_Click" />
            <br /><br />
            <asp:Label ID="lblSquareAreaResult" runat="server" Text=""></asp:Label>
            
            <h3>Tính diện tích hình tròn</h3>
            <label for="txtRadius">Bán kính:</label>
            <asp:TextBox ID="txtRadius" runat="server"></asp:TextBox>
            <br /><br />
            <asp:Button ID="btnCalculateCircleArea" runat="server" Text="Tính diện tích hình tròn" OnClick="btnCalculateCircleArea_Click" />
            <br /><br />
            <asp:Label ID="lblCircleAreaResult" runat="server" Text=""></asp:Label>
        </div>
    </form>
</body>
</html>
