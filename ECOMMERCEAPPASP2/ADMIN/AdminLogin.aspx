<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="AdminLogin.aspx.cs" Inherits="ECOMMERCEAPPASP2.ADMIN.AdminLogin" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <h1>ADMIN LOGIN</h1>

    <form id="form1" runat="server">
        <div>

            
            <asp:TextBox ID="TextBox1" runat="server" placeholder="USERNAME"></asp:TextBox>
            <br />
            <asp:TextBox ID="TextBox2" runat="server" placeholder="PASSWORD" TYPE="password"></asp:TextBox>
            <br />
            <asp:Button ID="Button1" runat="server" Text="Button" OnClick="Button1_Click" />

            <br />
            <asp:Label ID="Label1" runat="server" Text="Label"></asp:Label>

        </div>
    </form>
</body>
</html>
