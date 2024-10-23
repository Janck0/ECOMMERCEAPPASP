<%@ Page Title="" Language="C#" MasterPageFile="~/USERS/UserRegn2.Master" AutoEventWireup="true" CodeBehind="UserRegn.aspx.cs" Inherits="ECOMMERCEAPPASP2.UserRegn" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <asp:TextBox ID="TextBox1" runat="server" BorderColor="#3333FF" placeholder="name"></asp:TextBox>
<br />
<asp:TextBox ID="TextBox2" runat="server" placeholder="EMAIL"></asp:TextBox>
<br />
<asp:TextBox ID="TextBox3" runat="server" placeholder="AGE"></asp:TextBox>
<br />
<asp:TextBox ID="TextBox4" runat="server" placeholder="PHONE NUMBER" type="number"></asp:TextBox>
<br />
<asp:TextBox ID="TextBox5" runat="server" placeholder="ADDRESS" Width="160px"></asp:TextBox>
<br />
<asp:TextBox ID="TextBox6" runat="server" placeholder="DISTRICT"></asp:TextBox>
<br />
<asp:TextBox ID="TextBox7" runat="server" placeholder="STATE"></asp:TextBox>
<br />
<asp:TextBox ID="TextBox8" runat="server" placeholder="PIN-CODE" type="number"></asp:TextBox>
    <br />
    <asp:TextBox ID="TextBox9" runat="server" placeholder="USERNAME"></asp:TextBox>
    <br />
    <asp:TextBox ID="TextBox10" runat="server" placeholder="PASSWORD" type="password"></asp:TextBox>
    <br />
    <asp:TextBox ID="TextBox11" runat="server" placeholder="RE-TYPE PASSWORD"></asp:TextBox>
    <br />
    <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="Button" Width="173px" />
    <br />
    <asp:Label ID="Label1" runat="server" Text="Label"></asp:Label>
<br />
</asp:Content>
