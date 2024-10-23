<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="AdminRegi.aspx.cs" Inherits="ECOMMERCEAPPASP2.ADMIN.AdminRegi" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <header>ADMIN REGISTRATION</header>
    <form id="form1" runat="server">
        <div>
            
            <br />
            <asp:TextBox ID="TextBox1" runat="server" placeholder="ENTER YOUR NAME"></asp:TextBox>
            <br />
            <asp:TextBox ID="TextBox2" runat="server" placeholder="ENTER YOUR EMAIL"></asp:TextBox>
            <br />
            <asp:TextBox ID="TextBox3" runat="server" placeholder="ENTER YOUR PHONE NO"></asp:TextBox>
            <br />
            <asp:TextBox ID="TextBox4" runat="server" placeholder="ENTER YOUR USERNAME"></asp:TextBox>
            <br />
            <asp:TextBox ID="TextBox5" runat="server" placeholder="ENTER PASSWORD" type="PASSWORD"></asp:TextBox>
            <br />
            <asp:TextBox ID="TextBox6" runat="server" placeholder="RE-ENTER PASSWORD" type="PASSWORD"></asp:TextBox>
            <br />
            <br />
            <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="Button" />
            <br />
            <asp:Label ID="Label1" runat="server" Text="Label"></asp:Label>
            <br />
            <br />
            <br />
            
        </div>
    </form>
</body>
</html>
